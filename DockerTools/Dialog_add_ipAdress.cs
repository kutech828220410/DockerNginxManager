using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Basic;
using MyUI;
using SQLUI;
using DockerManagerLib;

namespace DockerTools
{
    public partial class Dialog_add_ipAdress : MyDialog
    {
        public string IPAdress
        {
            get
            {
                return ipAddressInput.IPAddress;
            }
        }
        public Dialog_add_ipAdress()
        {
            InitializeComponent();
            LoadFinishedEvent += Dialog_add_ipAdress_LoadFinishedEvent;
            this.KeyDown += new KeyEventHandler(Dialog_add_ipAdress_KeyDown);
        }

        private void Dialog_add_ipAdress_LoadFinishedEvent(EventArgs e)
        {
            rJ_Button_confirm.MouseDownEvent += RJ_Button_confirm_MouseDownEvent;
            rJ_Button_cancel.MouseDownEvent += RJ_Button_cancel_MouseDownEvent;
        }

        private void RJ_Button_cancel_MouseDownEvent(MouseEventArgs mevent)
        {
            Close();
        }

        private void RJ_Button_confirm_MouseDownEvent(MouseEventArgs mevent)
        {
            if (ipAddressInput.IPAddress.Check_IP_Adress() == false)
            {
                MyMessageBox.ShowDialog("IP地址格式錯誤");
                return;
            }
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void Dialog_add_ipAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RJ_Button_confirm_MouseDownEvent(null);
            }
        }
    }
}
