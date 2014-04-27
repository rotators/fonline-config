using FOnlineConfig.Interface;

namespace FOnlineConfigExtension
{
    public class FOnlineConfigExtension
    {
        public static void OnInit()
        {
            InitLanguagePolish();
        }

        private static void InitLanguagePolish()
        {
            InterfaceLanguage pols = new InterfaceLanguage( "pols", "Polski" );
            pols.Title = "FOnline konfigurator";

            // buttons
            pols.Play = "Graj";
            pols.Save = "Zapisz";
            pols.Exit = "Wyjdź";

            // tabs
            pols.Other = "Inne";
            pols.Game = "Gra";
            pols.Combat = "Walka";
            pols.Net = "Połączenie";
            pols.Video = "Grafika";
            pols.Sound = "Dźwięk";

            // tabOther
            pols.Language = "Język";

            // tabNet
            pols.Server = "Serwer gry";

            // tabSound
            pols.Music = "Muzyka";

            InterfaceLanguage.Add( pols );
        }
    }
}
