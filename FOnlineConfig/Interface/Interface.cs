using System;
using System.Collections.Generic;
using System.Text;

using FOnlineConfig;

namespace FOnlineConfig.Interface
{
    public static class Interface
    {
        /// <summary>
        /// Refresh main window
        /// </summary>
        /// <remarks>Available for extensions</remarks>
        public static void Refresh()
        {
            FOnlineConfig.formMain.RefreshSize();
        }
    }
}
