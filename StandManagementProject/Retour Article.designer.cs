namespace StandManagementProject
{
    partial class Retour_Article
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.QTERet = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.checkBoxRet = new System.Windows.Forms.CheckBox();
            this.checkBoxADD = new System.Windows.Forms.CheckBox();
            this.checkBoxPRICE = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(-1, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantitée Retournée ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QTERet
            // 
            // 
            // 
            // 
            this.QTERet.CustomButton.Image = null;
            this.QTERet.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.QTERet.CustomButton.Name = "";
            this.QTERet.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.QTERet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QTERet.CustomButton.TabIndex = 1;
            this.QTERet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QTERet.CustomButton.UseSelectable = true;
            this.QTERet.CustomButton.Visible = false;
            this.QTERet.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.QTERet.Lines = new string[0];
            this.QTERet.Location = new System.Drawing.Point(55, 80);
            this.QTERet.MaxLength = 32767;
            this.QTERet.Name = "QTERet";
            this.QTERet.PasswordChar = '\0';
            this.QTERet.PromptText = "Entrer Quantitée";
            this.QTERet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QTERet.SelectedText = "";
            this.QTERet.SelectionLength = 0;
            this.QTERet.SelectionStart = 0;
            this.QTERet.ShortcutsEnabled = true;
            this.QTERet.Size = new System.Drawing.Size(273, 35);
            this.QTERet.TabIndex = 1;
            this.QTERet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QTERet.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QTERet.UseSelectable = true;
            this.QTERet.WaterMark = "Entrer Quantitée";
            this.QTERet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QTERet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.QTERet.TextChanged += new System.EventHandler(this.QTERet_TextChanged);
            this.QTERet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QTERet_KeyPress);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.DarkGreen;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.metroButton1.Location = new System.Drawing.Point(124, 136);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(135, 32);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Confirmer Retour";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // checkBoxRet
            // 
            this.checkBoxRet.AutoSize = true;
            this.checkBoxRet.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRet.Location = new System.Drawing.Point(36, 14);
            this.checkBoxRet.Name = "checkBoxRet";
            this.checkBoxRet.Size = new System.Drawing.Size(78, 24);
            this.checkBoxRet.TabIndex = 3;
            this.checkBoxRet.Text = "Retour";
            this.checkBoxRet.UseVisualStyleBackColor = true;
            this.checkBoxRet.CheckStateChanged += new System.EventHandler(this.checkBoxRet_CheckStateChanged);
            // 
            // checkBoxADD
            // 
            this.checkBoxADD.AutoSize = true;
            this.checkBoxADD.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.checkBoxADD.Location = new System.Drawing.Point(156, 13);
            this.checkBoxADD.Name = "checkBoxADD";
            this.checkBoxADD.Size = new System.Drawing.Size(68, 24);
            this.checkBoxADD.TabIndex = 4;
            this.checkBoxADD.Text = "Ajout";
            this.checkBoxADD.UseVisualStyleBackColor = true;
            this.checkBoxADD.CheckStateChanged += new System.EventHandler(this.checkBoxRet_CheckStateChanged);
            // 
            // checkBoxPRICE
            // 
            this.checkBoxPRICE.AutoSize = true;
            this.checkBoxPRICE.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F);
            this.checkBoxPRICE.Location = new System.Drawing.Point(263, 13);
            this.checkBoxPRICE.Name = "checkBoxPRICE";
            this.checkBoxPRICE.Size = new System.Drawing.Size(55, 24);
            this.checkBoxPRICE.TabIndex = 4;
            this.checkBoxPRICE.Text = "Prix";
            this.checkBoxPRICE.UseVisualStyleBackColor = true;
            this.checkBoxPRICE.CheckStateChanged += new System.EventHandler(this.checkBoxRet_CheckStateChanged);
            // 
            // Retour_Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.checkBoxPRICE);
            this.Controls.Add(this.checkBoxADD);
            this.Controls.Add(this.checkBoxRet);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.QTERet);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Retour_Article";
            this.Size = new System.Drawing.Size(384, 186);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox QTERet;
        private MetroFramework.Controls.MetroButton metroButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.CheckBox checkBoxADD;
        private System.Windows.Forms.CheckBox checkBoxRet;
        private System.Windows.Forms.CheckBox checkBoxPRICE;
    }
}
