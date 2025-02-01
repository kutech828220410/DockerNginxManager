namespace DockerTools
{
    partial class Dialog_add_ipAdress
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rJ_Button_cancel = new MyUI.RJ_Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rJ_Button_confirm = new MyUI.RJ_Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ipAddressInput = new MyUI.IPAddressInput();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rJ_Button_cancel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rJ_Button_confirm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(4, 90);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.panel1.Size = new System.Drawing.Size(457, 49);
            this.panel1.TabIndex = 159;
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
            this.rJ_Button_cancel.Location = new System.Drawing.Point(182, 0);
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
            this.panel2.Location = new System.Drawing.Point(308, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 44);
            this.panel2.TabIndex = 157;
            // 
            // rJ_Button_confirm
            // 
            this.rJ_Button_confirm.AutoResetState = false;
            this.rJ_Button_confirm.BackColor = System.Drawing.Color.White;
            this.rJ_Button_confirm.BackgroundColor = System.Drawing.Color.DimGray;
            this.rJ_Button_confirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Button_confirm.BorderRadius = 22;
            this.rJ_Button_confirm.BorderSize = 0;
            this.rJ_Button_confirm.buttonType = MyUI.RJ_Button.ButtonType.Push;
            this.rJ_Button_confirm.DisenableColor = System.Drawing.Color.Gray;
            this.rJ_Button_confirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.rJ_Button_confirm.FlatAppearance.BorderSize = 0;
            this.rJ_Button_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Button_confirm.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.rJ_Button_confirm.ForeColor = System.Drawing.Color.White;
            this.rJ_Button_confirm.GUID = "";
            this.rJ_Button_confirm.Image_padding = new System.Windows.Forms.Padding(0);
            this.rJ_Button_confirm.Location = new System.Drawing.Point(321, 0);
            this.rJ_Button_confirm.Name = "rJ_Button_confirm";
            this.rJ_Button_confirm.ProhibitionBorderLineWidth = 1;
            this.rJ_Button_confirm.ProhibitionLineWidth = 4;
            this.rJ_Button_confirm.ProhibitionSymbolSize = 30;
            this.rJ_Button_confirm.ShadowColor = System.Drawing.Color.DimGray;
            this.rJ_Button_confirm.ShadowSize = 0;
            this.rJ_Button_confirm.ShowLoadingForm = false;
            this.rJ_Button_confirm.Size = new System.Drawing.Size(126, 44);
            this.rJ_Button_confirm.State = false;
            this.rJ_Button_confirm.TabIndex = 155;
            this.rJ_Button_confirm.Text = "Confirm";
            this.rJ_Button_confirm.TextColor = System.Drawing.Color.White;
            this.rJ_Button_confirm.TextHeight = 0;
            this.rJ_Button_confirm.UseVisualStyleBackColor = false;
            // 
            // ipAddressInput
            // 
            this.ipAddressInput.BackColor = System.Drawing.Color.Transparent;
            this.ipAddressInput.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F);
            this.ipAddressInput.Location = new System.Drawing.Point(55, 31);
            this.ipAddressInput.Name = "ipAddressInput";
            this.ipAddressInput.Size = new System.Drawing.Size(396, 42);
            this.ipAddressInput.TabIndex = 161;
            this.ipAddressInput.TextBoxWidth = 80;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(10, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 48);
            this.label5.TabIndex = 174;
            this.label5.Text = "IP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dialog_add_ipAdress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionHeight = 40;
            this.ClientSize = new System.Drawing.Size(465, 143);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ipAddressInput);
            this.Controls.Add(this.panel1);
            this.Name = "Dialog_add_ipAdress";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MyUI.RJ_Button rJ_Button_cancel;
        private System.Windows.Forms.Panel panel2;
        private MyUI.RJ_Button rJ_Button_confirm;
        private System.Windows.Forms.ToolTip toolTip1;
        private MyUI.IPAddressInput ipAddressInput;
        private System.Windows.Forms.Label label5;
    }
}