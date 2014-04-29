namespace FOnlineConfigExtension
{
    partial class frmDebug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabDebugParent = new System.Windows.Forms.TabControl();
            this.tabDebug = new System.Windows.Forms.TabPage();
            this.tabDebugControl = new System.Windows.Forms.TabControl();
            this.tabLanguages = new System.Windows.Forms.TabPage();
            this.treeLang = new System.Windows.Forms.TreeView();
            this.tabDebugParent.SuspendLayout();
            this.tabDebug.SuspendLayout();
            this.tabDebugControl.SuspendLayout();
            this.tabLanguages.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDebugParent
            // 
            this.tabDebugParent.Controls.Add( this.tabDebug );
            this.tabDebugParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDebugParent.Location = new System.Drawing.Point( 0, 0 );
            this.tabDebugParent.Name = "tabDebugParent";
            this.tabDebugParent.SelectedIndex = 0;
            this.tabDebugParent.Size = new System.Drawing.Size( 292, 273 );
            this.tabDebugParent.TabIndex = 1;
            // 
            // tabDebug
            // 
            this.tabDebug.Controls.Add( this.tabDebugControl );
            this.tabDebug.Location = new System.Drawing.Point( 4, 22 );
            this.tabDebug.Name = "tabDebug";
            this.tabDebug.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabDebug.Size = new System.Drawing.Size( 284, 247 );
            this.tabDebug.TabIndex = 1;
            this.tabDebug.Text = "Debug";
            this.tabDebug.UseVisualStyleBackColor = true;
            // 
            // tabDebugControl
            // 
            this.tabDebugControl.Controls.Add( this.tabLanguages );
            this.tabDebugControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDebugControl.Location = new System.Drawing.Point( 3, 3 );
            this.tabDebugControl.Name = "tabDebugControl";
            this.tabDebugControl.SelectedIndex = 0;
            this.tabDebugControl.Size = new System.Drawing.Size( 278, 241 );
            this.tabDebugControl.TabIndex = 0;
            // 
            // tabLanguages
            // 
            this.tabLanguages.Controls.Add( this.treeLang );
            this.tabLanguages.Location = new System.Drawing.Point( 4, 22 );
            this.tabLanguages.Name = "tabLanguages";
            this.tabLanguages.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabLanguages.Size = new System.Drawing.Size( 270, 215 );
            this.tabLanguages.TabIndex = 0;
            this.tabLanguages.Text = "Language";
            this.tabLanguages.UseVisualStyleBackColor = true;
            // 
            // treeLang
            // 
            this.treeLang.BackColor = System.Drawing.SystemColors.Control;
            this.treeLang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeLang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeLang.Location = new System.Drawing.Point( 3, 3 );
            this.treeLang.Name = "treeLang";
            this.treeLang.PathSeparator = "/";
            this.treeLang.Size = new System.Drawing.Size( 264, 209 );
            this.treeLang.TabIndex = 0;
            // 
            // frmDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 292, 273 );
            this.Controls.Add( this.tabDebugParent );
            this.Name = "frmDebug";
            this.Text = "frmDebug";
            this.tabDebugParent.ResumeLayout( false );
            this.tabDebug.ResumeLayout( false );
            this.tabDebugControl.ResumeLayout( false );
            this.tabLanguages.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.TabPage tabDebug;
        internal System.Windows.Forms.TabControl tabDebugParent;
        private System.Windows.Forms.TabControl tabDebugControl;
        private System.Windows.Forms.TabPage tabLanguages;
        internal System.Windows.Forms.TreeView treeLang;

    }
}