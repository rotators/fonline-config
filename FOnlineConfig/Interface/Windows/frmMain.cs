using System;
using System.Collections.Generic;
using System.Windows.Forms;

using FOnlineConfig.ExtensionMethods;
using FOnlineConfig.Interface;

namespace FOnlineConfig
{
    internal partial class frmMain : Form
    {
        public frmMain()
        {
            this.KeyPreview = true;

            InitializeComponent();
            foreach( InterfaceLanguage lang in InterfaceLanguage.Languages )
            {
                cmbLanguages.Items.Add( lang.Name );
            }

            if( cmbLanguages.Items.Count <= 1 )
                cmbLanguages.Enabled = false;

            this.HideTools();

            checkLog_CheckedChanged( null, null );

            this.trackMusic_Scroll( null, null );
            this.trackSound_Scroll( null, null );

            if( InterfaceLanguage.DefaultLanguage != null )
            {
                cmbLanguages.SelectedIndex = cmbLanguages.Items.IndexOf( InterfaceLanguage.DefaultLanguage.Name );
                ChangeLanguage( InterfaceLanguage.DefaultLanguage );
            }
        }

        public frmMain( object cfg )
            : this()
        {
        }

        public void RefreshSize()
        {
            int width = tabs.GetTabRect( tabs.TabCount - 1 ).Right + tabs.GetTabRect( tabs.TabCount - 1 ).Width;
            this.MinimumSize = this.MaximumSize = new System.Drawing.Size( width, this.Height );
            this.CenterToScreen();

            this.button2.Width = this.buttons.Width / 3;
            this.button3.Width = this.buttons.Width / 3;
            this.button4.Width = this.buttons.Width / 3;

            this.Refresh();
        }

        /// <summary>
        /// Hides "Tools" tab
        /// </summary>
        private void HideTools()
        {
            if( this.tabs.TabPages.Contains( this.tabTools ) )
            {
                this.tabs.TabPages.Remove( this.tabTools );
                this.RefreshSize();
            }
        }

        /// <summary>
        /// Shows "Tools
        /// </summary>
        private void ShowTools()
        {
            if( !this.tabs.TabPages.Contains( this.tabTools ) )
            {
                this.tabs.TabPages.Add( this.tabTools );
                this.RefreshSize();
            }
        }

        private void ChangeLanguage( InterfaceLanguage lang )
        {
            List<Control> controls = new List<Control>();
            controls.Add( this );

            this.GetAllControls( ref controls );

            foreach( Control control in controls )
            {
                if( control.Tag == null )
                    continue;

                control.Translate( lang );
            }

            DllExtension.Run( "OnLanguageChange" );

            this.RefreshSize();
        }

        private void cmbLanguages_SelectedIndexChanged( object sender, EventArgs e )
        {
            // and that, kids, is why we dont expose InterfaceLanguage::Languages
            InterfaceLanguage lang = InterfaceLanguage.Languages[this.cmbLanguages.SelectedIndex];
            this.ChangeLanguage( lang );
        }

        private void trackMusic_Scroll( object sender, EventArgs e )
        {
            labelMusicValue.Text = this.trackMusic.Value + "%";
        }

        private void trackSound_Scroll( object sender, EventArgs e )
        {
            labelSoundVolume.Text = this.trackSound.Value + "%";
        }

        private void checkLog_CheckedChanged( object sender, EventArgs e )
        {
            Control[] controls = { this.checkLogTime };

            foreach( Control control in controls )
            {
                control.Enabled = this.checkLog.Checked;
            }
        }
    }
}
