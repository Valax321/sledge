namespace Sledge.BspEditor.Environment.Source
{
    partial class SourceEnvironmentEditor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBaseGame = new System.Windows.Forms.Label();
            this.txtGameDir = new System.Windows.Forms.TextBox();
            this.lblGameDir = new System.Windows.Forms.Label();
            this.btnGameDirBrowse = new System.Windows.Forms.Button();
            this.lstFgds = new System.Windows.Forms.ListView();
            this.colFgdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFgdPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddFgd = new System.Windows.Forms.Button();
            this.lblDefaultBrushEntity = new System.Windows.Forms.Label();
            this.btnRemoveFgd = new System.Windows.Forms.Button();
            this.lblDefaultPointEntity = new System.Windows.Forms.Label();
            this.cmbDefaultBrushEntity = new System.Windows.Forms.ComboBox();
            this.cmbDefaultPointEntity = new System.Windows.Forms.ComboBox();
            this.nudDefaultTextureScale = new System.Windows.Forms.NumericUpDown();
            this.lblDefaultTextureScale = new System.Windows.Forms.Label();
            this.cmbMapSizeOverrideHigh = new System.Windows.Forms.ComboBox();
            this.lblMapSizeOverrideHigh = new System.Windows.Forms.Label();
            this.cmbMapSizeOverrideLow = new System.Windows.Forms.ComboBox();
            this.chkOverrideMapSize = new System.Windows.Forms.CheckBox();
            this.lblMapSizeOverrideLow = new System.Windows.Forms.Label();
            this.grpDirectories = new System.Windows.Forms.GroupBox();
            this.grpFgds = new System.Windows.Forms.GroupBox();
            this.grpBuildTools = new System.Windows.Forms.GroupBox();
            this.lblCopyToMapFolder = new System.Windows.Forms.Label();
            this.chkCopyBsp = new System.Windows.Forms.CheckBox();
            this.chkCopyRes = new System.Windows.Forms.CheckBox();
            this.chkCopyErr = new System.Windows.Forms.CheckBox();
            this.chkCopyLog = new System.Windows.Forms.CheckBox();
            this.chkCopyMap = new System.Windows.Forms.CheckBox();
            this.chkMapCopyBsp = new System.Windows.Forms.CheckBox();
            this.chkAskRunGame = new System.Windows.Forms.CheckBox();
            this.chkRunGame = new System.Windows.Forms.CheckBox();
            this.lblBuildExeFolder = new System.Windows.Forms.Label();
            this.lblBuildBSP = new System.Windows.Forms.Label();
            this.txtBuildToolsDirectory = new System.Windows.Forms.TextBox();
            this.cmbRadExe = new System.Windows.Forms.ComboBox();
            this.cmbBspExe = new System.Windows.Forms.ComboBox();
            this.lblBuildVIS = new System.Windows.Forms.Label();
            this.cmbVisExe = new System.Windows.Forms.ComboBox();
            this.lblBuildRAD = new System.Windows.Forms.Label();
            this.btnBuildToolsBrowse = new System.Windows.Forms.Button();
            this.grpTextures = new System.Windows.Forms.GroupBox();
            this.lblTexturePackageExclusions = new System.Windows.Forms.Label();
            this.cmbGameExe = new System.Windows.Forms.ComboBox();
            this.lblGameExe = new System.Windows.Forms.Label();
            this.btnAddMaterialExclude = new System.Windows.Forms.Button();
            this.btnRemoveMaterialExclude = new System.Windows.Forms.Button();
            this.lblCordonTextureName = new System.Windows.Forms.Label();
            this.txtCordonTextureName = new System.Windows.Forms.TextBox();
            this.txtGameModDir = new System.Windows.Forms.TextBox();
            this.btnGameModBrowse = new System.Windows.Forms.Button();
            this.listExcludedMaterialDirs = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultTextureScale)).BeginInit();
            this.grpDirectories.SuspendLayout();
            this.grpFgds.SuspendLayout();
            this.grpBuildTools.SuspendLayout();
            this.grpTextures.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaseGame
            // 
            this.lblBaseGame.Location = new System.Drawing.Point(3, 44);
            this.lblBaseGame.Name = "lblBaseGame";
            this.lblBaseGame.Size = new System.Drawing.Size(99, 20);
            this.lblBaseGame.TabIndex = 20;
            this.lblBaseGame.Text = "Base Game Directory (e.g. \'valve\')";
            this.lblBaseGame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGameDir
            // 
            this.txtGameDir.Location = new System.Drawing.Point(107, 16);
            this.txtGameDir.Name = "txtGameDir";
            this.txtGameDir.Size = new System.Drawing.Size(256, 20);
            this.txtGameDir.TabIndex = 13;
            this.txtGameDir.Text = "example: $SteamUserDir\\Half Life 2";
            this.txtGameDir.TextChanged += new System.EventHandler(this.GameDirectoryTextChanged);
            // 
            // lblGameDir
            // 
            this.lblGameDir.Location = new System.Drawing.Point(6, 16);
            this.lblGameDir.Name = "lblGameDir";
            this.lblGameDir.Size = new System.Drawing.Size(95, 20);
            this.lblGameDir.TabIndex = 14;
            this.lblGameDir.Text = "Game Dir";
            this.lblGameDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGameDirBrowse
            // 
            this.btnGameDirBrowse.Location = new System.Drawing.Point(369, 16);
            this.btnGameDirBrowse.Name = "btnGameDirBrowse";
            this.btnGameDirBrowse.Size = new System.Drawing.Size(74, 20);
            this.btnGameDirBrowse.TabIndex = 15;
            this.btnGameDirBrowse.Text = "Browse...";
            this.btnGameDirBrowse.UseVisualStyleBackColor = true;
            this.btnGameDirBrowse.Click += new System.EventHandler(this.BrowseGameDirectory);
            // 
            // lstFgds
            // 
            this.lstFgds.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFgdName,
            this.colFgdPath});
            this.lstFgds.FullRowSelect = true;
            this.lstFgds.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstFgds.Location = new System.Drawing.Point(6, 19);
            this.lstFgds.Name = "lstFgds";
            this.lstFgds.ShowItemToolTips = true;
            this.lstFgds.Size = new System.Drawing.Size(357, 115);
            this.lstFgds.TabIndex = 34;
            this.lstFgds.UseCompatibleStateImageBehavior = false;
            this.lstFgds.View = System.Windows.Forms.View.Details;
            // 
            // colFgdName
            // 
            this.colFgdName.Text = "Name";
            // 
            // colFgdPath
            // 
            this.colFgdPath.Text = "Path";
            // 
            // btnAddFgd
            // 
            this.btnAddFgd.Location = new System.Drawing.Point(369, 19);
            this.btnAddFgd.Name = "btnAddFgd";
            this.btnAddFgd.Size = new System.Drawing.Size(74, 23);
            this.btnAddFgd.TabIndex = 27;
            this.btnAddFgd.Text = "Add...";
            this.btnAddFgd.UseVisualStyleBackColor = true;
            this.btnAddFgd.Click += new System.EventHandler(this.BrowseFgd);
            // 
            // lblDefaultBrushEntity
            // 
            this.lblDefaultBrushEntity.Location = new System.Drawing.Point(7, 168);
            this.lblDefaultBrushEntity.Name = "lblDefaultBrushEntity";
            this.lblDefaultBrushEntity.Size = new System.Drawing.Size(151, 20);
            this.lblDefaultBrushEntity.TabIndex = 30;
            this.lblDefaultBrushEntity.Text = "Default Brush Entity";
            this.lblDefaultBrushEntity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRemoveFgd
            // 
            this.btnRemoveFgd.Location = new System.Drawing.Point(369, 48);
            this.btnRemoveFgd.Name = "btnRemoveFgd";
            this.btnRemoveFgd.Size = new System.Drawing.Size(74, 23);
            this.btnRemoveFgd.TabIndex = 28;
            this.btnRemoveFgd.Text = "Remove";
            this.btnRemoveFgd.UseVisualStyleBackColor = true;
            this.btnRemoveFgd.Click += new System.EventHandler(this.RemoveFgd);
            // 
            // lblDefaultPointEntity
            // 
            this.lblDefaultPointEntity.Location = new System.Drawing.Point(7, 141);
            this.lblDefaultPointEntity.Name = "lblDefaultPointEntity";
            this.lblDefaultPointEntity.Size = new System.Drawing.Size(151, 20);
            this.lblDefaultPointEntity.TabIndex = 31;
            this.lblDefaultPointEntity.Text = "Default Point Entity";
            this.lblDefaultPointEntity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbDefaultBrushEntity
            // 
            this.cmbDefaultBrushEntity.DropDownHeight = 300;
            this.cmbDefaultBrushEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefaultBrushEntity.FormattingEnabled = true;
            this.cmbDefaultBrushEntity.IntegralHeight = false;
            this.cmbDefaultBrushEntity.Items.AddRange(new object[] {
            "Valve"});
            this.cmbDefaultBrushEntity.Location = new System.Drawing.Point(164, 167);
            this.cmbDefaultBrushEntity.Name = "cmbDefaultBrushEntity";
            this.cmbDefaultBrushEntity.Size = new System.Drawing.Size(199, 21);
            this.cmbDefaultBrushEntity.TabIndex = 32;
            // 
            // cmbDefaultPointEntity
            // 
            this.cmbDefaultPointEntity.DropDownHeight = 300;
            this.cmbDefaultPointEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDefaultPointEntity.FormattingEnabled = true;
            this.cmbDefaultPointEntity.IntegralHeight = false;
            this.cmbDefaultPointEntity.Items.AddRange(new object[] {
            "Valve"});
            this.cmbDefaultPointEntity.Location = new System.Drawing.Point(164, 140);
            this.cmbDefaultPointEntity.Name = "cmbDefaultPointEntity";
            this.cmbDefaultPointEntity.Size = new System.Drawing.Size(199, 21);
            this.cmbDefaultPointEntity.TabIndex = 33;
            // 
            // nudDefaultTextureScale
            // 
            this.nudDefaultTextureScale.DecimalPlaces = 2;
            this.nudDefaultTextureScale.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudDefaultTextureScale.Location = new System.Drawing.Point(198, 16);
            this.nudDefaultTextureScale.Name = "nudDefaultTextureScale";
            this.nudDefaultTextureScale.Size = new System.Drawing.Size(51, 20);
            this.nudDefaultTextureScale.TabIndex = 38;
            this.nudDefaultTextureScale.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // lblDefaultTextureScale
            // 
            this.lblDefaultTextureScale.Location = new System.Drawing.Point(6, 16);
            this.lblDefaultTextureScale.Name = "lblDefaultTextureScale";
            this.lblDefaultTextureScale.Size = new System.Drawing.Size(186, 20);
            this.lblDefaultTextureScale.TabIndex = 36;
            this.lblDefaultTextureScale.Text = "Default Texture Scale";
            this.lblDefaultTextureScale.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbMapSizeOverrideHigh
            // 
            this.cmbMapSizeOverrideHigh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMapSizeOverrideHigh.FormattingEnabled = true;
            this.cmbMapSizeOverrideHigh.Items.AddRange(new object[] {
            "4096",
            "8192",
            "16384",
            "32768",
            "65536",
            "131072"});
            this.cmbMapSizeOverrideHigh.Location = new System.Drawing.Point(75, 275);
            this.cmbMapSizeOverrideHigh.Name = "cmbMapSizeOverrideHigh";
            this.cmbMapSizeOverrideHigh.Size = new System.Drawing.Size(57, 21);
            this.cmbMapSizeOverrideHigh.TabIndex = 44;
            // 
            // lblMapSizeOverrideHigh
            // 
            this.lblMapSizeOverrideHigh.Location = new System.Drawing.Point(5, 274);
            this.lblMapSizeOverrideHigh.Name = "lblMapSizeOverrideHigh";
            this.lblMapSizeOverrideHigh.Size = new System.Drawing.Size(64, 20);
            this.lblMapSizeOverrideHigh.TabIndex = 43;
            this.lblMapSizeOverrideHigh.Text = "High";
            this.lblMapSizeOverrideHigh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbMapSizeOverrideLow
            // 
            this.cmbMapSizeOverrideLow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMapSizeOverrideLow.FormattingEnabled = true;
            this.cmbMapSizeOverrideLow.Items.AddRange(new object[] {
            "-4096",
            "-8192",
            "-16384",
            "-32768",
            "-65536",
            "-131072"});
            this.cmbMapSizeOverrideLow.Location = new System.Drawing.Point(75, 248);
            this.cmbMapSizeOverrideLow.Name = "cmbMapSizeOverrideLow";
            this.cmbMapSizeOverrideLow.Size = new System.Drawing.Size(57, 21);
            this.cmbMapSizeOverrideLow.TabIndex = 42;
            // 
            // chkOverrideMapSize
            // 
            this.chkOverrideMapSize.Checked = true;
            this.chkOverrideMapSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOverrideMapSize.Location = new System.Drawing.Point(6, 194);
            this.chkOverrideMapSize.Name = "chkOverrideMapSize";
            this.chkOverrideMapSize.Size = new System.Drawing.Size(196, 24);
            this.chkOverrideMapSize.TabIndex = 41;
            this.chkOverrideMapSize.Text = "Override FGD map size";
            this.chkOverrideMapSize.UseVisualStyleBackColor = true;
            // 
            // lblMapSizeOverrideLow
            // 
            this.lblMapSizeOverrideLow.Location = new System.Drawing.Point(6, 249);
            this.lblMapSizeOverrideLow.Name = "lblMapSizeOverrideLow";
            this.lblMapSizeOverrideLow.Size = new System.Drawing.Size(63, 20);
            this.lblMapSizeOverrideLow.TabIndex = 40;
            this.lblMapSizeOverrideLow.Text = "Low";
            this.lblMapSizeOverrideLow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpDirectories
            // 
            this.grpDirectories.Controls.Add(this.btnGameModBrowse);
            this.grpDirectories.Controls.Add(this.txtGameModDir);
            this.grpDirectories.Controls.Add(this.lblGameDir);
            this.grpDirectories.Controls.Add(this.cmbGameExe);
            this.grpDirectories.Controls.Add(this.lblGameExe);
            this.grpDirectories.Controls.Add(this.btnGameDirBrowse);
            this.grpDirectories.Controls.Add(this.txtGameDir);
            this.grpDirectories.Controls.Add(this.lblBaseGame);
            this.grpDirectories.Location = new System.Drawing.Point(6, 3);
            this.grpDirectories.Name = "grpDirectories";
            this.grpDirectories.Size = new System.Drawing.Size(459, 99);
            this.grpDirectories.TabIndex = 46;
            this.grpDirectories.TabStop = false;
            this.grpDirectories.Text = "Directories";
            // 
            // grpFgds
            // 
            this.grpFgds.Controls.Add(this.lstFgds);
            this.grpFgds.Controls.Add(this.cmbDefaultPointEntity);
            this.grpFgds.Controls.Add(this.cmbDefaultBrushEntity);
            this.grpFgds.Controls.Add(this.cmbMapSizeOverrideHigh);
            this.grpFgds.Controls.Add(this.lblDefaultPointEntity);
            this.grpFgds.Controls.Add(this.lblMapSizeOverrideHigh);
            this.grpFgds.Controls.Add(this.btnRemoveFgd);
            this.grpFgds.Controls.Add(this.cmbMapSizeOverrideLow);
            this.grpFgds.Controls.Add(this.lblDefaultBrushEntity);
            this.grpFgds.Controls.Add(this.chkOverrideMapSize);
            this.grpFgds.Controls.Add(this.btnAddFgd);
            this.grpFgds.Controls.Add(this.lblMapSizeOverrideLow);
            this.grpFgds.Location = new System.Drawing.Point(6, 108);
            this.grpFgds.Name = "grpFgds";
            this.grpFgds.Size = new System.Drawing.Size(459, 304);
            this.grpFgds.TabIndex = 47;
            this.grpFgds.TabStop = false;
            this.grpFgds.Text = "Game Data Files";
            // 
            // grpBuildTools
            // 
            this.grpBuildTools.Controls.Add(this.lblCopyToMapFolder);
            this.grpBuildTools.Controls.Add(this.chkCopyBsp);
            this.grpBuildTools.Controls.Add(this.chkCopyRes);
            this.grpBuildTools.Controls.Add(this.chkCopyErr);
            this.grpBuildTools.Controls.Add(this.chkCopyLog);
            this.grpBuildTools.Controls.Add(this.chkCopyMap);
            this.grpBuildTools.Controls.Add(this.chkMapCopyBsp);
            this.grpBuildTools.Controls.Add(this.chkAskRunGame);
            this.grpBuildTools.Controls.Add(this.chkRunGame);
            this.grpBuildTools.Controls.Add(this.lblBuildExeFolder);
            this.grpBuildTools.Controls.Add(this.lblBuildBSP);
            this.grpBuildTools.Controls.Add(this.txtBuildToolsDirectory);
            this.grpBuildTools.Controls.Add(this.cmbRadExe);
            this.grpBuildTools.Controls.Add(this.cmbBspExe);
            this.grpBuildTools.Controls.Add(this.lblBuildVIS);
            this.grpBuildTools.Controls.Add(this.cmbVisExe);
            this.grpBuildTools.Controls.Add(this.lblBuildRAD);
            this.grpBuildTools.Controls.Add(this.btnBuildToolsBrowse);
            this.grpBuildTools.Location = new System.Drawing.Point(6, 418);
            this.grpBuildTools.Name = "grpBuildTools";
            this.grpBuildTools.Size = new System.Drawing.Size(459, 249);
            this.grpBuildTools.TabIndex = 48;
            this.grpBuildTools.TabStop = false;
            this.grpBuildTools.Text = "Build Tools";
            // 
            // lblCopyToMapFolder
            // 
            this.lblCopyToMapFolder.Location = new System.Drawing.Point(6, 220);
            this.lblCopyToMapFolder.Name = "lblCopyToMapFolder";
            this.lblCopyToMapFolder.Size = new System.Drawing.Size(182, 20);
            this.lblCopyToMapFolder.TabIndex = 43;
            this.lblCopyToMapFolder.Text = "Copy to map folder:";
            this.lblCopyToMapFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkCopyBsp
            // 
            this.chkCopyBsp.Checked = true;
            this.chkCopyBsp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopyBsp.Location = new System.Drawing.Point(75, 145);
            this.chkCopyBsp.Name = "chkCopyBsp";
            this.chkCopyBsp.Size = new System.Drawing.Size(368, 20);
            this.chkCopyBsp.TabIndex = 42;
            this.chkCopyBsp.Text = "Copy BSP/RES to game folder";
            this.chkCopyBsp.UseVisualStyleBackColor = true;
            // 
            // chkCopyRes
            // 
            this.chkCopyRes.Checked = true;
            this.chkCopyRes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopyRes.Location = new System.Drawing.Point(379, 219);
            this.chkCopyRes.Name = "chkCopyRes";
            this.chkCopyRes.Size = new System.Drawing.Size(49, 24);
            this.chkCopyRes.TabIndex = 42;
            this.chkCopyRes.Text = "RES";
            this.chkCopyRes.UseVisualStyleBackColor = true;
            // 
            // chkCopyErr
            // 
            this.chkCopyErr.Checked = true;
            this.chkCopyErr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopyErr.Location = new System.Drawing.Point(332, 219);
            this.chkCopyErr.Name = "chkCopyErr";
            this.chkCopyErr.Size = new System.Drawing.Size(49, 24);
            this.chkCopyErr.TabIndex = 42;
            this.chkCopyErr.Text = "ERR";
            this.chkCopyErr.UseVisualStyleBackColor = true;
            // 
            // chkCopyLog
            // 
            this.chkCopyLog.Checked = true;
            this.chkCopyLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopyLog.Location = new System.Drawing.Point(284, 219);
            this.chkCopyLog.Name = "chkCopyLog";
            this.chkCopyLog.Size = new System.Drawing.Size(49, 24);
            this.chkCopyLog.TabIndex = 42;
            this.chkCopyLog.Text = "LOG";
            this.chkCopyLog.UseVisualStyleBackColor = true;
            // 
            // chkCopyMap
            // 
            this.chkCopyMap.Checked = true;
            this.chkCopyMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopyMap.Location = new System.Drawing.Point(238, 219);
            this.chkCopyMap.Name = "chkCopyMap";
            this.chkCopyMap.Size = new System.Drawing.Size(49, 24);
            this.chkCopyMap.TabIndex = 42;
            this.chkCopyMap.Text = "MAP";
            this.chkCopyMap.UseVisualStyleBackColor = true;
            // 
            // chkMapCopyBsp
            // 
            this.chkMapCopyBsp.Checked = true;
            this.chkMapCopyBsp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMapCopyBsp.Location = new System.Drawing.Point(194, 219);
            this.chkMapCopyBsp.Name = "chkMapCopyBsp";
            this.chkMapCopyBsp.Size = new System.Drawing.Size(49, 24);
            this.chkMapCopyBsp.TabIndex = 42;
            this.chkMapCopyBsp.Text = "BSP";
            this.chkMapCopyBsp.UseVisualStyleBackColor = true;
            // 
            // chkAskRunGame
            // 
            this.chkAskRunGame.Checked = true;
            this.chkAskRunGame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAskRunGame.Location = new System.Drawing.Point(75, 197);
            this.chkAskRunGame.Name = "chkAskRunGame";
            this.chkAskRunGame.Size = new System.Drawing.Size(368, 20);
            this.chkAskRunGame.TabIndex = 42;
            this.chkAskRunGame.Text = "Ask before running the game";
            this.chkAskRunGame.UseVisualStyleBackColor = true;
            // 
            // chkRunGame
            // 
            this.chkRunGame.Checked = true;
            this.chkRunGame.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRunGame.Location = new System.Drawing.Point(75, 171);
            this.chkRunGame.Name = "chkRunGame";
            this.chkRunGame.Size = new System.Drawing.Size(368, 20);
            this.chkRunGame.TabIndex = 42;
            this.chkRunGame.Text = "Run the game after successful compile";
            this.chkRunGame.UseVisualStyleBackColor = true;
            // 
            // lblBuildExeFolder
            // 
            this.lblBuildExeFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBuildExeFolder.Location = new System.Drawing.Point(6, 16);
            this.lblBuildExeFolder.Name = "lblBuildExeFolder";
            this.lblBuildExeFolder.Size = new System.Drawing.Size(357, 20);
            this.lblBuildExeFolder.TabIndex = 27;
            this.lblBuildExeFolder.Text = "Folder containing build executables:";
            this.lblBuildExeFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBuildBSP
            // 
            this.lblBuildBSP.Location = new System.Drawing.Point(15, 65);
            this.lblBuildBSP.Name = "lblBuildBSP";
            this.lblBuildBSP.Size = new System.Drawing.Size(54, 20);
            this.lblBuildBSP.TabIndex = 23;
            this.lblBuildBSP.Text = "VBSP";
            this.lblBuildBSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBuildToolsDirectory
            // 
            this.txtBuildToolsDirectory.Location = new System.Drawing.Point(9, 38);
            this.txtBuildToolsDirectory.Name = "txtBuildToolsDirectory";
            this.txtBuildToolsDirectory.Size = new System.Drawing.Size(354, 20);
            this.txtBuildToolsDirectory.TabIndex = 22;
            this.txtBuildToolsDirectory.Text = "example: C:\\hammer_alt";
            this.txtBuildToolsDirectory.TextChanged += new System.EventHandler(this.BuildToolsDirectoryTextChanged);
            // 
            // cmbRadExe
            // 
            this.cmbRadExe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRadExe.FormattingEnabled = true;
            this.cmbRadExe.Location = new System.Drawing.Point(75, 118);
            this.cmbRadExe.Name = "cmbRadExe";
            this.cmbRadExe.Size = new System.Drawing.Size(153, 21);
            this.cmbRadExe.TabIndex = 28;
            // 
            // cmbBspExe
            // 
            this.cmbBspExe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBspExe.FormattingEnabled = true;
            this.cmbBspExe.Location = new System.Drawing.Point(75, 64);
            this.cmbBspExe.Name = "cmbBspExe";
            this.cmbBspExe.Size = new System.Drawing.Size(153, 21);
            this.cmbBspExe.TabIndex = 29;
            // 
            // lblBuildVIS
            // 
            this.lblBuildVIS.Location = new System.Drawing.Point(18, 92);
            this.lblBuildVIS.Name = "lblBuildVIS";
            this.lblBuildVIS.Size = new System.Drawing.Size(51, 20);
            this.lblBuildVIS.TabIndex = 25;
            this.lblBuildVIS.Text = "VVIS";
            this.lblBuildVIS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbVisExe
            // 
            this.cmbVisExe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisExe.FormattingEnabled = true;
            this.cmbVisExe.Location = new System.Drawing.Point(75, 91);
            this.cmbVisExe.Name = "cmbVisExe";
            this.cmbVisExe.Size = new System.Drawing.Size(153, 21);
            this.cmbVisExe.TabIndex = 30;
            // 
            // lblBuildRAD
            // 
            this.lblBuildRAD.Location = new System.Drawing.Point(21, 119);
            this.lblBuildRAD.Name = "lblBuildRAD";
            this.lblBuildRAD.Size = new System.Drawing.Size(48, 20);
            this.lblBuildRAD.TabIndex = 26;
            this.lblBuildRAD.Text = "VRAD";
            this.lblBuildRAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuildToolsBrowse
            // 
            this.btnBuildToolsBrowse.Location = new System.Drawing.Point(369, 38);
            this.btnBuildToolsBrowse.Name = "btnBuildToolsBrowse";
            this.btnBuildToolsBrowse.Size = new System.Drawing.Size(74, 20);
            this.btnBuildToolsBrowse.TabIndex = 32;
            this.btnBuildToolsBrowse.Text = "Browse...";
            this.btnBuildToolsBrowse.UseVisualStyleBackColor = true;
            this.btnBuildToolsBrowse.Click += new System.EventHandler(this.BrowseBuildToolsDirectory);
            // 
            // grpTextures
            // 
            this.grpTextures.Controls.Add(this.listExcludedMaterialDirs);
            this.grpTextures.Controls.Add(this.txtCordonTextureName);
            this.grpTextures.Controls.Add(this.lblCordonTextureName);
            this.grpTextures.Controls.Add(this.btnRemoveMaterialExclude);
            this.grpTextures.Controls.Add(this.btnAddMaterialExclude);
            this.grpTextures.Controls.Add(this.lblTexturePackageExclusions);
            this.grpTextures.Controls.Add(this.lblDefaultTextureScale);
            this.grpTextures.Controls.Add(this.nudDefaultTextureScale);
            this.grpTextures.Location = new System.Drawing.Point(3, 673);
            this.grpTextures.Name = "grpTextures";
            this.grpTextures.Size = new System.Drawing.Size(459, 261);
            this.grpTextures.TabIndex = 49;
            this.grpTextures.TabStop = false;
            this.grpTextures.Text = "Textures";
            // 
            // lblTexturePackageExclusions
            // 
            this.lblTexturePackageExclusions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTexturePackageExclusions.Location = new System.Drawing.Point(7, 62);
            this.lblTexturePackageExclusions.Name = "lblTexturePackageExclusions";
            this.lblTexturePackageExclusions.Size = new System.Drawing.Size(314, 20);
            this.lblTexturePackageExclusions.TabIndex = 34;
            this.lblTexturePackageExclusions.Text = "Material directory exclusion list";
            this.lblTexturePackageExclusions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbGameExe
            // 
            this.cmbGameExe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGameExe.FormattingEnabled = true;
            this.cmbGameExe.Items.AddRange(new object[] {
            "Valve"});
            this.cmbGameExe.Location = new System.Drawing.Point(210, 67);
            this.cmbGameExe.Name = "cmbGameExe";
            this.cmbGameExe.Size = new System.Drawing.Size(153, 21);
            this.cmbGameExe.TabIndex = 18;
            // 
            // lblGameExe
            // 
            this.lblGameExe.Location = new System.Drawing.Point(3, 66);
            this.lblGameExe.Name = "lblGameExe";
            this.lblGameExe.Size = new System.Drawing.Size(198, 20);
            this.lblGameExe.TabIndex = 16;
            this.lblGameExe.Text = "Game Executable (e.g. \'hl.exe\')";
            this.lblGameExe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAddMaterialExclude
            // 
            this.btnAddMaterialExclude.Location = new System.Drawing.Point(379, 85);
            this.btnAddMaterialExclude.Name = "btnAddMaterialExclude";
            this.btnAddMaterialExclude.Size = new System.Drawing.Size(69, 23);
            this.btnAddMaterialExclude.TabIndex = 40;
            this.btnAddMaterialExclude.Text = "Add";
            this.btnAddMaterialExclude.UseVisualStyleBackColor = true;
            this.btnAddMaterialExclude.Click += new System.EventHandler(this.AddMaterialExclusion);
            // 
            // btnRemoveMaterialExclude
            // 
            this.btnRemoveMaterialExclude.Location = new System.Drawing.Point(379, 114);
            this.btnRemoveMaterialExclude.Name = "btnRemoveMaterialExclude";
            this.btnRemoveMaterialExclude.Size = new System.Drawing.Size(69, 23);
            this.btnRemoveMaterialExclude.TabIndex = 41;
            this.btnRemoveMaterialExclude.Text = "Remove";
            this.btnRemoveMaterialExclude.UseVisualStyleBackColor = true;
            this.btnRemoveMaterialExclude.Click += new System.EventHandler(this.RemoveMaterialExclusion);
            // 
            // lblCordonTextureName
            // 
            this.lblCordonTextureName.AutoSize = true;
            this.lblCordonTextureName.Location = new System.Drawing.Point(9, 42);
            this.lblCordonTextureName.Name = "lblCordonTextureName";
            this.lblCordonTextureName.Size = new System.Drawing.Size(80, 13);
            this.lblCordonTextureName.TabIndex = 42;
            this.lblCordonTextureName.Text = "Cordon Texture";
            // 
            // txtCordonTextureName
            // 
            this.txtCordonTextureName.Location = new System.Drawing.Point(95, 39);
            this.txtCordonTextureName.Name = "txtCordonTextureName";
            this.txtCordonTextureName.Size = new System.Drawing.Size(192, 20);
            this.txtCordonTextureName.TabIndex = 43;
            // 
            // txtGameModDir
            // 
            this.txtGameModDir.Location = new System.Drawing.Point(107, 41);
            this.txtGameModDir.Name = "txtGameModDir";
            this.txtGameModDir.Size = new System.Drawing.Size(256, 20);
            this.txtGameModDir.TabIndex = 21;
            this.txtGameModDir.Text = "example: $SteamDir\\steamapps\\sourcemods\\hl2mod";
            // 
            // btnGameModBrowse
            // 
            this.btnGameModBrowse.Location = new System.Drawing.Point(369, 41);
            this.btnGameModBrowse.Name = "btnGameModBrowse";
            this.btnGameModBrowse.Size = new System.Drawing.Size(74, 20);
            this.btnGameModBrowse.TabIndex = 22;
            this.btnGameModBrowse.Text = "Browse...";
            this.btnGameModBrowse.UseVisualStyleBackColor = true;
            // 
            // listExcludedMaterialDirs
            // 
            this.listExcludedMaterialDirs.FormattingEnabled = true;
            this.listExcludedMaterialDirs.Location = new System.Drawing.Point(6, 85);
            this.listExcludedMaterialDirs.Name = "listExcludedMaterialDirs";
            this.listExcludedMaterialDirs.Size = new System.Drawing.Size(367, 160);
            this.listExcludedMaterialDirs.TabIndex = 44;
            // 
            // SourceEnvironmentEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpTextures);
            this.Controls.Add(this.grpBuildTools);
            this.Controls.Add(this.grpFgds);
            this.Controls.Add(this.grpDirectories);
            this.Name = "SourceEnvironmentEditor";
            this.Size = new System.Drawing.Size(472, 939);
            ((System.ComponentModel.ISupportInitialize)(this.nudDefaultTextureScale)).EndInit();
            this.grpDirectories.ResumeLayout(false);
            this.grpDirectories.PerformLayout();
            this.grpFgds.ResumeLayout(false);
            this.grpBuildTools.ResumeLayout(false);
            this.grpBuildTools.PerformLayout();
            this.grpTextures.ResumeLayout(false);
            this.grpTextures.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBaseGame;
        private System.Windows.Forms.TextBox txtGameDir;
        private System.Windows.Forms.Label lblGameDir;
        private System.Windows.Forms.Button btnGameDirBrowse;
        private System.Windows.Forms.ListView lstFgds;
        private System.Windows.Forms.ColumnHeader colFgdName;
        private System.Windows.Forms.ColumnHeader colFgdPath;
        private System.Windows.Forms.Button btnAddFgd;
        private System.Windows.Forms.Label lblDefaultBrushEntity;
        private System.Windows.Forms.Button btnRemoveFgd;
        private System.Windows.Forms.Label lblDefaultPointEntity;
        private System.Windows.Forms.ComboBox cmbDefaultBrushEntity;
        private System.Windows.Forms.ComboBox cmbDefaultPointEntity;
        private System.Windows.Forms.NumericUpDown nudDefaultTextureScale;
        private System.Windows.Forms.Label lblDefaultTextureScale;
        private System.Windows.Forms.ComboBox cmbMapSizeOverrideHigh;
        private System.Windows.Forms.Label lblMapSizeOverrideHigh;
        private System.Windows.Forms.ComboBox cmbMapSizeOverrideLow;
        private System.Windows.Forms.CheckBox chkOverrideMapSize;
        private System.Windows.Forms.Label lblMapSizeOverrideLow;
        private System.Windows.Forms.GroupBox grpDirectories;
        private System.Windows.Forms.GroupBox grpFgds;
        private System.Windows.Forms.GroupBox grpBuildTools;
        private System.Windows.Forms.Label lblBuildExeFolder;
        private System.Windows.Forms.Label lblBuildBSP;
        private System.Windows.Forms.TextBox txtBuildToolsDirectory;
        private System.Windows.Forms.ComboBox cmbRadExe;
        private System.Windows.Forms.ComboBox cmbBspExe;
        private System.Windows.Forms.Label lblBuildVIS;
        private System.Windows.Forms.ComboBox cmbVisExe;
        private System.Windows.Forms.Label lblBuildRAD;
        private System.Windows.Forms.Button btnBuildToolsBrowse;
        private System.Windows.Forms.GroupBox grpTextures;
        private System.Windows.Forms.Label lblTexturePackageExclusions;
        private System.Windows.Forms.Label lblCopyToMapFolder;
        private System.Windows.Forms.CheckBox chkCopyBsp;
        private System.Windows.Forms.CheckBox chkCopyRes;
        private System.Windows.Forms.CheckBox chkCopyErr;
        private System.Windows.Forms.CheckBox chkCopyLog;
        private System.Windows.Forms.CheckBox chkCopyMap;
        private System.Windows.Forms.CheckBox chkMapCopyBsp;
        private System.Windows.Forms.CheckBox chkAskRunGame;
        private System.Windows.Forms.CheckBox chkRunGame;
        private System.Windows.Forms.ComboBox cmbGameExe;
        private System.Windows.Forms.Label lblGameExe;
        private System.Windows.Forms.Button btnAddMaterialExclude;
        private System.Windows.Forms.Button btnRemoveMaterialExclude;
        private System.Windows.Forms.Label lblCordonTextureName;
        private System.Windows.Forms.TextBox txtCordonTextureName;
        private System.Windows.Forms.TextBox txtGameModDir;
        private System.Windows.Forms.Button btnGameModBrowse;
        private System.Windows.Forms.ListBox listExcludedMaterialDirs;
    }
}
