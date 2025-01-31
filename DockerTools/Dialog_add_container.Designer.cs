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
            this.rJ_TextBox_docker_command = new MyUI.RJ_TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rJ_TextBox_ContainerName = new MyUI.RJ_TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rJ_TextBox_Network = new MyUI.RJ_TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rJ_TextBox_PortForward = new MyUI.RJ_TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_ImageName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rJ_TextBox_ImageTag = new MyUI.RJ_TextBox();
            this.rJ_Pannel1 = new MyUI.RJ_Pannel();
            this.rJ_Button_refresh_docker_command = new MyUI.RJ_Button();
            this.sqL_DataGridView_VolumeMappings = new SQLUI.SQL_DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.rJ_Pannel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rJ_Button_cancel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rJ_Button_creat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 853);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.panel1.Size = new System.Drawing.Size(1244, 49);
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
            this.rJ_Button_cancel.Location = new System.Drawing.Point(969, 0);
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
            this.panel2.Location = new System.Drawing.Point(1095, 0);
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
            this.rJ_Button_creat.Location = new System.Drawing.Point(1108, 0);
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
            this.panel3.Location = new System.Drawing.Point(4, 845);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1244, 8);
            this.panel3.TabIndex = 160;
            // 
            // rJ_TextBox_docker_command
            // 
            this.rJ_TextBox_docker_command.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rJ_TextBox_docker_command.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_docker_command.BorderFocusColor = System.Drawing.Color.Blue;
            this.rJ_TextBox_docker_command.BorderRadius = 10;
            this.rJ_TextBox_docker_command.BorderSize = 1;
            this.rJ_TextBox_docker_command.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rJ_TextBox_docker_command.Font = new System.Drawing.Font("Cascadia Code", 14.25F);
            this.rJ_TextBox_docker_command.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_docker_command.GUID = "";
            this.rJ_TextBox_docker_command.Location = new System.Drawing.Point(4, 495);
            this.rJ_TextBox_docker_command.Multiline = true;
            this.rJ_TextBox_docker_command.Name = "rJ_TextBox_docker_command";
            this.rJ_TextBox_docker_command.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_docker_command.PassWordChar = false;
            this.rJ_TextBox_docker_command.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_docker_command.PlaceholderText = "enter docker command...";
            this.rJ_TextBox_docker_command.ShowTouchPannel = false;
            this.rJ_TextBox_docker_command.Size = new System.Drawing.Size(1244, 350);
            this.rJ_TextBox_docker_command.TabIndex = 161;
            this.rJ_TextBox_docker_command.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_docker_command.Texts = "";
            this.rJ_TextBox_docker_command.UnderlineStyle = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.rJ_TextBox_ContainerName);
            this.panel4.Location = new System.Drawing.Point(35, 83);
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
            this.rJ_TextBox_ContainerName.BackColor = System.Drawing.SystemColors.Window;
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
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.rJ_TextBox_Network);
            this.panel5.Location = new System.Drawing.Point(35, 167);
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
            this.rJ_TextBox_Network.BackColor = System.Drawing.SystemColors.Window;
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
            this.rJ_TextBox_Network.PlaceholderText = "host";
            this.rJ_TextBox_Network.ShowTouchPannel = false;
            this.rJ_TextBox_Network.Size = new System.Drawing.Size(426, 40);
            this.rJ_TextBox_Network.TabIndex = 164;
            this.rJ_TextBox_Network.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_Network.Texts = "";
            this.rJ_TextBox_Network.UnderlineStyle = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 14.25F);
            this.checkBox1.Location = new System.Drawing.Point(35, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 35);
            this.checkBox1.TabIndex = 167;
            this.checkBox1.Text = "Detach";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.rJ_TextBox_PortForward);
            this.panel6.Location = new System.Drawing.Point(35, 251);
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
            this.rJ_TextBox_PortForward.BackColor = System.Drawing.SystemColors.Window;
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
            this.panel7.Controls.Add(this.comboBox_ImageName);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.rJ_TextBox_ImageTag);
            this.panel7.Location = new System.Drawing.Point(35, 335);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(471, 78);
            this.panel7.TabIndex = 169;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 14.25F);
            this.label5.Location = new System.Drawing.Point(224, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 170;
            this.label5.Text = ":";
            // 
            // comboBox_ImageName
            // 
            this.comboBox_ImageName.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ImageName.FormattingEnabled = true;
            this.comboBox_ImageName.Location = new System.Drawing.Point(26, 41);
            this.comboBox_ImageName.Name = "comboBox_ImageName";
            this.comboBox_ImageName.Size = new System.Drawing.Size(190, 33);
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
            // rJ_TextBox_ImageTag
            // 
            this.rJ_TextBox_ImageTag.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_ImageTag.BorderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_ImageTag.BorderFocusColor = System.Drawing.Color.SteelBlue;
            this.rJ_TextBox_ImageTag.BorderRadius = 5;
            this.rJ_TextBox_ImageTag.BorderSize = 1;
            this.rJ_TextBox_ImageTag.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_TextBox_ImageTag.ForeColor = System.Drawing.Color.Black;
            this.rJ_TextBox_ImageTag.GUID = "";
            this.rJ_TextBox_ImageTag.Location = new System.Drawing.Point(253, 33);
            this.rJ_TextBox_ImageTag.Multiline = false;
            this.rJ_TextBox_ImageTag.Name = "rJ_TextBox_ImageTag";
            this.rJ_TextBox_ImageTag.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_ImageTag.PassWordChar = false;
            this.rJ_TextBox_ImageTag.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_ImageTag.PlaceholderText = "latest";
            this.rJ_TextBox_ImageTag.ShowTouchPannel = false;
            this.rJ_TextBox_ImageTag.Size = new System.Drawing.Size(199, 40);
            this.rJ_TextBox_ImageTag.TabIndex = 164;
            this.rJ_TextBox_ImageTag.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_ImageTag.Texts = "";
            this.rJ_TextBox_ImageTag.UnderlineStyle = true;
            // 
            // rJ_Pannel1
            // 
            this.rJ_Pannel1.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.rJ_Pannel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.rJ_Pannel1.BorderRadius = 40;
            this.rJ_Pannel1.BorderSize = 2;
            this.rJ_Pannel1.Controls.Add(this.sqL_DataGridView_VolumeMappings);
            this.rJ_Pannel1.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel1.IsSelected = false;
            this.rJ_Pannel1.Location = new System.Drawing.Point(531, 42);
            this.rJ_Pannel1.Name = "rJ_Pannel1";
            this.rJ_Pannel1.Padding = new System.Windows.Forms.Padding(10, 10, 15, 15);
            this.rJ_Pannel1.ShadowColor = System.Drawing.Color.Gainsboro;
            this.rJ_Pannel1.ShadowSize = 3;
            this.rJ_Pannel1.Size = new System.Drawing.Size(691, 371);
            this.rJ_Pannel1.TabIndex = 170;
            // 
            // rJ_Button_refresh_docker_command
            // 
            this.rJ_Button_refresh_docker_command.AutoResetState = false;
            this.rJ_Button_refresh_docker_command.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rJ_Button_refresh_docker_command.BackgroundColor = System.Drawing.SystemColors.MenuBar;
            this.rJ_Button_refresh_docker_command.BackgroundImage = global::DockerTools.Properties.Resources._568370;
            this.rJ_Button_refresh_docker_command.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_refresh_docker_command.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_refresh_docker_command.BorderRadius = 40;
            this.rJ_Button_refresh_docker_command.BorderSize = 1;
            this.rJ_Button_refresh_docker_command.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_refresh_docker_command.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_refresh_docker_command.FlatAppearance.BorderSize = 0;
            this.rJ_Button_refresh_docker_command.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_refresh_docker_command.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_refresh_docker_command.GUID = "";
            this.rJ_Button_refresh_docker_command.Image_padding = new System.Windows.Forms.Padding(8, 5, 5, 5);
            this.rJ_Button_refresh_docker_command.Location = new System.Drawing.Point(1192, 506);
            this.rJ_Button_refresh_docker_command.Name = "rJ_Button_refresh_docker_command";
            this.rJ_Button_refresh_docker_command.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button_refresh_docker_command.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_refresh_docker_command.ProhibitionLineWidth = 4;
            this.rJ_Button_refresh_docker_command.ProhibitionSymbolSize = 30;
            this.rJ_Button_refresh_docker_command.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_refresh_docker_command.ShadowSize = 0;
            this.rJ_Button_refresh_docker_command.ShowLoadingForm = false;
            this.rJ_Button_refresh_docker_command.Size = new System.Drawing.Size(46, 43);
            this.rJ_Button_refresh_docker_command.State = false;
            this.rJ_Button_refresh_docker_command.TabIndex = 172;
            this.rJ_Button_refresh_docker_command.TextColor = System.Drawing.Color.White;
            this.rJ_Button_refresh_docker_command.TextHeight = 0;
            this.rJ_Button_refresh_docker_command.UseVisualStyleBackColor = false;
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
            this.sqL_DataGridView_VolumeMappings.cellStyleFont = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqL_DataGridView_VolumeMappings.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_VolumeMappings.checkedRowBackColor = System.Drawing.Color.YellowGreen;
            this.sqL_DataGridView_VolumeMappings.columnHeaderBackColor = System.Drawing.Color.White;
            this.sqL_DataGridView_VolumeMappings.columnHeaderBorderColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_VolumeMappings.columnHeaderFont = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold);
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
            this.sqL_DataGridView_VolumeMappings.Size = new System.Drawing.Size(666, 346);
            this.sqL_DataGridView_VolumeMappings.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_VolumeMappings.TabIndex = 171;
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
            // Dialog_add_container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1252, 906);
            this.Controls.Add(this.rJ_Button_refresh_docker_command);
            this.Controls.Add(this.rJ_Pannel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.rJ_TextBox_docker_command);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cascadia Code ExtraLight", 14.25F);
            this.Name = "Dialog_add_container";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MyUI.RJ_Button rJ_Button_cancel;
        private System.Windows.Forms.Panel panel2;
        private MyUI.RJ_Button rJ_Button_creat;
        private System.Windows.Forms.Panel panel3;
        private MyUI.RJ_TextBox rJ_TextBox_docker_command;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private MyUI.RJ_TextBox rJ_TextBox_ContainerName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private MyUI.RJ_TextBox rJ_TextBox_Network;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private MyUI.RJ_TextBox rJ_TextBox_PortForward;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_ImageName;
        private System.Windows.Forms.Label label4;
        private MyUI.RJ_TextBox rJ_TextBox_ImageTag;
        private MyUI.RJ_Pannel rJ_Pannel1;
        private MyUI.RJ_Button rJ_Button_refresh_docker_command;
        private SQLUI.SQL_DataGridView sqL_DataGridView_VolumeMappings;
    }
}