
namespace Free_Crypter
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFileSize = new MaterialSkin.Controls.MaterialLabel();
            this.txtFilePath = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBrowse = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbInstallUtil = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbAppLaunch = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbMSBuild = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbRegAsm = new MaterialSkin.Controls.MaterialRadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRegistryName = new MaterialSkin.Controls.MaterialTextBox();
            this.cbRegistry = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtStartupFile = new MaterialSkin.Controls.MaterialTextBox();
            this.cbStartup = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnCrypt = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFileSize);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select File";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Depth = 0;
            this.lblFileSize.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFileSize.Location = new System.Drawing.Point(6, 61);
            this.lblFileSize.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(100, 19);
            this.lblFileSize.TabIndex = 3;
            this.lblFileSize.Text = "File Length : 0";
            // 
            // txtFilePath
            // 
            this.txtFilePath.AnimateReadOnly = false;
            this.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFilePath.Depth = 0;
            this.txtFilePath.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFilePath.LeadingIcon = null;
            this.txtFilePath.Location = new System.Drawing.Point(6, 19);
            this.txtFilePath.MaxLength = 50;
            this.txtFilePath.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFilePath.Multiline = false;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(457, 36);
            this.txtFilePath.TabIndex = 2;
            this.txtFilePath.Text = "";
            this.txtFilePath.TrailingIcon = null;
            this.txtFilePath.UseTallSize = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = false;
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBrowse.Depth = 0;
            this.btnBrowse.HighEmphasis = true;
            this.btnBrowse.Icon = null;
            this.btnBrowse.Location = new System.Drawing.Point(470, 19);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBrowse.Size = new System.Drawing.Size(100, 36);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBrowse.UseAccentColor = false;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbInstallUtil);
            this.groupBox2.Controls.Add(this.rbAppLaunch);
            this.groupBox2.Controls.Add(this.rbMSBuild);
            this.groupBox2.Controls.Add(this.rbRegAsm);
            this.groupBox2.Location = new System.Drawing.Point(6, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 66);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payload Injection";
            // 
            // rbInstallUtil
            // 
            this.rbInstallUtil.AutoSize = true;
            this.rbInstallUtil.Depth = 0;
            this.rbInstallUtil.Location = new System.Drawing.Point(429, 19);
            this.rbInstallUtil.Margin = new System.Windows.Forms.Padding(0);
            this.rbInstallUtil.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbInstallUtil.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbInstallUtil.Name = "rbInstallUtil";
            this.rbInstallUtil.Ripple = true;
            this.rbInstallUtil.Size = new System.Drawing.Size(129, 37);
            this.rbInstallUtil.TabIndex = 3;
            this.rbInstallUtil.TabStop = true;
            this.rbInstallUtil.Text = "InstallUtil.exe";
            this.rbInstallUtil.UseVisualStyleBackColor = true;
            // 
            // rbAppLaunch
            // 
            this.rbAppLaunch.AutoSize = true;
            this.rbAppLaunch.Depth = 0;
            this.rbAppLaunch.Location = new System.Drawing.Point(273, 19);
            this.rbAppLaunch.Margin = new System.Windows.Forms.Padding(0);
            this.rbAppLaunch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbAppLaunch.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbAppLaunch.Name = "rbAppLaunch";
            this.rbAppLaunch.Ripple = true;
            this.rbAppLaunch.Size = new System.Drawing.Size(144, 37);
            this.rbAppLaunch.TabIndex = 2;
            this.rbAppLaunch.TabStop = true;
            this.rbAppLaunch.Text = "AppLaunch.exe";
            this.rbAppLaunch.UseVisualStyleBackColor = true;
            // 
            // rbMSBuild
            // 
            this.rbMSBuild.AutoSize = true;
            this.rbMSBuild.Depth = 0;
            this.rbMSBuild.Location = new System.Drawing.Point(137, 19);
            this.rbMSBuild.Margin = new System.Windows.Forms.Padding(0);
            this.rbMSBuild.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbMSBuild.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbMSBuild.Name = "rbMSBuild";
            this.rbMSBuild.Ripple = true;
            this.rbMSBuild.Size = new System.Drawing.Size(123, 37);
            this.rbMSBuild.TabIndex = 1;
            this.rbMSBuild.TabStop = true;
            this.rbMSBuild.Text = "MSBuild.exe";
            this.rbMSBuild.UseVisualStyleBackColor = true;
            // 
            // rbRegAsm
            // 
            this.rbRegAsm.AutoSize = true;
            this.rbRegAsm.Checked = true;
            this.rbRegAsm.Depth = 0;
            this.rbRegAsm.Location = new System.Drawing.Point(6, 19);
            this.rbRegAsm.Margin = new System.Windows.Forms.Padding(0);
            this.rbRegAsm.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbRegAsm.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbRegAsm.Name = "rbRegAsm";
            this.rbRegAsm.Ripple = true;
            this.rbRegAsm.Size = new System.Drawing.Size(122, 37);
            this.rbRegAsm.TabIndex = 0;
            this.rbRegAsm.TabStop = true;
            this.rbRegAsm.Text = "RegAsm.exe";
            this.rbRegAsm.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRegistryName);
            this.groupBox3.Controls.Add(this.cbRegistry);
            this.groupBox3.Controls.Add(this.txtStartupFile);
            this.groupBox3.Controls.Add(this.cbStartup);
            this.groupBox3.Location = new System.Drawing.Point(6, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(577, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payload Installation";
            // 
            // txtRegistryName
            // 
            this.txtRegistryName.AnimateReadOnly = false;
            this.txtRegistryName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegistryName.Depth = 0;
            this.txtRegistryName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtRegistryName.LeadingIcon = null;
            this.txtRegistryName.Location = new System.Drawing.Point(220, 64);
            this.txtRegistryName.MaxLength = 50;
            this.txtRegistryName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRegistryName.Multiline = false;
            this.txtRegistryName.Name = "txtRegistryName";
            this.txtRegistryName.Size = new System.Drawing.Size(344, 36);
            this.txtRegistryName.TabIndex = 5;
            this.txtRegistryName.Text = "RegStartup";
            this.txtRegistryName.TrailingIcon = null;
            this.txtRegistryName.UseTallSize = false;
            // 
            // cbRegistry
            // 
            this.cbRegistry.AutoSize = true;
            this.cbRegistry.Depth = 0;
            this.cbRegistry.Location = new System.Drawing.Point(9, 61);
            this.cbRegistry.Margin = new System.Windows.Forms.Padding(0);
            this.cbRegistry.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbRegistry.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbRegistry.Name = "cbRegistry";
            this.cbRegistry.ReadOnly = false;
            this.cbRegistry.Ripple = true;
            this.cbRegistry.Size = new System.Drawing.Size(148, 37);
            this.cbRegistry.TabIndex = 4;
            this.cbRegistry.Text = "Registry Startup";
            this.cbRegistry.UseVisualStyleBackColor = true;
            // 
            // txtStartupFile
            // 
            this.txtStartupFile.AnimateReadOnly = false;
            this.txtStartupFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartupFile.Depth = 0;
            this.txtStartupFile.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtStartupFile.LeadingIcon = null;
            this.txtStartupFile.Location = new System.Drawing.Point(220, 22);
            this.txtStartupFile.MaxLength = 50;
            this.txtStartupFile.MouseState = MaterialSkin.MouseState.OUT;
            this.txtStartupFile.Multiline = false;
            this.txtStartupFile.Name = "txtStartupFile";
            this.txtStartupFile.Size = new System.Drawing.Size(344, 36);
            this.txtStartupFile.TabIndex = 3;
            this.txtStartupFile.Text = "Startup.exe";
            this.txtStartupFile.TrailingIcon = null;
            this.txtStartupFile.UseTallSize = false;
            // 
            // cbStartup
            // 
            this.cbStartup.AutoSize = true;
            this.cbStartup.Depth = 0;
            this.cbStartup.Location = new System.Drawing.Point(9, 22);
            this.cbStartup.Margin = new System.Windows.Forms.Padding(0);
            this.cbStartup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbStartup.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbStartup.Name = "cbStartup";
            this.cbStartup.ReadOnly = false;
            this.cbStartup.Ripple = true;
            this.cbStartup.Size = new System.Drawing.Size(196, 37);
            this.cbStartup.TabIndex = 0;
            this.cbStartup.Text = "Drop To Startup Folder";
            this.cbStartup.UseVisualStyleBackColor = true;
            // 
            // btnCrypt
            // 
            this.btnCrypt.AutoSize = false;
            this.btnCrypt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrypt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCrypt.Depth = 0;
            this.btnCrypt.HighEmphasis = true;
            this.btnCrypt.Icon = null;
            this.btnCrypt.Location = new System.Drawing.Point(6, 355);
            this.btnCrypt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrypt.Name = "btnCrypt";
            this.btnCrypt.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCrypt.Size = new System.Drawing.Size(577, 37);
            this.btnCrypt.TabIndex = 3;
            this.btnCrypt.Text = "Crypt";
            this.btnCrypt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCrypt.UseAccentColor = false;
            this.btnCrypt.UseVisualStyleBackColor = true;
            this.btnCrypt.Click += new System.EventHandler(this.btnCrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 400);
            this.Controls.Add(this.btnCrypt);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Free-Crypter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox txtFilePath;
        private MaterialSkin.Controls.MaterialButton btnBrowse;
        private MaterialSkin.Controls.MaterialLabel lblFileSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialRadioButton rbInstallUtil;
        private MaterialSkin.Controls.MaterialRadioButton rbAppLaunch;
        private MaterialSkin.Controls.MaterialRadioButton rbMSBuild;
        private MaterialSkin.Controls.MaterialRadioButton rbRegAsm;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialCheckbox cbStartup;
        private MaterialSkin.Controls.MaterialTextBox txtStartupFile;
        private MaterialSkin.Controls.MaterialTextBox txtRegistryName;
        private MaterialSkin.Controls.MaterialCheckbox cbRegistry;
        private MaterialSkin.Controls.MaterialButton btnCrypt;
    }
}

