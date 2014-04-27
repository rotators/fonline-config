using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace FOnlineConfig.Interface
{
    /// <summary>
    /// Allows interface translations
    /// </summary>
    /// <remarks>Available for extensions</remarks>
    public class InterfaceLanguage
    {
        public static List<InterfaceLanguage> Languages
        {
            get;
            internal set;
        }
        public static InterfaceLanguage DefaultLanguage
        {
            get;
            internal set;
        }

        #region "Static functions"

        /// <summary>
        /// Adds a new language
        /// </summary>
        /// <remarks>Available for extensions</remarks>
        /// <param name="newLang"></param>
        /// <returns></returns>
        public static bool Add( InterfaceLanguage newLang )
        {
            if( newLang.Id.Length != 4 )
                return (false);

            if( Languages == null )
                Languages = new List<InterfaceLanguage>();

            foreach( InterfaceLanguage lang in Languages )
            {
                if( lang.Id == newLang.Id )
                    return (false);
            }

            Languages.Add( newLang );

            return (true);
        }

        /// <summary>
        /// Sets default language of the interface;
        /// should be called before creating main window
        /// </summary>
        /// <remarks>Available for extensions</remarks>
        /// <param name="id">Language ID</param>
        /// <returns>True if identifier has been found, false otherwise</returns>
        public static bool SetDefault( string id )
        {
            if( id.Length != 4 )
                return (false);

            foreach( InterfaceLanguage lang in Languages )
            {
                if( lang.Id == id )
                {
                    DefaultLanguage = lang;
                    return (true);
                }
            }
            return (false);
        }

        /// <summary>
        /// Adds new language and sets it as default
        /// </summary>
        /// <remarks>Available for extensions</remarks>
        /// <param name="lang">Language object</param>
        /// <returns>True if language has been added and set as default, false otherwise</returns>
        public static bool AddDefault( InterfaceLanguage lang )
        {
            if( Add( lang ) && SetDefault( lang.Id ) )
                return (true);
            return (false);
        }

        /// <summary>
        /// Translates control using InterfaceLanguage instance
        /// </summary>
        /// <param name="control">Control to translate</param>
        /// <param name="lang">Language object</param>
        /// <returns>True if control has been translated, false otherwise</returns>
        public static bool TranslateControl( Control control, InterfaceLanguage lang )
        {
            string prefix = "lang";

            if( control.Tag == null )
                return (false);

            string tag = (string)control.Tag;
            if( !tag.StartsWith( prefix ) )
                return (false);

            tag = tag.Substring( prefix.Length );

            FieldInfo field = null;
            try
            {
                field = lang.GetType().GetField( tag );
            }
            catch( Exception )
            {
                return (false);
            }

            if( field == null )
                return (false);
            else if( !field.IsPublic )
                return (false);
            else if( field.FieldType != typeof( string ) )
                return (false);

            string value = (string)field.GetValue( lang );
            control.Text = value;

            return (true);
        }

        #endregion // Static functions

        /// <summary>
        /// Unique language ID.
        /// It should be 
        /// </summary>
        public readonly string Id = "engl";
        public readonly string Name = "English";

        // frmMain
        public string Title = "FOnline configurator";

        // buttons
        public string Play = "Play";
        public string Save = "Save";
        public string Exit = "Exit";

        // tabs
        public string Other = "Other";
        public string Game = "Game";
        public string Combat = "Combat";
        public string Net = "Network";
        public string Video = "Video";
        public string Sound = "Sound";

        // tabOther
        public string Language = "Language";

        public string Flush = "Flush window on not active game";
        public string Beep = "Beep sound on not active game";
        public string Invert = "Invert text in message box";
        public string Log = "Logging to 'FOnline.log'";
        public string LogTime = "Logging with time";

        // tabGame
        public string ScrollDelay = "Scroll delay";
        public string ScrollStep = "Scroll step";
        public string TextDelay = "Text delay (ms)";
        public string AlwaysRun = "Always run";

        // tabCombat
        public string CombatMode = "Default combat mode";
        public string CombatModeBoth = "Both modes";
        public string CombatModeRT = "Real-time";
        public string CombatModeTB = "Turn-based";

        public string CombatAmmo = "Ammo amount and deterioration display";
        public string CombatAmmoBoth = "Lines and numbers";
        public string CombatAmmoLines = "Lines";
        public string CombatAmmoNumbers = "Numbers";

        public string CombatMessages = "Combat messages";
        public string CombatMessagesVerbose = "Verbose";
        public string CombatMessagesBrief = "Brief";

        public string CombatDamage = "Damage indication on head";
        public string CombatDamageDelay = "Delay (ms)";

        // tabNet
        public string Server = "Game server";

        // tabSound
        public string Volume = "Volume";
        public string Music = "Music";

        public InterfaceLanguage()
        {
        }

        /// <summary>
        /// Creates language object which will be used to transate interface.
        /// By default, all fields are initially set to english language.
        /// </summary>
        /// <param name="id">Unique language id</param>
        /// <param name="name">Language name, as seen by user</param>
        /// <exception cref="ArgumentException"/>
        /// <exception cref="ArgumentNullException"/>
        public InterfaceLanguage( string id, string name )
        {
            if( id == null )
                throw new ArgumentNullException( "id" );
            else if( name == null )
                throw new ArgumentNullException( "name" );
            else if( id.Length != 4 )
                throw new ArgumentException( "Language id must be 4 characters long", "id" );

            this.Id = id;
            this.Name = name;
        }
    }
}
