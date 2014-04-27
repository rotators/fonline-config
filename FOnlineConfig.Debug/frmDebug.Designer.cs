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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLanguages = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tree = new System.Windows.Forms.TreeView();
            this.tabDebugParent.SuspendLayout();
            this.tabDebug.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.tabDebug.Controls.Add( this.tabControl1 );
            this.tabDebug.Location = new System.Drawing.Point( 4, 22 );
            this.tabDebug.Name = "tabDebug";
            this.tabDebug.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabDebug.Size = new System.Drawing.Size( 284, 247 );
            this.tabDebug.TabIndex = 1;
            this.tabDebug.Text = "Debug";
            this.tabDebug.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add( this.tabLanguages );
            this.tabControl1.Controls.Add( this.tabPage2 );
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point( 3, 3 );
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size( 278, 241 );
            this.tabControl1.TabIndex = 0;
            // 
            // tabLanguages
            // 
            this.tabLanguages.Controls.Add( this.tree );
            this.tabLanguages.Location = new System.Drawing.Point( 4, 22 );
            this.tabLanguages.Name = "tabLanguages";
            this.tabLanguages.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabLanguages.Size = new System.Drawing.Size( 270, 215 );
            this.tabLanguages.TabIndex = 0;
            this.tabLanguages.Text = "Languages";
            this.tabLanguages.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point( 4, 22 );
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding( 3 );
            this.tabPage2.Size = new System.Drawing.Size( 270, 215 );
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tree
            // 
            this.tree.BackColor = System.Drawing.SystemColors.Control;
            this.tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.Location = new System.Drawing.Point( 3, 3 );
            this.tree.Name = "tree";
            this.tree.PathSeparator = "/";
            this.tree.Size = new System.Drawing.Size( 264, 209 );
            this.tree.TabIndex = 0;
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
            this.tabControl1.ResumeLayout( false );
            this.tabLanguages.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.TabPage tabDebug;
        internal System.Windows.Forms.TabControl tabDebugParent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLanguages;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.TreeView tree;

    }
}