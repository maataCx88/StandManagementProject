namespace StandManagementProject
{
    partial class Eventform
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.note = new MetroFramework.Controls.MetroTextBox();
            this.datetxt = new MetroFramework.Controls.MetroTextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.savebtn = new System.Windows.Forms.Button();
            this.guna2Panel1.SuspendLayout();
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
            this.guna2Panel1.Size = new System.Drawing.Size(800, 32);
            this.guna2Panel1.TabIndex = 36;
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
            this.label17.Size = new System.Drawing.Size(307, 19);
            this.label17.TabIndex = 8;
            this.label17.Text = "DZOFTWARE STORE MANAGEMENT APP - NOTE";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(733, 0);
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
            this.guna2ControlBox4.Location = new System.Drawing.Point(769, 0);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.ShadowDecoration.Parent = this.guna2ControlBox4;
            this.guna2ControlBox4.Size = new System.Drawing.Size(31, 29);
            this.guna2ControlBox4.TabIndex = 2;
            // 
            // note
            // 
            // 
            // 
            // 
            this.note.CustomButton.Image = null;
            this.note.CustomButton.Location = new System.Drawing.Point(476, 2);
            this.note.CustomButton.Name = "";
            this.note.CustomButton.Size = new System.Drawing.Size(179, 179);
            this.note.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.note.CustomButton.TabIndex = 1;
            this.note.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.note.CustomButton.UseSelectable = true;
            this.note.CustomButton.Visible = false;
            this.note.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.note.Lines = new string[0];
            this.note.Location = new System.Drawing.Point(68, 145);
            this.note.MaxLength = 32767;
            this.note.Multiline = true;
            this.note.Name = "note";
            this.note.PasswordChar = '\0';
            this.note.PromptText = "AJOUTER NOTE";
            this.note.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.note.SelectedText = "";
            this.note.SelectionLength = 0;
            this.note.SelectionStart = 0;
            this.note.ShortcutsEnabled = true;
            this.note.Size = new System.Drawing.Size(658, 184);
            this.note.TabIndex = 37;
            this.note.UseSelectable = true;
            this.note.WaterMark = "AJOUTER NOTE";
            this.note.WaterMarkColor = System.Drawing.Color.Gray;
            this.note.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // datetxt
            // 
            // 
            // 
            // 
            this.datetxt.CustomButton.Image = null;
            this.datetxt.CustomButton.Location = new System.Drawing.Point(536, 1);
            this.datetxt.CustomButton.Name = "";
            this.datetxt.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.datetxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.datetxt.CustomButton.TabIndex = 1;
            this.datetxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.datetxt.CustomButton.UseSelectable = true;
            this.datetxt.CustomButton.Visible = false;
            this.datetxt.Enabled = false;
            this.datetxt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.datetxt.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.datetxt.Lines = new string[0];
            this.datetxt.Location = new System.Drawing.Point(152, 85);
            this.datetxt.MaxLength = 32767;
            this.datetxt.Multiline = true;
            this.datetxt.Name = "datetxt";
            this.datetxt.PasswordChar = '\0';
            this.datetxt.ReadOnly = true;
            this.datetxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.datetxt.SelectedText = "";
            this.datetxt.SelectionLength = 0;
            this.datetxt.SelectionStart = 0;
            this.datetxt.ShortcutsEnabled = true;
            this.datetxt.Size = new System.Drawing.Size(574, 39);
            this.datetxt.TabIndex = 38;
            this.datetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.datetxt.UseSelectable = true;
            this.datetxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.datetxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Franklin Gothic Medium", 16F);
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(63, 96);
            this.bunifuCustomLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(57, 28);
            this.bunifuCustomLabel7.TabIndex = 39;
            this.bunifuCustomLabel7.Text = "Date";
            // 
            // savebtn
            // 
            this.savebtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.savebtn.BackColor = System.Drawing.Color.DarkGreen;
            this.savebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.savebtn.Image = global::StandManagementProject.Properties.Resources.receipt_approved_64px;
            this.savebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savebtn.Location = new System.Drawing.Point(482, 349);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(244, 69);
            this.savebtn.TabIndex = 40;
            this.savebtn.Text = "Sauvgarder note";
            this.savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // Eventform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.datetxt);
            this.Controls.Add(this.note);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Eventform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventform";
            this.Load += new System.EventHandler(this.Eventform_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseUp);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private MetroFramework.Controls.MetroTextBox note;
        private MetroFramework.Controls.MetroTextBox datetxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.Button savebtn;
    }
}