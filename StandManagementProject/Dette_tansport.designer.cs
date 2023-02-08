namespace StandManagementProject
{
    partial class Dette_tansport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dette_tansport));
            this.TextNom = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelVERS = new System.Windows.Forms.Label();
            this.labelReste = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroTextVersé = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // TextNom
            // 
            this.TextNom.AutoSize = true;
            this.TextNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNom.Location = new System.Drawing.Point(108, 18);
            this.TextNom.Name = "TextNom";
            this.TextNom.Size = new System.Drawing.Size(39, 16);
            this.TextNom.TabIndex = 0;
            this.TextNom.Text = "Nom";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 272);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 26);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(55, 56);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Dettes Transport";
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTotal.ForeColor = System.Drawing.Color.Black;
            this.labelTotal.Location = new System.Drawing.Point(148, 106);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(113, 19);
            this.labelTotal.TabIndex = 18;
            this.labelTotal.Text = "Montant Dette";
            // 
            // labelVERS
            // 
            this.labelVERS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVERS.AutoSize = true;
            this.labelVERS.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelVERS.ForeColor = System.Drawing.Color.Black;
            this.labelVERS.Location = new System.Drawing.Point(148, 157);
            this.labelVERS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVERS.Name = "labelVERS";
            this.labelVERS.Size = new System.Drawing.Size(113, 19);
            this.labelVERS.TabIndex = 20;
            this.labelVERS.Text = "Montant Versé";
            // 
            // labelReste
            // 
            this.labelReste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelReste.AutoSize = true;
            this.labelReste.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelReste.ForeColor = System.Drawing.Color.Black;
            this.labelReste.Location = new System.Drawing.Point(148, 201);
            this.labelReste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelReste.Name = "labelReste";
            this.labelReste.Size = new System.Drawing.Size(128, 19);
            this.labelReste.TabIndex = 22;
            this.labelReste.Text = "Montant Restant";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Teal;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButton1.ForeColor = System.Drawing.Color.Snow;
            this.metroButton1.Location = new System.Drawing.Point(79, 315);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(124, 35);
            this.metroButton1.TabIndex = 26;
            this.metroButton1.Text = "Imprimer";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Montant Dette";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Montant Versé";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Montant Restant";
            // 
            // metroTextVersé
            // 
            // 
            // 
            // 
            this.metroTextVersé.CustomButton.Image = null;
            this.metroTextVersé.CustomButton.Location = new System.Drawing.Point(166, 2);
            this.metroTextVersé.CustomButton.Name = "";
            this.metroTextVersé.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextVersé.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextVersé.CustomButton.TabIndex = 1;
            this.metroTextVersé.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextVersé.CustomButton.UseSelectable = true;
            this.metroTextVersé.CustomButton.Visible = false;
            this.metroTextVersé.Lines = new string[0];
            this.metroTextVersé.Location = new System.Drawing.Point(45, 241);
            this.metroTextVersé.MaxLength = 32767;
            this.metroTextVersé.Multiline = true;
            this.metroTextVersé.Name = "metroTextVersé";
            this.metroTextVersé.PasswordChar = '\0';
            this.metroTextVersé.PromptText = "Entrer Versement";
            this.metroTextVersé.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextVersé.SelectedText = "";
            this.metroTextVersé.SelectionLength = 0;
            this.metroTextVersé.SelectionStart = 0;
            this.metroTextVersé.ShortcutsEnabled = true;
            this.metroTextVersé.Size = new System.Drawing.Size(190, 26);
            this.metroTextVersé.TabIndex = 30;
            this.metroTextVersé.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextVersé.UseCustomForeColor = true;
            this.metroTextVersé.UseSelectable = true;
            this.metroTextVersé.WaterMark = "Entrer Versement";
            this.metroTextVersé.WaterMarkColor = System.Drawing.Color.Black;
            this.metroTextVersé.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextVersé.TextChanged += new System.EventHandler(this.metroTextVersé_TextChanged);
            this.metroTextVersé.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextVersé_KeyPress);
            // 
            // Dette_tansport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 378);
            this.Controls.Add(this.metroTextVersé);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelVERS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelReste);
            this.Controls.Add(this.TextNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 417);
            this.MinimumSize = new System.Drawing.Size(300, 417);
            this.Name = "Dette_tansport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dette_tansport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TextNom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelVERS;
        private System.Windows.Forms.Label labelReste;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox metroTextVersé;
    }
}