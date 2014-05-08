using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

using FOnlineConfig.ExtensionMethods;
using FOnlineConfig.Interface;

namespace FOnlineConfig
{
    internal partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            //tabRoot.AutoSize = true;

            foreach( InterfaceLanguage lang in InterfaceLanguage.Languages )
            {
                this.AddLanguage( lang );
            }

            this.HideTools();

            checkLog_CheckedChanged( null, null );

            this.trackMusic_Scroll( null, null );
            this.trackSound_Scroll( null, null );

            if( InterfaceLanguage.DefaultLanguage != null )
            {
                cmbLanguages.SelectedIndex = cmbLanguages.Items.IndexOf( InterfaceLanguage.DefaultLanguage.Name );
                ChangeLanguage( InterfaceLanguage.DefaultLanguage );
            }


            List<Control> controls = new List<Control>();
            foreach( Control c in controls )
            {
                c.BackColor = Color.Aqua;
            }
            this.Invalidate();
        }

        public frmMain( object cfg )
            : this()
        {
        }

        #region Language

        public void AddLanguage( InterfaceLanguage lang )
        {
            this.cmbLanguages.Items.Add( lang.Name );

            this.cmbLanguages.Enabled = cmbLanguages.Items.Count > 1;
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
            this.OnAutoSizeChanged( EventArgs.Empty );
        }

        #endregion // Language

        public void RefreshSize()
        {
            /*
            int width = tabRoot.GetTabRect( tabRoot.TabCount - 1 ).Right + tabRoot.GetTabRect( tabRoot.TabCount - 1 ).Width;
            this.MinimumSize = this.MaximumSize = new System.Drawing.Size( width, this.Height );
            this.CenterToScreen();
            */
            this.Refresh();
        }

        /// <summary>
        /// Hides "Tools" tab
        /// </summary>
        private void HideTools()
        {
            if( this.tabRoot.TabPages.Contains( this.tabTools ) )
            {
                this.tabRoot.TabPages.Remove( this.tabTools );
                this.RefreshSize();
            }
        }

        /// <summary>
        /// Shows "Tools
        /// </summary>
        private void ShowTools()
        {
            if( !this.tabRoot.TabPages.Contains( this.tabTools ) )
            {
                this.tabRoot.TabPages.Add( this.tabTools );
                this.RefreshSize();
            }
        }

        private void cmbLanguages_SelectedIndexChanged( object sender, EventArgs e )
        {
            InterfaceLanguage lang = InterfaceLanguage.Languages[this.cmbLanguages.SelectedIndex];
            this.ChangeLanguage( lang );
        }

        private void trackMusic_Scroll( object sender, EventArgs e )
        {
            this.labelMusicValue.Text = this.trackMusic.Value + "%";
        }

        private void trackSound_Scroll( object sender, EventArgs e )
        {
            this.labelSoundVolume.Text = this.trackSound.Value + "%";
        }

        private void checkLog_CheckedChanged( object sender, EventArgs e )
        {
            Control[] controls = { this.checkLogTime };

            foreach( Control control in controls )
            {
                control.Enabled = this.checkLog.Checked;
            }
        }

        private void button3_Click( object sender, EventArgs e )
        {
            Application.Exit();
        }
    }
}
