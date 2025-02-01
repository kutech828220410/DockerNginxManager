namespace DockerTools
{
    partial class Dialog_add_container
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rJ_Button_cancel = new MyUI.RJ_Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rJ_Button_creat = new MyUI.RJ_Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rJ_TextBox_ContainerName = new MyUI.RJ_TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rJ_TextBox_Network = new MyUI.RJ_TextBox();
            this.checkBox_Detach = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rJ_TextBox_PortForward = new MyUI.RJ_TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.comboBox_ImageName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rJ_Pannel1 = new MyUI.RJ_Pannel();
            this.sqL_DataGridView_VolumeMappings = new SQLUI.SQL_DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rJ_Button_VolumeMappings_edit = new MyUI.RJ_Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rJ_Button_VolumeMappings_delete = new MyUI.RJ_Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.rJ_Button_VolumeMappings_add = new MyUI.RJ_Button();
            this.rJ_Pannel2 = new MyUI.RJ_Pannel();
            this.rJ_Button_generate = new MyUI.RJ_Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.rJ_Button_load_template = new MyUI.RJ_Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_template = new System.Windows.Forms.ComboBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.rJ_Button_refresh_docker_command = new MyUI.RJ_Button();
            this.rJ_TextBox_docker_command = new MyUI.RJ_TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.rJ_Pannel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.rJ_Pannel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rJ_Button_cancel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rJ_Button_creat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(7, 850);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.panel1.Size = new System.Drawing.Size(1238, 49);
            this.panel1.TabIndex = 158;
            // 
            // rJ_Button_cancel
            // 
            this.rJ_Button_cancel.AutoResetState = false;
            this.rJ_Button_cancel.BackColor = System.Drawing.Color.Transparent;
            this.rJ_Button_cancel.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button_cancel.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Button_cancel.BorderRadius = 22;
            this.rJ_Button_cancel.BorderSize = 1;
            this.rJ_Button_cancel.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_cancel.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_cancel.FlatAppearance.BorderSize = 0;
            this.rJ_Button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_cancel.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.rJ_Button_cancel.ForeColor = System.Drawing.Color.Black;
            this.rJ_Button_cancel.GUID = "";
            this.rJ_Button_cancel.Image_padding = new System.Windows.Forms.Padding(0);
            this.rJ_Button_cancel.Location = new System.Drawing.Point(963, 0);
            this.rJ_Button_cancel.Name = "rJ_Button_cancel";
            this.rJ_Button_cancel.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_cancel.ProhibitionLineWidth = 4;
            this.rJ_Button_cancel.ProhibitionSymbolSize = 30;
            this.rJ_Button_cancel.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_cancel.ShadowSize = 0;
            this.rJ_Button_cancel.ShowLoadingForm = false;
            this.rJ_Button_cancel.Size = new System.Drawing.Size(126, 44);
            this.rJ_Button_cancel.State = false;
            this.rJ_Button_cancel.TabIndex = 158;
            this.rJ_Button_cancel.Text = "Cancel";
            this.rJ_Button_cancel.TextColor = System.Drawing.Color.Black;
            this.rJ_Button_cancel.TextHeight = 0;
            this.rJ_Button_cancel.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1089, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 44);
            this.panel2.TabIndex = 157;
            // 
            // rJ_Button_creat
            // 
            this.rJ_Button_creat.AutoResetState = false;
            this.rJ_Button_creat.BackColor = System.Drawing.Color.White;
            this.rJ_Button_creat.BackgroundColor = System.Drawing.Color.DimGray;
            this.rJ_Button_creat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Button_creat.BorderRadius = 22;
            this.rJ_Button_creat.BorderSize = 0;
            this.rJ_Button_creat.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_creat.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_creat.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_creat.FlatAppearance.BorderSize = 0;
            this.rJ_Button_creat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_creat.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.rJ_Button_creat.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_creat.GUID = "";
            this.rJ_Button_creat.Image_padding = new System.Windows.Forms.Padding(0);
            this.rJ_Button_creat.Location = new System.Drawing.Point(1102, 0);
            this.rJ_Button_creat.Name = "rJ_Button_creat";
            this.rJ_Button_creat.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_creat.ProhibitionLineWidth = 4;
            this.rJ_Button_creat.ProhibitionSymbolSize = 30;
            this.rJ_Button_creat.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_creat.ShadowSize = 0;
            this.rJ_Button_creat.ShowLoadingForm = false;
            this.rJ_Button_creat.Size = new System.Drawing.Size(126, 44);
            this.rJ_Button_creat.State = false;
            this.rJ_Button_creat.TabIndex = 155;
            this.rJ_Button_creat.Text = "Creat";
            this.rJ_Button_creat.TextColor = System.Drawing.Color.White;
            this.rJ_Button_creat.TextHeight = 0;
            this.rJ_Button_creat.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(7, 842);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1238, 8);
            this.panel3.TabIndex = 160;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.rJ_TextBox_ContainerName);
            this.panel4.Location = new System.Drawing.Point(23, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(471, 78);
            this.panel4.TabIndex = 164;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 165;
            this.label2.Text = "ContainerName";
            // 
            // rJ_TextBox_ContainerName
            // 
            this.rJ_TextBox_ContainerName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rJ_TextBox_ContainerName.BorderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_ContainerName.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.rJ_TextBox_ContainerName.BorderRadius = 5;
            this.rJ_TextBox_ContainerName.BorderSize = 1;
            this.rJ_TextBox_ContainerName.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_TextBox_ContainerName.ForeColor = System.Drawing.Color.Black;
            this.rJ_TextBox_ContainerName.GUID = "";
            this.rJ_TextBox_ContainerName.Location = new System.Drawing.Point(26, 33);
            this.rJ_TextBox_ContainerName.Multiline = false;
            this.rJ_TextBox_ContainerName.Name = "rJ_TextBox_ContainerName";
            this.rJ_TextBox_ContainerName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_ContainerName.PassWordChar = false;
            this.rJ_TextBox_ContainerName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_ContainerName.PlaceholderText = "";
            this.rJ_TextBox_ContainerName.ShowTouchPannel = false;
            this.rJ_TextBox_ContainerName.Size = new System.Drawing.Size(426, 40);
            this.rJ_TextBox_ContainerName.TabIndex = 164;
            this.rJ_TextBox_ContainerName.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_ContainerName.Texts = "";
            this.rJ_TextBox_ContainerName.UnderlineStyle = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.rJ_TextBox_Network);
            this.panel5.Location = new System.Drawing.Point(23, 138);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(471, 78);
            this.panel5.TabIndex = 166;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 165;
            this.label1.Text = "Network";
            // 
            // rJ_TextBox_Network
            // 
            this.rJ_TextBox_Network.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rJ_TextBox_Network.BorderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_Network.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.rJ_TextBox_Network.BorderRadius = 5;
            this.rJ_TextBox_Network.BorderSize = 1;
            this.rJ_TextBox_Network.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_TextBox_Network.ForeColor = System.Drawing.Color.Black;
            this.rJ_TextBox_Network.GUID = "";
            this.rJ_TextBox_Network.Location = new System.Drawing.Point(26, 33);
            this.rJ_TextBox_Network.Multiline = false;
            this.rJ_TextBox_Network.Name = "rJ_TextBox_Network";
            this.rJ_TextBox_Network.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_Network.PassWordChar = false;
            this.rJ_TextBox_Network.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_Network.PlaceholderText = "";
            this.rJ_TextBox_Network.ShowTouchPannel = false;
            this.rJ_TextBox_Network.Size = new System.Drawing.Size(426, 40);
            this.rJ_TextBox_Network.TabIndex = 164;
            this.rJ_TextBox_Network.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_Network.Texts = "";
            this.rJ_TextBox_Network.UnderlineStyle = true;
            // 
            // checkBox_Detach
            // 
            this.checkBox_Detach.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Detach.Checked = true;
            this.checkBox_Detach.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Detach.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Detach.ForeColor = System.Drawing.Color.Gray;
            this.checkBox_Detach.Location = new System.Drawing.Point(23, 13);
            this.checkBox_Detach.Name = "checkBox_Detach";
            this.checkBox_Detach.Size = new System.Drawing.Size(94, 35);
            this.checkBox_Detach.TabIndex = 167;
            this.checkBox_Detach.Text = "Detach";
            this.checkBox_Detach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Detach.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.rJ_TextBox_PortForward);
            this.panel6.Location = new System.Drawing.Point(23, 222);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(471, 78);
            this.panel6.TabIndex = 168;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 165;
            this.label3.Text = "PortForward";
            // 
            // rJ_TextBox_PortForward
            // 
            this.rJ_TextBox_PortForward.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rJ_TextBox_PortForward.BorderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_PortForward.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.rJ_TextBox_PortForward.BorderRadius = 5;
            this.rJ_TextBox_PortForward.BorderSize = 1;
            this.rJ_TextBox_PortForward.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_TextBox_PortForward.ForeColor = System.Drawing.Color.Black;
            this.rJ_TextBox_PortForward.GUID = "";
            this.rJ_TextBox_PortForward.Location = new System.Drawing.Point(26, 33);
            this.rJ_TextBox_PortForward.Multiline = false;
            this.rJ_TextBox_PortForward.Name = "rJ_TextBox_PortForward";
            this.rJ_TextBox_PortForward.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_PortForward.PassWordChar = false;
            this.rJ_TextBox_PortForward.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_PortForward.PlaceholderText = "";
            this.rJ_TextBox_PortForward.ShowTouchPannel = false;
            this.rJ_TextBox_PortForward.Size = new System.Drawing.Size(426, 40);
            this.rJ_TextBox_PortForward.TabIndex = 164;
            this.rJ_TextBox_PortForward.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_PortForward.Texts = "";
            this.rJ_TextBox_PortForward.UnderlineStyle = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.Controls.Add(this.comboBox_ImageName);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(23, 306);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(471, 78);
            this.panel7.TabIndex = 169;
            // 
            // comboBox_ImageName
            // 
            this.comboBox_ImageName.BackColor = System.Drawing.Color.White;
            this.comboBox_ImageName.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ImageName.FormattingEnabled = true;
            this.comboBox_ImageName.Location = new System.Drawing.Point(26, 41);
            this.comboBox_ImageName.Name = "comboBox_ImageName";
            this.comboBox_ImageName.Size = new System.Drawing.Size(426, 33);
            this.comboBox_ImageName.TabIndex = 170;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 165;
            this.label4.Text = "ImageName";
            // 
            // rJ_Pannel1
            // 
            this.rJ_Pannel1.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.rJ_Pannel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.rJ_Pannel1.BorderRadius = 40;
            this.rJ_Pannel1.BorderSize = 2;
            this.rJ_Pannel1.Controls.Add(this.sqL_DataGridView_VolumeMappings);
            this.rJ_Pannel1.Controls.Add(this.panel8);
            this.rJ_Pannel1.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel1.IsSelected = false;
            this.rJ_Pannel1.Location = new System.Drawing.Point(535, 13);
            this.rJ_Pannel1.Name = "rJ_Pannel1";
            this.rJ_Pannel1.Padding = new System.Windows.Forms.Padding(10, 10, 15, 15);
            this.rJ_Pannel1.ShadowColor = System.Drawing.Color.Gainsboro;
            this.rJ_Pannel1.ShadowSize = 3;
            this.rJ_Pannel1.Size = new System.Drawing.Size(691, 371);
            this.rJ_Pannel1.TabIndex = 170;
            // 
            // sqL_DataGridView_VolumeMappings
            // 
            this.sqL_DataGridView_VolumeMappings.AutoSelectToDeep = false;
            this.sqL_DataGridView_VolumeMappings.backColor = System.Drawing.Color.WhiteSmoke;
            this.sqL_DataGridView_VolumeMappings.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.sqL_DataGridView_VolumeMappings.BorderRadius = 1;
            this.sqL_DataGridView_VolumeMappings.BorderSize = 1;
            this.sqL_DataGridView_VolumeMappings.CellBorderColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_VolumeMappings.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_VolumeMappings.cellStylBackColor = System.Drawing.Color.Transparent;
            this.sqL_DataGridView_VolumeMappings.cellStyleFont = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqL_DataGridView_VolumeMappings.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_VolumeMappings.checkedRowBackColor = System.Drawing.Color.YellowGreen;
            this.sqL_DataGridView_VolumeMappings.columnHeaderBackColor = System.Drawing.Color.White;
            this.sqL_DataGridView_VolumeMappings.columnHeaderBorderColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_VolumeMappings.columnHeaderFont = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_VolumeMappings.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_VolumeMappings.columnHeadersHeight = 50;
            this.sqL_DataGridView_VolumeMappings.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.sqL_DataGridView_VolumeMappings.DataGridViewAutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sqL_DataGridView_VolumeMappings.DataKeyEnable = false;
            this.sqL_DataGridView_VolumeMappings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqL_DataGridView_VolumeMappings.Font = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_VolumeMappings.ImageBox = false;
            this.sqL_DataGridView_VolumeMappings.Location = new System.Drawing.Point(10, 10);
            this.sqL_DataGridView_VolumeMappings.Name = "sqL_DataGridView_VolumeMappings";
            this.sqL_DataGridView_VolumeMappings.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_VolumeMappings.Password = "user82822040";
            this.sqL_DataGridView_VolumeMappings.Port = ((uint)(3306u));
            this.sqL_DataGridView_VolumeMappings.rowBorderStyleOption = SQLUI.SQL_DataGridView.RowBorderStyleOption.BottomLine;
            this.sqL_DataGridView_VolumeMappings.rowHeaderBackColor = System.Drawing.Color.White;
            this.sqL_DataGridView_VolumeMappings.rowHeaderBorderStyleOption = SQLUI.SQL_DataGridView.RowBorderStyleOption.BottomLine;
            this.sqL_DataGridView_VolumeMappings.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_VolumeMappings.RowsColor = System.Drawing.Color.White;
            this.sqL_DataGridView_VolumeMappings.RowsHeight = 10;
            this.sqL_DataGridView_VolumeMappings.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_VolumeMappings.selectedBorderSize = 0;
            this.sqL_DataGridView_VolumeMappings.selectedRowBackColor = System.Drawing.Color.DarkGray;
            this.sqL_DataGridView_VolumeMappings.selectedRowBorderColor = System.Drawing.Color.Blue;
            this.sqL_DataGridView_VolumeMappings.selectedRowForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_VolumeMappings.Server = "127.0.0.0";
            this.sqL_DataGridView_VolumeMappings.Size = new System.Drawing.Size(666, 298);
            this.sqL_DataGridView_VolumeMappings.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_VolumeMappings.TabIndex = 172;
            this.sqL_DataGridView_VolumeMappings.UserName = "root";
            this.sqL_DataGridView_VolumeMappings.可拖曳欄位寬度 = false;
            this.sqL_DataGridView_VolumeMappings.可選擇多列 = false;
            this.sqL_DataGridView_VolumeMappings.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_VolumeMappings.自動換行 = true;
            this.sqL_DataGridView_VolumeMappings.表單字體 = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_VolumeMappings.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_VolumeMappings.顯示CheckBox = false;
            this.sqL_DataGridView_VolumeMappings.顯示首列 = false;
            this.sqL_DataGridView_VolumeMappings.顯示首行 = true;
            this.sqL_DataGridView_VolumeMappings.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_VolumeMappings.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.rJ_Button_VolumeMappings_edit);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.rJ_Button_VolumeMappings_delete);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.rJ_Button_VolumeMappings_add);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(10, 308);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.panel8.Size = new System.Drawing.Size(666, 48);
            this.panel8.TabIndex = 0;
            // 
            // rJ_Button_VolumeMappings_edit
            // 
            this.rJ_Button_VolumeMappings_edit.AutoResetState = false;
            this.rJ_Button_VolumeMappings_edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rJ_Button_VolumeMappings_edit.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.rJ_Button_VolumeMappings_edit.BackgroundImage = global::DockerTools.Properties.Resources.write;
            this.rJ_Button_VolumeMappings_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_VolumeMappings_edit.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_VolumeMappings_edit.BorderRadius = 30;
            this.rJ_Button_VolumeMappings_edit.BorderSize = 1;
            this.rJ_Button_VolumeMappings_edit.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_VolumeMappings_edit.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_VolumeMappings_edit.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_VolumeMappings_edit.FlatAppearance.BorderSize = 0;
            this.rJ_Button_VolumeMappings_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_VolumeMappings_edit.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_VolumeMappings_edit.GUID = "";
            this.rJ_Button_VolumeMappings_edit.Image_padding = new System.Windows.Forms.Padding(8);
            this.rJ_Button_VolumeMappings_edit.Location = new System.Drawing.Point(508, 3);
            this.rJ_Button_VolumeMappings_edit.Name = "rJ_Button_VolumeMappings_edit";
            this.rJ_Button_VolumeMappings_edit.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button_VolumeMappings_edit.ProhibitionBorderLineWidth = 0;
            this.rJ_Button_VolumeMappings_edit.ProhibitionLineWidth = 0;
            this.rJ_Button_VolumeMappings_edit.ProhibitionSymbolSize = 0;
            this.rJ_Button_VolumeMappings_edit.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_VolumeMappings_edit.ShadowSize = 0;
            this.rJ_Button_VolumeMappings_edit.ShowLoadingForm = false;
            this.rJ_Button_VolumeMappings_edit.Size = new System.Drawing.Size(46, 45);
            this.rJ_Button_VolumeMappings_edit.State = false;
            this.rJ_Button_VolumeMappings_edit.TabIndex = 177;
            this.rJ_Button_VolumeMappings_edit.TextColor = System.Drawing.Color.White;
            this.rJ_Button_VolumeMappings_edit.TextHeight = 0;
            this.rJ_Button_VolumeMappings_edit.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(554, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 45);
            this.panel10.TabIndex = 176;
            // 
            // rJ_Button_VolumeMappings_delete
            // 
            this.rJ_Button_VolumeMappings_delete.AutoResetState = false;
            this.rJ_Button_VolumeMappings_delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rJ_Button_VolumeMappings_delete.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.rJ_Button_VolumeMappings_delete.BackgroundImage = global::DockerTools.Properties.Resources.minus;
            this.rJ_Button_VolumeMappings_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_VolumeMappings_delete.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_VolumeMappings_delete.BorderRadius = 30;
            this.rJ_Button_VolumeMappings_delete.BorderSize = 1;
            this.rJ_Button_VolumeMappings_delete.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_VolumeMappings_delete.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_VolumeMappings_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_VolumeMappings_delete.FlatAppearance.BorderSize = 0;
            this.rJ_Button_VolumeMappings_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_VolumeMappings_delete.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_VolumeMappings_delete.GUID = "";
            this.rJ_Button_VolumeMappings_delete.Image_padding = new System.Windows.Forms.Padding(5);
            this.rJ_Button_VolumeMappings_delete.Location = new System.Drawing.Point(564, 3);
            this.rJ_Button_VolumeMappings_delete.Name = "rJ_Button_VolumeMappings_delete";
            this.rJ_Button_VolumeMappings_delete.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button_VolumeMappings_delete.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_VolumeMappings_delete.ProhibitionLineWidth = 4;
            this.rJ_Button_VolumeMappings_delete.ProhibitionSymbolSize = 30;
            this.rJ_Button_VolumeMappings_delete.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_VolumeMappings_delete.ShadowSize = 0;
            this.rJ_Button_VolumeMappings_delete.ShowLoadingForm = false;
            this.rJ_Button_VolumeMappings_delete.Size = new System.Drawing.Size(46, 45);
            this.rJ_Button_VolumeMappings_delete.State = false;
            this.rJ_Button_VolumeMappings_delete.TabIndex = 175;
            this.rJ_Button_VolumeMappings_delete.TextColor = System.Drawing.Color.White;
            this.rJ_Button_VolumeMappings_delete.TextHeight = 0;
            this.rJ_Button_VolumeMappings_delete.UseVisualStyleBackColor = false;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(610, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 45);
            this.panel9.TabIndex = 174;
            // 
            // rJ_Button_VolumeMappings_add
            // 
            this.rJ_Button_VolumeMappings_add.AutoResetState = false;
            this.rJ_Button_VolumeMappings_add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rJ_Button_VolumeMappings_add.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.rJ_Button_VolumeMappings_add.BackgroundImage = global::DockerTools.Properties.Resources.plus;
            this.rJ_Button_VolumeMappings_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_VolumeMappings_add.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_VolumeMappings_add.BorderRadius = 30;
            this.rJ_Button_VolumeMappings_add.BorderSize = 1;
            this.rJ_Button_VolumeMappings_add.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_VolumeMappings_add.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_VolumeMappings_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_VolumeMappings_add.FlatAppearance.BorderSize = 0;
            this.rJ_Button_VolumeMappings_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_VolumeMappings_add.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_VolumeMappings_add.GUID = "";
            this.rJ_Button_VolumeMappings_add.Image_padding = new System.Windows.Forms.Padding(5);
            this.rJ_Button_VolumeMappings_add.Location = new System.Drawing.Point(620, 3);
            this.rJ_Button_VolumeMappings_add.Name = "rJ_Button_VolumeMappings_add";
            this.rJ_Button_VolumeMappings_add.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button_VolumeMappings_add.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_VolumeMappings_add.ProhibitionLineWidth = 4;
            this.rJ_Button_VolumeMappings_add.ProhibitionSymbolSize = 30;
            this.rJ_Button_VolumeMappings_add.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_VolumeMappings_add.ShadowSize = 0;
            this.rJ_Button_VolumeMappings_add.ShowLoadingForm = false;
            this.rJ_Button_VolumeMappings_add.Size = new System.Drawing.Size(46, 45);
            this.rJ_Button_VolumeMappings_add.State = false;
            this.rJ_Button_VolumeMappings_add.TabIndex = 173;
            this.rJ_Button_VolumeMappings_add.TextColor = System.Drawing.Color.White;
            this.rJ_Button_VolumeMappings_add.TextHeight = 0;
            this.rJ_Button_VolumeMappings_add.UseVisualStyleBackColor = false;
            // 
            // rJ_Pannel2
            // 
            this.rJ_Pannel2.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.rJ_Pannel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.rJ_Pannel2.BorderRadius = 40;
            this.rJ_Pannel2.BorderSize = 2;
            this.rJ_Pannel2.Controls.Add(this.rJ_Button_generate);
            this.rJ_Pannel2.Controls.Add(this.checkBox_Detach);
            this.rJ_Pannel2.Controls.Add(this.panel4);
            this.rJ_Pannel2.Controls.Add(this.panel5);
            this.rJ_Pannel2.Controls.Add(this.rJ_Pannel1);
            this.rJ_Pannel2.Controls.Add(this.panel6);
            this.rJ_Pannel2.Controls.Add(this.panel7);
            this.rJ_Pannel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rJ_Pannel2.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel2.IsSelected = false;
            this.rJ_Pannel2.Location = new System.Drawing.Point(7, 109);
            this.rJ_Pannel2.Margin = new System.Windows.Forms.Padding(10);
            this.rJ_Pannel2.Name = "rJ_Pannel2";
            this.rJ_Pannel2.Padding = new System.Windows.Forms.Padding(10, 10, 15, 15);
            this.rJ_Pannel2.ShadowColor = System.Drawing.Color.Gainsboro;
            this.rJ_Pannel2.ShadowSize = 3;
            this.rJ_Pannel2.Size = new System.Drawing.Size(1238, 447);
            this.rJ_Pannel2.TabIndex = 174;
            // 
            // rJ_Button_generate
            // 
            this.rJ_Button_generate.AutoResetState = false;
            this.rJ_Button_generate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rJ_Button_generate.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.rJ_Button_generate.BackgroundImage = global::DockerTools.Properties.Resources.message;
            this.rJ_Button_generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_generate.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_generate.BorderRadius = 30;
            this.rJ_Button_generate.BorderSize = 1;
            this.rJ_Button_generate.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_generate.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_generate.FlatAppearance.BorderSize = 0;
            this.rJ_Button_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_generate.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_generate.GUID = "";
            this.rJ_Button_generate.Image_padding = new System.Windows.Forms.Padding(8, 5, 5, 5);
            this.rJ_Button_generate.Location = new System.Drawing.Point(1165, 390);
            this.rJ_Button_generate.Name = "rJ_Button_generate";
            this.rJ_Button_generate.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button_generate.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_generate.ProhibitionLineWidth = 4;
            this.rJ_Button_generate.ProhibitionSymbolSize = 30;
            this.rJ_Button_generate.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_generate.ShadowSize = 0;
            this.rJ_Button_generate.ShowLoadingForm = false;
            this.rJ_Button_generate.Size = new System.Drawing.Size(46, 45);
            this.rJ_Button_generate.State = false;
            this.rJ_Button_generate.TabIndex = 178;
            this.rJ_Button_generate.TextColor = System.Drawing.Color.White;
            this.rJ_Button_generate.TextHeight = 0;
            this.rJ_Button_generate.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(7, 556);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1238, 12);
            this.panel11.TabIndex = 175;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.rJ_Button_load_template);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Controls.Add(this.comboBox_template);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(7, 47);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1238, 62);
            this.panel12.TabIndex = 178;
            // 
            // rJ_Button_load_template
            // 
            this.rJ_Button_load_template.AutoResetState = false;
            this.rJ_Button_load_template.BackColor = System.Drawing.Color.White;
            this.rJ_Button_load_template.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.rJ_Button_load_template.BackgroundImage = global::DockerTools.Properties.Resources.download_circular_button;
            this.rJ_Button_load_template.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_load_template.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_load_template.BorderRadius = 30;
            this.rJ_Button_load_template.BorderSize = 1;
            this.rJ_Button_load_template.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_load_template.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_load_template.FlatAppearance.BorderSize = 0;
            this.rJ_Button_load_template.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_load_template.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_load_template.GUID = "";
            this.rJ_Button_load_template.Image_padding = new System.Windows.Forms.Padding(5);
            this.rJ_Button_load_template.Location = new System.Drawing.Point(500, 3);
            this.rJ_Button_load_template.Name = "rJ_Button_load_template";
            this.rJ_Button_load_template.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button_load_template.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_load_template.ProhibitionLineWidth = 4;
            this.rJ_Button_load_template.ProhibitionSymbolSize = 30;
            this.rJ_Button_load_template.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_load_template.ShadowSize = 0;
            this.rJ_Button_load_template.ShowLoadingForm = false;
            this.rJ_Button_load_template.Size = new System.Drawing.Size(46, 45);
            this.rJ_Button_load_template.State = false;
            this.rJ_Button_load_template.TabIndex = 179;
            this.rJ_Button_load_template.TextColor = System.Drawing.Color.White;
            this.rJ_Button_load_template.TextHeight = 0;
            this.rJ_Button_load_template.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(26, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 172;
            this.label5.Text = "Template";
            // 
            // comboBox_template
            // 
            this.comboBox_template.BackColor = System.Drawing.Color.White;
            this.comboBox_template.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_template.FormattingEnabled = true;
            this.comboBox_template.Location = new System.Drawing.Point(132, 9);
            this.comboBox_template.Name = "comboBox_template";
            this.comboBox_template.Size = new System.Drawing.Size(362, 33);
            this.comboBox_template.TabIndex = 171;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.rJ_Button_refresh_docker_command);
            this.panel13.Controls.Add(this.rJ_TextBox_docker_command);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(7, 568);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1238, 274);
            this.panel13.TabIndex = 179;
            // 
            // rJ_Button_refresh_docker_command
            // 
            this.rJ_Button_refresh_docker_command.AutoResetState = false;
            this.rJ_Button_refresh_docker_command.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rJ_Button_refresh_docker_command.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.rJ_Button_refresh_docker_command.BackgroundImage = global::DockerTools.Properties.Resources._568370;
            this.rJ_Button_refresh_docker_command.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_refresh_docker_command.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_refresh_docker_command.BorderRadius = 30;
            this.rJ_Button_refresh_docker_command.BorderSize = 1;
            this.rJ_Button_refresh_docker_command.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_refresh_docker_command.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_refresh_docker_command.FlatAppearance.BorderSize = 0;
            this.rJ_Button_refresh_docker_command.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_refresh_docker_command.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_refresh_docker_command.GUID = "";
            this.rJ_Button_refresh_docker_command.Image_padding = new System.Windows.Forms.Padding(8, 5, 5, 5);
            this.rJ_Button_refresh_docker_command.Location = new System.Drawing.Point(1186, 6);
            this.rJ_Button_refresh_docker_command.Name = "rJ_Button_refresh_docker_command";
            this.rJ_Button_refresh_docker_command.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button_refresh_docker_command.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_refresh_docker_command.ProhibitionLineWidth = 4;
            this.rJ_Button_refresh_docker_command.ProhibitionSymbolSize = 30;
            this.rJ_Button_refresh_docker_command.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_refresh_docker_command.ShadowSize = 0;
            this.rJ_Button_refresh_docker_command.ShowLoadingForm = false;
            this.rJ_Button_refresh_docker_command.Size = new System.Drawing.Size(46, 45);
            this.rJ_Button_refresh_docker_command.State = false;
            this.rJ_Button_refresh_docker_command.TabIndex = 179;
            this.rJ_Button_refresh_docker_command.TextColor = System.Drawing.Color.White;
            this.rJ_Button_refresh_docker_command.TextHeight = 0;
            this.rJ_Button_refresh_docker_command.UseVisualStyleBackColor = false;
            // 
            // rJ_TextBox_docker_command
            // 
            this.rJ_TextBox_docker_command.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rJ_TextBox_docker_command.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_docker_command.BorderFocusColor = System.Drawing.Color.Blue;
            this.rJ_TextBox_docker_command.BorderRadius = 10;
            this.rJ_TextBox_docker_command.BorderSize = 1;
            this.rJ_TextBox_docker_command.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_TextBox_docker_command.Font = new System.Drawing.Font("Cascadia Code", 14.25F);
            this.rJ_TextBox_docker_command.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_docker_command.GUID = "";
            this.rJ_TextBox_docker_command.Location = new System.Drawing.Point(0, 0);
            this.rJ_TextBox_docker_command.Multiline = true;
            this.rJ_TextBox_docker_command.Name = "rJ_TextBox_docker_command";
            this.rJ_TextBox_docker_command.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_docker_command.PassWordChar = false;
            this.rJ_TextBox_docker_command.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_docker_command.PlaceholderText = "enter docker command...";
            this.rJ_TextBox_docker_command.ShowTouchPannel = false;
            this.rJ_TextBox_docker_command.Size = new System.Drawing.Size(1238, 274);
            this.rJ_TextBox_docker_command.TabIndex = 178;
            this.rJ_TextBox_docker_command.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_docker_command.Texts = "";
            this.rJ_TextBox_docker_command.UnderlineStyle = false;
            // 
            // Dialog_add_container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionHeight = 40;
            this.ClientSize = new System.Drawing.Size(1252, 906);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.rJ_Pannel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel12);
            this.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 14.25F);
            this.Name = "Dialog_add_container";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Add Container";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.rJ_Pannel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.rJ_Pannel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MyUI.RJ_Button rJ_Button_cancel;
        private System.Windows.Forms.Panel panel2;
        private MyUI.RJ_Button rJ_Button_creat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private MyUI.RJ_TextBox rJ_TextBox_ContainerName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private MyUI.RJ_TextBox rJ_TextBox_Network;
        private System.Windows.Forms.CheckBox checkBox_Detach;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private MyUI.RJ_TextBox rJ_TextBox_PortForward;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox comboBox_ImageName;
        private System.Windows.Forms.Label label4;
        private MyUI.RJ_Pannel rJ_Pannel1;
        private SQLUI.SQL_DataGridView sqL_DataGridView_VolumeMappings;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private MyUI.RJ_Button rJ_Button_VolumeMappings_add;
        private MyUI.RJ_Button rJ_Button_VolumeMappings_delete;
        private MyUI.RJ_Button rJ_Button_VolumeMappings_edit;
        private System.Windows.Forms.Panel panel10;
        private MyUI.RJ_Pannel rJ_Pannel2;
        private MyUI.RJ_Button rJ_Button_generate;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private MyUI.RJ_Button rJ_Button_refresh_docker_command;
        private MyUI.RJ_TextBox rJ_TextBox_docker_command;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_template;
        private MyUI.RJ_Button rJ_Button_load_template;
    }
}