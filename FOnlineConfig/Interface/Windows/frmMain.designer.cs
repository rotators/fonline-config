namespace FOnlineConfig
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( frmMain ) );
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.groupOther = new System.Windows.Forms.GroupBox();
            this.checkLogTime = new System.Windows.Forms.CheckBox();
            this.checkLog = new System.Windows.Forms.CheckBox();
            this.checkBeep = new System.Windows.Forms.CheckBox();
            this.checkFlush = new System.Windows.Forms.CheckBox();
            this.checkInvert = new System.Windows.Forms.CheckBox();
            this.groupLanguage = new System.Windows.Forms.GroupBox();
            this.cmbLanguages = new System.Windows.Forms.ComboBox();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.groupGame = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelTextDelay = new System.Windows.Forms.Label();
            this.labelScrollStep = new System.Windows.Forms.Label();
            this.labelScrollDelay = new System.Windows.Forms.Label();
            this.numTextDelay = new System.Windows.Forms.NumericUpDown();
            this.numScrollStep = new System.Windows.Forms.NumericUpDown();
            this.numScrollDelay = new System.Windows.Forms.NumericUpDown();
            this.tabCombat = new System.Windows.Forms.TabPage();
            this.groupCombatDamage = new System.Windows.Forms.GroupBox();
            this.numCombatDamage = new System.Windows.Forms.NumericUpDown();
            this.labelCombatDamage = new System.Windows.Forms.Label();
            this.groupCombatMessages = new System.Windows.Forms.GroupBox();
            this.radioCombatMessagesBrief = new System.Windows.Forms.RadioButton();
            this.radioCombatMessagesVerbose = new System.Windows.Forms.RadioButton();
            this.groupCombatAmmo = new System.Windows.Forms.GroupBox();
            this.radioCombatAmmoNumbers = new System.Windows.Forms.RadioButton();
            this.radioCombatAmmoLines = new System.Windows.Forms.RadioButton();
            this.radioCombatAmmoBoth = new System.Windows.Forms.RadioButton();
            this.groupCombatMode = new System.Windows.Forms.GroupBox();
            this.radioCombatModeTB = new System.Windows.Forms.RadioButton();
            this.radioCombatModeRT = new System.Windows.Forms.RadioButton();
            this.radioCombatModeBoth = new System.Windows.Forms.RadioButton();
            this.tabNet = new System.Windows.Forms.TabPage();
            this.groupServer = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabVideo = new System.Windows.Forms.TabPage();
            this.tabSound = new System.Windows.Forms.TabPage();
            this.groupVolume = new System.Windows.Forms.GroupBox();
            this.labelSoundVolume = new System.Windows.Forms.Label();
            this.labelMusicValue = new System.Windows.Forms.Label();
            this.labelSound = new System.Windows.Forms.Label();
            this.labelMusic = new System.Windows.Forms.Label();
            this.trackSound = new System.Windows.Forms.TrackBar();
            this.trackMusic = new System.Windows.Forms.TrackBar();
            this.tabTools = new System.Windows.Forms.TabPage();
            this.buttons = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.tabOther.SuspendLayout();
            this.groupOther.SuspendLayout();
            this.groupLanguage.SuspendLayout();
            this.tabGame.SuspendLayout();
            this.groupGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTextDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScrollStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScrollDelay)).BeginInit();
            this.tabCombat.SuspendLayout();
            this.groupCombatDamage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCombatDamage)).BeginInit();
            this.groupCombatMessages.SuspendLayout();
            this.groupCombatAmmo.SuspendLayout();
            this.groupCombatMode.SuspendLayout();
            this.tabNet.SuspendLayout();
            this.groupServer.SuspendLayout();
            this.tabSound.SuspendLayout();
            this.groupVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMusic)).BeginInit();
            this.buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabs.Controls.Add( this.tabOther );
            this.tabs.Controls.Add( this.tabGame );
            this.tabs.Controls.Add( this.tabCombat );
            this.tabs.Controls.Add( this.tabNet );
            this.tabs.Controls.Add( this.tabVideo );
            this.tabs.Controls.Add( this.tabSound );
            this.tabs.Controls.Add( this.tabTools );
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point( 5, 5 );
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size( 487, 277 );
            this.tabs.TabIndex = 0;
            // 
            // tabOther
            // 
            this.tabOther.Controls.Add( this.groupOther );
            this.tabOther.Controls.Add( this.groupLanguage );
            this.tabOther.Location = new System.Drawing.Point( 4, 25 );
            this.tabOther.Name = "tabOther";
            this.tabOther.Size = new System.Drawing.Size( 479, 248 );
            this.tabOther.TabIndex = 0;
            this.tabOther.Tag = "langOther";
            this.tabOther.Text = "langOther";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // groupOther
            // 
            this.groupOther.Controls.Add( this.checkLogTime );
            this.groupOther.Controls.Add( this.checkLog );
            this.groupOther.Controls.Add( this.checkBeep );
            this.groupOther.Controls.Add( this.checkFlush );
            this.groupOther.Controls.Add( this.checkInvert );
            this.groupOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupOther.Location = new System.Drawing.Point( 0, 50 );
            this.groupOther.Name = "groupOther";
            this.groupOther.Size = new System.Drawing.Size( 479, 198 );
            this.groupOther.TabIndex = 1;
            this.groupOther.TabStop = false;
            // 
            // checkLogTime
            // 
            this.checkLogTime.AutoSize = true;
            this.checkLogTime.Location = new System.Drawing.Point( 6, 111 );
            this.checkLogTime.Name = "checkLogTime";
            this.checkLogTime.Size = new System.Drawing.Size( 87, 17 );
            this.checkLogTime.TabIndex = 4;
            this.checkLogTime.Tag = "langLogTime";
            this.checkLogTime.Text = "langLogTime";
            this.checkLogTime.UseVisualStyleBackColor = true;
            // 
            // checkLog
            // 
            this.checkLog.AutoSize = true;
            this.checkLog.Location = new System.Drawing.Point( 6, 88 );
            this.checkLog.Name = "checkLog";
            this.checkLog.Size = new System.Drawing.Size( 64, 17 );
            this.checkLog.TabIndex = 3;
            this.checkLog.Tag = "langLog";
            this.checkLog.Text = "langLog";
            this.checkLog.UseVisualStyleBackColor = true;
            this.checkLog.CheckedChanged += new System.EventHandler( this.checkLog_CheckedChanged );
            // 
            // checkBeep
            // 
            this.checkBeep.AutoSize = true;
            this.checkBeep.Location = new System.Drawing.Point( 6, 42 );
            this.checkBeep.Name = "checkBeep";
            this.checkBeep.Size = new System.Drawing.Size( 71, 17 );
            this.checkBeep.TabIndex = 1;
            this.checkBeep.Tag = "langBeep";
            this.checkBeep.Text = "langBeep";
            this.checkBeep.UseVisualStyleBackColor = true;
            // 
            // checkFlush
            // 
            this.checkFlush.AutoSize = true;
            this.checkFlush.Location = new System.Drawing.Point( 6, 19 );
            this.checkFlush.Name = "checkFlush";
            this.checkFlush.Size = new System.Drawing.Size( 71, 17 );
            this.checkFlush.TabIndex = 0;
            this.checkFlush.Tag = "langFlush";
            this.checkFlush.Text = "langFlush";
            this.checkFlush.UseVisualStyleBackColor = true;
            // 
            // checkInvert
            // 
            this.checkInvert.AutoSize = true;
            this.checkInvert.Location = new System.Drawing.Point( 6, 65 );
            this.checkInvert.Name = "checkInvert";
            this.checkInvert.Size = new System.Drawing.Size( 73, 17 );
            this.checkInvert.TabIndex = 2;
            this.checkInvert.Tag = "langInvert";
            this.checkInvert.Text = "langInvert";
            this.checkInvert.UseVisualStyleBackColor = true;
            // 
            // groupLanguage
            // 
            this.groupLanguage.Controls.Add( this.cmbLanguages );
            this.groupLanguage.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupLanguage.Location = new System.Drawing.Point( 0, 0 );
            this.groupLanguage.Name = "groupLanguage";
            this.groupLanguage.Size = new System.Drawing.Size( 479, 50 );
            this.groupLanguage.TabIndex = 0;
            this.groupLanguage.TabStop = false;
            this.groupLanguage.Tag = "langLanguage";
            this.groupLanguage.Text = "langLanguage";
            // 
            // cmbLanguages
            // 
            this.cmbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguages.FormattingEnabled = true;
            this.cmbLanguages.Location = new System.Drawing.Point( 6, 19 );
            this.cmbLanguages.Name = "cmbLanguages";
            this.cmbLanguages.Size = new System.Drawing.Size( 121, 21 );
            this.cmbLanguages.TabIndex = 0;
            this.cmbLanguages.SelectedIndexChanged += new System.EventHandler( this.cmbLanguages_SelectedIndexChanged );
            // 
            // tabGame
            // 
            this.tabGame.Controls.Add( this.groupGame );
            this.tabGame.Location = new System.Drawing.Point( 4, 25 );
            this.tabGame.Name = "tabGame";
            this.tabGame.Size = new System.Drawing.Size( 479, 248 );
            this.tabGame.TabIndex = 1;
            this.tabGame.Tag = "langGame";
            this.tabGame.Text = "langGame";
            this.tabGame.UseVisualStyleBackColor = true;
            // 
            // groupGame
            // 
            this.groupGame.Controls.Add( this.checkBox1 );
            this.groupGame.Controls.Add( this.labelTextDelay );
            this.groupGame.Controls.Add( this.labelScrollStep );
            this.groupGame.Controls.Add( this.labelScrollDelay );
            this.groupGame.Controls.Add( this.numTextDelay );
            this.groupGame.Controls.Add( this.numScrollStep );
            this.groupGame.Controls.Add( this.numScrollDelay );
            this.groupGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupGame.Location = new System.Drawing.Point( 0, 0 );
            this.groupGame.Name = "groupGame";
            this.groupGame.Size = new System.Drawing.Size( 479, 248 );
            this.groupGame.TabIndex = 0;
            this.groupGame.TabStop = false;
            this.groupGame.Tag = "langGame";
            this.groupGame.Text = "langGame";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point( 9, 89 );
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size( 99, 17 );
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Tag = "langAlwaysRun";
            this.checkBox1.Text = "langAlwaysRun";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelTextDelay
            // 
            this.labelTextDelay.AutoSize = true;
            this.labelTextDelay.Location = new System.Drawing.Point( 6, 73 );
            this.labelTextDelay.Name = "labelTextDelay";
            this.labelTextDelay.Size = new System.Drawing.Size( 75, 13 );
            this.labelTextDelay.TabIndex = 5;
            this.labelTextDelay.Tag = "langTextDelay";
            this.labelTextDelay.Text = "langTextDelay";
            // 
            // labelScrollStep
            // 
            this.labelScrollStep.AutoSize = true;
            this.labelScrollStep.Location = new System.Drawing.Point( 6, 47 );
            this.labelScrollStep.Name = "labelScrollStep";
            this.labelScrollStep.Size = new System.Drawing.Size( 75, 13 );
            this.labelScrollStep.TabIndex = 4;
            this.labelScrollStep.Tag = "langScrollStep";
            this.labelScrollStep.Text = "langScrollStep";
            // 
            // labelScrollDelay
            // 
            this.labelScrollDelay.AutoSize = true;
            this.labelScrollDelay.Location = new System.Drawing.Point( 6, 21 );
            this.labelScrollDelay.Name = "labelScrollDelay";
            this.labelScrollDelay.Size = new System.Drawing.Size( 80, 13 );
            this.labelScrollDelay.TabIndex = 3;
            this.labelScrollDelay.Tag = "langScrollDelay";
            this.labelScrollDelay.Text = "langScrollDelay";
            // 
            // numTextDelay
            // 
            this.numTextDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numTextDelay.Location = new System.Drawing.Point( 353, 71 );
            this.numTextDelay.Name = "numTextDelay";
            this.numTextDelay.Size = new System.Drawing.Size( 120, 20 );
            this.numTextDelay.TabIndex = 2;
            // 
            // numScrollStep
            // 
            this.numScrollStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numScrollStep.Location = new System.Drawing.Point( 353, 45 );
            this.numScrollStep.Name = "numScrollStep";
            this.numScrollStep.Size = new System.Drawing.Size( 120, 20 );
            this.numScrollStep.TabIndex = 1;
            // 
            // numScrollDelay
            // 
            this.numScrollDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numScrollDelay.Location = new System.Drawing.Point( 353, 19 );
            this.numScrollDelay.Name = "numScrollDelay";
            this.numScrollDelay.Size = new System.Drawing.Size( 120, 20 );
            this.numScrollDelay.TabIndex = 0;
            // 
            // tabCombat
            // 
            this.tabCombat.Controls.Add( this.groupCombatDamage );
            this.tabCombat.Controls.Add( this.groupCombatMessages );
            this.tabCombat.Controls.Add( this.groupCombatAmmo );
            this.tabCombat.Controls.Add( this.groupCombatMode );
            this.tabCombat.Location = new System.Drawing.Point( 4, 25 );
            this.tabCombat.Name = "tabCombat";
            this.tabCombat.Size = new System.Drawing.Size( 479, 248 );
            this.tabCombat.TabIndex = 2;
            this.tabCombat.Tag = "langCombat";
            this.tabCombat.Text = "langCombat";
            this.tabCombat.UseVisualStyleBackColor = true;
            // 
            // groupCombatDamage
            // 
            this.groupCombatDamage.AutoSize = true;
            this.groupCombatDamage.Controls.Add( this.numCombatDamage );
            this.groupCombatDamage.Controls.Add( this.labelCombatDamage );
            this.groupCombatDamage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCombatDamage.Location = new System.Drawing.Point( 0, 205 );
            this.groupCombatDamage.Name = "groupCombatDamage";
            this.groupCombatDamage.Size = new System.Drawing.Size( 479, 43 );
            this.groupCombatDamage.TabIndex = 3;
            this.groupCombatDamage.TabStop = false;
            this.groupCombatDamage.Tag = "langCombatDamage";
            this.groupCombatDamage.Text = "langCombatDamage";
            // 
            // numCombatDamage
            // 
            this.numCombatDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numCombatDamage.Location = new System.Drawing.Point( 353, 14 );
            this.numCombatDamage.Margin = new System.Windows.Forms.Padding( 3, 3, 3, 0 );
            this.numCombatDamage.Maximum = new decimal( new int[] {
            10000,
            0,
            0,
            0} );
            this.numCombatDamage.Name = "numCombatDamage";
            this.numCombatDamage.Size = new System.Drawing.Size( 120, 20 );
            this.numCombatDamage.TabIndex = 1;
            // 
            // labelCombatDamage
            // 
            this.labelCombatDamage.AutoSize = true;
            this.labelCombatDamage.Location = new System.Drawing.Point( 6, 21 );
            this.labelCombatDamage.Name = "labelCombatDamage";
            this.labelCombatDamage.Size = new System.Drawing.Size( 130, 13 );
            this.labelCombatDamage.TabIndex = 0;
            this.labelCombatDamage.Tag = "langCombatDamageDelay";
            this.labelCombatDamage.Text = "langCombatDamageDelay";
            // 
            // groupCombatMessages
            // 
            this.groupCombatMessages.AutoSize = true;
            this.groupCombatMessages.Controls.Add( this.radioCombatMessagesBrief );
            this.groupCombatMessages.Controls.Add( this.radioCombatMessagesVerbose );
            this.groupCombatMessages.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupCombatMessages.Location = new System.Drawing.Point( 0, 148 );
            this.groupCombatMessages.Name = "groupCombatMessages";
            this.groupCombatMessages.Padding = new System.Windows.Forms.Padding( 5 );
            this.groupCombatMessages.Size = new System.Drawing.Size( 479, 57 );
            this.groupCombatMessages.TabIndex = 2;
            this.groupCombatMessages.TabStop = false;
            this.groupCombatMessages.Tag = "langCombatMessages";
            this.groupCombatMessages.Text = "langCombatMessages";
            // 
            // radioCombatMessagesBrief
            // 
            this.radioCombatMessagesBrief.AutoSize = true;
            this.radioCombatMessagesBrief.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioCombatMessagesBrief.Location = new System.Drawing.Point( 5, 35 );
            this.radioCombatMessagesBrief.Name = "radioCombatMessagesBrief";
            this.radioCombatMessagesBrief.Size = new System.Drawing.Size( 469, 17 );
            this.radioCombatMessagesBrief.TabIndex = 1;
            this.radioCombatMessagesBrief.TabStop = true;
            this.radioCombatMessagesBrief.Tag = "langCombatMessagesBrief";
            this.radioCombatMessagesBrief.Text = "langCombatMessagesBrief";
            this.radioCombatMessagesBrief.UseVisualStyleBackColor = true;
            // 
            // radioCombatMessagesVerbose
            // 
            this.radioCombatMessagesVerbose.AutoSize = true;
            this.radioCombatMessagesVerbose.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioCombatMessagesVerbose.Location = new System.Drawing.Point( 5, 18 );
            this.radioCombatMessagesVerbose.Name = "radioCombatMessagesVerbose";
            this.radioCombatMessagesVerbose.Size = new System.Drawing.Size( 469, 17 );
            this.radioCombatMessagesVerbose.TabIndex = 0;
            this.radioCombatMessagesVerbose.TabStop = true;
            this.radioCombatMessagesVerbose.Tag = "langCombatMessagesVerbose";
            this.radioCombatMessagesVerbose.Text = "langCombatMessagesVerbose";
            this.radioCombatMessagesVerbose.UseVisualStyleBackColor = true;
            // 
            // groupCombatAmmo
            // 
            this.groupCombatAmmo.AutoSize = true;
            this.groupCombatAmmo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupCombatAmmo.Controls.Add( this.radioCombatAmmoNumbers );
            this.groupCombatAmmo.Controls.Add( this.radioCombatAmmoLines );
            this.groupCombatAmmo.Controls.Add( this.radioCombatAmmoBoth );
            this.groupCombatAmmo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupCombatAmmo.Location = new System.Drawing.Point( 0, 74 );
            this.groupCombatAmmo.Name = "groupCombatAmmo";
            this.groupCombatAmmo.Padding = new System.Windows.Forms.Padding( 5 );
            this.groupCombatAmmo.Size = new System.Drawing.Size( 479, 74 );
            this.groupCombatAmmo.TabIndex = 1;
            this.groupCombatAmmo.TabStop = false;
            this.groupCombatAmmo.Tag = "langCombatAmmo";
            this.groupCombatAmmo.Text = "langCombatAmmo";
            // 
            // radioCombatAmmoNumbers
            // 
            this.radioCombatAmmoNumbers.AutoSize = true;
            this.radioCombatAmmoNumbers.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioCombatAmmoNumbers.Location = new System.Drawing.Point( 5, 52 );
            this.radioCombatAmmoNumbers.Name = "radioCombatAmmoNumbers";
            this.radioCombatAmmoNumbers.Size = new System.Drawing.Size( 469, 17 );
            this.radioCombatAmmoNumbers.TabIndex = 2;
            this.radioCombatAmmoNumbers.TabStop = true;
            this.radioCombatAmmoNumbers.Tag = "langCombatAmmoNumbers";
            this.radioCombatAmmoNumbers.Text = "langCombatAmmoNumbers";
            this.radioCombatAmmoNumbers.UseVisualStyleBackColor = true;
            // 
            // radioCombatAmmoLines
            // 
            this.radioCombatAmmoLines.AutoSize = true;
            this.radioCombatAmmoLines.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioCombatAmmoLines.Location = new System.Drawing.Point( 5, 35 );
            this.radioCombatAmmoLines.Name = "radioCombatAmmoLines";
            this.radioCombatAmmoLines.Size = new System.Drawing.Size( 469, 17 );
            this.radioCombatAmmoLines.TabIndex = 1;
            this.radioCombatAmmoLines.TabStop = true;
            this.radioCombatAmmoLines.Tag = "langCombatAmmoLines";
            this.radioCombatAmmoLines.Text = "langCombatAmmoLines";
            this.radioCombatAmmoLines.UseVisualStyleBackColor = true;
            // 
            // radioCombatAmmoBoth
            // 
            this.radioCombatAmmoBoth.AutoSize = true;
            this.radioCombatAmmoBoth.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioCombatAmmoBoth.Location = new System.Drawing.Point( 5, 18 );
            this.radioCombatAmmoBoth.Name = "radioCombatAmmoBoth";
            this.radioCombatAmmoBoth.Size = new System.Drawing.Size( 469, 17 );
            this.radioCombatAmmoBoth.TabIndex = 0;
            this.radioCombatAmmoBoth.TabStop = true;
            this.radioCombatAmmoBoth.Tag = "langCombatAmmoBoth";
            this.radioCombatAmmoBoth.Text = "langCombatAmmoBoth";
            this.radioCombatAmmoBoth.UseVisualStyleBackColor = true;
            // 
            // groupCombatMode
            // 
            this.groupCombatMode.AutoSize = true;
            this.groupCombatMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupCombatMode.Controls.Add( this.radioCombatModeTB );
            this.groupCombatMode.Controls.Add( this.radioCombatModeRT );
            this.groupCombatMode.Controls.Add( this.radioCombatModeBoth );
            this.groupCombatMode.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupCombatMode.Location = new System.Drawing.Point( 0, 0 );
            this.groupCombatMode.Name = "groupCombatMode";
            this.groupCombatMode.Padding = new System.Windows.Forms.Padding( 5 );
            this.groupCombatMode.Size = new System.Drawing.Size( 479, 74 );
            this.groupCombatMode.TabIndex = 0;
            this.groupCombatMode.TabStop = false;
            this.groupCombatMode.Tag = "langCombatMode";
            this.groupCombatMode.Text = "langCombatMode";
            // 
            // radioCombatModeTB
            // 
            this.radioCombatModeTB.AutoSize = true;
            this.radioCombatModeTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioCombatModeTB.Location = new System.Drawing.Point( 5, 52 );
            this.radioCombatModeTB.Name = "radioCombatModeTB";
            this.radioCombatModeTB.Size = new System.Drawing.Size( 469, 17 );
            this.radioCombatModeTB.TabIndex = 2;
            this.radioCombatModeTB.TabStop = true;
            this.radioCombatModeTB.Tag = "langCombatModeTB";
            this.radioCombatModeTB.Text = "langCombatModeTB";
            this.radioCombatModeTB.UseVisualStyleBackColor = true;
            // 
            // radioCombatModeRT
            // 
            this.radioCombatModeRT.AutoSize = true;
            this.radioCombatModeRT.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioCombatModeRT.Location = new System.Drawing.Point( 5, 35 );
            this.radioCombatModeRT.Name = "radioCombatModeRT";
            this.radioCombatModeRT.Size = new System.Drawing.Size( 469, 17 );
            this.radioCombatModeRT.TabIndex = 1;
            this.radioCombatModeRT.TabStop = true;
            this.radioCombatModeRT.Tag = "langCombatModeRT";
            this.radioCombatModeRT.Text = "langCombatModeRT";
            this.radioCombatModeRT.UseVisualStyleBackColor = true;
            // 
            // radioCombatModeBoth
            // 
            this.radioCombatModeBoth.AutoSize = true;
            this.radioCombatModeBoth.Dock = System.Windows.Forms.DockStyle.Top;
            this.radioCombatModeBoth.Location = new System.Drawing.Point( 5, 18 );
            this.radioCombatModeBoth.Name = "radioCombatModeBoth";
            this.radioCombatModeBoth.Size = new System.Drawing.Size( 469, 17 );
            this.radioCombatModeBoth.TabIndex = 0;
            this.radioCombatModeBoth.TabStop = true;
            this.radioCombatModeBoth.Tag = "langCombatModeBoth";
            this.radioCombatModeBoth.Text = "langCombatModeBoth";
            this.radioCombatModeBoth.UseVisualStyleBackColor = true;
            // 
            // tabNet
            // 
            this.tabNet.Controls.Add( this.groupServer );
            this.tabNet.Location = new System.Drawing.Point( 4, 25 );
            this.tabNet.Name = "tabNet";
            this.tabNet.Size = new System.Drawing.Size( 479, 248 );
            this.tabNet.TabIndex = 3;
            this.tabNet.Tag = "langNet";
            this.tabNet.Text = "langNet";
            this.tabNet.UseVisualStyleBackColor = true;
            // 
            // groupServer
            // 
            this.groupServer.Controls.Add( this.comboBox1 );
            this.groupServer.Controls.Add( this.label1 );
            this.groupServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupServer.Location = new System.Drawing.Point( 0, 0 );
            this.groupServer.Name = "groupServer";
            this.groupServer.Size = new System.Drawing.Size( 479, 71 );
            this.groupServer.TabIndex = 0;
            this.groupServer.TabStop = false;
            this.groupServer.Text = "langServer";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point( 7, 37 );
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size( 121, 21 );
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 7, 20 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 35, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabVideo
            // 
            this.tabVideo.Location = new System.Drawing.Point( 4, 25 );
            this.tabVideo.Name = "tabVideo";
            this.tabVideo.Size = new System.Drawing.Size( 479, 248 );
            this.tabVideo.TabIndex = 4;
            this.tabVideo.Tag = "langVideo";
            this.tabVideo.Text = "langVideo";
            this.tabVideo.UseVisualStyleBackColor = true;
            // 
            // tabSound
            // 
            this.tabSound.Controls.Add( this.groupVolume );
            this.tabSound.Location = new System.Drawing.Point( 4, 25 );
            this.tabSound.Name = "tabSound";
            this.tabSound.Size = new System.Drawing.Size( 479, 248 );
            this.tabSound.TabIndex = 5;
            this.tabSound.Tag = "langSound";
            this.tabSound.Text = "langSound";
            this.tabSound.UseVisualStyleBackColor = true;
            // 
            // groupVolume
            // 
            this.groupVolume.Controls.Add( this.labelSoundVolume );
            this.groupVolume.Controls.Add( this.labelMusicValue );
            this.groupVolume.Controls.Add( this.labelSound );
            this.groupVolume.Controls.Add( this.labelMusic );
            this.groupVolume.Controls.Add( this.trackSound );
            this.groupVolume.Controls.Add( this.trackMusic );
            this.groupVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupVolume.Location = new System.Drawing.Point( 0, 0 );
            this.groupVolume.Name = "groupVolume";
            this.groupVolume.Size = new System.Drawing.Size( 479, 248 );
            this.groupVolume.TabIndex = 0;
            this.groupVolume.TabStop = false;
            this.groupVolume.Tag = "langVolume";
            this.groupVolume.Text = "langVolume";
            // 
            // labelSoundVolume
            // 
            this.labelSoundVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSoundVolume.Location = new System.Drawing.Point( 394, 87 );
            this.labelSoundVolume.Name = "labelSoundVolume";
            this.labelSoundVolume.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSoundVolume.Size = new System.Drawing.Size( 79, 13 );
            this.labelSoundVolume.TabIndex = 5;
            this.labelSoundVolume.Text = "_SoundVolume";
            this.labelSoundVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMusicValue
            // 
            this.labelMusicValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMusicValue.Location = new System.Drawing.Point( 397, 22 );
            this.labelMusicValue.Name = "labelMusicValue";
            this.labelMusicValue.Size = new System.Drawing.Size( 76, 13 );
            this.labelMusicValue.TabIndex = 4;
            this.labelMusicValue.Text = "_MusicVolume";
            this.labelMusicValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSound
            // 
            this.labelSound.AutoSize = true;
            this.labelSound.Location = new System.Drawing.Point( 10, 85 );
            this.labelSound.Name = "labelSound";
            this.labelSound.Size = new System.Drawing.Size( 58, 13 );
            this.labelSound.TabIndex = 3;
            this.labelSound.Tag = "langSound";
            this.labelSound.Text = "langSound";
            // 
            // labelMusic
            // 
            this.labelMusic.AutoSize = true;
            this.labelMusic.Location = new System.Drawing.Point( 7, 20 );
            this.labelMusic.Name = "labelMusic";
            this.labelMusic.Size = new System.Drawing.Size( 55, 13 );
            this.labelMusic.TabIndex = 2;
            this.labelMusic.Tag = "langMusic";
            this.labelMusic.Text = "langMusic";
            // 
            // trackSound
            // 
            this.trackSound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackSound.Location = new System.Drawing.Point( 3, 104 );
            this.trackSound.Maximum = 100;
            this.trackSound.Name = "trackSound";
            this.trackSound.Size = new System.Drawing.Size( 469, 42 );
            this.trackSound.TabIndex = 1;
            this.trackSound.TickFrequency = 5;
            this.trackSound.Scroll += new System.EventHandler( this.trackSound_Scroll );
            // 
            // trackMusic
            // 
            this.trackMusic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackMusic.Location = new System.Drawing.Point( 3, 38 );
            this.trackMusic.Maximum = 100;
            this.trackMusic.Name = "trackMusic";
            this.trackMusic.Size = new System.Drawing.Size( 468, 42 );
            this.trackMusic.TabIndex = 0;
            this.trackMusic.TickFrequency = 5;
            this.trackMusic.Scroll += new System.EventHandler( this.trackMusic_Scroll );
            // 
            // tabTools
            // 
            this.tabTools.Location = new System.Drawing.Point( 4, 25 );
            this.tabTools.Name = "tabTools";
            this.tabTools.Size = new System.Drawing.Size( 479, 248 );
            this.tabTools.TabIndex = 6;
            this.tabTools.Tag = "langTools";
            this.tabTools.Text = "langTools";
            this.tabTools.UseVisualStyleBackColor = true;
            // 
            // buttons
            // 
            this.buttons.Controls.Add( this.button4 );
            this.buttons.Controls.Add( this.button3 );
            this.buttons.Controls.Add( this.button2 );
            this.buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttons.Location = new System.Drawing.Point( 5, 282 );
            this.buttons.Name = "buttons";
            this.buttons.Padding = new System.Windows.Forms.Padding( 5 );
            this.buttons.Size = new System.Drawing.Size( 487, 38 );
            this.buttons.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point( 155, 5 );
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size( 177, 28 );
            this.button4.TabIndex = 2;
            this.button4.Tag = "langSave";
            this.button4.Text = "langSave";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Location = new System.Drawing.Point( 332, 5 );
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size( 150, 28 );
            this.button3.TabIndex = 1;
            this.button3.Tag = "langExit";
            this.button3.Text = "langExit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point( 5, 5 );
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size( 150, 28 );
            this.button2.TabIndex = 0;
            this.button2.Tag = "langPlay";
            this.button2.Text = "langPlay";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 497, 325 );
            this.Controls.Add( this.tabs );
            this.Controls.Add( this.buttons );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding( 5 );
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "langTitle";
            this.Text = "langTitle";
            this.tabs.ResumeLayout( false );
            this.tabOther.ResumeLayout( false );
            this.groupOther.ResumeLayout( false );
            this.groupOther.PerformLayout();
            this.groupLanguage.ResumeLayout( false );
            this.tabGame.ResumeLayout( false );
            this.groupGame.ResumeLayout( false );
            this.groupGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTextDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScrollStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScrollDelay)).EndInit();
            this.tabCombat.ResumeLayout( false );
            this.tabCombat.PerformLayout();
            this.groupCombatDamage.ResumeLayout( false );
            this.groupCombatDamage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCombatDamage)).EndInit();
            this.groupCombatMessages.ResumeLayout( false );
            this.groupCombatMessages.PerformLayout();
            this.groupCombatAmmo.ResumeLayout( false );
            this.groupCombatAmmo.PerformLayout();
            this.groupCombatMode.ResumeLayout( false );
            this.groupCombatMode.PerformLayout();
            this.tabNet.ResumeLayout( false );
            this.groupServer.ResumeLayout( false );
            this.groupServer.PerformLayout();
            this.tabSound.ResumeLayout( false );
            this.groupVolume.ResumeLayout( false );
            this.groupVolume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackMusic)).EndInit();
            this.buttons.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabOther;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.TabPage tabCombat;
        private System.Windows.Forms.TabPage tabNet;
        private System.Windows.Forms.TabPage tabVideo;
        private System.Windows.Forms.TabPage tabSound;
        private System.Windows.Forms.GroupBox groupLanguage;
        private System.Windows.Forms.GroupBox groupOther;
        private System.Windows.Forms.ComboBox cmbLanguages;
        private System.Windows.Forms.GroupBox groupServer;
        private System.Windows.Forms.GroupBox groupVolume;
        private System.Windows.Forms.TrackBar trackSound;
        private System.Windows.Forms.TrackBar trackMusic;
        private System.Windows.Forms.Label labelSound;
        private System.Windows.Forms.Label labelMusic;
        private System.Windows.Forms.Label labelSoundVolume;
        private System.Windows.Forms.Label labelMusicValue;
        private System.Windows.Forms.CheckBox checkLogTime;
        private System.Windows.Forms.CheckBox checkLog;
        private System.Windows.Forms.CheckBox checkInvert;
        private System.Windows.Forms.CheckBox checkBeep;
        private System.Windows.Forms.CheckBox checkFlush;
        private System.Windows.Forms.GroupBox groupGame;
        private System.Windows.Forms.Label labelScrollDelay;
        private System.Windows.Forms.NumericUpDown numTextDelay;
        private System.Windows.Forms.NumericUpDown numScrollStep;
        private System.Windows.Forms.NumericUpDown numScrollDelay;
        private System.Windows.Forms.Label labelTextDelay;
        private System.Windows.Forms.Label labelScrollStep;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabTools;
        private System.Windows.Forms.GroupBox groupCombatAmmo;
        private System.Windows.Forms.GroupBox groupCombatMode;
        private System.Windows.Forms.RadioButton radioCombatModeTB;
        private System.Windows.Forms.RadioButton radioCombatModeRT;
        private System.Windows.Forms.RadioButton radioCombatModeBoth;
        private System.Windows.Forms.GroupBox groupCombatMessages;
        private System.Windows.Forms.RadioButton radioCombatMessagesBrief;
        private System.Windows.Forms.RadioButton radioCombatMessagesVerbose;
        private System.Windows.Forms.RadioButton radioCombatAmmoNumbers;
        private System.Windows.Forms.RadioButton radioCombatAmmoLines;
        private System.Windows.Forms.RadioButton radioCombatAmmoBoth;
        private System.Windows.Forms.GroupBox groupCombatDamage;
        private System.Windows.Forms.NumericUpDown numCombatDamage;
        private System.Windows.Forms.Label labelCombatDamage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel buttons;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

