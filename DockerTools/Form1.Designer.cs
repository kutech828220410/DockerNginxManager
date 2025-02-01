
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
            this.rJ_Button_docker_run_container = new MyUI.RJ_Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.rJ_Button_docker_stop_container = new MyUI.RJ_Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rJ_Button_docker_restart_container = new MyUI.RJ_Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.rJ_Button_docker_add_container = new MyUI.RJ_Button();
            this.rJ_Button_docker_remove_container = new MyUI.RJ_Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.richTextBox_powershell = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_檢查環境 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_nginx配置生成 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.rJ_Pannel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rJ_Pannel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(707, 837);
            this.panel1.TabIndex = 1;
            // 
            // rJ_Pannel1
            // 
            this.rJ_Pannel1.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.rJ_Pannel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.rJ_Pannel1.BorderRadius = 40;
            this.rJ_Pannel1.BorderSize = 2;
            this.rJ_Pannel1.Controls.Add(this.tabControl2);
            this.rJ_Pannel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_Pannel1.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel1.IsSelected = false;
            this.rJ_Pannel1.Location = new System.Drawing.Point(5, 5);
            this.rJ_Pannel1.Name = "rJ_Pannel1";
            this.rJ_Pannel1.Padding = new System.Windows.Forms.Padding(10, 12, 12, 25);
            this.rJ_Pannel1.ShadowColor = System.Drawing.Color.Gainsboro;
            this.rJ_Pannel1.ShadowSize = 3;
            this.rJ_Pannel1.Size = new System.Drawing.Size(697, 827);
            this.rJ_Pannel1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.tabControl2.Location = new System.Drawing.Point(10, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(675, 790);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(667, 757);
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
            this.panel4.Size = new System.Drawing.Size(661, 675);
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
            this.sqL_DataGridView_Docker_Images.Size = new System.Drawing.Size(655, 669);
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
            this.panel5.Location = new System.Drawing.Point(3, 689);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Size = new System.Drawing.Size(661, 65);
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
            this.rJ_Button_docker_upload_image.Location = new System.Drawing.Point(466, 3);
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
            this.panel7.Location = new System.Drawing.Point(527, 3);
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
            this.rJ_Button_docker_download_image.Location = new System.Drawing.Point(532, 3);
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
            this.panel6.Location = new System.Drawing.Point(593, 3);
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
            this.rJ_Button_docker_delete_image.Location = new System.Drawing.Point(598, 3);
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
            this.panel3.Size = new System.Drawing.Size(661, 11);
            this.panel3.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.sqL_DataGridView_Docker_Containers);
            this.tabPage4.Controls.Add(this.panel9);
            this.tabPage4.Controls.Add(this.panel8);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(667, 757);
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
            this.sqL_DataGridView_Docker_Containers.Size = new System.Drawing.Size(661, 675);
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
            this.panel9.Controls.Add(this.rJ_Button_docker_run_container);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Controls.Add(this.rJ_Button_docker_stop_container);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.rJ_Button_docker_restart_container);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.rJ_Button_docker_add_container);
            this.panel9.Controls.Add(this.rJ_Button_docker_remove_container);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(3, 689);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel9.Size = new System.Drawing.Size(661, 65);
            this.panel9.TabIndex = 6;
            // 
            // rJ_Button_docker_run_container
            // 
            this.rJ_Button_docker_run_container.AutoResetState = false;
            this.rJ_Button_docker_run_container.BackColor = System.Drawing.Color.White;
            this.rJ_Button_docker_run_container.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button_docker_run_container.BackgroundImage = global::DockerTools.Properties.Resources.play_button;
            this.rJ_Button_docker_run_container.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_docker_run_container.BorderRadius = 30;
            this.rJ_Button_docker_run_container.BorderSize = 1;
            this.rJ_Button_docker_run_container.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_docker_run_container.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_docker_run_container.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_docker_run_container.FlatAppearance.BorderSize = 0;
            this.rJ_Button_docker_run_container.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_docker_run_container.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_docker_run_container.GUID = "";
            this.rJ_Button_docker_run_container.Image_padding = new System.Windows.Forms.Padding(8);
            this.rJ_Button_docker_run_container.Location = new System.Drawing.Point(400, 3);
            this.rJ_Button_docker_run_container.Name = "rJ_Button_docker_run_container";
            this.rJ_Button_docker_run_container.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button_docker_run_container.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_docker_run_container.ProhibitionLineWidth = 4;
            this.rJ_Button_docker_run_container.ProhibitionSymbolSize = 30;
            this.rJ_Button_docker_run_container.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_docker_run_container.ShadowSize = 0;
            this.rJ_Button_docker_run_container.ShowLoadingForm = false;
            this.rJ_Button_docker_run_container.Size = new System.Drawing.Size(61, 59);
            this.rJ_Button_docker_run_container.State = false;
            this.rJ_Button_docker_run_container.TabIndex = 161;
            this.rJ_Button_docker_run_container.TextColor = System.Drawing.Color.White;
            this.rJ_Button_docker_run_container.TextHeight = 0;
            this.rJ_Button_docker_run_container.UseVisualStyleBackColor = false;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(461, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(5, 59);
            this.panel12.TabIndex = 160;
            // 
            // rJ_Button_docker_stop_container
            // 
            this.rJ_Button_docker_stop_container.AutoResetState = false;
            this.rJ_Button_docker_stop_container.BackColor = System.Drawing.Color.White;
            this.rJ_Button_docker_stop_container.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button_docker_stop_container.BackgroundImage = global::DockerTools.Properties.Resources.stop_button;
            this.rJ_Button_docker_stop_container.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_docker_stop_container.BorderRadius = 30;
            this.rJ_Button_docker_stop_container.BorderSize = 1;
            this.rJ_Button_docker_stop_container.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_docker_stop_container.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_docker_stop_container.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_docker_stop_container.FlatAppearance.BorderSize = 0;
            this.rJ_Button_docker_stop_container.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_docker_stop_container.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_docker_stop_container.GUID = "";
            this.rJ_Button_docker_stop_container.Image_padding = new System.Windows.Forms.Padding(8);
            this.rJ_Button_docker_stop_container.Location = new System.Drawing.Point(466, 3);
            this.rJ_Button_docker_stop_container.Name = "rJ_Button_docker_stop_container";
            this.rJ_Button_docker_stop_container.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button_docker_stop_container.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_docker_stop_container.ProhibitionLineWidth = 4;
            this.rJ_Button_docker_stop_container.ProhibitionSymbolSize = 30;
            this.rJ_Button_docker_stop_container.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_docker_stop_container.ShadowSize = 0;
            this.rJ_Button_docker_stop_container.ShowLoadingForm = false;
            this.rJ_Button_docker_stop_container.Size = new System.Drawing.Size(61, 59);
            this.rJ_Button_docker_stop_container.State = false;
            this.rJ_Button_docker_stop_container.TabIndex = 158;
            this.rJ_Button_docker_stop_container.TextColor = System.Drawing.Color.White;
            this.rJ_Button_docker_stop_container.TextHeight = 0;
            this.rJ_Button_docker_stop_container.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(527, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 59);
            this.panel10.TabIndex = 157;
            // 
            // rJ_Button_docker_restart_container
            // 
            this.rJ_Button_docker_restart_container.AutoResetState = false;
            this.rJ_Button_docker_restart_container.BackColor = System.Drawing.Color.White;
            this.rJ_Button_docker_restart_container.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button_docker_restart_container.BackgroundImage = global::DockerTools.Properties.Resources.refresh;
            this.rJ_Button_docker_restart_container.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_docker_restart_container.BorderRadius = 30;
            this.rJ_Button_docker_restart_container.BorderSize = 1;
            this.rJ_Button_docker_restart_container.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_docker_restart_container.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_docker_restart_container.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_docker_restart_container.FlatAppearance.BorderSize = 0;
            this.rJ_Button_docker_restart_container.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_docker_restart_container.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_docker_restart_container.GUID = "";
            this.rJ_Button_docker_restart_container.Image_padding = new System.Windows.Forms.Padding(8);
            this.rJ_Button_docker_restart_container.Location = new System.Drawing.Point(532, 3);
            this.rJ_Button_docker_restart_container.Name = "rJ_Button_docker_restart_container";
            this.rJ_Button_docker_restart_container.Padding = new System.Windows.Forms.Padding(2);
            this.rJ_Button_docker_restart_container.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_docker_restart_container.ProhibitionLineWidth = 4;
            this.rJ_Button_docker_restart_container.ProhibitionSymbolSize = 30;
            this.rJ_Button_docker_restart_container.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_docker_restart_container.ShadowSize = 0;
            this.rJ_Button_docker_restart_container.ShowLoadingForm = false;
            this.rJ_Button_docker_restart_container.Size = new System.Drawing.Size(61, 59);
            this.rJ_Button_docker_restart_container.State = false;
            this.rJ_Button_docker_restart_container.TabIndex = 156;
            this.rJ_Button_docker_restart_container.TextColor = System.Drawing.Color.White;
            this.rJ_Button_docker_restart_container.TextHeight = 0;
            this.rJ_Button_docker_restart_container.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(593, 3);
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
            this.rJ_Button_docker_add_container.BorderRadius = 30;
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
            // rJ_Button_docker_remove_container
            // 
            this.rJ_Button_docker_remove_container.AutoResetState = false;
            this.rJ_Button_docker_remove_container.BackColor = System.Drawing.Color.White;
            this.rJ_Button_docker_remove_container.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button_docker_remove_container.BackgroundImage = global::DockerTools.Properties.Resources.trash_512;
            this.rJ_Button_docker_remove_container.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_docker_remove_container.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_docker_remove_container.BorderRadius = 30;
            this.rJ_Button_docker_remove_container.BorderSize = 1;
            this.rJ_Button_docker_remove_container.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_docker_remove_container.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_docker_remove_container.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_docker_remove_container.FlatAppearance.BorderSize = 0;
            this.rJ_Button_docker_remove_container.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_docker_remove_container.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_docker_remove_container.GUID = "";
            this.rJ_Button_docker_remove_container.Image_padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.rJ_Button_docker_remove_container.Location = new System.Drawing.Point(598, 3);
            this.rJ_Button_docker_remove_container.Name = "rJ_Button_docker_remove_container";
            this.rJ_Button_docker_remove_container.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_docker_remove_container.ProhibitionLineWidth = 4;
            this.rJ_Button_docker_remove_container.ProhibitionSymbolSize = 30;
            this.rJ_Button_docker_remove_container.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_docker_remove_container.ShadowSize = 0;
            this.rJ_Button_docker_remove_container.ShowLoadingForm = false;
            this.rJ_Button_docker_remove_container.Size = new System.Drawing.Size(61, 59);
            this.rJ_Button_docker_remove_container.State = false;
            this.rJ_Button_docker_remove_container.TabIndex = 153;
            this.rJ_Button_docker_remove_container.TextColor = System.Drawing.Color.White;
            this.rJ_Button_docker_remove_container.TextHeight = 0;
            this.rJ_Button_docker_remove_container.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(661, 11);
            this.panel8.TabIndex = 4;
            // 
            // richTextBox_powershell
            // 
            this.richTextBox_powershell.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox_powershell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_powershell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_powershell.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox_powershell.ForeColor = System.Drawing.Color.White;
            this.richTextBox_powershell.Location = new System.Drawing.Point(707, 24);
            this.richTextBox_powershell.Name = "richTextBox_powershell";
            this.richTextBox_powershell.Size = new System.Drawing.Size(777, 837);
            this.richTextBox_powershell.TabIndex = 2;
            this.richTextBox_powershell.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "*.*";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.離開ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 離開ToolStripMenuItem
            // 
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.離開ToolStripMenuItem.Text = "結束";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_檢查環境,
            this.ToolStripMenuItem_nginx配置生成});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // ToolStripMenuItem_檢查環境
            // 
            this.ToolStripMenuItem_檢查環境.Name = "ToolStripMenuItem_檢查環境";
            this.ToolStripMenuItem_檢查環境.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_檢查環境.Text = "檢查環境";
            // 
            // ToolStripMenuItem_nginx配置生成
            // 
            this.ToolStripMenuItem_nginx配置生成.Name = "ToolStripMenuItem_nginx配置生成";
            this.ToolStripMenuItem_nginx配置生成.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItem_nginx配置生成.Text = "Nginx配置生成";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.richTextBox_powershell);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DockerTools";
            this.panel1.ResumeLayout(false);
            this.rJ_Pannel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox_powershell;
        private MyUI.RJ_Pannel rJ_Pannel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private SQLUI.SQL_DataGridView sqL_DataGridView_Docker_Images;
        private System.Windows.Forms.Panel panel5;
        private MyUI.RJ_Button rJ_Button_docker_upload_image;
        private System.Windows.Forms.Panel panel7;
        private MyUI.RJ_Button rJ_Button_docker_download_image;
        private System.Windows.Forms.Panel panel6;
        private MyUI.RJ_Button rJ_Button_docker_add_image;
        private MyUI.RJ_Button rJ_Button_docker_delete_image;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage4;
        private SQLUI.SQL_DataGridView sqL_DataGridView_Docker_Containers;
        private System.Windows.Forms.Panel panel9;
        private MyUI.RJ_Button rJ_Button_docker_run_container;
        private System.Windows.Forms.Panel panel12;
        private MyUI.RJ_Button rJ_Button_docker_stop_container;
        private System.Windows.Forms.Panel panel10;
        private MyUI.RJ_Button rJ_Button_docker_restart_container;
        private System.Windows.Forms.Panel panel11;
        private MyUI.RJ_Button rJ_Button_docker_add_container;
        private MyUI.RJ_Button rJ_Button_docker_remove_container;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ToolStripMenuItem 離開ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_檢查環境;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_nginx配置生成;
    }
}

