using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace FOnlineConfig
{
    internal sealed class DllExtension
    {
        /// <summary>
        /// Last error message
        /// </summary>
        public static string LastError
        {
            get
            {
                return (_lastError);
            }
        }
        private static string _lastError = null;

        private static List<DllExtension> Extensions = new List<DllExtension>();

        public static uint LoadPattern( string pattern, string rootName )
        {
            uint loaded = 0;

            string[] files = Directory.GetFiles( Directory.GetParent( Assembly.GetExecutingAssembly().Location ).ToString(), pattern, SearchOption.TopDirectoryOnly );
            foreach( string file in files )
            {
                if( Load( Path.GetFileName(file), rootName ) )
                    loaded++;
            }

            return (loaded);
        }

        /// <summary>
        /// Attempt to load specified .dll file
        /// <param name="filename">.dll filename</param>
        /// <returns>True if .dll file has been loaded and passed all checks, false otherwise</returns>
        /// </summary>
        public static bool Load( string filename, string rootName )
        {
            _lastError = null;

            string file = Directory.GetParent( Assembly.GetExecutingAssembly().Location ).ToString();
            file += "\\" + filename;

            foreach( DllExtension dll in Extensions )
            {
                if( dll.Filename == file )
                    return (false);
            }

            Assembly assembly = null;
            try
            {
                assembly = Assembly.LoadFile( file );
            }
            catch( Exception e )
            {
                _lastError = "Error loading assembly : " + e.Message;
                return (false);
            }

            if( assembly == null )
                return (false); // don't report errors

            Type root = null;

            string objName = rootName + "::" + rootName;

            try
            {
                root = assembly.GetType( objName.Replace( "::", "." ) );
            }
            catch( Exception )
            {
                _lastError = "Error getting root class";
                return (false);
            }

            if( root == null )
            {
                _lastError = objName + " : not found";
                return (false);
            }
            // public?
            else if( !root.IsPublic )
            {
                _lastError = objName + " : not public";
                return (false);
            }
            // class?
            else if( !root.IsClass )
            {
                _lastError = objName + " : not a class";
                return (false);
            }

            DllExtension extension = new DllExtension( root, rootName, filename );
            Extensions.Add( extension );

            return (true);
        }

        /// <summary>
        /// Call void f() function in all loaded extensions
        /// </summary>
        /// <param name="function"></param>
        public static void Run( string function )
        {
            foreach( DllExtension dll in Extensions )
            {
                dll.Void( function );
            }
        }

        /// <summary>
        /// Type of root class
        /// </summary>
        public readonly Type Root;

        /// <summary>
        /// Name of root class
        /// </summary>
        public readonly string RootName;

        /// <summary>
        /// Dll filename
        /// </summary>
        public readonly string Filename;

        private DllExtension( Type root, string rootName, string filename )
        {
            this.Root = root;
            this.RootName = rootName;
            this.Filename = filename;
        }

        /// <summary>
        /// Performs basic checks of requested function
        /// </summary>
        /// <param name="function">Function name</param>
        /// <returns>MethodInfo if function has been found and no errors has been found, null otherwise</returns>
        private MethodInfo PrepareMethod( string function )
        {
            _lastError = null;

            if( this.Root == null || this.RootName == null )
            {
                _lastError = this.Filename + " : root class not set";
                return (null);
            }

            MethodInfo method = null;
            try
            {
                method = this.Root.GetMethod( function );
            }
            catch( Exception )
            {
                _lastError = this.RootName + " : error getting method '" + function + "()' info";
                return (null);
            }

            return (method);
        }

        private bool IsPublicStatic( ref MethodInfo method )
        {
            if( method == null )
            {
                _lastError = "IsPublicStatic : method is null";
                return (false);
            }

            string objName = this.RootName + "::" + method.Name + "()";
            if( !method.IsPublic )
            {
                _lastError = objName + " : not public";
                return (false);
            }
            // static?
            else if( !method.IsStatic )
            {
                _lastError = objName + " : not static";
                return (false);
            }

            return (true);
        }

        /// <summary>
        /// Call void f() function
        /// </summary>
        /// <param name="function">Function name</param>
        /// <returns>True if function was invoked, false if error has been found</returns>
        public bool Void( string function )
        {
            string objName = this.RootName + "::" + function + "()";

            MethodInfo method = PrepareMethod( function );
            if( method == null )
            {
                _lastError = objName + " : method not found";
                return (false);
            }

            if( !IsPublicStatic( ref method ) )
                return (false);
            // void?
            else if( method.ReturnType != typeof( void ) )
            {
                _lastError = objName + " : not void";
                return (false);
            }
            // () ?
            else if( method.GetParameters().Length > 0 )
            {
                _lastError = objName + " : too many parameters";
                return (false);
            }

            try
            {
                method.Invoke( null, null );
            }
            catch( Exception )
            {
                return (false);
            }
            return (true);
        }
    }
}
