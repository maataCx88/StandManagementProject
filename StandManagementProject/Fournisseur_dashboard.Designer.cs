namespace StandManagementProject
{
    partial class Fournisseur_dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewFournisseur = new System.Windows.Forms.DataGridView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroConfirm = new MetroFramework.Controls.MetroButton();
            this.metroTextPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroTextPrénom = new MetroFramework.Controls.MetroTextBox();
            this.metroTextNom = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.metroNouveauAchat = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroTextReste = new MetroFramework.Controls.MetroTextBox();
            this.metroTextVersé = new MetroFramework.Controls.MetroTextBox();
            this.metroTextTotal = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.metroTextGros = new MetroFramework.Controls.MetroTextBox();
            this.metroTextRemise = new MetroFramework.Controls.MetroTextBox();
            this.metroTextVente = new MetroFramework.Controls.MetroTextBox();
            this.metroTextDesignation = new MetroFramework.Controls.MetroTextBox();
            this.metroTextAchat = new MetroFramework.Controls.MetroTextBox();
            this.metroTextQte = new MetroFramework.Controls.MetroTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.metroTextSearch = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseur)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste des Fournisseurs";
            // 
            // dataGridViewFournisseur
            // 
            this.dataGridViewFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFournisseur.Location = new System.Drawing.Point(23, 105);
            this.dataGridViewFournisseur.Name = "dataGridViewFournisseur";
            this.dataGridViewFournisseur.ReadOnly = true;
            this.dataGridViewFournisseur.RowHeadersWidth = 51;
            this.dataGridViewFournisseur.RowTemplate.Height = 24;
            this.dataGridViewFournisseur.Size = new System.Drawing.Size(389, 441);
            this.dataGridViewFournisseur.TabIndex = 2;
            this.dataGridViewFournisseur.DoubleClick += new System.EventHandler(this.dataGridViewFournisseur_DoubleClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.metroPanel1.Controls.Add(this.metroConfirm);
            this.metroPanel1.Controls.Add(this.metroTextPhone);
            this.metroPanel1.Controls.Add(this.metroTextPrénom);
            this.metroPanel1.Controls.Add(this.metroTextNom);
            this.metroPanel1.Controls.Add(this.label5);
            this.metroPanel1.Controls.Add(this.label4);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(436, 57);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(349, 284);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroConfirm
            // 
            this.metroConfirm.BackColor = System.Drawing.Color.DarkSlateGray;
            this.metroConfirm.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroConfirm.ForeColor = System.Drawing.Color.Snow;
            this.metroConfirm.Location = new System.Drawing.Point(87, 233);
            this.metroConfirm.Name = "metroConfirm";
            this.metroConfirm.Size = new System.Drawing.Size(192, 36);
            this.metroConfirm.TabIndex = 4;
            this.metroConfirm.Text = "Ajouter Nouveau Fournisseur";
            this.metroConfirm.UseCustomBackColor = true;
            this.metroConfirm.UseCustomForeColor = true;
            this.metroConfirm.UseSelectable = true;
            this.metroConfirm.Click += new System.EventHandler(this.metroConfirm_Click);
            // 
            // metroTextPhone
            // 
            this.metroTextPhone.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.metroTextPhone.CustomButton.Image = null;
            this.metroTextPhone.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.metroTextPhone.CustomButton.Name = "";
            this.metroTextPhone.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextPhone.CustomButton.TabIndex = 1;
            this.metroTextPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextPhone.CustomButton.UseSelectable = true;
            this.metroTextPhone.CustomButton.Visible = false;
            this.metroTextPhone.Lines = new string[0];
            this.metroTextPhone.Location = new System.Drawing.Point(36, 186);
            this.metroTextPhone.MaxLength = 32767;
            this.metroTextPhone.Multiline = true;
            this.metroTextPhone.Name = "metroTextPhone";
            this.metroTextPhone.PasswordChar = '\0';
            this.metroTextPhone.PromptText = "Téléphone du Fournisseur";
            this.metroTextPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextPhone.SelectedText = "";
            this.metroTextPhone.SelectionLength = 0;
            this.metroTextPhone.SelectionStart = 0;
            this.metroTextPhone.ShortcutsEnabled = true;
            this.metroTextPhone.Size = new System.Drawing.Size(283, 31);
            this.metroTextPhone.TabIndex = 3;
            this.metroTextPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextPhone.UseCustomBackColor = true;
            this.metroTextPhone.UseCustomForeColor = true;
            this.metroTextPhone.UseSelectable = true;
            this.metroTextPhone.UseStyleColors = true;
            this.metroTextPhone.WaterMark = "Téléphone du Fournisseur";
            this.metroTextPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextAchat_KeyPress);
            // 
            // metroTextPrénom
            // 
            this.metroTextPrénom.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.metroTextPrénom.CustomButton.Image = null;
            this.metroTextPrénom.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.metroTextPrénom.CustomButton.Name = "";
            this.metroTextPrénom.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextPrénom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextPrénom.CustomButton.TabIndex = 1;
            this.metroTextPrénom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextPrénom.CustomButton.UseSelectable = true;
            this.metroTextPrénom.CustomButton.Visible = false;
            this.metroTextPrénom.Lines = new string[0];
            this.metroTextPrénom.Location = new System.Drawing.Point(32, 110);
            this.metroTextPrénom.MaxLength = 32767;
            this.metroTextPrénom.Multiline = true;
            this.metroTextPrénom.Name = "metroTextPrénom";
            this.metroTextPrénom.PasswordChar = '\0';
            this.metroTextPrénom.PromptText = "Prénom du Fournisseur";
            this.metroTextPrénom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextPrénom.SelectedText = "";
            this.metroTextPrénom.SelectionLength = 0;
            this.metroTextPrénom.SelectionStart = 0;
            this.metroTextPrénom.ShortcutsEnabled = true;
            this.metroTextPrénom.Size = new System.Drawing.Size(289, 31);
            this.metroTextPrénom.TabIndex = 2;
            this.metroTextPrénom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextPrénom.UseCustomBackColor = true;
            this.metroTextPrénom.UseCustomForeColor = true;
            this.metroTextPrénom.UseSelectable = true;
            this.metroTextPrénom.UseStyleColors = true;
            this.metroTextPrénom.WaterMark = "Prénom du Fournisseur";
            this.metroTextPrénom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextPrénom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTextNom
            // 
            this.metroTextNom.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.metroTextNom.CustomButton.Image = null;
            this.metroTextNom.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.metroTextNom.CustomButton.Name = "";
            this.metroTextNom.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextNom.CustomButton.TabIndex = 1;
            this.metroTextNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextNom.CustomButton.UseSelectable = true;
            this.metroTextNom.CustomButton.Visible = false;
            this.metroTextNom.Lines = new string[0];
            this.metroTextNom.Location = new System.Drawing.Point(36, 36);
            this.metroTextNom.MaxLength = 32767;
            this.metroTextNom.Multiline = true;
            this.metroTextNom.Name = "metroTextNom";
            this.metroTextNom.PasswordChar = '\0';
            this.metroTextNom.PromptText = "Nom du Fournisseur";
            this.metroTextNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextNom.SelectedText = "";
            this.metroTextNom.SelectionLength = 0;
            this.metroTextNom.SelectionStart = 0;
            this.metroTextNom.ShortcutsEnabled = true;
            this.metroTextNom.Size = new System.Drawing.Size(283, 31);
            this.metroTextNom.TabIndex = 1;
            this.metroTextNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextNom.UseCustomBackColor = true;
            this.metroTextNom.UseCustomForeColor = true;
            this.metroTextNom.UseSelectable = true;
            this.metroTextNom.UseStyleColors = true;
            this.metroTextNom.WaterMark = "Nom du Fournisseur";
            this.metroTextNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Téléphone du Fournisseur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prénom du Fournisseur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom du Fournisseur";
            // 
            // metroNouveauAchat
            // 
            this.metroNouveauAchat.BackColor = System.Drawing.Color.OliveDrab;
            this.metroNouveauAchat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroNouveauAchat.Location = new System.Drawing.Point(85, 243);
            this.metroNouveauAchat.Name = "metroNouveauAchat";
            this.metroNouveauAchat.Size = new System.Drawing.Size(165, 36);
            this.metroNouveauAchat.TabIndex = 5;
            this.metroNouveauAchat.Text = "Confirmer Nouveau Achat";
            this.metroNouveauAchat.UseCustomBackColor = true;
            this.metroNouveauAchat.UseCustomForeColor = true;
            this.metroNouveauAchat.UseSelectable = true;
            this.metroNouveauAchat.UseStyleColors = true;
            this.metroNouveauAchat.Click += new System.EventHandler(this.metroNouveauAchat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Information du Fournisseur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(856, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "Information de Facture";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.metroPanel2.Controls.Add(this.dateTimePicker1);
            this.metroPanel2.Controls.Add(this.metroNouveauAchat);
            this.metroPanel2.Controls.Add(this.metroTextReste);
            this.metroPanel2.Controls.Add(this.metroTextVersé);
            this.metroPanel2.Controls.Add(this.metroTextTotal);
            this.metroPanel2.Controls.Add(this.label7);
            this.metroPanel2.Controls.Add(this.label8);
            this.metroPanel2.Controls.Add(this.label9);
            this.metroPanel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(805, 57);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(345, 284);
            this.metroPanel2.TabIndex = 4;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(327, 33);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // metroTextReste
            // 
            this.metroTextReste.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.metroTextReste.CustomButton.Image = null;
            this.metroTextReste.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.metroTextReste.CustomButton.Name = "";
            this.metroTextReste.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextReste.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextReste.CustomButton.TabIndex = 1;
            this.metroTextReste.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextReste.CustomButton.UseSelectable = true;
            this.metroTextReste.CustomButton.Visible = false;
            this.metroTextReste.Enabled = false;
            this.metroTextReste.Lines = new string[0];
            this.metroTextReste.Location = new System.Drawing.Point(28, 164);
            this.metroTextReste.MaxLength = 32767;
            this.metroTextReste.Multiline = true;
            this.metroTextReste.Name = "metroTextReste";
            this.metroTextReste.PasswordChar = '\0';
            this.metroTextReste.PromptText = "Reste";
            this.metroTextReste.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextReste.SelectedText = "";
            this.metroTextReste.SelectionLength = 0;
            this.metroTextReste.SelectionStart = 0;
            this.metroTextReste.ShortcutsEnabled = true;
            this.metroTextReste.Size = new System.Drawing.Size(283, 31);
            this.metroTextReste.TabIndex = 3;
            this.metroTextReste.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextReste.UseCustomBackColor = true;
            this.metroTextReste.UseCustomForeColor = true;
            this.metroTextReste.UseSelectable = true;
            this.metroTextReste.UseStyleColors = true;
            this.metroTextReste.WaterMark = "Reste";
            this.metroTextReste.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextReste.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTextVersé
            // 
            this.metroTextVersé.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.metroTextVersé.CustomButton.Image = null;
            this.metroTextVersé.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.metroTextVersé.CustomButton.Name = "";
            this.metroTextVersé.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextVersé.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextVersé.CustomButton.TabIndex = 1;
            this.metroTextVersé.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextVersé.CustomButton.UseSelectable = true;
            this.metroTextVersé.CustomButton.Visible = false;
            this.metroTextVersé.Lines = new string[0];
            this.metroTextVersé.Location = new System.Drawing.Point(28, 100);
            this.metroTextVersé.MaxLength = 32767;
            this.metroTextVersé.Multiline = true;
            this.metroTextVersé.Name = "metroTextVersé";
            this.metroTextVersé.PasswordChar = '\0';
            this.metroTextVersé.PromptText = "Versé";
            this.metroTextVersé.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextVersé.SelectedText = "";
            this.metroTextVersé.SelectionLength = 0;
            this.metroTextVersé.SelectionStart = 0;
            this.metroTextVersé.ShortcutsEnabled = true;
            this.metroTextVersé.Size = new System.Drawing.Size(283, 31);
            this.metroTextVersé.TabIndex = 2;
            this.metroTextVersé.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextVersé.UseCustomBackColor = true;
            this.metroTextVersé.UseCustomForeColor = true;
            this.metroTextVersé.UseSelectable = true;
            this.metroTextVersé.UseStyleColors = true;
            this.metroTextVersé.WaterMark = "Versé";
            this.metroTextVersé.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextVersé.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextVersé.TextChanged += new System.EventHandler(this.metroTextVersé_TextChanged);
            this.metroTextVersé.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextAchat_KeyPress);
            // 
            // metroTextTotal
            // 
            this.metroTextTotal.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.metroTextTotal.CustomButton.Image = null;
            this.metroTextTotal.CustomButton.Location = new System.Drawing.Point(253, 1);
            this.metroTextTotal.CustomButton.Name = "";
            this.metroTextTotal.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextTotal.CustomButton.TabIndex = 1;
            this.metroTextTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextTotal.CustomButton.UseSelectable = true;
            this.metroTextTotal.CustomButton.Visible = false;
            this.metroTextTotal.Enabled = false;
            this.metroTextTotal.Lines = new string[0];
            this.metroTextTotal.Location = new System.Drawing.Point(28, 36);
            this.metroTextTotal.MaxLength = 32767;
            this.metroTextTotal.Multiline = true;
            this.metroTextTotal.Name = "metroTextTotal";
            this.metroTextTotal.PasswordChar = '\0';
            this.metroTextTotal.PromptText = "Total de Facture";
            this.metroTextTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextTotal.SelectedText = "";
            this.metroTextTotal.SelectionLength = 0;
            this.metroTextTotal.SelectionStart = 0;
            this.metroTextTotal.ShortcutsEnabled = true;
            this.metroTextTotal.Size = new System.Drawing.Size(283, 31);
            this.metroTextTotal.TabIndex = 1;
            this.metroTextTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextTotal.UseCustomBackColor = true;
            this.metroTextTotal.UseCustomForeColor = true;
            this.metroTextTotal.UseSelectable = true;
            this.metroTextTotal.UseStyleColors = true;
            this.metroTextTotal.WaterMark = "Total de Facture";
            this.metroTextTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextTotal.TextChanged += new System.EventHandler(this.metroTextTotal_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Montant Reste";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "Montant Versé";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(137, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total";
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.NavajoWhite;
            this.metroPanel3.Controls.Add(this.label13);
            this.metroPanel3.Controls.Add(this.label11);
            this.metroPanel3.Controls.Add(this.label16);
            this.metroPanel3.Controls.Add(this.label14);
            this.metroPanel3.Controls.Add(this.label15);
            this.metroPanel3.Controls.Add(this.label10);
            this.metroPanel3.Controls.Add(this.metroTextGros);
            this.metroPanel3.Controls.Add(this.metroTextRemise);
            this.metroPanel3.Controls.Add(this.metroTextVente);
            this.metroPanel3.Controls.Add(this.metroTextDesignation);
            this.metroPanel3.Controls.Add(this.metroTextAchat);
            this.metroPanel3.Controls.Add(this.metroTextQte);
            this.metroPanel3.Controls.Add(this.label12);
            this.metroPanel3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(455, 350);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(682, 199);
            this.metroPanel3.TabIndex = 5;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.UseCustomForeColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(541, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Quantité";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(531, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "Prix De Gros";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(79, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 19);
            this.label16.TabIndex = 3;
            this.label16.Text = "Désignation";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(77, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 19);
            this.label14.TabIndex = 3;
            this.label14.Text = "Prix D\'Achat";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(312, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "Prix De Remise";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(315, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Prix De Vente";
            // 
            // metroTextGros
            // 
            this.metroTextGros.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.metroTextGros.CustomButton.Image = null;
            this.metroTextGros.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.metroTextGros.CustomButton.Name = "";
            this.metroTextGros.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextGros.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextGros.CustomButton.TabIndex = 1;
            this.metroTextGros.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextGros.CustomButton.UseSelectable = true;
            this.metroTextGros.CustomButton.Visible = false;
            this.metroTextGros.Lines = new string[0];
            this.metroTextGros.Location = new System.Drawing.Point(478, 54);
            this.metroTextGros.MaxLength = 32767;
            this.metroTextGros.Multiline = true;
            this.metroTextGros.Name = "metroTextGros";
            this.metroTextGros.PasswordChar = '\0';
            this.metroTextGros.PromptText = "Prix Gros";
            this.metroTextGros.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextGros.SelectedText = "";
            this.metroTextGros.SelectionLength = 0;
            this.metroTextGros.SelectionStart = 0;
            this.metroTextGros.ShortcutsEnabled = true;
            this.metroTextGros.Size = new System.Drawing.Size(201, 31);
            this.metroTextGros.TabIndex = 5;
            this.metroTextGros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextGros.UseCustomBackColor = true;
            this.metroTextGros.UseCustomForeColor = true;
            this.metroTextGros.UseSelectable = true;
            this.metroTextGros.UseStyleColors = true;
            this.metroTextGros.WaterMark = "Prix Gros";
            this.metroTextGros.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextGros.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextGros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextAchat_KeyPress);
            // 
            // metroTextRemise
            // 
            this.metroTextRemise.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.metroTextRemise.CustomButton.Image = null;
            this.metroTextRemise.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.metroTextRemise.CustomButton.Name = "";
            this.metroTextRemise.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextRemise.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextRemise.CustomButton.TabIndex = 1;
            this.metroTextRemise.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextRemise.CustomButton.UseSelectable = true;
            this.metroTextRemise.CustomButton.Visible = false;
            this.metroTextRemise.Lines = new string[0];
            this.metroTextRemise.Location = new System.Drawing.Point(257, 54);
            this.metroTextRemise.MaxLength = 32767;
            this.metroTextRemise.Multiline = true;
            this.metroTextRemise.Name = "metroTextRemise";
            this.metroTextRemise.PasswordChar = '\0';
            this.metroTextRemise.PromptText = "Prix de Remise";
            this.metroTextRemise.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextRemise.SelectedText = "";
            this.metroTextRemise.SelectionLength = 0;
            this.metroTextRemise.SelectionStart = 0;
            this.metroTextRemise.ShortcutsEnabled = true;
            this.metroTextRemise.Size = new System.Drawing.Size(215, 31);
            this.metroTextRemise.TabIndex = 3;
            this.metroTextRemise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextRemise.UseCustomBackColor = true;
            this.metroTextRemise.UseCustomForeColor = true;
            this.metroTextRemise.UseSelectable = true;
            this.metroTextRemise.UseStyleColors = true;
            this.metroTextRemise.WaterMark = "Prix de Remise";
            this.metroTextRemise.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextRemise.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextRemise.TextChanged += new System.EventHandler(this.metroTextVente_TextChanged);
            this.metroTextRemise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextAchat_KeyPress);
            // 
            // metroTextVente
            // 
            this.metroTextVente.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.metroTextVente.CustomButton.Image = null;
            this.metroTextVente.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.metroTextVente.CustomButton.Name = "";
            this.metroTextVente.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextVente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextVente.CustomButton.TabIndex = 1;
            this.metroTextVente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextVente.CustomButton.UseSelectable = true;
            this.metroTextVente.CustomButton.Visible = false;
            this.metroTextVente.Lines = new string[0];
            this.metroTextVente.Location = new System.Drawing.Point(257, 140);
            this.metroTextVente.MaxLength = 32767;
            this.metroTextVente.Multiline = true;
            this.metroTextVente.Name = "metroTextVente";
            this.metroTextVente.PasswordChar = '\0';
            this.metroTextVente.PromptText = "Prix Vente";
            this.metroTextVente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextVente.SelectedText = "";
            this.metroTextVente.SelectionLength = 0;
            this.metroTextVente.SelectionStart = 0;
            this.metroTextVente.ShortcutsEnabled = true;
            this.metroTextVente.Size = new System.Drawing.Size(216, 31);
            this.metroTextVente.TabIndex = 4;
            this.metroTextVente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextVente.UseCustomBackColor = true;
            this.metroTextVente.UseCustomForeColor = true;
            this.metroTextVente.UseSelectable = true;
            this.metroTextVente.UseStyleColors = true;
            this.metroTextVente.WaterMark = "Prix Vente";
            this.metroTextVente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextVente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextVente.TextChanged += new System.EventHandler(this.metroTextVente_TextChanged);
            this.metroTextVente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextAchat_KeyPress);
            // 
            // metroTextDesignation
            // 
            this.metroTextDesignation.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.metroTextDesignation.CustomButton.Image = null;
            this.metroTextDesignation.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.metroTextDesignation.CustomButton.Name = "";
            this.metroTextDesignation.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextDesignation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextDesignation.CustomButton.TabIndex = 1;
            this.metroTextDesignation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextDesignation.CustomButton.UseSelectable = true;
            this.metroTextDesignation.CustomButton.Visible = false;
            this.metroTextDesignation.Lines = new string[0];
            this.metroTextDesignation.Location = new System.Drawing.Point(20, 55);
            this.metroTextDesignation.MaxLength = 32767;
            this.metroTextDesignation.Multiline = true;
            this.metroTextDesignation.Name = "metroTextDesignation";
            this.metroTextDesignation.PasswordChar = '\0';
            this.metroTextDesignation.PromptText = "Désignation";
            this.metroTextDesignation.ReadOnly = true;
            this.metroTextDesignation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextDesignation.SelectedText = "";
            this.metroTextDesignation.SelectionLength = 0;
            this.metroTextDesignation.SelectionStart = 0;
            this.metroTextDesignation.ShortcutsEnabled = true;
            this.metroTextDesignation.Size = new System.Drawing.Size(216, 31);
            this.metroTextDesignation.TabIndex = 1;
            this.metroTextDesignation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextDesignation.UseCustomBackColor = true;
            this.metroTextDesignation.UseCustomForeColor = true;
            this.metroTextDesignation.UseSelectable = true;
            this.metroTextDesignation.UseStyleColors = true;
            this.metroTextDesignation.WaterMark = "Désignation";
            this.metroTextDesignation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextDesignation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTextAchat
            // 
            this.metroTextAchat.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.metroTextAchat.CustomButton.Image = null;
            this.metroTextAchat.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.metroTextAchat.CustomButton.Name = "";
            this.metroTextAchat.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextAchat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextAchat.CustomButton.TabIndex = 1;
            this.metroTextAchat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextAchat.CustomButton.UseSelectable = true;
            this.metroTextAchat.CustomButton.Visible = false;
            this.metroTextAchat.Lines = new string[0];
            this.metroTextAchat.Location = new System.Drawing.Point(20, 139);
            this.metroTextAchat.MaxLength = 32767;
            this.metroTextAchat.Multiline = true;
            this.metroTextAchat.Name = "metroTextAchat";
            this.metroTextAchat.PasswordChar = '\0';
            this.metroTextAchat.PromptText = "Prix Achat";
            this.metroTextAchat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextAchat.SelectedText = "";
            this.metroTextAchat.SelectionLength = 0;
            this.metroTextAchat.SelectionStart = 0;
            this.metroTextAchat.ShortcutsEnabled = true;
            this.metroTextAchat.Size = new System.Drawing.Size(216, 31);
            this.metroTextAchat.TabIndex = 2;
            this.metroTextAchat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextAchat.UseCustomBackColor = true;
            this.metroTextAchat.UseCustomForeColor = true;
            this.metroTextAchat.UseSelectable = true;
            this.metroTextAchat.UseStyleColors = true;
            this.metroTextAchat.WaterMark = "Prix Achat";
            this.metroTextAchat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextAchat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextAchat.TextChanged += new System.EventHandler(this.metroTextAchat_TextChanged);
            this.metroTextAchat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextAchat_KeyPress);
            // 
            // metroTextQte
            // 
            this.metroTextQte.BackColor = System.Drawing.Color.Ivory;
            // 
            // 
            // 
            this.metroTextQte.CustomButton.Image = null;
            this.metroTextQte.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.metroTextQte.CustomButton.Name = "";
            this.metroTextQte.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.metroTextQte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextQte.CustomButton.TabIndex = 1;
            this.metroTextQte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextQte.CustomButton.UseSelectable = true;
            this.metroTextQte.CustomButton.Visible = false;
            this.metroTextQte.Lines = new string[0];
            this.metroTextQte.Location = new System.Drawing.Point(499, 140);
            this.metroTextQte.MaxLength = 32767;
            this.metroTextQte.Multiline = true;
            this.metroTextQte.Name = "metroTextQte";
            this.metroTextQte.PasswordChar = '\0';
            this.metroTextQte.PromptText = "Qte Acheté";
            this.metroTextQte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextQte.SelectedText = "";
            this.metroTextQte.SelectionLength = 0;
            this.metroTextQte.SelectionStart = 0;
            this.metroTextQte.ShortcutsEnabled = true;
            this.metroTextQte.Size = new System.Drawing.Size(166, 31);
            this.metroTextQte.TabIndex = 6;
            this.metroTextQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextQte.UseCustomBackColor = true;
            this.metroTextQte.UseCustomForeColor = true;
            this.metroTextQte.UseSelectable = true;
            this.metroTextQte.UseStyleColors = true;
            this.metroTextQte.WaterMark = "Qte Acheté";
            this.metroTextQte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextQte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextQte.TextChanged += new System.EventHandler(this.metroTextAchat_TextChanged);
            this.metroTextQte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroTextAchat_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(244, 27);
            this.label12.TabIndex = 0;
            this.label12.Text = "Information MultiCode";
            // 
            // metroTextSearch
            // 
            this.metroTextSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.metroTextSearch.CustomButton.Image = null;
            this.metroTextSearch.CustomButton.Location = new System.Drawing.Point(349, 2);
            this.metroTextSearch.CustomButton.Name = "";
            this.metroTextSearch.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.metroTextSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextSearch.CustomButton.TabIndex = 1;
            this.metroTextSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextSearch.CustomButton.UseSelectable = true;
            this.metroTextSearch.CustomButton.Visible = false;
            this.metroTextSearch.DisplayIcon = true;
            this.metroTextSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextSearch.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextSearch.ForeColor = System.Drawing.Color.AliceBlue;
            this.metroTextSearch.Icon = global::StandManagementProject.Properties.Resources.google_web_search_208px;
            this.metroTextSearch.Lines = new string[0];
            this.metroTextSearch.Location = new System.Drawing.Point(23, 57);
            this.metroTextSearch.MaxLength = 32767;
            this.metroTextSearch.Multiline = true;
            this.metroTextSearch.Name = "metroTextSearch";
            this.metroTextSearch.PasswordChar = '\0';
            this.metroTextSearch.PromptText = "Rechercher un Fournisseur";
            this.metroTextSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextSearch.SelectedText = "";
            this.metroTextSearch.SelectionLength = 0;
            this.metroTextSearch.SelectionStart = 0;
            this.metroTextSearch.ShortcutsEnabled = true;
            this.metroTextSearch.Size = new System.Drawing.Size(389, 42);
            this.metroTextSearch.TabIndex = 1;
            this.metroTextSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextSearch.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextSearch.UseCustomBackColor = true;
            this.metroTextSearch.UseCustomForeColor = true;
            this.metroTextSearch.UseSelectable = true;
            this.metroTextSearch.UseStyleColors = true;
            this.metroTextSearch.WaterMark = "Rechercher un Fournisseur";
            this.metroTextSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextSearch.TextChanged += new System.EventHandler(this.metroTextSearch_TextChanged);
            // 
            // Fournisseur_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 559);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dataGridViewFournisseur);
            this.Controls.Add(this.metroTextSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1173, 559);
            this.MinimumSize = new System.Drawing.Size(1173, 559);
            this.Name = "Fournisseur_dashboard";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.TransparencyKey = System.Drawing.Color.AliceBlue;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Fournisseur_dashboard_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFournisseur)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox metroTextSearch;
        private System.Windows.Forms.DataGridView dataGridViewFournisseur;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox metroTextPhone;
        private MetroFramework.Controls.MetroTextBox metroTextPrénom;
        private MetroFramework.Controls.MetroTextBox metroTextNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroButton metroNouveauAchat;
        private MetroFramework.Controls.MetroButton metroConfirm;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox metroTextReste;
        private MetroFramework.Controls.MetroTextBox metroTextVersé;
        private MetroFramework.Controls.MetroTextBox metroTextTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTextBox metroTextQte;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroTextBox metroTextAchat;
        private MetroFramework.Controls.MetroTextBox metroTextVente;
        private MetroFramework.Controls.MetroTextBox metroTextGros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private MetroFramework.Controls.MetroTextBox metroTextRemise;
        private System.Windows.Forms.Label label16;
        private MetroFramework.Controls.MetroTextBox metroTextDesignation;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}