﻿namespace Rectify11Installer.Pages
{
    partial class EPPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.darkAwareLabel1 = new Rectify11Installer.Controls.DarkAwareLabel();
            this.w10StartImg = new System.Windows.Forms.PictureBox();
            this.w11StartImg = new System.Windows.Forms.PictureBox();
            this.w10StartRad = new Rectify11Installer.Controls.DarkAwareRadioButton();
            this.w11StartRad = new Rectify11Installer.Controls.DarkAwareRadioButton();
            this.chkEnhancedRibbon = new Rectify11Installer.Controls.DarkAwareCheckBox();
            this.chkExtendMica = new Rectify11Installer.Controls.DarkAwareCheckBox();
            this.chkW10Taskbar = new Rectify11Installer.Controls.DarkAwareCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.w10StartImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.w11StartImg)).BeginInit();
            this.SuspendLayout();
            // 
            // darkAwareLabel1
            // 
            this.darkAwareLabel1.AutoSize = true;
            this.darkAwareLabel1.BackColor = System.Drawing.Color.Transparent;
            this.darkAwareLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkAwareLabel1.ForeColor = System.Drawing.Color.Black;
            this.darkAwareLabel1.Location = new System.Drawing.Point(0, 0);
            this.darkAwareLabel1.Name = "darkAwareLabel1";
            this.darkAwareLabel1.Size = new System.Drawing.Size(276, 20);
            this.darkAwareLabel1.TabIndex = 2;
            this.darkAwareLabel1.Text = global::Rectify11Installer.Strings.Rectify11.epTitle;
            // 
            // w10StartImg
            // 
            this.w10StartImg.BackgroundImage = global::Rectify11Installer.Properties.Resources._10start;
            this.w10StartImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.w10StartImg.Location = new System.Drawing.Point(0, 43);
            this.w10StartImg.Name = "w10StartImg";
            this.w10StartImg.Size = new System.Drawing.Size(146, 90);
            this.w10StartImg.TabIndex = 1;
            this.w10StartImg.TabStop = false;
            this.w10StartImg.Click += new System.EventHandler(this.w10StartImg_Click);
            // 
            // w11StartImg
            // 
            this.w11StartImg.BackgroundImage = global::Rectify11Installer.Properties.Resources._11start;
            this.w11StartImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.w11StartImg.Location = new System.Drawing.Point(186, 43);
            this.w11StartImg.Name = "w11StartImg";
            this.w11StartImg.Size = new System.Drawing.Size(147, 90);
            this.w11StartImg.TabIndex = 0;
            this.w11StartImg.TabStop = false;
            this.w11StartImg.Click += new System.EventHandler(this.w11StartImg_Click);
            // 
            // w10StartRad
            // 
            this.w10StartRad.AutoSize = true;
            this.w10StartRad.ForeColor = System.Drawing.Color.Black;
            this.w10StartRad.Location = new System.Drawing.Point(4, 140);
            this.w10StartRad.Name = "w10StartRad";
            this.w10StartRad.Size = new System.Drawing.Size(140, 19);
            this.w10StartRad.TabIndex = 3;
            this.w10StartRad.TabStop = true;
            this.w10StartRad.Text = global::Rectify11Installer.Strings.Rectify11.epW10Radio;
            this.w10StartRad.UseVisualStyleBackColor = true;
            // 
            // w11StartRad
            // 
            this.w11StartRad.AutoSize = true;
            this.w11StartRad.ForeColor = System.Drawing.Color.Black;
            this.w11StartRad.Location = new System.Drawing.Point(186, 140);
            this.w11StartRad.Name = "w11StartRad";
            this.w11StartRad.Size = new System.Drawing.Size(130, 19);
            this.w11StartRad.TabIndex = 4;
            this.w11StartRad.TabStop = true;
            this.w11StartRad.Text = global::Rectify11Installer.Strings.Rectify11.epW11Radio;
            this.w11StartRad.UseVisualStyleBackColor = true;
            // 
            // chkEnhancedRibbon
            // 
            this.chkEnhancedRibbon.AutoSize = true;
            this.chkEnhancedRibbon.ForeColor = System.Drawing.Color.Black;
            this.chkEnhancedRibbon.Location = new System.Drawing.Point(4, 208);
            this.chkEnhancedRibbon.Name = "chkEnhancedRibbon";
            this.chkEnhancedRibbon.Size = new System.Drawing.Size(141, 19);
            this.chkEnhancedRibbon.TabIndex = 5;
            this.chkEnhancedRibbon.Text = global::Rectify11Installer.Strings.Rectify11.epEnhRibbon;
            this.chkEnhancedRibbon.UseVisualStyleBackColor = true;
            // 
            // chkExtendMica
            // 
            this.chkExtendMica.AutoSize = true;
            this.chkExtendMica.ForeColor = System.Drawing.Color.Black;
            this.chkExtendMica.Location = new System.Drawing.Point(4, 233);
            this.chkExtendMica.Name = "chkExtendMica";
            this.chkExtendMica.Size = new System.Drawing.Size(228, 19);
            this.chkExtendMica.TabIndex = 6;
            this.chkExtendMica.Text = global::Rectify11Installer.Strings.Rectify11.epExtMica;
            this.chkExtendMica.UseVisualStyleBackColor = true;
            // 
            // chkW10Taskbar
            // 
            this.chkW10Taskbar.AutoSize = true;
            this.chkW10Taskbar.ForeColor = System.Drawing.Color.Black;
            this.chkW10Taskbar.Location = new System.Drawing.Point(4, 258);
            this.chkW10Taskbar.Name = "chkW10Taskbar";
            this.chkW10Taskbar.Size = new System.Drawing.Size(133, 19);
            this.chkW10Taskbar.TabIndex = 7;
            this.chkW10Taskbar.Text = global::Rectify11Installer.Strings.Rectify11.epW10Taskbar;
            this.chkW10Taskbar.UseVisualStyleBackColor = true;
            // 
            // EPPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkW10Taskbar);
            this.Controls.Add(this.chkExtendMica);
            this.Controls.Add(this.chkEnhancedRibbon);
            this.Controls.Add(this.w11StartRad);
            this.Controls.Add(this.w10StartRad);
            this.Controls.Add(this.w11StartImg);
            this.Controls.Add(this.w10StartImg);
            this.Controls.Add(this.darkAwareLabel1);
            this.Name = "EPPage";
            this.SideImage = global::Rectify11Installer.Properties.Resources.ep;
            this.WizardHeader = global::Rectify11Installer.Strings.Rectify11.epHeader;
            ((System.ComponentModel.ISupportInitialize)(this.w10StartImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.w11StartImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.DarkAwareLabel darkAwareLabel1;
        private System.Windows.Forms.PictureBox w10StartImg;
        private System.Windows.Forms.PictureBox w11StartImg;
        private Controls.DarkAwareRadioButton w10StartRad;
        private Controls.DarkAwareRadioButton w11StartRad;
        private Controls.DarkAwareCheckBox chkEnhancedRibbon;
        private Controls.DarkAwareCheckBox chkExtendMica;
        private Controls.DarkAwareCheckBox chkW10Taskbar;
    }
}