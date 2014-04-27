using FOnlineConfig.Interface;

namespace FOnlineConfigExtension
{
    public static class FOnlineConfigExtension
    {
        public static void OnInit()
        {
            InitLanguageRussian();
        }

        public static void OnLanguageChange( string langId )
        {
            
        }

        private static void InitLanguageRussian()
        {
            InterfaceLanguage russ = new InterfaceLanguage( "russ", "Русский" );
            russ.Title = "FOnline конфигуратор";

            // buttons
            russ.Play = "Играть";
            russ.Save = "Сохранить";
            russ.Exit = "Выход";

            // tabs
            russ.Other = "Разное";
            russ.Game = "Игра";
            russ.Combat = "Боевка";
            russ.Net = "Сеть";
            russ.Video = "Видео";
            russ.Sound = "Звук";

            // tabOther
            russ.Language = "Язык";

            russ.Flush = "Извещение о сообщениях при неактивном окне";
            russ.Beep = "Звуковое извещение о сообщениях при неактивном окн";
            russ.Invert = "Инвертирование текста в окне сообщений";
            russ.Log = "Ведение лога в 'FOnline.log'";
            russ.LogTime = "Запись в лог с указанием времени";

            // tabGame
            russ.ScrollDelay = "Задержка скроллинга";
            russ.ScrollStep = "Шаг скроллинга";
            russ.TextDelay = "Время задержки текста (мс)";
            russ.AlwaysRun = "Постоянный бег";

            // tabCombat
            russ.CombatMode = "Режим боя по-умолчанию";
            russ.CombatModeBoth = "Оба режима";
            russ.CombatModeRT = "Реальное время";
            russ.CombatModeTB = "Пошаговый режим";

            russ.CombatAmmo = "Индикатор патронов и износа";
            russ.CombatAmmoBoth = "Линии и номера";
            russ.CombatAmmoLines = "Линии";
            russ.CombatAmmoNumbers = "Номера";

            russ.CombatMessages = "Боевые сообщения";
            russ.CombatMessagesVerbose = "Полные";
            russ.CombatMessagesBrief = "Краткие";

            russ.CombatDamage = "Режим индикации повреждений над головой";
            russ.CombatDamageDelay = "Задержка, в мс";

            InterfaceLanguage.Add( russ );
        }
    }
}
