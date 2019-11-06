namespace UE4_TestPlay
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TextBox IP_Text;
            System.Windows.Forms.TextBox Port_Text;
            System.Windows.Forms.TextBox WinSizeX_Text;
            System.Windows.Forms.TextBox WinSizeY_Text;
            System.Windows.Forms.TextBox Client_Text;
            System.Windows.Forms.TextBox Server_Text;
            System.Windows.Forms.TextBox textBox18;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.TestStart_Button = new System.Windows.Forms.Button();
            this.SelectSetting_ComboBox = new System.Windows.Forms.ComboBox();
            this.CurrentSettingSave = new System.Windows.Forms.Button();
            this.CurrentSettingInitialize = new System.Windows.Forms.Button();
            this.DefuaultSettingBox = new System.Windows.Forms.TextBox();
            this.CurrentSettting_Group = new System.Windows.Forms.GroupBox();
            this.CurrentSettingCreate = new System.Windows.Forms.Button();
            this.CurrentSettingRemove = new System.Windows.Forms.Button();
            this.SelectSetting_Group = new System.Windows.Forms.GroupBox();
            this.ClientDirectory_Group = new System.Windows.Forms.GroupBox();
            this.ClientDirectory_Button = new System.Windows.Forms.Button();
            this.ClientDirectory_Box = new System.Windows.Forms.TextBox();
            this.Option_Group = new System.Windows.Forms.GroupBox();
            this.ETC_Group = new System.Windows.Forms.GroupBox();
            this.Cooked_CheckBox = new System.Windows.Forms.CheckBox();
            this.Log_CheckBox = new System.Windows.Forms.CheckBox();
            this.ProcessCount_Group = new System.Windows.Forms.GroupBox();
            this.ClientCount_TextBox = new System.Windows.Forms.TextBox();
            this.SeverCount_TextBox = new System.Windows.Forms.TextBox();
            this.OptionNetwork_Group = new System.Windows.Forms.GroupBox();
            this.Port_TextBox = new System.Windows.Forms.TextBox();
            this.IP_TextBox = new System.Windows.Forms.TextBox();
            this.WindowSize_Group = new System.Windows.Forms.GroupBox();
            this.WinSizeY_TextBox = new System.Windows.Forms.TextBox();
            this.WinSizeX_TextBox = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.ServerDirectory_Group = new System.Windows.Forms.GroupBox();
            this.ServerDirectory_Button = new System.Windows.Forms.Button();
            this.ServerDirectory_Box = new System.Windows.Forms.TextBox();
            this.MapDirectory_Group = new System.Windows.Forms.GroupBox();
            this.MapDirectory_Button = new System.Windows.Forms.Button();
            this.MapDirectory_Box = new System.Windows.Forms.TextBox();
            this.TestExport = new System.Windows.Forms.Button();
            IP_Text = new System.Windows.Forms.TextBox();
            Port_Text = new System.Windows.Forms.TextBox();
            WinSizeX_Text = new System.Windows.Forms.TextBox();
            WinSizeY_Text = new System.Windows.Forms.TextBox();
            Client_Text = new System.Windows.Forms.TextBox();
            Server_Text = new System.Windows.Forms.TextBox();
            textBox18 = new System.Windows.Forms.TextBox();
            this.CurrentSettting_Group.SuspendLayout();
            this.SelectSetting_Group.SuspendLayout();
            this.ClientDirectory_Group.SuspendLayout();
            this.Option_Group.SuspendLayout();
            this.ETC_Group.SuspendLayout();
            this.ProcessCount_Group.SuspendLayout();
            this.OptionNetwork_Group.SuspendLayout();
            this.WindowSize_Group.SuspendLayout();
            this.ServerDirectory_Group.SuspendLayout();
            this.MapDirectory_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // IP_Text
            // 
            IP_Text.CausesValidation = false;
            IP_Text.Cursor = System.Windows.Forms.Cursors.Default;
            IP_Text.Enabled = false;
            IP_Text.Location = new System.Drawing.Point(14, 22);
            IP_Text.Name = "IP_Text";
            IP_Text.ReadOnly = true;
            IP_Text.ShortcutsEnabled = false;
            IP_Text.Size = new System.Drawing.Size(186, 23);
            IP_Text.TabIndex = 0;
            IP_Text.TabStop = false;
            IP_Text.Text = "IP";
            IP_Text.WordWrap = false;
            // 
            // Port_Text
            // 
            Port_Text.Cursor = System.Windows.Forms.Cursors.Default;
            Port_Text.Enabled = false;
            Port_Text.Location = new System.Drawing.Point(14, 51);
            Port_Text.Name = "Port_Text";
            Port_Text.ReadOnly = true;
            Port_Text.ShortcutsEnabled = false;
            Port_Text.Size = new System.Drawing.Size(186, 23);
            Port_Text.TabIndex = 0;
            Port_Text.TabStop = false;
            Port_Text.Text = "Port";
            Port_Text.WordWrap = false;
            // 
            // WinSizeX_Text
            // 
            WinSizeX_Text.Cursor = System.Windows.Forms.Cursors.Default;
            WinSizeX_Text.Enabled = false;
            WinSizeX_Text.Location = new System.Drawing.Point(14, 22);
            WinSizeX_Text.Name = "WinSizeX_Text";
            WinSizeX_Text.ReadOnly = true;
            WinSizeX_Text.ShortcutsEnabled = false;
            WinSizeX_Text.Size = new System.Drawing.Size(186, 23);
            WinSizeX_Text.TabIndex = 0;
            WinSizeX_Text.TabStop = false;
            WinSizeX_Text.Text = "X";
            WinSizeX_Text.WordWrap = false;
            // 
            // WinSizeY_Text
            // 
            WinSizeY_Text.Cursor = System.Windows.Forms.Cursors.Default;
            WinSizeY_Text.Enabled = false;
            WinSizeY_Text.Location = new System.Drawing.Point(14, 51);
            WinSizeY_Text.Name = "WinSizeY_Text";
            WinSizeY_Text.ReadOnly = true;
            WinSizeY_Text.ShortcutsEnabled = false;
            WinSizeY_Text.Size = new System.Drawing.Size(186, 23);
            WinSizeY_Text.TabIndex = 0;
            WinSizeY_Text.TabStop = false;
            WinSizeY_Text.Text = "Y";
            WinSizeY_Text.WordWrap = false;
            // 
            // Client_Text
            // 
            Client_Text.Cursor = System.Windows.Forms.Cursors.Default;
            Client_Text.Enabled = false;
            Client_Text.Location = new System.Drawing.Point(14, 51);
            Client_Text.Name = "Client_Text";
            Client_Text.ReadOnly = true;
            Client_Text.ShortcutsEnabled = false;
            Client_Text.Size = new System.Drawing.Size(186, 23);
            Client_Text.TabIndex = 0;
            Client_Text.TabStop = false;
            Client_Text.Text = "Client";
            Client_Text.WordWrap = false;
            // 
            // Server_Text
            // 
            Server_Text.CausesValidation = false;
            Server_Text.Cursor = System.Windows.Forms.Cursors.Default;
            Server_Text.Enabled = false;
            Server_Text.Location = new System.Drawing.Point(14, 22);
            Server_Text.Name = "Server_Text";
            Server_Text.ReadOnly = true;
            Server_Text.ShortcutsEnabled = false;
            Server_Text.Size = new System.Drawing.Size(186, 23);
            Server_Text.TabIndex = 0;
            Server_Text.TabStop = false;
            Server_Text.Text = "Server";
            Server_Text.WordWrap = false;
            // 
            // textBox18
            // 
            textBox18.Cursor = System.Windows.Forms.Cursors.Default;
            textBox18.Enabled = false;
            textBox18.Location = new System.Drawing.Point(723, 353);
            textBox18.Name = "textBox18";
            textBox18.ReadOnly = true;
            textBox18.ShortcutsEnabled = false;
            textBox18.Size = new System.Drawing.Size(186, 23);
            textBox18.TabIndex = 1000;
            textBox18.TabStop = false;
            textBox18.Visible = false;
            textBox18.WordWrap = false;
            // 
            // MainNotifyIcon
            // 
            this.MainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MainNotifyIcon.Icon")));
            this.MainNotifyIcon.Text = "UE4_TestPlayer";
            this.MainNotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MainNotifyIcon_MouseDoubleClick);
            // 
            // TestStart_Button
            // 
            this.TestStart_Button.Font = new System.Drawing.Font("Arial", 10F);
            this.TestStart_Button.Location = new System.Drawing.Point(33, 346);
            this.TestStart_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TestStart_Button.Name = "TestStart_Button";
            this.TestStart_Button.Size = new System.Drawing.Size(186, 25);
            this.TestStart_Button.TabIndex = 6;
            this.TestStart_Button.Text = "Test Start";
            this.TestStart_Button.UseVisualStyleBackColor = true;
            this.TestStart_Button.Click += new System.EventHandler(this.TestStart_Button_Click);
            // 
            // SelectSetting_ComboBox
            // 
            this.SelectSetting_ComboBox.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSetting_ComboBox.FormattingEnabled = true;
            this.SelectSetting_ComboBox.Location = new System.Drawing.Point(21, 24);
            this.SelectSetting_ComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectSetting_ComboBox.Name = "SelectSetting_ComboBox";
            this.SelectSetting_ComboBox.Size = new System.Drawing.Size(186, 24);
            this.SelectSetting_ComboBox.TabIndex = 3;
            this.SelectSetting_ComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectSetting_ComboBox_SelectedIndexChanged);
            // 
            // CurrentSettingSave
            // 
            this.CurrentSettingSave.Location = new System.Drawing.Point(21, 55);
            this.CurrentSettingSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentSettingSave.Name = "CurrentSettingSave";
            this.CurrentSettingSave.Size = new System.Drawing.Size(88, 23);
            this.CurrentSettingSave.TabIndex = 1;
            this.CurrentSettingSave.Text = "Save";
            this.CurrentSettingSave.UseVisualStyleBackColor = true;
            this.CurrentSettingSave.Click += new System.EventHandler(this.CurrentSettingSave_Click);
            // 
            // CurrentSettingInitialize
            // 
            this.CurrentSettingInitialize.Location = new System.Drawing.Point(119, 55);
            this.CurrentSettingInitialize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentSettingInitialize.Name = "CurrentSettingInitialize";
            this.CurrentSettingInitialize.Size = new System.Drawing.Size(88, 23);
            this.CurrentSettingInitialize.TabIndex = 2;
            this.CurrentSettingInitialize.Text = "Initialize";
            this.CurrentSettingInitialize.UseVisualStyleBackColor = true;
            this.CurrentSettingInitialize.Click += new System.EventHandler(this.CurrentSettingInit_Click);
            // 
            // DefuaultSettingBox
            // 
            this.DefuaultSettingBox.Font = new System.Drawing.Font("굴림", 10F);
            this.DefuaultSettingBox.Location = new System.Drawing.Point(21, 24);
            this.DefuaultSettingBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DefuaultSettingBox.Name = "DefuaultSettingBox";
            this.DefuaultSettingBox.Size = new System.Drawing.Size(186, 23);
            this.DefuaultSettingBox.TabIndex = 0;
            // 
            // CurrentSettting_Group
            // 
            this.CurrentSettting_Group.Controls.Add(this.DefuaultSettingBox);
            this.CurrentSettting_Group.Controls.Add(this.CurrentSettingSave);
            this.CurrentSettting_Group.Controls.Add(this.CurrentSettingCreate);
            this.CurrentSettting_Group.Controls.Add(this.CurrentSettingRemove);
            this.CurrentSettting_Group.Controls.Add(this.CurrentSettingInitialize);
            this.CurrentSettting_Group.Font = new System.Drawing.Font("Arial", 10F);
            this.CurrentSettting_Group.Location = new System.Drawing.Point(12, 13);
            this.CurrentSettting_Group.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentSettting_Group.Name = "CurrentSettting_Group";
            this.CurrentSettting_Group.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentSettting_Group.Size = new System.Drawing.Size(222, 126);
            this.CurrentSettting_Group.TabIndex = 0;
            this.CurrentSettting_Group.TabStop = false;
            this.CurrentSettting_Group.Text = "Current Settting";
            // 
            // CurrentSettingCreate
            // 
            this.CurrentSettingCreate.Location = new System.Drawing.Point(21, 86);
            this.CurrentSettingCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentSettingCreate.Name = "CurrentSettingCreate";
            this.CurrentSettingCreate.Size = new System.Drawing.Size(88, 23);
            this.CurrentSettingCreate.TabIndex = 2;
            this.CurrentSettingCreate.Text = "Create";
            this.CurrentSettingCreate.UseVisualStyleBackColor = true;
            this.CurrentSettingCreate.Click += new System.EventHandler(this.CurrentSettingCreate_Click);
            // 
            // CurrentSettingRemove
            // 
            this.CurrentSettingRemove.Location = new System.Drawing.Point(119, 86);
            this.CurrentSettingRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CurrentSettingRemove.Name = "CurrentSettingRemove";
            this.CurrentSettingRemove.Size = new System.Drawing.Size(88, 23);
            this.CurrentSettingRemove.TabIndex = 2;
            this.CurrentSettingRemove.Text = "Remove";
            this.CurrentSettingRemove.UseVisualStyleBackColor = true;
            this.CurrentSettingRemove.Click += new System.EventHandler(this.CurrentSettingRemove_Click);
            // 
            // SelectSetting_Group
            // 
            this.SelectSetting_Group.Controls.Add(this.SelectSetting_ComboBox);
            this.SelectSetting_Group.Font = new System.Drawing.Font("Arial", 10F);
            this.SelectSetting_Group.Location = new System.Drawing.Point(12, 144);
            this.SelectSetting_Group.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectSetting_Group.Name = "SelectSetting_Group";
            this.SelectSetting_Group.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectSetting_Group.Size = new System.Drawing.Size(222, 65);
            this.SelectSetting_Group.TabIndex = 1;
            this.SelectSetting_Group.TabStop = false;
            this.SelectSetting_Group.Text = "Select Setting";
            // 
            // ClientDirectory_Group
            // 
            this.ClientDirectory_Group.Controls.Add(this.ClientDirectory_Button);
            this.ClientDirectory_Group.Controls.Add(this.ClientDirectory_Box);
            this.ClientDirectory_Group.Font = new System.Drawing.Font("Arial", 10F);
            this.ClientDirectory_Group.Location = new System.Drawing.Point(263, 13);
            this.ClientDirectory_Group.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClientDirectory_Group.Name = "ClientDirectory_Group";
            this.ClientDirectory_Group.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClientDirectory_Group.Size = new System.Drawing.Size(694, 58);
            this.ClientDirectory_Group.TabIndex = 2;
            this.ClientDirectory_Group.TabStop = false;
            this.ClientDirectory_Group.Text = "Client Directory";
            // 
            // ClientDirectory_Button
            // 
            this.ClientDirectory_Button.Location = new System.Drawing.Point(652, 24);
            this.ClientDirectory_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClientDirectory_Button.Name = "ClientDirectory_Button";
            this.ClientDirectory_Button.Size = new System.Drawing.Size(31, 23);
            this.ClientDirectory_Button.TabIndex = 1;
            this.ClientDirectory_Button.Text = "...";
            this.ClientDirectory_Button.UseVisualStyleBackColor = true;
            this.ClientDirectory_Button.Click += new System.EventHandler(this.ClientDirectory_Button_Click);
            // 
            // ClientDirectory_Box
            // 
            this.ClientDirectory_Box.AllowDrop = true;
            this.ClientDirectory_Box.Font = new System.Drawing.Font("굴림", 10F);
            this.ClientDirectory_Box.Location = new System.Drawing.Point(14, 24);
            this.ClientDirectory_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClientDirectory_Box.Name = "ClientDirectory_Box";
            this.ClientDirectory_Box.Size = new System.Drawing.Size(632, 23);
            this.ClientDirectory_Box.TabIndex = 0;
            // 
            // Option_Group
            // 
            this.Option_Group.Controls.Add(this.ETC_Group);
            this.Option_Group.Controls.Add(this.ProcessCount_Group);
            this.Option_Group.Controls.Add(this.OptionNetwork_Group);
            this.Option_Group.Controls.Add(this.WindowSize_Group);
            this.Option_Group.Font = new System.Drawing.Font("Arial", 10F);
            this.Option_Group.Location = new System.Drawing.Point(12, 217);
            this.Option_Group.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Option_Group.Name = "Option_Group";
            this.Option_Group.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Option_Group.Size = new System.Drawing.Size(945, 121);
            this.Option_Group.TabIndex = 5;
            this.Option_Group.TabStop = false;
            this.Option_Group.Text = "Options";
            // 
            // ETC_Group
            // 
            this.ETC_Group.Controls.Add(this.Cooked_CheckBox);
            this.ETC_Group.Controls.Add(this.Log_CheckBox);
            this.ETC_Group.Location = new System.Drawing.Point(712, 23);
            this.ETC_Group.Name = "ETC_Group";
            this.ETC_Group.Size = new System.Drawing.Size(213, 86);
            this.ETC_Group.TabIndex = 4;
            this.ETC_Group.TabStop = false;
            this.ETC_Group.Text = "e.t.c";
            // 
            // Cooked_CheckBox
            // 
            this.Cooked_CheckBox.AutoSize = true;
            this.Cooked_CheckBox.Location = new System.Drawing.Point(14, 53);
            this.Cooked_CheckBox.Name = "Cooked_CheckBox";
            this.Cooked_CheckBox.Size = new System.Drawing.Size(76, 20);
            this.Cooked_CheckBox.TabIndex = 0;
            this.Cooked_CheckBox.Text = "Cooked";
            this.Cooked_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Log_CheckBox
            // 
            this.Log_CheckBox.AutoSize = true;
            this.Log_CheckBox.Location = new System.Drawing.Point(14, 24);
            this.Log_CheckBox.Name = "Log_CheckBox";
            this.Log_CheckBox.Size = new System.Drawing.Size(51, 20);
            this.Log_CheckBox.TabIndex = 0;
            this.Log_CheckBox.Text = "Log";
            this.Log_CheckBox.UseVisualStyleBackColor = true;
            // 
            // ProcessCount_Group
            // 
            this.ProcessCount_Group.Controls.Add(this.ClientCount_TextBox);
            this.ProcessCount_Group.Controls.Add(this.SeverCount_TextBox);
            this.ProcessCount_Group.Controls.Add(Client_Text);
            this.ProcessCount_Group.Controls.Add(Server_Text);
            this.ProcessCount_Group.Location = new System.Drawing.Point(251, 23);
            this.ProcessCount_Group.Name = "ProcessCount_Group";
            this.ProcessCount_Group.Size = new System.Drawing.Size(213, 86);
            this.ProcessCount_Group.TabIndex = 2;
            this.ProcessCount_Group.TabStop = false;
            this.ProcessCount_Group.Text = "Process Count";
            // 
            // ClientCount_TextBox
            // 
            this.ClientCount_TextBox.Location = new System.Drawing.Point(67, 51);
            this.ClientCount_TextBox.Name = "ClientCount_TextBox";
            this.ClientCount_TextBox.Size = new System.Drawing.Size(133, 23);
            this.ClientCount_TextBox.TabIndex = 1;
            this.ClientCount_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ClientCount_TextBox_KeyPress);
            // 
            // SeverCount_TextBox
            // 
            this.SeverCount_TextBox.Location = new System.Drawing.Point(67, 22);
            this.SeverCount_TextBox.Name = "SeverCount_TextBox";
            this.SeverCount_TextBox.Size = new System.Drawing.Size(133, 23);
            this.SeverCount_TextBox.TabIndex = 0;
            this.SeverCount_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SeverCount_TextBox_KeyPress);
            // 
            // OptionNetwork_Group
            // 
            this.OptionNetwork_Group.Controls.Add(this.Port_TextBox);
            this.OptionNetwork_Group.Controls.Add(this.IP_TextBox);
            this.OptionNetwork_Group.Controls.Add(Port_Text);
            this.OptionNetwork_Group.Controls.Add(IP_Text);
            this.OptionNetwork_Group.Location = new System.Drawing.Point(21, 23);
            this.OptionNetwork_Group.Name = "OptionNetwork_Group";
            this.OptionNetwork_Group.Size = new System.Drawing.Size(213, 86);
            this.OptionNetwork_Group.TabIndex = 1;
            this.OptionNetwork_Group.TabStop = false;
            this.OptionNetwork_Group.Text = "Network";
            // 
            // Port_TextBox
            // 
            this.Port_TextBox.Location = new System.Drawing.Point(67, 51);
            this.Port_TextBox.Name = "Port_TextBox";
            this.Port_TextBox.Size = new System.Drawing.Size(133, 23);
            this.Port_TextBox.TabIndex = 1;
            this.Port_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Port_TextBox_KeyPress);
            // 
            // IP_TextBox
            // 
            this.IP_TextBox.Location = new System.Drawing.Point(67, 22);
            this.IP_TextBox.Name = "IP_TextBox";
            this.IP_TextBox.Size = new System.Drawing.Size(133, 23);
            this.IP_TextBox.TabIndex = 0;
            this.IP_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IP_TextBox_KeyPress);
            // 
            // WindowSize_Group
            // 
            this.WindowSize_Group.Controls.Add(this.WinSizeY_TextBox);
            this.WindowSize_Group.Controls.Add(this.WinSizeX_TextBox);
            this.WindowSize_Group.Controls.Add(WinSizeX_Text);
            this.WindowSize_Group.Controls.Add(WinSizeY_Text);
            this.WindowSize_Group.Location = new System.Drawing.Point(482, 23);
            this.WindowSize_Group.Name = "WindowSize_Group";
            this.WindowSize_Group.Size = new System.Drawing.Size(213, 86);
            this.WindowSize_Group.TabIndex = 3;
            this.WindowSize_Group.TabStop = false;
            this.WindowSize_Group.Text = "Window Size (Client)";
            // 
            // WinSizeY_TextBox
            // 
            this.WinSizeY_TextBox.Location = new System.Drawing.Point(67, 51);
            this.WinSizeY_TextBox.Name = "WinSizeY_TextBox";
            this.WinSizeY_TextBox.Size = new System.Drawing.Size(133, 23);
            this.WinSizeY_TextBox.TabIndex = 1;
            this.WinSizeY_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WinSizeY_TextBox_KeyPress);
            // 
            // WinSizeX_TextBox
            // 
            this.WinSizeX_TextBox.Location = new System.Drawing.Point(67, 22);
            this.WinSizeX_TextBox.Name = "WinSizeX_TextBox";
            this.WinSizeX_TextBox.Size = new System.Drawing.Size(133, 23);
            this.WinSizeX_TextBox.TabIndex = 0;
            this.WinSizeX_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WinSizeX_TextBox_KeyPress);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(776, 353);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(133, 23);
            this.textBox15.TabIndex = 1;
            this.textBox15.TabStop = false;
            this.textBox15.Visible = false;
            // 
            // ServerDirectory_Group
            // 
            this.ServerDirectory_Group.Controls.Add(this.ServerDirectory_Button);
            this.ServerDirectory_Group.Controls.Add(this.ServerDirectory_Box);
            this.ServerDirectory_Group.Font = new System.Drawing.Font("Arial", 10F);
            this.ServerDirectory_Group.Location = new System.Drawing.Point(263, 81);
            this.ServerDirectory_Group.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServerDirectory_Group.Name = "ServerDirectory_Group";
            this.ServerDirectory_Group.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServerDirectory_Group.Size = new System.Drawing.Size(694, 58);
            this.ServerDirectory_Group.TabIndex = 3;
            this.ServerDirectory_Group.TabStop = false;
            this.ServerDirectory_Group.Text = "Server(Engine) Directory  [If Uncook => Engine]";
            // 
            // ServerDirectory_Button
            // 
            this.ServerDirectory_Button.Location = new System.Drawing.Point(652, 24);
            this.ServerDirectory_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServerDirectory_Button.Name = "ServerDirectory_Button";
            this.ServerDirectory_Button.Size = new System.Drawing.Size(31, 23);
            this.ServerDirectory_Button.TabIndex = 1;
            this.ServerDirectory_Button.Text = "...";
            this.ServerDirectory_Button.UseVisualStyleBackColor = true;
            this.ServerDirectory_Button.Click += new System.EventHandler(this.ServerDirectory_Button_Click);
            // 
            // ServerDirectory_Box
            // 
            this.ServerDirectory_Box.AllowDrop = true;
            this.ServerDirectory_Box.Font = new System.Drawing.Font("굴림", 10F);
            this.ServerDirectory_Box.Location = new System.Drawing.Point(14, 24);
            this.ServerDirectory_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ServerDirectory_Box.Name = "ServerDirectory_Box";
            this.ServerDirectory_Box.Size = new System.Drawing.Size(632, 23);
            this.ServerDirectory_Box.TabIndex = 0;
            // 
            // MapDirectory_Group
            // 
            this.MapDirectory_Group.Controls.Add(this.MapDirectory_Button);
            this.MapDirectory_Group.Controls.Add(this.MapDirectory_Box);
            this.MapDirectory_Group.Font = new System.Drawing.Font("Arial", 10F);
            this.MapDirectory_Group.Location = new System.Drawing.Point(263, 151);
            this.MapDirectory_Group.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MapDirectory_Group.Name = "MapDirectory_Group";
            this.MapDirectory_Group.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MapDirectory_Group.Size = new System.Drawing.Size(694, 58);
            this.MapDirectory_Group.TabIndex = 4;
            this.MapDirectory_Group.TabStop = false;
            this.MapDirectory_Group.Text = "Map Directory (Relative)";
            // 
            // MapDirectory_Button
            // 
            this.MapDirectory_Button.Location = new System.Drawing.Point(652, 24);
            this.MapDirectory_Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MapDirectory_Button.Name = "MapDirectory_Button";
            this.MapDirectory_Button.Size = new System.Drawing.Size(31, 23);
            this.MapDirectory_Button.TabIndex = 1;
            this.MapDirectory_Button.Text = "...";
            this.MapDirectory_Button.UseVisualStyleBackColor = true;
            this.MapDirectory_Button.Click += new System.EventHandler(this.MapDirectory_Button_Click);
            // 
            // MapDirectory_Box
            // 
            this.MapDirectory_Box.AllowDrop = true;
            this.MapDirectory_Box.Font = new System.Drawing.Font("굴림", 10F);
            this.MapDirectory_Box.Location = new System.Drawing.Point(14, 24);
            this.MapDirectory_Box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MapDirectory_Box.Name = "MapDirectory_Box";
            this.MapDirectory_Box.Size = new System.Drawing.Size(632, 23);
            this.MapDirectory_Box.TabIndex = 0;
            // 
            // TestExport
            // 
            this.TestExport.Font = new System.Drawing.Font("Arial", 10F);
            this.TestExport.Location = new System.Drawing.Point(263, 346);
            this.TestExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TestExport.Name = "TestExport";
            this.TestExport.Size = new System.Drawing.Size(186, 25);
            this.TestExport.TabIndex = 1001;
            this.TestExport.Text = "TestExport";
            this.TestExport.UseVisualStyleBackColor = true;
            this.TestExport.Click += new System.EventHandler(this.TestExport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(969, 388);
            this.Controls.Add(this.TestExport);
            this.Controls.Add(this.Option_Group);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(textBox18);
            this.Controls.Add(this.TestStart_Button);
            this.Controls.Add(this.MapDirectory_Group);
            this.Controls.Add(this.ServerDirectory_Group);
            this.Controls.Add(this.ClientDirectory_Group);
            this.Controls.Add(this.SelectSetting_Group);
            this.Controls.Add(this.CurrentSettting_Group);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TestPlayer(UE4)";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.CurrentSettting_Group.ResumeLayout(false);
            this.CurrentSettting_Group.PerformLayout();
            this.SelectSetting_Group.ResumeLayout(false);
            this.ClientDirectory_Group.ResumeLayout(false);
            this.ClientDirectory_Group.PerformLayout();
            this.Option_Group.ResumeLayout(false);
            this.ETC_Group.ResumeLayout(false);
            this.ETC_Group.PerformLayout();
            this.ProcessCount_Group.ResumeLayout(false);
            this.ProcessCount_Group.PerformLayout();
            this.OptionNetwork_Group.ResumeLayout(false);
            this.OptionNetwork_Group.PerformLayout();
            this.WindowSize_Group.ResumeLayout(false);
            this.WindowSize_Group.PerformLayout();
            this.ServerDirectory_Group.ResumeLayout(false);
            this.ServerDirectory_Group.PerformLayout();
            this.MapDirectory_Group.ResumeLayout(false);
            this.MapDirectory_Group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon MainNotifyIcon;
        private System.Windows.Forms.Button TestStart_Button;
        private System.Windows.Forms.ComboBox SelectSetting_ComboBox;
        private System.Windows.Forms.Button CurrentSettingSave;
        private System.Windows.Forms.Button CurrentSettingInitialize;
        private System.Windows.Forms.TextBox DefuaultSettingBox;
        private System.Windows.Forms.GroupBox CurrentSettting_Group;
        private System.Windows.Forms.GroupBox SelectSetting_Group;
        private System.Windows.Forms.GroupBox ClientDirectory_Group;
        private System.Windows.Forms.GroupBox Option_Group;
        private System.Windows.Forms.TextBox ClientDirectory_Box;
        private System.Windows.Forms.Button ClientDirectory_Button;
        private System.Windows.Forms.TextBox Port_TextBox;
        private System.Windows.Forms.TextBox IP_TextBox;
        private System.Windows.Forms.GroupBox WindowSize_Group;
        private System.Windows.Forms.TextBox WinSizeY_TextBox;
        private System.Windows.Forms.TextBox WinSizeX_TextBox;
        private System.Windows.Forms.GroupBox ProcessCount_Group;
        private System.Windows.Forms.TextBox ClientCount_TextBox;
        private System.Windows.Forms.TextBox SeverCount_TextBox;
        private System.Windows.Forms.GroupBox OptionNetwork_Group;
        private System.Windows.Forms.GroupBox ETC_Group;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.CheckBox Log_CheckBox;
        private System.Windows.Forms.GroupBox ServerDirectory_Group;
        private System.Windows.Forms.Button ServerDirectory_Button;
        private System.Windows.Forms.TextBox ServerDirectory_Box;
        private System.Windows.Forms.GroupBox MapDirectory_Group;
        private System.Windows.Forms.Button MapDirectory_Button;
        private System.Windows.Forms.TextBox MapDirectory_Box;
        private System.Windows.Forms.CheckBox Cooked_CheckBox;
        private System.Windows.Forms.Button TestExport;
        private System.Windows.Forms.Button CurrentSettingCreate;
        private System.Windows.Forms.Button CurrentSettingRemove;
    }
}

