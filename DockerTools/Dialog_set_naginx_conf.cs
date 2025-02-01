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
using NginxManagerLib;

namespace DockerTools
{
    public partial class Dialog_set_naginx_conf : MyDialog
    {
        public static string currentDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        public NginxParameters nginxParameters = new NginxParameters();
        public Dialog_set_naginx_conf()
        {
            InitializeComponent();

            this.LoadFinishedEvent += Dialog_set_naginx_conf_LoadFinishedEvent;
            form.Invoke(new Action(delegate
            {
                this.sqL_DataGridView_location.RowsHeight = 50;
                this.sqL_DataGridView_location.Init(new SQLUI.Table(new LocationAttributes()));
                this.sqL_DataGridView_location.Set_ColumnVisible(false, new LocationAttributes().GetEnumNames());
                this.sqL_DataGridView_location.Set_ColumnWidth(400, DataGridViewContentAlignment.MiddleLeft, LocationAttributes.Path);
                this.sqL_DataGridView_location.Set_ColumnWidth(680, DataGridViewContentAlignment.MiddleLeft, LocationAttributes.ProxyPass);
                this.sqL_DataGridView_location.Set_ColumnWidth(300, DataGridViewContentAlignment.MiddleLeft, LocationAttributes.ProxyMaxTempFileSize);

                this.sqL_DataGridView_location.Set_ColumnText("Proxy", LocationAttributes.ProxyPass);
                this.sqL_DataGridView_location.Set_ColumnText("MaxTempFileSize(M)", LocationAttributes.ProxyMaxTempFileSize);
            }));
    
        }

        private void Dialog_set_naginx_conf_LoadFinishedEvent(EventArgs e)
        {
            comboBox_SslCiphers.Items.AddRange(new NginxParameters.SslCiphersEnum().GetEnumNames());
            comboBox_SslBufferSize.Items.AddRange(new NginxParameters.SslBufferSizeEnum().GetEnumNames());
            comboBox_SslSessionTimeout.Items.AddRange(new NginxParameters.SslSessionTimeoutEnum().GetEnumNames());
            comboBox_LargeClientHeaderBuffers.Items.AddRange(new NginxParameters.LargeClientHeaderBuffersEnum().GetEnumNames());

            string text = System.IO.File.ReadAllText(currentDirectory + "\\conf\\nginx.conf");
            NginxManagerLib.NginxParameters nginxParameters = NginxManagerLib.NginxParameters.FromString(text);

            rJ_TextBox_ServerName.Text = nginxParameters.ServerName;
            rJ_TextBox_ListenPort.Text = nginxParameters.ListenPort.ToString();
            rJ_TextBox_ClientMaxBodySize.Text = nginxParameters.ClientMaxBodySize.ToString();

            comboBox_SslCiphers.SelectedItem = nginxParameters.SslCiphers.GetEnumName();
            comboBox_SslBufferSize.SelectedItem = nginxParameters.SslBufferSize.GetEnumName();
            comboBox_SslSessionTimeout.SelectedItem = nginxParameters.SslSessionTimeout.GetEnumName();
            comboBox_LargeClientHeaderBuffers.SelectedItem = nginxParameters.LargeClientHeaderBuffers.GetEnumName();

            rJ_Button_DNS_add.MouseDownEvent += RJ_Button_DNS_add_MouseDownEvent;
            rJ_Button_DNS_delete.MouseDownEvent += RJ_Button_DNS_delete_MouseDownEvent;

            rJ_Button_nginx_conf_generate.MouseDownEvent += RJ_Button_nginx_conf_generate_MouseDownEvent;

            rJ_Button_location_add.MouseDownEvent += RJ_Button_location_add_MouseDownEvent;
            rJ_Button_location_delete.MouseDownEvent += RJ_Button_location_delete_MouseDownEvent;
            rJ_Button_loaction_edit.MouseDownEvent += RJ_Button_loaction_edit_MouseDownEvent;

            

            List<object[]> list_location = nginxParameters.Locations.ClassToSQL<Location , LocationAttributes>();
            this.sqL_DataGridView_location.RefreshGrid(list_location);

           for(int i = 0; i < nginxParameters.DNS.Count; i++)
            {
                listBox_DNS.Items.Add(nginxParameters.DNS[i]);
            }
            //rJ_Button_OK.MouseDownEvent += RJ_Button_OK_MouseDownEvent;
            this.Refresh();
        }

