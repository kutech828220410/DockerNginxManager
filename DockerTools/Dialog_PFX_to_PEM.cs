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
using CertificateConverter;

namespace DockerTools
{
    public partial class Dialog_PFX_to_PEM : MyDialog
    {
        public Dialog_PFX_to_PEM()
        {
            InitializeComponent();
            LoadFinishedEvent += Dialog_PFX_to_PEM_LoadFinishedEvent;
      
        }

        private void Dialog_PFX_to_PEM_LoadFinishedEvent(EventArgs e)
        {
            rJ_Button_browse_pfx_file.MouseDownEvent += RJ_Button_browse_pfx_file_MouseDownEvent;
            rJ_Button_creat.MouseDownEvent += RJ_Button_creat_MouseDownEvent;
        }

        private void RJ_Button_creat_MouseDownEvent(MouseEventArgs mevent)
        {
            form.Invoke(new Action(delegate
            {
                if (rJ_TextBox_filepath.Text == "")
                {
                    MyMessageBox.ShowDialog("Please select a pfx file");
                    return;
                }
                string pfx_file = rJ_TextBox_filepath.Text;
                string password = rJ_TextBox_password.Text;
                string pem_file = pfx_file.Replace(".pfx", ".pem");
                if (PfxConverter.IsPfxPasswordCorrect(pfx_file, password) == false)
                {
                    MyMessageBox.ShowDialog("Password is incorrect");
                    return;
                }
                saveFileDialog.Title = "Save CRT file";
                saveFileDialog.Filter = "CRT files (*.crt)|*.crt";
                saveFileDialog.FileName = "";
                saveFileDialog.DefaultExt = "crt";
                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
                string crt_file = saveFileDialog.FileName;

                saveFileDialog.Title = "Save Key file";
                saveFileDialog.Filter = "Key files (*.key)|*.key";
                saveFileDialog.DefaultExt = "key";
                saveFileDialog.FileName = "";
                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
                string key_file = saveFileDialog.FileName;

                PfxConverter.ConvertPfxToPem(pfx_file, password, key_file, crt_file);

                MyMessageBox.ShowDialog("Convert success");
            }));
            
        }
        private void RJ_Button_browse_pfx_file_MouseDownEvent(MouseEventArgs mevent)
        {
            form.Invoke(new Action(delegate
            {
                openFileDialog.Filter = "PFX files (*.pfx)|*.pfx";
                openFileDialog.DefaultExt = "pfx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string pfx_file = openFileDialog.FileName;
                    rJ_TextBox_filepath.Text = pfx_file;
                }
            }));
          
        }
    }
}
