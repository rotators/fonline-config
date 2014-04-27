using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;

using FOnlineConfig.ExtensionMethods;
using FOnlineConfig.Interface;

namespace FOnlineConfigExtension
{
    public class FOnlineConfigExtension
    {
        public static void OnInit()
        {
            Application.Idle += new EventHandler( Application_Idle );
        }

        static void Application_Idle( object sender, EventArgs e )
        {
            IntPtr hWnd = Process.GetCurrentProcess().MainWindowHandle;
            Form formMain = (Form)Form.FromHandle( hWnd );

            if( formMain == null )
                return;

            Application.Idle -= Application_Idle;

            List<Control> controls = new List<Control>();
            formMain.GetAllControls( ref controls );

            foreach( Control control in controls )
            {
                if( control.GetType().Name == "TabControl" && control.Name == "tabs" )
                {
                    frmDebug formDebug = new frmDebug();

                    TabControl tab = (TabControl)control;
                    tab.TabPages.Add( formDebug.tabDebugParent.TabPages[0] );

                    Init( formMain, formDebug );

                    Interface.Refresh();
                    break;
                }
            }
        }

        private static void Init( Form formMain, frmDebug formDebug )
        {
            InitLanguage( formMain, formDebug );
        }

        private static void InitLanguage( Form formMain, frmDebug formDebug )
        {
            InterfaceLanguage engl = null;

            foreach( InterfaceLanguage lang in InterfaceLanguage.Languages )
            {
                if( lang.Id == "engl" )
                {
                    engl = lang;
                    break;
                }
            }

            if( engl == null )
                return;

            List<Control> controls = new List<Control>();
            formMain.GetAllControls( ref controls );
            List<string> tags = new List<string>();

            foreach( Control control in controls )
            {
                if( control.Tag != null && control.Tag.ToString().StartsWith( "lang" ) )
                {
                    string tag = control.Tag.ToString().Substring( 4 );
                    if( !tags.Contains( tag ) )
                        tags.Add( tag );
                }
            }

            TreeNode loaded = new TreeNode( "Loaded" );
            foreach( InterfaceLanguage lang in InterfaceLanguage.Languages )
            {
                TreeNode langNode = new TreeNode( lang.Id + " (" + lang.Name + ")" );

                TreeNode fields = langNode.Nodes.Add( "Fields" );
                TreeNode missing = new TreeNode( "Missing" );
                FieldInfo[] fieldInfos = lang.GetType().GetFields();
                int fieldsCount = 0, missingCount = 0;
                foreach( FieldInfo field in fieldInfos )
                {
                    if( field.FieldType != typeof( string ) )
                        continue;

                    if( lang.Id == "engl" )
                        tags.Remove( field.Name );

                    if( field.Name == "Id" || field.Name == "Name" )
                        continue;

                    fieldsCount++;
                    string englValue = (string)engl.GetType().GetField( field.Name ).GetValue( engl );
                    string value = (string)field.GetValue( lang );
                    fields.Nodes.Add( field.Name + " = " + value );
                    if( lang.Id != "engl" && value == englValue )
                    {
                        missingCount++;
                        missing.Nodes.Add( field.Name );
                    }
                }

                if( missing.Nodes.Count > 0 )
                {
                    missing.Text += " (" + missingCount + "/" + fieldsCount + ")";
                    langNode.Nodes.Add( missing );
                }

                loaded.Nodes.Add( langNode );
            }
            if( tags.Count > 0 )
            {
                TreeNode notImplemented = formDebug.tree.Nodes.Add( "Not implemented (" + tags.Count + ")" );
                foreach( string tag in tags )
                {
                    notImplemented.Nodes.Add( tag );
                }
            }
            if( loaded.Nodes.Count > 0 )
            {
                loaded.Text += " (" + loaded.Nodes.Count + ")";
                formDebug.tree.Nodes.Add( loaded );
            }

            if( formDebug.tree.Nodes.Count == 1 )
            {
                formDebug.tree.Nodes[0].Expand();
            }
        }
    }
}