        private void RJ_Button_loaction_edit_MouseDownEvent(MouseEventArgs mevent)
        {
            if (sqL_DataGridView_location.Get_All_Select_RowsValues().Count == 0)
            {
                MyMessageBox.ShowDialog("請選擇要編輯的資料");
                return;
            }
            if (sqL_DataGridView_location.Get_All_Select_RowsValues().Count > 1)
            {
                MyMessageBox.ShowDialog("只能選擇一筆資料進行編輯");
                return;
            }
            NginxManagerLib.Location location = sqL_DataGridView_location.Get_All_Select_RowsValues()[0].SQLToClass<Location, LocationAttributes>();
            Dialog_add_location dialog_Add_Location = new Dialog_add_location(location);
            dialog_Add_Location.ShowDialog();
            if (dialog_Add_Location.DialogResult == DialogResult.Yes)
            {
                location = dialog_Add_Location.location;
                object[] value = location.ClassToSQL<Location, LocationAttributes>();
                this.sqL_DataGridView_location.ReplaceExtra(value , true);

                List<object[]> list_location = sqL_DataGridView_location.GetAllRows();
                nginxParameters.Locations = list_location.SQLToClass<Location, LocationAttributes>();
            }
        }

        private void RJ_Button_location_delete_MouseDownEvent(MouseEventArgs mevent)
        {
            if(sqL_DataGridView_location.Get_All_Select_RowsValues().Count == 0)
            {
                MyMessageBox.ShowDialog("請選擇要刪除的資料");
                return;
            }
            if(MyMessageBox.ShowDialog("確定要刪除選擇的資料?", MyMessageBox.enum_BoxType.Warning, MyMessageBox.enum_Button.Confirm_Cancel) != DialogResult.Yes)
            {
                return;
            }
            List<object[]> list_location = sqL_DataGridView_location.Get_All_Select_RowsValues();
            this.sqL_DataGridView_location.DeleteExtra(list_location, true);
            list_location = sqL_DataGridView_location.GetAllRows();
            nginxParameters.Locations = list_location.SQLToClass<Location, LocationAttributes>();
        }
        private void RJ_Button_location_add_MouseDownEvent(MouseEventArgs mevent)
        {
            Dialog_add_location dialog_Add_Location = new Dialog_add_location(new NginxManagerLib.Location());
            dialog_Add_Location.ShowDialog();
            if (dialog_Add_Location.DialogResult == DialogResult.Yes)
            {
                NginxManagerLib.Location location = dialog_Add_Location.location;
                nginxParameters.Locations.Add(location);
                List<object[]> list_location = nginxParameters.Locations.ClassToSQL<Location, LocationAttributes>();
                this.sqL_DataGridView_location.RefreshGrid(list_location);
            }
        }

        private void RJ_Button_nginx_conf_generate_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(() =>
            {
                if (rJ_RatioButton_https.Checked)
                {
                    nginxParameters.UseHttp = false;
                }
                else
                {
                    nginxParameters.UseHttp = true;
                }
                nginxParameters.ServerName = rJ_TextBox_ServerName.Text;
                nginxParameters.ListenPort = int.Parse(rJ_TextBox_ListenPort.Text);
                nginxParameters.ClientMaxBodySize = rJ_TextBox_ClientMaxBodySize.Text;
                nginxParameters.SslCiphers = (NginxParameters.SslCiphersEnum)comboBox_SslCiphers.SelectedIndex;
                nginxParameters.SslBufferSize = (NginxParameters.SslBufferSizeEnum)comboBox_SslBufferSize.SelectedIndex;
                nginxParameters.SslSessionTimeout = (NginxParameters.SslSessionTimeoutEnum)comboBox_SslSessionTimeout.SelectedIndex;
                nginxParameters.LargeClientHeaderBuffers = (NginxParameters.LargeClientHeaderBuffersEnum)comboBox_LargeClientHeaderBuffers.SelectedIndex;
                nginxParameters.DNS.Clear();
                for (int i = 0; i < listBox_DNS.Items.Count; i++)
                {
                    nginxParameters.DNS.Add(listBox_DNS.Items[i].ToString());
                }

                Dialog_nginx_conf dialog_Nginx_Conf = new Dialog_nginx_conf(nginxParameters);
                dialog_Nginx_Conf.ShowDialog();
            }));
            
        }
        private void RJ_Button_DNS_delete_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(delegate
            {
                listBox_DNS.Items.Remove(listBox_DNS.SelectedItem);
            }));
        
        }

        private void RJ_Button_DNS_add_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(delegate
            {
                Dialog_add_ipAdress dialog_Add_IpAdress = new Dialog_add_ipAdress();
                dialog_Add_IpAdress.ShowDialog();
                if (dialog_Add_IpAdress.DialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < listBox_DNS.Items.Count; i++)
                    {
                        if (listBox_DNS.Items[i].ToString() == dialog_Add_IpAdress.IPAdress)
                        {
                            MessageBox.Show("IP地址已存在");
                            return;
                        }
                    }
                    listBox_DNS.Items.Add(dialog_Add_IpAdress.IPAdress);
                }
            }));
        }


        private void RJ_Button_OK_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Close();
        }
    }
}
