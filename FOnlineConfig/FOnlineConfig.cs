using System;
using System.Windows.Forms;

using FOnlineConfig.Interface;

namespace FOnlineConfig
{
    internal static class FOnlineConfig
    {
        internal static frmMain formMain;

        /// <summary>
        /// The main entry point for the application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            // always add "engl" language as default
            InterfaceLanguage.AddDefault( new InterfaceLanguage() );

            formMain = new frmMain();

            bool init = false;
            string rootName = "FOnlineConfigExtension";

            if( DllExtension.Load( "FOnlineConfig.dll", rootName ) )
                init = true;

            if( DllExtension.LoadPattern( "FOnlineConfig.*.dll", rootName ) > 0 )
                init = true;

            if( init )
                DllExtension.Run( "OnInit" );

            Application.Run( formMain );
        }
    }
}
