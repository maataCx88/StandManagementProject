
namespace StandManagementProject
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxpassword = new textboxdesign.textBoxdesign();
            this.textBoxusername = new textboxdesign.textBoxdesign();
            this.metroButtonlogin = new MetroFramework.Controls.MetroButton();
            this.metroButtonternout = new MetroFramework.Controls.MetroButton();
            this.labelpassword = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.labellogin = new System.Windows.Forms.Label();
            this.pictureBoxhide = new System.Windows.Forms.PictureBox();
            this.pictureBoxshow = new System.Windows.Forms.PictureBox();
            this.pictureBoxlogin = new System.Windows.Forms.PictureBox();
            this.pictureBoxpicture = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxshow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxpassword);
            this.panel1.Controls.Add(this.textBoxusername);
            this.panel1.Controls.Add(this.pictureBoxhide);
            this.panel1.Controls.Add(this.pictureBoxshow);
            this.panel1.Controls.Add(this.metroButtonlogin);
            this.panel1.Controls.Add(this.metroButtonternout);
            this.panel1.Controls.Add(this.pictureBoxlogin);
            this.panel1.Controls.Add(this.labelpassword);
            this.panel1.Controls.Add(this.labelusername);
            this.panel1.Controls.Add(this.labellogin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 360);
            this.panel1.TabIndex = 2;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxpassword.BottomBorderColor = System.Drawing.Color.Black;
            this.textBoxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpassword.Location = new System.Drawing.Point(42, 260);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.OnFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.textBoxpassword.Size = new System.Drawing.Size(150, 20);
            this.textBoxpassword.TabIndex = 2;
            this.textBoxpassword.UseSystemPasswordChar = true;
            // 
            // textBoxusername
            // 
            this.textBoxusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxusername.BottomBorderColor = System.Drawing.Color.Black;
            this.textBoxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxusername.Location = new System.Drawing.Point(42, 185);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.OnFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.textBoxusername.Size = new System.Drawing.Size(150, 20);
            this.textBoxusername.TabIndex = 1;
            // 
            // metroButtonlogin
            // 
            this.metroButtonlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonlogin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonlogin.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.metroButtonlogin.Location = new System.Drawing.Point(134, 302);
            this.metroButtonlogin.Name = "metroButtonlogin";
            this.metroButtonlogin.Size = new System.Drawing.Size(90, 25);
            this.metroButtonlogin.TabIndex = 3;
            this.metroButtonlogin.Text = "LOGIN";
            this.metroButtonlogin.UseSelectable = true;
            this.metroButtonlogin.Click += new System.EventHandler(this.metroButtonlogin_Click);
            // 
            // metroButtonternout
            // 
            this.metroButtonternout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonternout.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonternout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.metroButtonternout.Location = new System.Drawing.Point(11, 302);
            this.metroButtonternout.Name = "metroButtonternout";
            this.metroButtonternout.Size = new System.Drawing.Size(90, 25);
            this.metroButtonternout.TabIndex = 4;
            this.metroButtonternout.Text = "EXIT";
            this.metroButtonternout.UseSelectable = true;
            this.metroButtonternout.Click += new System.EventHandler(this.metroButtonternout_Click);
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.BackColor = System.Drawing.Color.White;
            this.labelpassword.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(62, 225);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(112, 32);
            this.labelpassword.TabIndex = 0;
            this.labelpassword.Text = "Password";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.BackColor = System.Drawing.Color.White;
            this.labelusername.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(57, 150);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(122, 32);
            this.labelusername.TabIndex = 0;
            this.labelusername.Text = "Username";
            // 
            // labellogin
            // 
            this.labellogin.AutoSize = true;
            this.labellogin.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.labellogin.Location = new System.Drawing.Point(78, 22);
            this.labellogin.Name = "labellogin";
            this.labellogin.Size = new System.Drawing.Size(78, 30);
            this.labellogin.TabIndex = 0;
            this.labellogin.Text = "LOGIN";
            // 
            // pictureBoxhide
            // 
            this.pictureBoxhide.Image = global::StandManagementProject.Properties.Resources.icons8_hide_32;
            this.pictureBoxhide.Location = new System.Drawing.Point(198, 260);
            this.pictureBoxhide.Name = "pictureBoxhide";
            this.pictureBoxhide.Size = new System.Drawing.Size(30, 25);
            this.pictureBoxhide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxhide.TabIndex = 6;
            this.pictureBoxhide.TabStop = false;
            this.pictureBoxhide.Visible = false;
            this.pictureBoxhide.Click += new System.EventHandler(this.pictureBoxhide_Click);
            // 
            // pictureBoxshow
            // 
            this.pictureBoxshow.Image = global::StandManagementProject.Properties.Resources.icons8_eye_32;
            this.pictureBoxshow.Location = new System.Drawing.Point(198, 260);
            this.pictureBoxshow.Name = "pictureBoxshow";
            this.pictureBoxshow.Size = new System.Drawing.Size(30, 25);
            this.pictureBoxshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxshow.TabIndex = 5;
            this.pictureBoxshow.TabStop = false;
            this.pictureBoxshow.Click += new System.EventHandler(this.pictureBoxshow_Click);
            // 
            // pictureBoxlogin
            // 
            this.pictureBoxlogin.Image = global::StandManagementProject.Properties.Resources.icons8_enter_64;
            this.pictureBoxlogin.Location = new System.Drawing.Point(42, 60);
            this.pictureBoxlogin.Name = "pictureBoxlogin";
            this.pictureBoxlogin.Size = new System.Drawing.Size(150, 75);
            this.pictureBoxlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxlogin.TabIndex = 3;
            this.pictureBoxlogin.TabStop = false;
            // 
            // pictureBoxpicture
            // 
            this.pictureBoxpicture.Image = global::StandManagementProject.Properties.Resources.ildar_garifullin_2Z6fSxr6LGk_unsplash;
            this.pictureBoxpicture.Location = new System.Drawing.Point(240, 0);
            this.pictureBoxpicture.Name = "pictureBoxpicture";
            this.pictureBoxpicture.Size = new System.Drawing.Size(400, 360);
            this.pictureBoxpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxpicture.TabIndex = 3;
            this.pictureBoxpicture.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxpicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxhide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxshow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxpicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxhide;
        private System.Windows.Forms.PictureBox pictureBoxshow;
        private MetroFramework.Controls.MetroButton metroButtonlogin;
        private MetroFramework.Controls.MetroButton metroButtonternout;
        private System.Windows.Forms.PictureBox pictureBoxlogin;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labellogin;
        private System.Windows.Forms.PictureBox pictureBoxpicture;
        private textboxdesign.textBoxdesign textBoxpassword;
        private textboxdesign.textBoxdesign textBoxusername;
    }
}