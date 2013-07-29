namespace Project_SFX_Config
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainMenu = new System.Windows.Forms.MenuStrip();
			this.TFile_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.TNewFile_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.TOpenFile_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.TSaveFile_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.TSaveFileAs_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.MRUList = new System.Windows.Forms.ToolStripMenuItem();
			this.ClearMRU = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.Clean = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.TClose_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.TTools_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.TChkSyntax_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.TPreference_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.THelping_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.THelp_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.TSiteModule_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.TSiteProgramm_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.TAbout_Menu = new System.Windows.Forms.ToolStripMenuItem();
			this.StatusBar = new System.Windows.Forms.StatusStrip();
			this.TStateLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.Tabs = new System.Windows.Forms.TabControl();
			this.TUnpackTab = new System.Windows.Forms.TabPage();
			this.TlistDown = new System.Windows.Forms.Button();
			this.TListUp = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label24 = new System.Windows.Forms.Label();
			this.TListx86Arch = new System.Windows.Forms.RadioButton();
			this.TListLangCombo = new System.Windows.Forms.ComboBox();
			this.TListx64Arch = new System.Windows.Forms.RadioButton();
			this.TListNoArch = new System.Windows.Forms.RadioButton();
			this.TModifText = new System.Windows.Forms.TextBox();
			this.Empty = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.TParamText = new System.Windows.Forms.TextBox();
			this.TCommText = new System.Windows.Forms.TextBox();
			this.TComDelete = new System.Windows.Forms.Button();
			this.TComAddBt = new System.Windows.Forms.Button();
			this.TCommandsList = new System.Windows.Forms.ListView();
			this.TIndexCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TCommandColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TParamColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TSectionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.TComListContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.TDoublicate_List = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.TDelete_List = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.TDesignTab = new System.Windows.Forms.TabPage();
			this.TOverwritesysCheck = new System.Windows.Forms.CheckBox();
			this.TOverWriteCombo = new System.Windows.Forms.ComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.TMiscList = new System.Windows.Forms.CheckedListBox();
			this.TSelfDeleteCheck = new System.Windows.Forms.CheckBox();
			this.TGUIMode = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TDesignList = new System.Windows.Forms.CheckedListBox();
			this.TTextsTab = new System.Windows.Forms.TabPage();
			this.TTextLangsCombo = new System.Windows.Forms.ComboBox();
			this.label23 = new System.Windows.Forms.Label();
			this.TBeginPromptTimeOut = new System.Windows.Forms.NumericUpDown();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.TPasswordText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TPasswordTitleEdit = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TWarningTitleEdit = new System.Windows.Forms.TextBox();
			this.THelpTextEdit = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.TCancelPromptText = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.TExtractCancelText = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.TErrorTitle = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.TExtractDialogText = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.TExtractPathText = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.TExtractPathTitle = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.TExtractTitle = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.TFinishMessageEdit = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TBeginPromptEdit = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TTitle = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.THelpTextBt = new System.Windows.Forms.Button();
			this.TCancelPromptBt = new System.Windows.Forms.Button();
			this.TExtractDialogBt = new System.Windows.Forms.Button();
			this.TExtractPathTextBt = new System.Windows.Forms.Button();
			this.TFinishMessageBt = new System.Windows.Forms.Button();
			this.TBeginPromptBt = new System.Windows.Forms.Button();
			this.SaveFile = new System.Windows.Forms.SaveFileDialog();
			this.PanelBar = new System.Windows.Forms.ToolStrip();
			this.TNewToolButton = new System.Windows.Forms.ToolStripButton();
			this.TOpenToolButton = new System.Windows.Forms.ToolStripButton();
			this.TSaveToolButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.TCheckButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.OpenFile = new System.Windows.Forms.OpenFileDialog();
			this.ToolTiper = new System.Windows.Forms.ToolTip(this.components);
			this.MainMenu.SuspendLayout();
			this.StatusBar.SuspendLayout();
			this.Tabs.SuspendLayout();
			this.TUnpackTab.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.TComListContext.SuspendLayout();
			this.TDesignTab.SuspendLayout();
			this.TTextsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TBeginPromptTimeOut)).BeginInit();
			this.PanelBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu
			// 
			this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TFile_Menu,
            this.TTools_Menu,
            this.THelping_Menu});
			this.MainMenu.Location = new System.Drawing.Point(0, 0);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(691, 24);
			this.MainMenu.TabIndex = 0;
			this.MainMenu.Text = "menuStrip1";
			// 
			// TFile_Menu
			// 
			this.TFile_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TNewFile_Menu,
            this.TOpenFile_Menu,
            this.TSaveFile_Menu,
            this.TSaveFileAs_Menu,
            this.toolStripMenuItem3,
            this.MRUList,
            this.toolStripMenuItem5,
            this.TClose_Menu});
			this.TFile_Menu.Name = "TFile_Menu";
			this.TFile_Menu.Size = new System.Drawing.Size(48, 20);
			this.TFile_Menu.Text = "Файл";
			// 
			// TNewFile_Menu
			// 
			this.TNewFile_Menu.Image = global::Project_SFX_Config.Properties.Resources.page_white_text;
			this.TNewFile_Menu.Name = "TNewFile_Menu";
			this.TNewFile_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.TNewFile_Menu.Size = new System.Drawing.Size(234, 22);
			this.TNewFile_Menu.Text = "Новый...";
			this.TNewFile_Menu.Click += new System.EventHandler(this.NewFileMenuClick);
			// 
			// TOpenFile_Menu
			// 
			this.TOpenFile_Menu.Image = global::Project_SFX_Config.Properties.Resources.folder_table;
			this.TOpenFile_Menu.Name = "TOpenFile_Menu";
			this.TOpenFile_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.TOpenFile_Menu.Size = new System.Drawing.Size(234, 22);
			this.TOpenFile_Menu.Text = "Открыть....";
			this.TOpenFile_Menu.Click += new System.EventHandler(this.OpenFileMenuClick);
			// 
			// TSaveFile_Menu
			// 
			this.TSaveFile_Menu.Enabled = false;
			this.TSaveFile_Menu.Image = global::Project_SFX_Config.Properties.Resources.disk;
			this.TSaveFile_Menu.Name = "TSaveFile_Menu";
			this.TSaveFile_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.TSaveFile_Menu.Size = new System.Drawing.Size(234, 22);
			this.TSaveFile_Menu.Text = "Сохранить...";
			this.TSaveFile_Menu.Click += new System.EventHandler(this.SaveFileMenuClick);
			// 
			// TSaveFileAs_Menu
			// 
			this.TSaveFileAs_Menu.Image = global::Project_SFX_Config.Properties.Resources.disk;
			this.TSaveFileAs_Menu.Name = "TSaveFileAs_Menu";
			this.TSaveFileAs_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.TSaveFileAs_Menu.Size = new System.Drawing.Size(234, 22);
			this.TSaveFileAs_Menu.Text = "Сохранить как...";
			this.TSaveFileAs_Menu.Click += new System.EventHandler(this.SaveFileAsMenuClick);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(231, 6);
			// 
			// MRUList
			// 
			this.MRUList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearMRU,
            this.toolStripSeparator4,
            this.Clean});
			this.MRUList.Image = global::Project_SFX_Config.Properties.Resources.folder_heart;
			this.MRUList.Name = "MRUList";
			this.MRUList.Size = new System.Drawing.Size(234, 22);
			this.MRUList.Text = "Недавние";
			// 
			// ClearMRU
			// 
			this.ClearMRU.Name = "ClearMRU";
			this.ClearMRU.Size = new System.Drawing.Size(135, 22);
			this.ClearMRU.Text = "Очистить...";
			this.ClearMRU.Click += new System.EventHandler(this.ClearMRU_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(132, 6);
			// 
			// Clean
			// 
			this.Clean.Enabled = false;
			this.Clean.Name = "Clean";
			this.Clean.Size = new System.Drawing.Size(135, 22);
			this.Clean.Text = "Пусто";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(231, 6);
			// 
			// TClose_Menu
			// 
			this.TClose_Menu.Image = global::Project_SFX_Config.Properties.Resources.door_open;
			this.TClose_Menu.Name = "TClose_Menu";
			this.TClose_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.TClose_Menu.Size = new System.Drawing.Size(234, 22);
			this.TClose_Menu.Text = "Выйти";
			this.TClose_Menu.Click += new System.EventHandler(this.CloseMenuClick);
			// 
			// TTools_Menu
			// 
			this.TTools_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TChkSyntax_Menu,
            this.toolStripMenuItem1,
            this.TPreference_Menu});
			this.TTools_Menu.Name = "TTools_Menu";
			this.TTools_Menu.Size = new System.Drawing.Size(95, 20);
			this.TTools_Menu.Text = "Инструменты";
			// 
			// TChkSyntax_Menu
			// 
			this.TChkSyntax_Menu.Image = global::Project_SFX_Config.Properties.Resources.tick;
			this.TChkSyntax_Menu.Name = "TChkSyntax_Menu";
			this.TChkSyntax_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
			this.TChkSyntax_Menu.Size = new System.Drawing.Size(267, 22);
			this.TChkSyntax_Menu.Text = "Проверить синтаксис";
			this.TChkSyntax_Menu.Click += new System.EventHandler(this.CheckButtonClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(264, 6);
			// 
			// TPreference_Menu
			// 
			this.TPreference_Menu.Image = global::Project_SFX_Config.Properties.Resources.wrench_orange;
			this.TPreference_Menu.Name = "TPreference_Menu";
			this.TPreference_Menu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.TPreference_Menu.Size = new System.Drawing.Size(267, 22);
			this.TPreference_Menu.Text = "Настройки програмы";
			this.TPreference_Menu.Click += new System.EventHandler(this.PreferenceMenuClick);
			// 
			// THelping_Menu
			// 
			this.THelping_Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.THelp_Menu,
            this.toolStripSeparator3,
            this.TSiteModule_Menu,
            this.TSiteProgramm_Menu,
            this.toolStripMenuItem2,
            this.TAbout_Menu});
			this.THelping_Menu.Name = "THelping_Menu";
			this.THelping_Menu.Size = new System.Drawing.Size(68, 20);
			this.THelping_Menu.Text = "Помощь";
			// 
			// THelp_Menu
			// 
			this.THelp_Menu.Image = global::Project_SFX_Config.Properties.Resources.help;
			this.THelp_Menu.Name = "THelp_Menu";
			this.THelp_Menu.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.THelp_Menu.Size = new System.Drawing.Size(233, 22);
			this.THelp_Menu.Text = "Справка модуля";
			this.THelp_Menu.Click += new System.EventHandler(this.HelpMenuClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(230, 6);
			// 
			// TSiteModule_Menu
			// 
			this.TSiteModule_Menu.Image = global::Project_SFX_Config.Properties.Resources.world;
			this.TSiteModule_Menu.Name = "TSiteModule_Menu";
			this.TSiteModule_Menu.Size = new System.Drawing.Size(233, 22);
			this.TSiteModule_Menu.Text = "Перейти на сайт модуля";
			this.TSiteModule_Menu.Click += new System.EventHandler(this.SiteModuleMenuClick);
			// 
			// TSiteProgramm_Menu
			// 
			this.TSiteProgramm_Menu.Image = global::Project_SFX_Config.Properties.Resources.world_go;
			this.TSiteProgramm_Menu.Name = "TSiteProgramm_Menu";
			this.TSiteProgramm_Menu.Size = new System.Drawing.Size(233, 22);
			this.TSiteProgramm_Menu.Text = "Перейти на сайт программы";
			this.TSiteProgramm_Menu.Click += new System.EventHandler(this.SiteProgrammMenuClick);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(230, 6);
			// 
			// TAbout_Menu
			// 
			this.TAbout_Menu.Image = global::Project_SFX_Config.Properties.Resources.information;
			this.TAbout_Menu.Name = "TAbout_Menu";
			this.TAbout_Menu.Size = new System.Drawing.Size(233, 22);
			this.TAbout_Menu.Text = "О программе...";
			this.TAbout_Menu.Click += new System.EventHandler(this.AboutMenuClick);
			// 
			// StatusBar
			// 
			this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TStateLabel});
			this.StatusBar.Location = new System.Drawing.Point(0, 482);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new System.Drawing.Size(691, 22);
			this.StatusBar.SizingGrip = false;
			this.StatusBar.Stretch = false;
			this.StatusBar.TabIndex = 1;
			this.StatusBar.Text = "statusStrip1";
			// 
			// TStateLabel
			// 
			this.TStateLabel.Name = "TStateLabel";
			this.TStateLabel.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.TStateLabel.Size = new System.Drawing.Size(676, 17);
			this.TStateLabel.Spring = true;
			this.TStateLabel.Text = "Готов...";
			this.TStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Tabs
			// 
			this.Tabs.Controls.Add(this.TUnpackTab);
			this.Tabs.Controls.Add(this.TDesignTab);
			this.Tabs.Controls.Add(this.TTextsTab);
			this.Tabs.Location = new System.Drawing.Point(3, 52);
			this.Tabs.Name = "Tabs";
			this.Tabs.SelectedIndex = 0;
			this.Tabs.Size = new System.Drawing.Size(688, 425);
			this.Tabs.TabIndex = 2;
			// 
			// TUnpackTab
			// 
			this.TUnpackTab.Controls.Add(this.TlistDown);
			this.TUnpackTab.Controls.Add(this.TListUp);
			this.TUnpackTab.Controls.Add(this.groupBox1);
			this.TUnpackTab.Controls.Add(this.TModifText);
			this.TUnpackTab.Controls.Add(this.label21);
			this.TUnpackTab.Controls.Add(this.label20);
			this.TUnpackTab.Controls.Add(this.label19);
			this.TUnpackTab.Controls.Add(this.TParamText);
			this.TUnpackTab.Controls.Add(this.TCommText);
			this.TUnpackTab.Controls.Add(this.TComDelete);
			this.TUnpackTab.Controls.Add(this.TComAddBt);
			this.TUnpackTab.Controls.Add(this.TCommandsList);
			this.TUnpackTab.Location = new System.Drawing.Point(4, 22);
			this.TUnpackTab.Name = "TUnpackTab";
			this.TUnpackTab.Padding = new System.Windows.Forms.Padding(3);
			this.TUnpackTab.Size = new System.Drawing.Size(680, 399);
			this.TUnpackTab.TabIndex = 1;
			this.TUnpackTab.Text = "Исполнение";
			this.TUnpackTab.UseVisualStyleBackColor = true;
			// 
			// TlistDown
			// 
			this.TlistDown.Image = global::Project_SFX_Config.Properties.Resources.bullet_arrow_down;
			this.TlistDown.Location = new System.Drawing.Point(597, 164);
			this.TlistDown.Name = "TlistDown";
			this.TlistDown.Size = new System.Drawing.Size(25, 27);
			this.TlistDown.TabIndex = 11;
			this.TlistDown.UseVisualStyleBackColor = true;
			this.TlistDown.Click += new System.EventHandler(this.TlistDownClick);
			// 
			// TListUp
			// 
			this.TListUp.Image = global::Project_SFX_Config.Properties.Resources.bullet_arrow_up;
			this.TListUp.Location = new System.Drawing.Point(597, 131);
			this.TListUp.Name = "TListUp";
			this.TListUp.Size = new System.Drawing.Size(25, 27);
			this.TListUp.TabIndex = 10;
			this.TListUp.UseVisualStyleBackColor = true;
			this.TListUp.Click += new System.EventHandler(this.ListUpClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.TListx86Arch);
			this.groupBox1.Controls.Add(this.TListLangCombo);
			this.groupBox1.Controls.Add(this.TListx64Arch);
			this.groupBox1.Controls.Add(this.TListNoArch);
			this.groupBox1.Location = new System.Drawing.Point(348, 314);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(243, 79);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Секция";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(67, 18);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(38, 13);
			this.label24.TabIndex = 4;
			this.label24.Text = "Язык:";
			// 
			// TListx86Arch
			// 
			this.TListx86Arch.AutoSize = true;
			this.TListx86Arch.Location = new System.Drawing.Point(6, 32);
			this.TListx86Arch.Name = "TListx86Arch";
			this.TListx86Arch.Size = new System.Drawing.Size(42, 17);
			this.TListx86Arch.TabIndex = 3;
			this.TListx86Arch.Text = "x86";
			this.TListx86Arch.UseVisualStyleBackColor = true;
			this.TListx86Arch.Click += new System.EventHandler(this.Listx86ArchClick);
			// 
			// TListLangCombo
			// 
			this.TListLangCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TListLangCombo.FormattingEnabled = true;
			this.TListLangCombo.Items.AddRange(new object[] {
            "Отсутствует"});
			this.TListLangCombo.Location = new System.Drawing.Point(70, 34);
			this.TListLangCombo.Name = "TListLangCombo";
			this.TListLangCombo.Size = new System.Drawing.Size(163, 21);
			this.TListLangCombo.TabIndex = 2;
			this.TListLangCombo.SelectedIndexChanged += new System.EventHandler(this.ListLangComboSelectedIndexChanged);
			// 
			// TListx64Arch
			// 
			this.TListx64Arch.AutoSize = true;
			this.TListx64Arch.Location = new System.Drawing.Point(6, 48);
			this.TListx64Arch.Name = "TListx64Arch";
			this.TListx64Arch.Size = new System.Drawing.Size(42, 17);
			this.TListx64Arch.TabIndex = 1;
			this.TListx64Arch.Text = "x64";
			this.TListx64Arch.UseVisualStyleBackColor = true;
			this.TListx64Arch.Click += new System.EventHandler(this.Listx64ArchClick);
			// 
			// TListNoArch
			// 
			this.TListNoArch.AutoSize = true;
			this.TListNoArch.Checked = true;
			this.TListNoArch.Location = new System.Drawing.Point(6, 16);
			this.TListNoArch.Name = "TListNoArch";
			this.TListNoArch.Size = new System.Drawing.Size(44, 17);
			this.TListNoArch.TabIndex = 0;
			this.TListNoArch.TabStop = true;
			this.TListNoArch.Text = "Нет";
			this.TListNoArch.UseVisualStyleBackColor = true;
			this.TListNoArch.Click += new System.EventHandler(this.ListNoArchClick);
			// 
			// TModifText
			// 
			this.TModifText.ContextMenuStrip = this.Empty;
			this.TModifText.Location = new System.Drawing.Point(282, 330);
			this.TModifText.MaxLength = 1;
			this.TModifText.Name = "TModifText";
			this.TModifText.Size = new System.Drawing.Size(60, 20);
			this.TModifText.TabIndex = 8;
			this.TModifText.TextChanged += new System.EventHandler(this.ModifTextTextChanged);
			this.TModifText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ModifTextKeyPress);
			// 
			// Empty
			// 
			this.Empty.Name = "Empty";
			this.Empty.Size = new System.Drawing.Size(61, 4);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(279, 314);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(47, 13);
			this.label21.TabIndex = 7;
			this.label21.Text = "Литера:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(3, 355);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(58, 13);
			this.label20.TabIndex = 6;
			this.label20.Text = "Значение:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(6, 314);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(61, 13);
			this.label19.TabIndex = 5;
			this.label19.Text = "Параметр:";
			// 
			// TParamText
			// 
			this.TParamText.Location = new System.Drawing.Point(6, 371);
			this.TParamText.Name = "TParamText";
			this.TParamText.Size = new System.Drawing.Size(336, 20);
			this.TParamText.TabIndex = 4;
			this.TParamText.TextChanged += new System.EventHandler(this.ParamTextTextChanged);
			// 
			// TCommText
			// 
			this.TCommText.Location = new System.Drawing.Point(6, 330);
			this.TCommText.Name = "TCommText";
			this.TCommText.Size = new System.Drawing.Size(270, 20);
			this.TCommText.TabIndex = 3;
			this.TCommText.TextChanged += new System.EventHandler(this.CommTextTextChanged);
			// 
			// TComDelete
			// 
			this.TComDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TComDelete.Image = global::Project_SFX_Config.Properties.Resources.delete2;
			this.TComDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.TComDelete.Location = new System.Drawing.Point(597, 248);
			this.TComDelete.Name = "TComDelete";
			this.TComDelete.Size = new System.Drawing.Size(75, 57);
			this.TComDelete.TabIndex = 2;
			this.TComDelete.Text = "Удалить";
			this.TComDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.TComDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.TComDelete.UseVisualStyleBackColor = true;
			this.TComDelete.Click += new System.EventHandler(this.ComDeleteClick);
			// 
			// TComAddBt
			// 
			this.TComAddBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TComAddBt.Image = global::Project_SFX_Config.Properties.Resources.plus;
			this.TComAddBt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.TComAddBt.Location = new System.Drawing.Point(597, 6);
			this.TComAddBt.Name = "TComAddBt";
			this.TComAddBt.Size = new System.Drawing.Size(75, 57);
			this.TComAddBt.TabIndex = 1;
			this.TComAddBt.Text = "Добавить";
			this.TComAddBt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.TComAddBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.TComAddBt.UseVisualStyleBackColor = true;
			this.TComAddBt.Click += new System.EventHandler(this.ComAddBtClick);
			// 
			// TCommandsList
			// 
			this.TCommandsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TIndexCol,
            this.TCommandColumn,
            this.TParamColumn,
            this.TSectionColumn});
			this.TCommandsList.ContextMenuStrip = this.TComListContext;
			this.TCommandsList.FullRowSelect = true;
			this.TCommandsList.GridLines = true;
			this.TCommandsList.Location = new System.Drawing.Point(6, 6);
			this.TCommandsList.Name = "TCommandsList";
			this.TCommandsList.Size = new System.Drawing.Size(585, 299);
			this.TCommandsList.SmallImageList = this.imageList;
			this.TCommandsList.TabIndex = 0;
			this.TCommandsList.UseCompatibleStateImageBehavior = false;
			this.TCommandsList.View = System.Windows.Forms.View.Details;
			this.TCommandsList.SelectedIndexChanged += new System.EventHandler(this.CommandsListSelectedIndexChanged);
			// 
			// TIndexCol
			// 
			this.TIndexCol.Text = "#";
			this.TIndexCol.Width = 43;
			// 
			// TCommandColumn
			// 
			this.TCommandColumn.Text = "Параметр";
			this.TCommandColumn.Width = 111;
			// 
			// TParamColumn
			// 
			this.TParamColumn.Text = "Значение";
			this.TParamColumn.Width = 310;
			// 
			// TSectionColumn
			// 
			this.TSectionColumn.Text = "Секция";
			this.TSectionColumn.Width = 117;
			// 
			// TComListContext
			// 
			this.TComListContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TDoublicate_List,
            this.toolStripMenuItem6,
            this.TDelete_List});
			this.TComListContext.Name = "contextMenuStrip1";
			this.TComListContext.Size = new System.Drawing.Size(147, 54);
			// 
			// TDoublicate_List
			// 
			this.TDoublicate_List.Image = global::Project_SFX_Config.Properties.Resources.page_copy;
			this.TDoublicate_List.Name = "TDoublicate_List";
			this.TDoublicate_List.Size = new System.Drawing.Size(146, 22);
			this.TDoublicate_List.Text = "Дублировать";
			this.TDoublicate_List.Click += new System.EventHandler(this.DoublicateListClick);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(143, 6);
			// 
			// TDelete_List
			// 
			this.TDelete_List.Image = global::Project_SFX_Config.Properties.Resources.delete;
			this.TDelete_List.Name = "TDelete_List";
			this.TDelete_List.Size = new System.Drawing.Size(146, 22);
			this.TDelete_List.Text = "Удалить";
			this.TDelete_List.Click += new System.EventHandler(this.DeleteListClick);
			// 
			// imageList
			// 
			this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "shortcut.png");
			this.imageList.Images.SetKeyName(1, "application_link.png");
			this.imageList.Images.SetKeyName(2, "application_xp_terminal.png");
			this.imageList.Images.SetKeyName(3, "delete.png");
			this.imageList.Images.SetKeyName(4, "question_frame.png");
			// 
			// TDesignTab
			// 
			this.TDesignTab.Controls.Add(this.TOverwritesysCheck);
			this.TDesignTab.Controls.Add(this.TOverWriteCombo);
			this.TDesignTab.Controls.Add(this.label22);
			this.TDesignTab.Controls.Add(this.label18);
			this.TDesignTab.Controls.Add(this.label17);
			this.TDesignTab.Controls.Add(this.TMiscList);
			this.TDesignTab.Controls.Add(this.TSelfDeleteCheck);
			this.TDesignTab.Controls.Add(this.TGUIMode);
			this.TDesignTab.Controls.Add(this.label1);
			this.TDesignTab.Controls.Add(this.TDesignList);
			this.TDesignTab.Location = new System.Drawing.Point(4, 22);
			this.TDesignTab.Name = "TDesignTab";
			this.TDesignTab.Size = new System.Drawing.Size(680, 399);
			this.TDesignTab.TabIndex = 2;
			this.TDesignTab.Text = "Внешний вид и параметры";
			this.TDesignTab.UseVisualStyleBackColor = true;
			// 
			// TOverwritesysCheck
			// 
			this.TOverwritesysCheck.AutoSize = true;
			this.TOverwritesysCheck.Location = new System.Drawing.Point(3, 359);
			this.TOverwritesysCheck.Name = "TOverwritesysCheck";
			this.TOverwritesysCheck.Size = new System.Drawing.Size(270, 17);
			this.TOverwritesysCheck.TabIndex = 9;
			this.TOverwritesysCheck.Text = "Пропускать файлы заблокированные системой";
			this.TOverwritesysCheck.UseVisualStyleBackColor = true;
			this.TOverwritesysCheck.CheckedChanged += new System.EventHandler(this.OverwritesysCheckCheckedChanged);
			// 
			// TOverWriteCombo
			// 
			this.TOverWriteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TOverWriteCombo.FormattingEnabled = true;
			this.TOverWriteCombo.Items.AddRange(new object[] {
            "Нет",
            "(0) - перезаписывать все файлы",
            "(1) - не перезаписывать существующие",
            "(2) - перезаписывать только старые"});
			this.TOverWriteCombo.Location = new System.Drawing.Point(3, 332);
			this.TOverWriteCombo.Name = "TOverWriteCombo";
			this.TOverWriteCombo.Size = new System.Drawing.Size(223, 21);
			this.TOverWriteCombo.TabIndex = 8;
			this.TOverWriteCombo.TextChanged += new System.EventHandler(this.OverWriteComboTextChanged);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(5, 316);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(82, 13);
			this.label22.TabIndex = 7;
			this.label22.Text = "OverwriteMode:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(5, 4);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(54, 13);
			this.label18.TabIndex = 6;
			this.label18.Text = "GUIFlags:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(233, 265);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(57, 13);
			this.label17.TabIndex = 5;
			this.label17.Text = "MiscFlags:";
			// 
			// TMiscList
			// 
			this.TMiscList.CheckOnClick = true;
			this.TMiscList.FormattingEnabled = true;
			this.TMiscList.Items.AddRange(new object[] {
            "(1) - не проверять свободное место на диске",
            "(2) - не проверять размер физической памяти",
            "(4) - запрашивать права администратора, если их нет у текущего пользователя",
            "(8) - запрашивать пароль после всех диалогов "});
			this.TMiscList.Location = new System.Drawing.Point(236, 281);
			this.TMiscList.Name = "TMiscList";
			this.TMiscList.Size = new System.Drawing.Size(441, 64);
			this.TMiscList.TabIndex = 4;
			this.TMiscList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MiscListMouseClick);
			// 
			// TSelfDeleteCheck
			// 
			this.TSelfDeleteCheck.AutoSize = true;
			this.TSelfDeleteCheck.Location = new System.Drawing.Point(314, 359);
			this.TSelfDeleteCheck.Name = "TSelfDeleteCheck";
			this.TSelfDeleteCheck.Size = new System.Drawing.Size(235, 17);
			this.TSelfDeleteCheck.TabIndex = 3;
			this.TSelfDeleteCheck.Text = "SelfDelete - удалять SFX после установки";
			this.TSelfDeleteCheck.UseVisualStyleBackColor = true;
			this.TSelfDeleteCheck.CheckedChanged += new System.EventHandler(this.SelfDeleteCheckCheckedChanged);
			// 
			// TGUIMode
			// 
			this.TGUIMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TGUIMode.FormattingEnabled = true;
			this.TGUIMode.Items.AddRange(new object[] {
            "Нет",
            "(0) - обычный режим",
            "(1) - без возможности отмены распаковки",
            "(2) - невидимый режим"});
			this.TGUIMode.Location = new System.Drawing.Point(3, 282);
			this.TGUIMode.Name = "TGUIMode";
			this.TGUIMode.Size = new System.Drawing.Size(223, 21);
			this.TGUIMode.TabIndex = 2;
			this.TGUIMode.TextChanged += new System.EventHandler(this.TguiModeTextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 265);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "GUIMode:";
			// 
			// TDesignList
			// 
			this.TDesignList.CheckOnClick = true;
			this.TDesignList.FormattingEnabled = true;
			this.TDesignList.Items.AddRange(new object[] {
            "(1) - отображать процент распаковки в заголовке окна процесса распаковки справа (" +
                "по умолчанию - слева)",
            "(2) - не отображать процент распаковки в заголовке окна процесса распаковки",
            "(4) - отображать процент распаковки под ProgressBar`ом",
            "(8) - использовать стили Windows XP",
            "(16) - использовать жирный шрифт для процента распаковки",
            "(32) - отображать иконку в окне процесса распаковки",
            "(64) - использовать для указания пути распаковки совмещенный диалог BeginPrompt +" +
                " ExtractPath",
            "(128) - использовать для указания пути распаковки отдельный диалог ExtractPath",
            "(256) - подтверждать отмену установки/распаковки",
            "(512) - не отображать иконку в заголовке всех окон и по [Alt+Tab]",
            "(1024) - отображать иконку в окне указания пути распаковки",
            "(2048) - отображать иконку модуля в BeginPrompt и в BeginPrompt + ExtractPath, вм" +
                "есто иконки со знаком вопроса",
            "(4096) - изменить в BeginPrompt и в BeginPrompt + ExtractPath названия кнопок",
            "(8192) - не отображать прогресс-бар на значке SFX архива в панели задач для Windo" +
                "ws 7 ",
            "(16384) - отображать символ \'&\' в текстах диалогов "});
			this.TDesignList.Location = new System.Drawing.Point(6, 20);
			this.TDesignList.Name = "TDesignList";
			this.TDesignList.Size = new System.Drawing.Size(669, 229);
			this.TDesignList.TabIndex = 0;
			this.TDesignList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DesignListMouseClick);
			// 
			// TTextsTab
			// 
			this.TTextsTab.Controls.Add(this.TTextLangsCombo);
			this.TTextsTab.Controls.Add(this.label23);
			this.TTextsTab.Controls.Add(this.TBeginPromptTimeOut);
			this.TTextsTab.Controls.Add(this.label16);
			this.TTextsTab.Controls.Add(this.label15);
			this.TTextsTab.Controls.Add(this.TPasswordText);
			this.TTextsTab.Controls.Add(this.label3);
			this.TTextsTab.Controls.Add(this.TPasswordTitleEdit);
			this.TTextsTab.Controls.Add(this.label2);
			this.TTextsTab.Controls.Add(this.TWarningTitleEdit);
			this.TTextsTab.Controls.Add(this.THelpTextEdit);
			this.TTextsTab.Controls.Add(this.label14);
			this.TTextsTab.Controls.Add(this.TCancelPromptText);
			this.TTextsTab.Controls.Add(this.label13);
			this.TTextsTab.Controls.Add(this.TExtractCancelText);
			this.TTextsTab.Controls.Add(this.label12);
			this.TTextsTab.Controls.Add(this.TErrorTitle);
			this.TTextsTab.Controls.Add(this.label11);
			this.TTextsTab.Controls.Add(this.TExtractDialogText);
			this.TTextsTab.Controls.Add(this.label10);
			this.TTextsTab.Controls.Add(this.TExtractPathText);
			this.TTextsTab.Controls.Add(this.label9);
			this.TTextsTab.Controls.Add(this.TExtractPathTitle);
			this.TTextsTab.Controls.Add(this.label8);
			this.TTextsTab.Controls.Add(this.TExtractTitle);
			this.TTextsTab.Controls.Add(this.label7);
			this.TTextsTab.Controls.Add(this.TFinishMessageEdit);
			this.TTextsTab.Controls.Add(this.label6);
			this.TTextsTab.Controls.Add(this.TBeginPromptEdit);
			this.TTextsTab.Controls.Add(this.label5);
			this.TTextsTab.Controls.Add(this.TTitle);
			this.TTextsTab.Controls.Add(this.label4);
			this.TTextsTab.Controls.Add(this.THelpTextBt);
			this.TTextsTab.Controls.Add(this.TCancelPromptBt);
			this.TTextsTab.Controls.Add(this.TExtractDialogBt);
			this.TTextsTab.Controls.Add(this.TExtractPathTextBt);
			this.TTextsTab.Controls.Add(this.TFinishMessageBt);
			this.TTextsTab.Controls.Add(this.TBeginPromptBt);
			this.TTextsTab.Location = new System.Drawing.Point(4, 22);
			this.TTextsTab.Name = "TTextsTab";
			this.TTextsTab.Size = new System.Drawing.Size(680, 399);
			this.TTextsTab.TabIndex = 3;
			this.TTextsTab.Text = "Тексты";
			this.TTextsTab.UseVisualStyleBackColor = true;
			// 
			// TTextLangsCombo
			// 
			this.TTextLangsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TTextLangsCombo.FormattingEnabled = true;
			this.TTextLangsCombo.Items.AddRange(new object[] {
            "Основная",
            "x86",
            "x64"});
			this.TTextLangsCombo.Location = new System.Drawing.Point(463, 364);
			this.TTextLangsCombo.Name = "TTextLangsCombo";
			this.TTextLangsCombo.Size = new System.Drawing.Size(202, 21);
			this.TTextLangsCombo.TabIndex = 37;
			this.TTextLangsCombo.SelectedIndexChanged += new System.EventHandler(this.TextLangsComboSelectedIndexChanged);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(399, 367);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(56, 13);
			this.label23.TabIndex = 36;
			this.label23.Text = "В секции:";
			// 
			// TBeginPromptTimeOut
			// 
			this.TBeginPromptTimeOut.Location = new System.Drawing.Point(584, 268);
			this.TBeginPromptTimeOut.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.TBeginPromptTimeOut.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
			this.TBeginPromptTimeOut.Name = "TBeginPromptTimeOut";
			this.TBeginPromptTimeOut.Size = new System.Drawing.Size(81, 20);
			this.TBeginPromptTimeOut.TabIndex = 35;
			this.TBeginPromptTimeOut.ValueChanged += new System.EventHandler(this.BeginPromptTimeOutValueChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(362, 264);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(187, 26);
			this.label16.TabIndex = 34;
			this.label16.Text = "BeginPromptTimeOut - таймаут окна \r\nперед установкой:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(362, 211);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(242, 13);
			this.label15.TabIndex = 33;
			this.label15.Text = "PasswordText - текст над полем ввода пароля:";
			// 
			// TPasswordText
			// 
			this.TPasswordText.Location = new System.Drawing.Point(365, 226);
			this.TPasswordText.Name = "TPasswordText";
			this.TPasswordText.Size = new System.Drawing.Size(300, 20);
			this.TPasswordText.TabIndex = 32;
			this.TPasswordText.TextChanged += new System.EventHandler(this.PasswordTextTextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(362, 170);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(249, 13);
			this.label3.TabIndex = 31;
			this.label3.Text = "PasswordTitle - заголовок окна запроса пароля:";
			// 
			// TPasswordTitleEdit
			// 
			this.TPasswordTitleEdit.Location = new System.Drawing.Point(365, 185);
			this.TPasswordTitleEdit.Name = "TPasswordTitleEdit";
			this.TPasswordTitleEdit.Size = new System.Drawing.Size(300, 20);
			this.TPasswordTitleEdit.TabIndex = 30;
			this.TPasswordTitleEdit.TextChanged += new System.EventHandler(this.PasswordTitleEditTextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(362, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(264, 13);
			this.label2.TabIndex = 29;
			this.label2.Text = "WarningTitle - заголовок окна с предупреждением:";
			// 
			// TWarningTitleEdit
			// 
			this.TWarningTitleEdit.Location = new System.Drawing.Point(365, 145);
			this.TWarningTitleEdit.Name = "TWarningTitleEdit";
			this.TWarningTitleEdit.Size = new System.Drawing.Size(300, 20);
			this.TWarningTitleEdit.TabIndex = 28;
			this.TWarningTitleEdit.TextChanged += new System.EventHandler(this.WarningTitleEditTextChanged);
			// 
			// THelpTextEdit
			// 
			this.THelpTextEdit.Location = new System.Drawing.Point(365, 105);
			this.THelpTextEdit.Name = "THelpTextEdit";
			this.THelpTextEdit.Size = new System.Drawing.Size(252, 20);
			this.THelpTextEdit.TabIndex = 21;
			this.THelpTextEdit.TextChanged += new System.EventHandler(this.HelpTextEditTextChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(362, 88);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(135, 13);
			this.label14.TabIndex = 20;
			this.label14.Text = "HelpText - текст справки:";
			// 
			// TCancelPromptText
			// 
			this.TCancelPromptText.Location = new System.Drawing.Point(365, 63);
			this.TCancelPromptText.Name = "TCancelPromptText";
			this.TCancelPromptText.Size = new System.Drawing.Size(252, 20);
			this.TCancelPromptText.TabIndex = 19;
			this.TCancelPromptText.TextChanged += new System.EventHandler(this.CancelPromptTextTextChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(362, 47);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(258, 13);
			this.label13.TabIndex = 18;
			this.label13.Text = "CancelPromptText - вопрос при отмене установки:";
			// 
			// TExtractCancelText
			// 
			this.TExtractCancelText.Location = new System.Drawing.Point(365, 22);
			this.TExtractCancelText.Name = "TExtractCancelText";
			this.TExtractCancelText.Size = new System.Drawing.Size(300, 20);
			this.TExtractCancelText.TabIndex = 17;
			this.TExtractCancelText.TextChanged += new System.EventHandler(this.ExtractCancelTextTextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(362, 6);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(270, 13);
			this.label12.TabIndex = 16;
			this.label12.Text = "ExtractCancelText - текст кнопки отмены установки:";
			// 
			// TErrorTitle
			// 
			this.TErrorTitle.Location = new System.Drawing.Point(16, 312);
			this.TErrorTitle.Name = "TErrorTitle";
			this.TErrorTitle.Size = new System.Drawing.Size(317, 20);
			this.TErrorTitle.TabIndex = 15;
			this.TErrorTitle.TextChanged += new System.EventHandler(this.ErrorTitleTextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(13, 296);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(274, 13);
			this.label11.TabIndex = 14;
			this.label11.Text = "ErrorTitle - заголовок окна с сообщением об ошибке:";
			// 
			// TExtractDialogText
			// 
			this.TExtractDialogText.Location = new System.Drawing.Point(16, 268);
			this.TExtractDialogText.Name = "TExtractDialogText";
			this.TExtractDialogText.Size = new System.Drawing.Size(269, 20);
			this.TExtractDialogText.TabIndex = 13;
			this.TExtractDialogText.TextChanged += new System.EventHandler(this.ExtractDialogTextTextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(13, 252);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(285, 13);
			this.label10.TabIndex = 12;
			this.label10.Text = "ExtractDialogText - текст над индикатором распаковки:";
			// 
			// TExtractPathText
			// 
			this.TExtractPathText.Location = new System.Drawing.Point(16, 227);
			this.TExtractPathText.Name = "TExtractPathText";
			this.TExtractPathText.Size = new System.Drawing.Size(269, 20);
			this.TExtractPathText.TabIndex = 11;
			this.TExtractPathText.TextChanged += new System.EventHandler(this.ExtractPathTextTextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(13, 211);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(290, 13);
			this.label9.TabIndex = 10;
			this.label9.Text = "ExtractPathText - текст над полем редактирования пути:";
			// 
			// TExtractPathTitle
			// 
			this.TExtractPathTitle.Location = new System.Drawing.Point(16, 186);
			this.TExtractPathTitle.Name = "TExtractPathTitle";
			this.TExtractPathTitle.Size = new System.Drawing.Size(317, 20);
			this.TExtractPathTitle.TabIndex = 9;
			this.TExtractPathTitle.TextChanged += new System.EventHandler(this.ExtractPathTitleTextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(13, 170);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(295, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "ExtractPathTitle - заголовок окна выбора пути установки:";
			// 
			// TExtractTitle
			// 
			this.TExtractTitle.Location = new System.Drawing.Point(16, 145);
			this.TExtractTitle.Name = "TExtractTitle";
			this.TExtractTitle.Size = new System.Drawing.Size(317, 20);
			this.TExtractTitle.TabIndex = 7;
			this.TExtractTitle.TextChanged += new System.EventHandler(this.ExtractTitleTextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 129);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(215, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "ExtractTitle - заголовок окна распаковки:";
			// 
			// TFinishMessageEdit
			// 
			this.TFinishMessageEdit.Location = new System.Drawing.Point(16, 104);
			this.TFinishMessageEdit.Name = "TFinishMessageEdit";
			this.TFinishMessageEdit.Size = new System.Drawing.Size(269, 20);
			this.TFinishMessageEdit.TabIndex = 5;
			this.TFinishMessageEdit.TextChanged += new System.EventHandler(this.FinishMessageEditTextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 88);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(272, 13);
			this.label6.TabIndex = 4;
			this.label6.Text = "FinishMessage - cообщение по окончании установки:";
			// 
			// TBeginPromptEdit
			// 
			this.TBeginPromptEdit.Location = new System.Drawing.Point(16, 63);
			this.TBeginPromptEdit.Name = "TBeginPromptEdit";
			this.TBeginPromptEdit.Size = new System.Drawing.Size(269, 20);
			this.TBeginPromptEdit.TabIndex = 3;
			this.TBeginPromptEdit.TextChanged += new System.EventHandler(this.BeginPromptEditTextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(228, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "BeginPrompt - текст окна перед установкой:";
			// 
			// TTitle
			// 
			this.TTitle.Location = new System.Drawing.Point(16, 22);
			this.TTitle.Name = "TTitle";
			this.TTitle.Size = new System.Drawing.Size(317, 20);
			this.TTitle.TabIndex = 1;
			this.TTitle.TextChanged += new System.EventHandler(this.TitleTextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(213, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Title - заголовок окна перед установкой:";
			// 
			// THelpTextBt
			// 
			this.THelpTextBt.Image = global::Project_SFX_Config.Properties.Resources.textfield;
			this.THelpTextBt.Location = new System.Drawing.Point(623, 103);
			this.THelpTextBt.Name = "THelpTextBt";
			this.THelpTextBt.Size = new System.Drawing.Size(42, 23);
			this.THelpTextBt.TabIndex = 27;
			this.THelpTextBt.UseVisualStyleBackColor = true;
			this.THelpTextBt.Click += new System.EventHandler(this.HelpTextBtClick);
			// 
			// TCancelPromptBt
			// 
			this.TCancelPromptBt.Image = global::Project_SFX_Config.Properties.Resources.textfield;
			this.TCancelPromptBt.Location = new System.Drawing.Point(623, 63);
			this.TCancelPromptBt.Name = "TCancelPromptBt";
			this.TCancelPromptBt.Size = new System.Drawing.Size(42, 23);
			this.TCancelPromptBt.TabIndex = 26;
			this.TCancelPromptBt.UseVisualStyleBackColor = true;
			this.TCancelPromptBt.Click += new System.EventHandler(this.CancelPromptBtClick);
			// 
			// TExtractDialogBt
			// 
			this.TExtractDialogBt.Image = global::Project_SFX_Config.Properties.Resources.textfield;
			this.TExtractDialogBt.Location = new System.Drawing.Point(291, 268);
			this.TExtractDialogBt.Name = "TExtractDialogBt";
			this.TExtractDialogBt.Size = new System.Drawing.Size(42, 23);
			this.TExtractDialogBt.TabIndex = 25;
			this.TExtractDialogBt.UseVisualStyleBackColor = true;
			this.TExtractDialogBt.Click += new System.EventHandler(this.ExtractDialogBtClick);
			// 
			// TExtractPathTextBt
			// 
			this.TExtractPathTextBt.Image = global::Project_SFX_Config.Properties.Resources.textfield;
			this.TExtractPathTextBt.Location = new System.Drawing.Point(291, 227);
			this.TExtractPathTextBt.Name = "TExtractPathTextBt";
			this.TExtractPathTextBt.Size = new System.Drawing.Size(42, 23);
			this.TExtractPathTextBt.TabIndex = 24;
			this.TExtractPathTextBt.UseVisualStyleBackColor = true;
			this.TExtractPathTextBt.Click += new System.EventHandler(this.ExtractPathTextBtClick);
			// 
			// TFinishMessageBt
			// 
			this.TFinishMessageBt.Image = global::Project_SFX_Config.Properties.Resources.textfield;
			this.TFinishMessageBt.Location = new System.Drawing.Point(291, 104);
			this.TFinishMessageBt.Name = "TFinishMessageBt";
			this.TFinishMessageBt.Size = new System.Drawing.Size(42, 23);
			this.TFinishMessageBt.TabIndex = 23;
			this.TFinishMessageBt.UseVisualStyleBackColor = true;
			this.TFinishMessageBt.Click += new System.EventHandler(this.FinishMessageBtClick);
			// 
			// TBeginPromptBt
			// 
			this.TBeginPromptBt.Image = global::Project_SFX_Config.Properties.Resources.textfield;
			this.TBeginPromptBt.Location = new System.Drawing.Point(291, 61);
			this.TBeginPromptBt.Name = "TBeginPromptBt";
			this.TBeginPromptBt.Size = new System.Drawing.Size(42, 22);
			this.TBeginPromptBt.TabIndex = 22;
			this.TBeginPromptBt.UseVisualStyleBackColor = true;
			this.TBeginPromptBt.Click += new System.EventHandler(this.BeginPromptBtClick);
			// 
			// SaveFile
			// 
			this.SaveFile.DefaultExt = "txt";
			this.SaveFile.Filter = "Текстовый файл (*.txt)|*.txt";
			// 
			// PanelBar
			// 
			this.PanelBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TNewToolButton,
            this.TOpenToolButton,
            this.TSaveToolButton,
            this.toolStripSeparator1,
            this.TCheckButton,
            this.toolStripSeparator2,
            this.toolStripButton1});
			this.PanelBar.Location = new System.Drawing.Point(0, 24);
			this.PanelBar.Name = "PanelBar";
			this.PanelBar.Size = new System.Drawing.Size(691, 25);
			this.PanelBar.TabIndex = 3;
			this.PanelBar.Text = "toolStrip1";
			// 
			// TNewToolButton
			// 
			this.TNewToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TNewToolButton.Image = global::Project_SFX_Config.Properties.Resources.page_white_text;
			this.TNewToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TNewToolButton.Name = "TNewToolButton";
			this.TNewToolButton.Size = new System.Drawing.Size(23, 22);
			this.TNewToolButton.Text = "Новый...";
			this.TNewToolButton.Click += new System.EventHandler(this.NewFileMenuClick);
			// 
			// TOpenToolButton
			// 
			this.TOpenToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TOpenToolButton.Image = global::Project_SFX_Config.Properties.Resources.folder_table;
			this.TOpenToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TOpenToolButton.Name = "TOpenToolButton";
			this.TOpenToolButton.Size = new System.Drawing.Size(23, 22);
			this.TOpenToolButton.Text = "Открыть...";
			this.TOpenToolButton.Click += new System.EventHandler(this.OpenFileMenuClick);
			// 
			// TSaveToolButton
			// 
			this.TSaveToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSaveToolButton.Enabled = false;
			this.TSaveToolButton.Image = global::Project_SFX_Config.Properties.Resources.disk;
			this.TSaveToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSaveToolButton.Name = "TSaveToolButton";
			this.TSaveToolButton.Size = new System.Drawing.Size(23, 22);
			this.TSaveToolButton.Text = "Сохранить...";
			this.TSaveToolButton.Click += new System.EventHandler(this.SaveFileMenuClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// TCheckButton
			// 
			this.TCheckButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TCheckButton.Image = global::Project_SFX_Config.Properties.Resources.tick;
			this.TCheckButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TCheckButton.Name = "TCheckButton";
			this.TCheckButton.Size = new System.Drawing.Size(23, 22);
			this.TCheckButton.Text = "Проверить синтаксис";
			this.TCheckButton.Click += new System.EventHandler(this.CheckButtonClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::Project_SFX_Config.Properties.Resources.question_frame;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.Visible = false;
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// OpenFile
			// 
			this.OpenFile.DefaultExt = "Text Files (*.txt)|*.txt";
			// 
			// ToolTiper
			// 
			this.ToolTiper.AutoPopDelay = 7000;
			this.ToolTiper.InitialDelay = 500;
			this.ToolTiper.ReshowDelay = 100;
			this.ToolTiper.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.ToolTiper.ToolTipTitle = "Примечание:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(691, 504);
			this.Controls.Add(this.PanelBar);
			this.Controls.Add(this.Tabs);
			this.Controls.Add(this.StatusBar);
			this.Controls.Add(this.MainMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.MainMenu;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Project SFX Config";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.MainMenu.ResumeLayout(false);
			this.MainMenu.PerformLayout();
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			this.Tabs.ResumeLayout(false);
			this.TUnpackTab.ResumeLayout(false);
			this.TUnpackTab.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.TComListContext.ResumeLayout(false);
			this.TDesignTab.ResumeLayout(false);
			this.TDesignTab.PerformLayout();
			this.TTextsTab.ResumeLayout(false);
			this.TTextsTab.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TBeginPromptTimeOut)).EndInit();
			this.PanelBar.ResumeLayout(false);
			this.PanelBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem TFile_Menu;
        private System.Windows.Forms.ToolStripMenuItem TTools_Menu;
        private System.Windows.Forms.ToolStripMenuItem THelping_Menu;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel TStateLabel;
        private System.Windows.Forms.TabControl Tabs;
		private System.Windows.Forms.TabPage TUnpackTab;
        private System.Windows.Forms.ColumnHeader TCommandColumn;
        private System.Windows.Forms.ColumnHeader TParamColumn;
        private System.Windows.Forms.TabPage TDesignTab;
        private System.Windows.Forms.CheckedListBox TDesignList;
        private System.Windows.Forms.TabPage TTextsTab;
        private System.Windows.Forms.ComboBox TGUIMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button THelpTextBt;
        private System.Windows.Forms.Button TCancelPromptBt;
        private System.Windows.Forms.Button TExtractDialogBt;
        private System.Windows.Forms.Button TExtractPathTextBt;
        private System.Windows.Forms.Button TFinishMessageBt;
        private System.Windows.Forms.Button TBeginPromptBt;
        private System.Windows.Forms.TextBox THelpTextEdit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TCancelPromptText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TExtractCancelText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TErrorTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TExtractDialogText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TExtractPathText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TExtractPathTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TExtractTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TFinishMessageEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TBeginPromptEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem TOpenFile_Menu;
        private System.Windows.Forms.ToolStripMenuItem TSaveFile_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem TClose_Menu;
        private System.Windows.Forms.ToolStripMenuItem TSiteModule_Menu;
        private System.Windows.Forms.ToolStripMenuItem TSiteProgramm_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TAbout_Menu;
        private System.Windows.Forms.Button TComDelete;
        private System.Windows.Forms.Button TComAddBt;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ColumnHeader TSectionColumn;
        private System.Windows.Forms.CheckBox TSelfDeleteCheck;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TPasswordText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TPasswordTitleEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TWarningTitleEdit;
        private System.Windows.Forms.NumericUpDown TBeginPromptTimeOut;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox TMiscList;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem TSaveFileAs_Menu;
        private System.Windows.Forms.ToolStrip PanelBar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripButton TNewToolButton;
        private System.Windows.Forms.ToolStripButton TOpenToolButton;
        private System.Windows.Forms.ToolStripButton TSaveToolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TModifText;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TParamText;
        private System.Windows.Forms.TextBox TCommText;
        private System.Windows.Forms.RadioButton TListx86Arch;
        private System.Windows.Forms.ComboBox TListLangCombo;
        private System.Windows.Forms.RadioButton TListx64Arch;
        private System.Windows.Forms.RadioButton TListNoArch;
        private System.Windows.Forms.Button TlistDown;
        private System.Windows.Forms.Button TListUp;
        private System.Windows.Forms.ToolStripButton TCheckButton;
        private System.Windows.Forms.ToolStripMenuItem TNewFile_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ColumnHeader TIndexCol;
        private System.Windows.Forms.ContextMenuStrip TComListContext;
        private System.Windows.Forms.ToolStripMenuItem TDoublicate_List;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem TDelete_List;
        private System.Windows.Forms.ToolStripMenuItem TPreference_Menu;
        private System.Windows.Forms.CheckBox TOverwritesysCheck;
        private System.Windows.Forms.ComboBox TOverWriteCombo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox TTextLangsCombo;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ContextMenuStrip Empty;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.ToolStripMenuItem THelp_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolTip ToolTiper;
        private System.Windows.Forms.ToolStripMenuItem TChkSyntax_Menu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem MRUList;
        private System.Windows.Forms.ToolStripMenuItem ClearMRU;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem Clean;
		private System.Windows.Forms.ListView TCommandsList;
    }
}

