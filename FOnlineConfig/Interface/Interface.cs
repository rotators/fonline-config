using System.Collections.Generic;
using System.Windows.Forms;

namespace FOnlineConfig.Interface
{
    /// <summary>
    /// Various functions for working with interface
    /// </summary>
    /// <remarks>Available for extensions</remarks>
    public static class Interface
    {
        public enum SubTab
        {
            Game,
            Net,
            Tools
        };

        /// <summary>
        /// Refresh main window
        /// </summary>
        /// <remarks>Available for extensions</remarks>
        public static void Refresh()
        {
            FOnlineConfig.formMain.RefreshSize();
        }

        public static bool AddRootTabPage( TabPage page )
        {
            if( FOnlineConfig.formMain == null )
                return( false);

            FOnlineConfig.formMain.tabRoot.TabPages.Add( page );
            return (true);
        }

        public static bool AddSubTabPage( SubTab subTab, TabPage page )
        {
            if( FOnlineConfig.formMain == null )
                return (false);

            TabControl parent = null;
            if( subTab == SubTab.Game )
                parent = FOnlineConfig.formMain.tabSubGame;

            if( parent == null )
                return (false);

            parent.TabPages.Add( page );
            return (true);
        }
    }
}

namespace FOnlineConfig.ExtensionMethods
{
    public static partial class ExtensionMethods
    {
        public static void GetAllControls( this Control parent, ref List<Control> list )
        {
            foreach( Control control in parent.Controls )
            {
                list.Add( control );

                if( control.Controls.Count > 0 )
                    control.GetAllControls( ref list );
            }
        }
    }
}