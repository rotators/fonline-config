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