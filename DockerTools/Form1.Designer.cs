
namespace DockerTools
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rJ_Pannel1 = new MyUI.RJ_Pannel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sqL_DataGridView_Docker_Images = new SQLUI.SQL_DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rJ_Button_docker_upload_image = new MyUI.RJ_Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rJ_Button_docker_download_image = new MyUI.RJ_Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rJ_Button_docker_add_image = new MyUI.RJ_Button();
            this.rJ_Button_docker_delete_image = new MyUI.RJ_Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.sqL_DataGridView_Docker_Containers = new SQLUI.SQL_DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.rJ_Button1 = new MyUI.RJ_Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rJ_Button2 = new MyUI.RJ_Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.rJ_Button_docker_add_container = new MyUI.RJ_Button();
            this.rJ_Button4 = new MyUI.RJ_Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rJ_Button_檢查環境 = new MyUI.RJ_Button();
            this.richTextBox_powershell = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.rJ_Pannel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rJ_Pannel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(707, 861);
            this.panel1.TabIndex = 1;
            // 
            // rJ_Pannel1
            // 
            this.rJ_Pannel1.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rJ_Pannel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.rJ_Pannel1.BorderRadius = 40;
            this.rJ_Pannel1.BorderSize = 2;
            this.rJ_Pannel1.Controls.Add(this.tabControl1);
            this.rJ_Pannel1.Controls.Add(this.panel2);
            this.rJ_Pannel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_Pannel1.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel1.IsSelected = false;
            this.rJ_Pannel1.Location = new System.Drawing.Point(5, 5);
            this.rJ_Pannel1.Name = "rJ_Pannel1";
            this.rJ_Pannel1.Padding = new System.Windows.Forms.Padding(10, 12, 12, 25);
            this.rJ_Pannel1.ShadowColor = System.Drawing.Color.Gainsboro;
            this.rJ_Pannel1.ShadowSize = 3;
            this.rJ_Pannel1.Size = new System.Drawing.Size(697, 851);
            this.rJ_Pannel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 93);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 733);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10);
            this.tabPage1.Size = new System.Drawing.Size(667, 707);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Docker";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(10, 10);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(647, 687);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(639, 661);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Images";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sqL_DataGridView_Docker_Images);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 14);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(633, 579);
            this.panel4.TabIndex = 6;
            // 
            // sqL_DataGridView_Docker_Images
            // 
            this.sqL_DataGridView_Docker_Images.AutoSelectToDeep = false;
            this.sqL_DataGridView_Docker_Images.backColor = System.Drawing.Color.WhiteSmoke;
            this.sqL_DataGridView_Docker_Images.BorderColor = System.Drawing.Color.White;
            this.sqL_DataGridView_Docker_Images.BorderRadius = 1;
            this.sqL_DataGridView_Docker_Images.BorderSize = 1;
            this.sqL_DataGridView_Docker_Images.CellBorderColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_Docker_Images.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Images.cellStylBackColor = System.Drawing.Color.Transparent;
            this.sqL_DataGridView_Docker_Images.cellStyleFont = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqL_DataGridView_Docker_Images.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_Docker_Images.checkedRowBackColor = System.Drawing.Color.YellowGreen;
            this.sqL_DataGridView_Docker_Images.columnHeaderBackColor = System.Drawing.Color.White;
            this.sqL_DataGridView_Docker_Images.columnHeaderBorderColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_Docker_Images.columnHeaderFont = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_Docker_Images.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Images.columnHeadersHeight = 50;
            this.sqL_DataGridView_Docker_Images.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.sqL_DataGridView_Docker_Images.DataGridViewAutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sqL_DataGridView_Docker_Images.DataKeyEnable = false;
            this.sqL_DataGridView_Docker_Images.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqL_DataGridView_Docker_Images.Font = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_Docker_Images.ImageBox = false;
            this.sqL_DataGridView_Docker_Images.Location = new System.Drawing.Point(3, 3);
            this.sqL_DataGridView_Docker_Images.Name = "sqL_DataGridView_Docker_Images";
            this.sqL_DataGridView_Docker_Images.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_Docker_Images.Password = "user82822040";
            this.sqL_DataGridView_Docker_Images.Port = ((uint)(3306u));
            this.sqL_DataGridView_Docker_Images.rowBorderStyleOption = SQLUI.SQL_DataGridView.RowBorderStyleOption.BottomLine;
            this.sqL_DataGridView_Docker_Images.rowHeaderBackColor = System.Drawing.Color.White;
            this.sqL_DataGridView_Docker_Images.rowHeaderBorderStyleOption = SQLUI.SQL_DataGridView.RowBorderStyleOption.BottomLine;
            this.sqL_DataGridView_Docker_Images.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Images.RowsColor = System.Drawing.Color.White;
            this.sqL_DataGridView_Docker_Images.RowsHeight = 10;
            this.sqL_DataGridView_Docker_Images.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_Docker_Images.selectedBorderSize = 0;
            this.sqL_DataGridView_Docker_Images.selectedRowBackColor = System.Drawing.Color.DarkGray;
            this.sqL_DataGridView_Docker_Images.selectedRowBorderColor = System.Drawing.Color.Blue;
            this.sqL_DataGridView_Docker_Images.selectedRowForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_Docker_Images.Server = "127.0.0.0";
            this.sqL_DataGridView_Docker_Images.Size = new System.Drawing.Size(627, 573);
            this.sqL_DataGridView_Docker_Images.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_Docker_Images.TabIndex = 5;
            this.sqL_DataGridView_Docker_Images.UserName = "root";
            this.sqL_DataGridView_Docker_Images.可拖曳欄位寬度 = false;
            this.sqL_DataGridView_Docker_Images.可選擇多列 = false;
            this.sqL_DataGridView_Docker_Images.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Images.自動換行 = true;
            this.sqL_DataGridView_Docker_Images.表單字體 = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_Docker_Images.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_Docker_Images.顯示CheckBox = false;
            this.sqL_DataGridView_Docker_Images.顯示首列 = false;
            this.sqL_DataGridView_Docker_Images.顯示首行 = true;
            this.sqL_DataGridView_Docker_Images.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Images.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rJ_Button_docker_upload_image);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.rJ_Button_docker_download_image);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.rJ_Button_docker_add_image);
            this.panel5.Controls.Add(this.rJ_Button_docker_delete_image);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 593);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Size = new System.Drawing.Size(633, 65);
            this.panel5.TabIndex = 5;
            // 
            // rJ_Button_docker_upload_image
            // 
            this.rJ_Button_docker_upload_image.AutoResetState = false;
            this.rJ_Button_docker_upload_image.BackColor = System.Drawing.Color.White;
            this.rJ_Button_docker_upload_image.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button_docker_upload_image.BackgroundImage = global::DockerTools.Properties.Resources.uploads;
            this.rJ_Button_docker_upload_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_docker_upload_image.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_docker_upload_image.BorderRadius = 40;
            this.rJ_Button_docker_upload_image.BorderSize = 1;
            this.rJ_Button_docker_upload_image.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_docker_upload_image.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_docker_upload_image.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_docker_upload_image.FlatAppearance.BorderSize = 0;
            this.rJ_Button_docker_upload_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_docker_upload_image.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_docker_upload_image.GUID = "";
            this.rJ_Button_docker_upload_image.Image_padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.rJ_Button_docker_upload_image.Location = new System.Drawing.Point(438, 3);
            this.rJ_Button_docker_upload_image.Name = "rJ_Button_docker_upload_image";
            this.rJ_Button_docker_upload_image.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button_docker_upload_image.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_docker_upload_image.ProhibitionLineWidth = 4;
            this.rJ_Button_docker_upload_image.ProhibitionSymbolSize = 30;
            this.rJ_Button_docker_upload_image.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_docker_upload_image.ShadowSize = 0;
            this.rJ_Button_docker_upload_image.ShowLoadingForm = false;
            this.rJ_Button_docker_upload_image.Size = new System.Drawing.Size(61, 59);
            this.rJ_Button_docker_upload_image.State = false;
            this.rJ_Button_docker_upload_image.TabIndex = 158;
            this.rJ_Button_docker_upload_image.TextColor = System.Drawing.Color.White;
            this.rJ_Button_docker_upload_image.TextHeight = 0;
            this.rJ_Button_docker_upload_image.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(499, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 59);
            this.panel7.TabIndex = 157;
            // 
            // rJ_Button_docker_download_image
            // 
            this.rJ_Button_docker_download_image.AutoResetState = false;
            this.rJ_Button_docker_download_image.BackColor = System.Drawing.Color.White;
            this.rJ_Button_docker_download_image.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button_docker_download_image.BackgroundImage = global::DockerTools.Properties.Resources.downloads;
            this.rJ_Button_docker_download_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_docker_download_image.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_docker_download_image.BorderRadius = 40;
            this.rJ_Button_docker_download_image.BorderSize = 1;
            this.rJ_Button_docker_download_image.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_docker_download_image.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_docker_download_image.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_docker_download_image.FlatAppearance.BorderSize = 0;
            this.rJ_Button_docker_download_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_docker_download_image.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_docker_download_image.GUID = "";
            this.rJ_Button_docker_download_image.Image_padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.rJ_Button_docker_download_image.Location = new System.Drawing.Point(504, 3);
            this.rJ_Button_docker_download_image.Name = "rJ_Button_docker_download_image";
            this.rJ_Button_docker_download_image.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button_docker_download_image.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_docker_download_image.ProhibitionLineWidth = 4;
            this.rJ_Button_docker_download_image.ProhibitionSymbolSize = 30;
            this.rJ_Button_docker_download_image.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_docker_download_image.ShadowSize = 0;
            this.rJ_Button_docker_download_image.ShowLoadingForm = false;
            this.rJ_Button_docker_download_image.Size = new System.Drawing.Size(61, 59);
            this.rJ_Button_docker_download_image.State = false;
            this.rJ_Button_docker_download_image.TabIndex = 156;
            this.rJ_Button_docker_download_image.TextColor = System.Drawing.Color.White;
            this.rJ_Button_docker_download_image.TextHeight = 0;
            this.rJ_Button_docker_download_image.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(565, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 59);
            this.panel6.TabIndex = 155;
            // 
            // rJ_Button_docker_add_image
            // 
            this.rJ_Button_docker_add_image.AutoResetState = false;
            this.rJ_Button_docker_add_image.BackColor = System.Drawing.Color.White;
            this.rJ_Button_docker_add_image.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button_docker_add_image.BackgroundImage = global::DockerTools.Properties.Resources.add_new_plus_512;
            this.rJ_Button_docker_add_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_docker_add_image.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_docker_add_image.BorderRadius = 40;
            this.rJ_Button_docker_add_image.BorderSize = 1;
            this.rJ_Button_docker_add_image.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_docker_add_image.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_docker_add_image.Dock = System.Windows.Forms.DockStyle.Left;
            this.rJ_Button_docker_add_image.FlatAppearance.BorderSize = 0;
            this.rJ_Button_docker_add_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_docker_add_image.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_docker_add_image.GUID = "";
            this.rJ_Button_docker_add_image.Image_padding = new System.Windows.Forms.Padding(8);
            this.rJ_Button_docker_add_image.Location = new System.Drawing.Point(2, 3);
            this.rJ_Button_docker_add_image.Name = "rJ_Button_docker_add_image";
            this.rJ_Button_docker_add_image.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_docker_add_image.ProhibitionLineWidth = 4;
            this.rJ_Button_docker_add_image.ProhibitionSymbolSize = 30;
            this.rJ_Button_docker_add_image.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_docker_add_image.ShadowSize = 0;
            this.rJ_Button_docker_add_image.ShowLoadingForm = false;
            this.rJ_Button_docker_add_image.Size = new System.Drawing.Size(61, 59);
            this.rJ_Button_docker_add_image.State = false;
            this.rJ_Button_docker_add_image.TabIndex = 154;
            this.rJ_Button_docker_add_image.TextColor = System.Drawing.Color.White;
            this.rJ_Button_docker_add_image.TextHeight = 0;
            this.rJ_Button_docker_add_image.UseVisualStyleBackColor = false;
            // 
            // rJ_Button_docker_delete_image
            // 
            this.rJ_Button_docker_delete_image.AutoResetState = false;
            this.rJ_Button_docker_delete_image.BackColor = System.Drawing.Color.White;
            this.rJ_Button_docker_delete_image.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button_docker_delete_image.BackgroundImage = global::DockerTools.Properties.Resources.trash_512;
            this.rJ_Button_docker_delete_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_docker_delete_image.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_docker_delete_image.BorderRadius = 40;
            this.rJ_Button_docker_delete_image.BorderSize = 1;
            this.rJ_Button_docker_delete_image.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_docker_delete_image.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_docker_delete_image.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_docker_delete_image.FlatAppearance.BorderSize = 0;
            this.rJ_Button_docker_delete_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_docker_delete_image.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_docker_delete_image.GUID = "";
            this.rJ_Button_docker_delete_image.Image_padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.rJ_Button_docker_delete_image.Location = new System.Drawing.Point(570, 3);
            this.rJ_Button_docker_delete_image.Name = "rJ_Button_docker_delete_image";
            this.rJ_Button_docker_delete_image.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_docker_delete_image.ProhibitionLineWidth = 4;
            this.rJ_Button_docker_delete_image.ProhibitionSymbolSize = 30;
            this.rJ_Button_docker_delete_image.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_docker_delete_image.ShadowSize = 0;
            this.rJ_Button_docker_delete_image.ShowLoadingForm = false;
            this.rJ_Button_docker_delete_image.Size = new System.Drawing.Size(61, 59);
            this.rJ_Button_docker_delete_image.State = false;
            this.rJ_Button_docker_delete_image.TabIndex = 153;
            this.rJ_Button_docker_delete_image.TextColor = System.Drawing.Color.White;
            this.rJ_Button_docker_delete_image.TextHeight = 0;
            this.rJ_Button_docker_delete_image.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(633, 11);
            this.panel3.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.sqL_DataGridView_Docker_Containers);
            this.tabPage4.Controls.Add(this.panel9);
            this.tabPage4.Controls.Add(this.panel8);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(639, 661);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Containers";
            // 
            // sqL_DataGridView_Docker_Containers
            // 
            this.sqL_DataGridView_Docker_Containers.AutoSelectToDeep = false;
            this.sqL_DataGridView_Docker_Containers.backColor = System.Drawing.Color.WhiteSmoke;
            this.sqL_DataGridView_Docker_Containers.BorderColor = System.Drawing.Color.White;
            this.sqL_DataGridView_Docker_Containers.BorderRadius = 1;
            this.sqL_DataGridView_Docker_Containers.BorderSize = 1;
            this.sqL_DataGridView_Docker_Containers.CellBorderColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_Docker_Containers.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Containers.cellStylBackColor = System.Drawing.Color.Transparent;
            this.sqL_DataGridView_Docker_Containers.cellStyleFont = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqL_DataGridView_Docker_Containers.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_Docker_Containers.checkedRowBackColor = System.Drawing.Color.YellowGreen;
            this.sqL_DataGridView_Docker_Containers.columnHeaderBackColor = System.Drawing.Color.White;
            this.sqL_DataGridView_Docker_Containers.columnHeaderBorderColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_Docker_Containers.columnHeaderFont = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_Docker_Containers.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Containers.columnHeadersHeight = 50;
            this.sqL_DataGridView_Docker_Containers.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.sqL_DataGridView_Docker_Containers.DataGridViewAutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sqL_DataGridView_Docker_Containers.DataKeyEnable = false;
            this.sqL_DataGridView_Docker_Containers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqL_DataGridView_Docker_Containers.Font = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_Docker_Containers.ImageBox = false;
            this.sqL_DataGridView_Docker_Containers.Location = new System.Drawing.Point(3, 14);
            this.sqL_DataGridView_Docker_Containers.Name = "sqL_DataGridView_Docker_Containers";
            this.sqL_DataGridView_Docker_Containers.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_Docker_Containers.Password = "user82822040";
            this.sqL_DataGridView_Docker_Containers.Port = ((uint)(3306u));
            this.sqL_DataGridView_Docker_Containers.rowBorderStyleOption = SQLUI.SQL_DataGridView.RowBorderStyleOption.BottomLine;
            this.sqL_DataGridView_Docker_Containers.rowHeaderBackColor = System.Drawing.Color.White;
            this.sqL_DataGridView_Docker_Containers.rowHeaderBorderStyleOption = SQLUI.SQL_DataGridView.RowBorderStyleOption.BottomLine;
            this.sqL_DataGridView_Docker_Containers.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Containers.RowsColor = System.Drawing.Color.White;
            this.sqL_DataGridView_Docker_Containers.RowsHeight = 10;
            this.sqL_DataGridView_Docker_Containers.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_Docker_Containers.selectedBorderSize = 0;
            this.sqL_DataGridView_Docker_Containers.selectedRowBackColor = System.Drawing.Color.DarkGray;
            this.sqL_DataGridView_Docker_Containers.selectedRowBorderColor = System.Drawing.Color.Blue;
            this.sqL_DataGridView_Docker_Containers.selectedRowForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_Docker_Containers.Server = "127.0.0.0";
            this.sqL_DataGridView_Docker_Containers.Size = new System.Drawing.Size(633, 579);
            this.sqL_DataGridView_Docker_Containers.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_Docker_Containers.TabIndex = 7;
            this.sqL_DataGridView_Docker_Containers.UserName = "root";
            this.sqL_DataGridView_Docker_Containers.可拖曳欄位寬度 = false;
            this.sqL_DataGridView_Docker_Containers.可選擇多列 = false;
            this.sqL_DataGridView_Docker_Containers.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Containers.自動換行 = true;
            this.sqL_DataGridView_Docker_Containers.表單字體 = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_Docker_Containers.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_Docker_Containers.顯示CheckBox = false;
            this.sqL_DataGridView_Docker_Containers.顯示首列 = false;
            this.sqL_DataGridView_Docker_Containers.顯示首行 = true;
            this.sqL_DataGridView_Docker_Containers.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Containers.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.rJ_Button1);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.rJ_Button2);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.rJ_Button_docker_add_container);
            this.panel9.Controls.Add(this.rJ_Button4);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(3, 593);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel9.Size = new System.Drawing.Size(633, 65);
            this.panel9.TabIndex = 6;
            // 
            // rJ_Button1
            // 
            this.rJ_Button1.AutoResetState = false;
            this.rJ_Button1.BackColor = System.Drawing.Color.White;
            this.rJ_Button1.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button1.BackgroundImage = global::DockerTools.Properties.Resources.uploads;
            this.rJ_Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button1.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button1.BorderRadius = 40;
            this.rJ_Button1.BorderSize = 1;
            this.rJ_Button1.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button1.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button1.FlatAppearance.BorderSize = 0;
            this.rJ_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button1.ForeColor = System.Drawing.Color.White;
            this.rJ_Button1.GUID = "";
            this.rJ_Button1.Image_padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.rJ_Button1.Location = new System.Drawing.Point(438, 3);
            this.rJ_Button1.Name = "rJ_Button1";
            this.rJ_Button1.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button1.ProhibitionBorderLineWidth = 1;
            this.rJ_Button1.ProhibitionLineWidth = 4;
            this.rJ_Button1.ProhibitionSymbolSize = 30;
            this.rJ_Button1.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button1.ShadowSize = 0;
            this.rJ_Button1.ShowLoadingForm = false;
            this.rJ_Button1.Size = new System.Drawing.Size(61, 59);
            this.rJ_Button1.State = false;
            this.rJ_Button1.TabIndex = 158;
            this.rJ_Button1.TextColor = System.Drawing.Color.White;
            this.rJ_Button1.TextHeight = 0;
            this.rJ_Button1.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(499, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 59);
            this.panel10.TabIndex = 157;
            // 
            // rJ_Button2
            // 
            this.rJ_Button2.AutoResetState = false;
            this.rJ_Button2.BackColor = System.Drawing.Color.White;
            this.rJ_Button2.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button2.BackgroundImage = global::DockerTools.Properties.Resources.downloads;
            this.rJ_Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button2.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button2.BorderRadius = 40;
            this.rJ_Button2.BorderSize = 1;
            this.rJ_Button2.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button2.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button2.FlatAppearance.BorderSize = 0;
            this.rJ_Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button2.ForeColor = System.Drawing.Color.White;
            this.rJ_Button2.GUID = "";
            this.rJ_Button2.Image_padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.rJ_Button2.Location = new System.Drawing.Point(504, 3);
            this.rJ_Button2.Name = "rJ_Button2";
            this.rJ_Button2.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button2.ProhibitionBorderLineWidth = 1;
            this.rJ_Button2.ProhibitionLineWidth = 4;
            this.rJ_Button2.ProhibitionSymbolSize = 30;
            this.rJ_Button2.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button2.ShadowSize = 0;
            this.rJ_Button2.ShowLoadingForm = false;
            this.rJ_Button2.Size = new System.Drawing.Size(61, 59);
            this.rJ_Button2.State = false;
            this.rJ_Button2.TabIndex = 156;
            this.rJ_Button2.TextColor = System.Drawing.Color.White;
            this.rJ_Button2.TextHeight = 0;
            this.rJ_Button2.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(565, 3);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(5, 59);
            this.panel11.TabIndex = 155;
            // 
            // rJ_Button_docker_add_container
            // 
            this.rJ_Button_docker_add_container.AutoResetState = false;
            this.rJ_Button_docker_add_container.BackColor = System.Drawing.Color.White;
            this.rJ_Button_docker_add_container.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button_docker_add_container.BackgroundImage = global::DockerTools.Properties.Resources.add_new_plus_512;
            this.rJ_Button_docker_add_container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_docker_add_container.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_docker_add_container.BorderRadius = 40;
            this.rJ_Button_docker_add_container.BorderSize = 1;
            this.rJ_Button_docker_add_container.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_docker_add_container.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_docker_add_container.Dock = System.Windows.Forms.DockStyle.Left;
            this.rJ_Button_docker_add_container.FlatAppearance.BorderSize = 0;
            this.rJ_Button_docker_add_container.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_docker_add_container.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_docker_add_container.GUID = "";
            this.rJ_Button_docker_add_container.Image_padding = new System.Windows.Forms.Padding(8);
            this.rJ_Button_docker_add_container.Location = new System.Drawing.Point(2, 3);
            this.rJ_Button_docker_add_container.Name = "rJ_Button_docker_add_container";
            this.rJ_Button_docker_add_container.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_docker_add_container.ProhibitionLineWidth = 4;
            this.rJ_Button_docker_add_container.ProhibitionSymbolSize = 30;
            this.rJ_Button_docker_add_container.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_docker_add_container.ShadowSize = 0;
            this.rJ_Button_docker_add_container.ShowLoadingForm = false;
            this.rJ_Button_docker_add_container.Size = new System.Drawing.Size(61, 59);
            this.rJ_Button_docker_add_container.State = false;
            this.rJ_Button_docker_add_container.TabIndex = 154;
            this.rJ_Button_docker_add_container.TextColor = System.Drawing.Color.White;
            this.rJ_Button_docker_add_container.TextHeight = 0;
            this.rJ_Button_docker_add_container.UseVisualStyleBackColor = false;
            // 
            // rJ_Button4
            // 
            this.rJ_Button4.AutoResetState = false;
            this.rJ_Button4.BackColor = System.Drawing.Color.White;
            this.rJ_Button4.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button4.BackgroundImage = global::DockerTools.Properties.Resources.trash_512;
            this.rJ_Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button4.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button4.BorderRadius = 40;
            this.rJ_Button4.BorderSize = 1;
            this.rJ_Button4.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button4.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button4.FlatAppearance.BorderSize = 0;
            this.rJ_Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button4.ForeColor = System.Drawing.Color.White;
            this.rJ_Button4.GUID = "";
            this.rJ_Button4.Image_padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.rJ_Button4.Location = new System.Drawing.Point(570, 3);
            this.rJ_Button4.Name = "rJ_Button4";
            this.rJ_Button4.ProhibitionBorderLineWidth = 1;
            this.rJ_Button4.ProhibitionLineWidth = 4;
            this.rJ_Button4.ProhibitionSymbolSize = 30;
            this.rJ_Button4.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button4.ShadowSize = 0;
            this.rJ_Button4.ShowLoadingForm = false;
            this.rJ_Button4.Size = new System.Drawing.Size(61, 59);
            this.rJ_Button4.State = false;
            this.rJ_Button4.TabIndex = 153;
            this.rJ_Button4.TextColor = System.Drawing.Color.White;
            this.rJ_Button4.TextHeight = 0;
            this.rJ_Button4.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(633, 11);
            this.panel8.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(667, 707);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nginx";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rJ_Button_檢查環境);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 81);
            this.panel2.TabIndex = 2;
            // 
            // rJ_Button_檢查環境
            // 
            this.rJ_Button_檢查環境.AutoResetState = false;
            this.rJ_Button_檢查環境.BackColor = System.Drawing.Color.Transparent;
            this.rJ_Button_檢查環境.BackgroundColor = System.Drawing.Color.DimGray;
            this.rJ_Button_檢查環境.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Button_檢查環境.BorderRadius = 30;
            this.rJ_Button_檢查環境.BorderSize = 0;
            this.rJ_Button_檢查環境.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_檢查環境.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_檢查環境.FlatAppearance.BorderSize = 0;
            this.rJ_Button_檢查環境.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_檢查環境.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Button_檢查環境.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_檢查環境.GUID = "";
            this.rJ_Button_檢查環境.Image_padding = new System.Windows.Forms.Padding(0);
            this.rJ_Button_檢查環境.Location = new System.Drawing.Point(15, 14);
            this.rJ_Button_檢查環境.Name = "rJ_Button_檢查環境";
            this.rJ_Button_檢查環境.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_檢查環境.ProhibitionLineWidth = 4;
            this.rJ_Button_檢查環境.ProhibitionSymbolSize = 30;
            this.rJ_Button_檢查環境.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_檢查環境.ShadowSize = 0;
            this.rJ_Button_檢查環境.ShowLoadingForm = false;
            this.rJ_Button_檢查環境.Size = new System.Drawing.Size(133, 55);
            this.rJ_Button_檢查環境.State = false;
            this.rJ_Button_檢查環境.TabIndex = 0;
            this.rJ_Button_檢查環境.Text = "檢查環境";
            this.rJ_Button_檢查環境.TextColor = System.Drawing.Color.White;
            this.rJ_Button_檢查環境.TextHeight = 0;
            this.rJ_Button_檢查環境.UseVisualStyleBackColor = false;
            // 
            // richTextBox_powershell
            // 
            this.richTextBox_powershell.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox_powershell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_powershell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_powershell.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox_powershell.ForeColor = System.Drawing.Color.White;
            this.richTextBox_powershell.Location = new System.Drawing.Point(707, 0);
            this.richTextBox_powershell.Name = "richTextBox_powershell";
            this.richTextBox_powershell.Size = new System.Drawing.Size(777, 861);
            this.richTextBox_powershell.TabIndex = 2;
            this.richTextBox_powershell.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.richTextBox_powershell);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DockerTools";
            this.panel1.ResumeLayout(false);
            this.rJ_Pannel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox_powershell;
        private MyUI.RJ_Pannel rJ_Pannel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private MyUI.RJ_Button rJ_Button_檢查環境;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private SQLUI.SQL_DataGridView sqL_DataGridView_Docker_Images;
        private System.Windows.Forms.Panel panel5;
        private MyUI.RJ_Button rJ_Button_docker_delete_image;
        private MyUI.RJ_Button rJ_Button_docker_add_image;
        private MyUI.RJ_Button rJ_Button_docker_upload_image;
        private System.Windows.Forms.Panel panel7;
        private MyUI.RJ_Button rJ_Button_docker_download_image;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private SQLUI.SQL_DataGridView sqL_DataGridView_Docker_Containers;
        private System.Windows.Forms.Panel panel9;
        private MyUI.RJ_Button rJ_Button1;
        private System.Windows.Forms.Panel panel10;
        private MyUI.RJ_Button rJ_Button2;
        private System.Windows.Forms.Panel panel11;
        private MyUI.RJ_Button rJ_Button_docker_add_container;
        private MyUI.RJ_Button rJ_Button4;
        private System.Windows.Forms.Panel panel8;
    }
}

