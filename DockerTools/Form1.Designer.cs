
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
            this.sqL_DataGridView_Docker_Image = new SQLUI.SQL_DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rJ_Button_docker_add_image = new MyUI.RJ_Button();
            this.rJ_Button_delete_image = new MyUI.RJ_Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rJ_Button_檢查環境 = new MyUI.RJ_Button();
            this.richTextBox_powershell = new System.Windows.Forms.RichTextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.panel1.SuspendLayout();
            this.rJ_Pannel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 707);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Docker";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(661, 475);
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
            this.tabPage3.Size = new System.Drawing.Size(653, 449);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Images";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sqL_DataGridView_Docker_Image);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 14);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(647, 367);
            this.panel4.TabIndex = 6;
            // 
            // sqL_DataGridView_Docker_Image
            // 
            this.sqL_DataGridView_Docker_Image.AutoSelectToDeep = false;
            this.sqL_DataGridView_Docker_Image.backColor = System.Drawing.Color.WhiteSmoke;
            this.sqL_DataGridView_Docker_Image.BorderColor = System.Drawing.Color.White;
            this.sqL_DataGridView_Docker_Image.BorderRadius = 1;
            this.sqL_DataGridView_Docker_Image.BorderSize = 1;
            this.sqL_DataGridView_Docker_Image.CellBorderColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_Docker_Image.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Image.cellStylBackColor = System.Drawing.Color.Transparent;
            this.sqL_DataGridView_Docker_Image.cellStyleFont = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqL_DataGridView_Docker_Image.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_Docker_Image.checkedRowBackColor = System.Drawing.Color.YellowGreen;
            this.sqL_DataGridView_Docker_Image.columnHeaderBackColor = System.Drawing.Color.White;
            this.sqL_DataGridView_Docker_Image.columnHeaderBorderColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_Docker_Image.columnHeaderFont = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_Docker_Image.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Image.columnHeadersHeight = 50;
            this.sqL_DataGridView_Docker_Image.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.sqL_DataGridView_Docker_Image.DataGridViewAutoSizeColumnMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sqL_DataGridView_Docker_Image.DataKeyEnable = false;
            this.sqL_DataGridView_Docker_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqL_DataGridView_Docker_Image.Font = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_Docker_Image.ImageBox = false;
            this.sqL_DataGridView_Docker_Image.Location = new System.Drawing.Point(3, 3);
            this.sqL_DataGridView_Docker_Image.Name = "sqL_DataGridView_Docker_Image";
            this.sqL_DataGridView_Docker_Image.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_Docker_Image.Password = "user82822040";
            this.sqL_DataGridView_Docker_Image.Port = ((uint)(3306u));
            this.sqL_DataGridView_Docker_Image.rowBorderStyleOption = SQLUI.SQL_DataGridView.RowBorderStyleOption.BottomLine;
            this.sqL_DataGridView_Docker_Image.rowHeaderBackColor = System.Drawing.Color.White;
            this.sqL_DataGridView_Docker_Image.rowHeaderBorderStyleOption = SQLUI.SQL_DataGridView.RowBorderStyleOption.BottomLine;
            this.sqL_DataGridView_Docker_Image.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Image.RowsColor = System.Drawing.Color.White;
            this.sqL_DataGridView_Docker_Image.RowsHeight = 10;
            this.sqL_DataGridView_Docker_Image.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_Docker_Image.selectedBorderSize = 0;
            this.sqL_DataGridView_Docker_Image.selectedRowBackColor = System.Drawing.Color.DarkGray;
            this.sqL_DataGridView_Docker_Image.selectedRowBorderColor = System.Drawing.Color.Blue;
            this.sqL_DataGridView_Docker_Image.selectedRowForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_Docker_Image.Server = "127.0.0.0";
            this.sqL_DataGridView_Docker_Image.Size = new System.Drawing.Size(641, 361);
            this.sqL_DataGridView_Docker_Image.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_Docker_Image.TabIndex = 5;
            this.sqL_DataGridView_Docker_Image.UserName = "root";
            this.sqL_DataGridView_Docker_Image.可拖曳欄位寬度 = false;
            this.sqL_DataGridView_Docker_Image.可選擇多列 = false;
            this.sqL_DataGridView_Docker_Image.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Image.自動換行 = true;
            this.sqL_DataGridView_Docker_Image.表單字體 = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_Docker_Image.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_Docker_Image.顯示CheckBox = false;
            this.sqL_DataGridView_Docker_Image.顯示首列 = false;
            this.sqL_DataGridView_Docker_Image.顯示首行 = true;
            this.sqL_DataGridView_Docker_Image.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_Docker_Image.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rJ_Button_docker_add_image);
            this.panel5.Controls.Add(this.rJ_Button_delete_image);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(3, 381);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel5.Size = new System.Drawing.Size(647, 65);
            this.panel5.TabIndex = 5;
            // 
            // rJ_Button_docker_add_image
            // 
            this.rJ_Button_docker_add_image.AutoResetState = false;
            this.rJ_Button_docker_add_image.BackColor = System.Drawing.Color.Transparent;
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
            this.rJ_Button_docker_add_image.Location = new System.Drawing.Point(0, 3);
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
            // rJ_Button_delete_image
            // 
            this.rJ_Button_delete_image.AutoResetState = false;
            this.rJ_Button_delete_image.BackColor = System.Drawing.Color.Transparent;
            this.rJ_Button_delete_image.BackgroundColor = System.Drawing.Color.White;
            this.rJ_Button_delete_image.BackgroundImage = global::DockerTools.Properties.Resources.trash_512;
            this.rJ_Button_delete_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rJ_Button_delete_image.BorderColor = System.Drawing.Color.Black;
            this.rJ_Button_delete_image.BorderRadius = 40;
            this.rJ_Button_delete_image.BorderSize = 1;
            this.rJ_Button_delete_image.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_delete_image.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_delete_image.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_delete_image.FlatAppearance.BorderSize = 0;
            this.rJ_Button_delete_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_delete_image.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_delete_image.GUID = "";
            this.rJ_Button_delete_image.Image_padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.rJ_Button_delete_image.Location = new System.Drawing.Point(586, 3);
            this.rJ_Button_delete_image.Name = "rJ_Button_delete_image";
            this.rJ_Button_delete_image.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_delete_image.ProhibitionLineWidth = 4;
            this.rJ_Button_delete_image.ProhibitionSymbolSize = 30;
            this.rJ_Button_delete_image.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_delete_image.ShadowSize = 0;
            this.rJ_Button_delete_image.ShowLoadingForm = false;
            this.rJ_Button_delete_image.Size = new System.Drawing.Size(61, 59);
            this.rJ_Button_delete_image.State = false;
            this.rJ_Button_delete_image.TabIndex = 153;
            this.rJ_Button_delete_image.TextColor = System.Drawing.Color.White;
            this.rJ_Button_delete_image.TextHeight = 0;
            this.rJ_Button_delete_image.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 11);
            this.panel3.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(653, 449);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Containers";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox_powershell;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
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
        private SQLUI.SQL_DataGridView sqL_DataGridView_Docker_Image;
        private System.Windows.Forms.Panel panel5;
        private MyUI.RJ_Button rJ_Button_delete_image;
        private MyUI.RJ_Button rJ_Button_docker_add_image;
    }
}

