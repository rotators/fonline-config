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

            InterfaceLanguage.AddDefault( new InterfaceLanguage() );

            string rootName = "FOnlineConfigExtension";

            if( DllExtension.Load( "FOnlineConfig.dll", rootName ) ||
                DllExtension.LoadPattern( "FOnlineConfig.*.dll", rootName ) > 0 )
            {
                DllExtension.Run( "OnInit" );
            }

            formMain = new frmMain();
            Application.Run( formMain );
        }
    }
}
