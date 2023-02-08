namespace StandManagementProject
{
    partial class Navigateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Navigateur));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.link = new MetroFramework.Controls.MetroTextBox();
            this.TotalLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.guna2Panel1.Controls.Add(this.label17);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox4);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1280, 32);
            this.guna2Panel1.TabIndex = 34;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseDown);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseMove);
            this.guna2Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(394, 19);
            this.label17.TabIndex = 8;
            this.label17.Text = "DZOFTWARE STORE1 MANAGEMENT APP - NAVIGATEUR WEB";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1213, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(31, 29);
            this.guna2ControlBox3.TabIndex = 3;
            // 
            // guna2ControlBox4
            // 
            this.guna2ControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox4.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox4.HoverState.Parent = this.guna2ControlBox4;
            this.guna2ControlBox4.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox4.Location = new System.Drawing.Point(1249, 0);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.ShadowDecoration.Parent = this.guna2ControlBox4;
            this.guna2ControlBox4.Size = new System.Drawing.Size(31, 29);
            this.guna2ControlBox4.TabIndex = 2;
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(8, 78);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1260, 630);
            this.webView.Source = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.webView.TabIndex = 35;
            this.webView.ZoomFactor = 1D;
            // 
            // link
            // 
            // 
            // 
            // 
            this.link.CustomButton.Image = null;
            this.link.CustomButton.Location = new System.Drawing.Point(828, 2);
            this.link.CustomButton.Name = "";
            this.link.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.link.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.link.CustomButton.TabIndex = 1;
            this.link.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.link.CustomButton.UseSelectable = true;
            this.link.CustomButton.Visible = false;
            this.link.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.link.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.link.Lines = new string[0];
            this.link.Location = new System.Drawing.Point(344, 38);
            this.link.MaxLength = 32767;
            this.link.Multiline = true;
            this.link.Name = "link";
            this.link.PasswordChar = '\0';
            this.link.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.link.SelectedText = "";
            this.link.SelectionLength = 0;
            this.link.SelectionStart = 0;
            this.link.ShortcutsEnabled = true;
            this.link.Size = new System.Drawing.Size(860, 34);
            this.link.TabIndex = 36;
            this.link.UseSelectable = true;
            this.link.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.link.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            // 
            // TotalLbl
            // 
            this.TotalLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalLbl.AutoSize = true;
            this.TotalLbl.BackColor = System.Drawing.Color.Transparent;
            this.TotalLbl.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.TotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TotalLbl.Location = new System.Drawing.Point(259, 45);
            this.TotalLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLbl.Name = "TotalLbl";
            this.TotalLbl.Size = new System.Drawing.Size(80, 21);
            this.TotalLbl.TabIndex = 37;
            this.TotalLbl.Text = "Aller vers :";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::StandManagementProject.Properties.Resources.search_480px;
            this.pictureBox5.Location = new System.Drawing.Point(1222, 38);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(46, 34);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::StandManagementProject.Properties.Resources.restart_480px;
            this.pictureBox4.Location = new System.Drawing.Point(164, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(46, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::StandManagementProject.Properties.Resources.home_page_480px;
            this.pictureBox3.Location = new System.Drawing.Point(112, 38);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StandManagementProject.Properties.Resources.circled_right_480px;
            this.pictureBox2.Location = new System.Drawing.Point(60, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StandManagementProject.Properties.Resources.go_back_480px;
            this.pictureBox1.Location = new System.Drawing.Point(8, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Navigateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TotalLbl);
            this.Controls.Add(this.link);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Navigateur";
            this.Text = "Browser";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseUp);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private MetroFramework.Controls.MetroTextBox link;
        private Bunifu.Framework.UI.BunifuCustomLabel TotalLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}