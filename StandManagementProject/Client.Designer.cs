
namespace StandManagementProject
{
    partial class Client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.Nom = new MetroFramework.Controls.MetroTextBox();
            this.PhoneFour = new MetroFramework.Controls.MetroTextBox();
            this.AjouterNew = new System.Windows.Forms.Button();
            this.Prénom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Recherchetxt = new MetroFramework.Controls.MetroTextBox();
            this.DataFournisseur = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.Nom);
            this.metroPanel1.Controls.Add(this.PhoneFour);
            this.metroPanel1.Controls.Add(this.AjouterNew);
            this.metroPanel1.Controls.Add(this.Prénom);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 47);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(309, 270);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sortir";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nom
            // 
            // 
            // 
            // 
            this.Nom.CustomButton.Image = null;
            this.Nom.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.Nom.CustomButton.Name = "";
            this.Nom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Nom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Nom.CustomButton.TabIndex = 1;
            this.Nom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Nom.CustomButton.UseSelectable = true;
            this.Nom.CustomButton.Visible = false;
            this.Nom.Lines = new string[0];
            this.Nom.Location = new System.Drawing.Point(57, 72);
            this.Nom.MaxLength = 32767;
            this.Nom.Name = "Nom";
            this.Nom.PasswordChar = '\0';
            this.Nom.PromptText = "Nom";
            this.Nom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Nom.SelectedText = "";
            this.Nom.SelectionLength = 0;
            this.Nom.SelectionStart = 0;
            this.Nom.ShortcutsEnabled = true;
            this.Nom.Size = new System.Drawing.Size(197, 23);
            this.Nom.TabIndex = 8;
            this.Nom.UseSelectable = true;
            this.Nom.UseStyleColors = true;
            this.Nom.WaterMark = "Nom";
            this.Nom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Nom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PhoneFour
            // 
            // 
            // 
            // 
            this.PhoneFour.CustomButton.Image = null;
            this.PhoneFour.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.PhoneFour.CustomButton.Name = "";
            this.PhoneFour.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.PhoneFour.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PhoneFour.CustomButton.TabIndex = 1;
            this.PhoneFour.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PhoneFour.CustomButton.UseSelectable = true;
            this.PhoneFour.CustomButton.Visible = false;
            this.PhoneFour.Lines = new string[0];
            this.PhoneFour.Location = new System.Drawing.Point(57, 161);
            this.PhoneFour.MaxLength = 32767;
            this.PhoneFour.Name = "PhoneFour";
            this.PhoneFour.PasswordChar = '\0';
            this.PhoneFour.PromptText = "Téléphone";
            this.PhoneFour.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PhoneFour.SelectedText = "";
            this.PhoneFour.SelectionLength = 0;
            this.PhoneFour.SelectionStart = 0;
            this.PhoneFour.ShortcutsEnabled = true;
            this.PhoneFour.Size = new System.Drawing.Size(197, 23);
            this.PhoneFour.TabIndex = 6;
            this.PhoneFour.UseSelectable = true;
            this.PhoneFour.UseStyleColors = true;
            this.PhoneFour.WaterMark = "Téléphone";
            this.PhoneFour.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PhoneFour.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AjouterNew
            // 
            this.AjouterNew.Location = new System.Drawing.Point(69, 190);
            this.AjouterNew.Name = "AjouterNew";
            this.AjouterNew.Size = new System.Drawing.Size(161, 35);
            this.AjouterNew.TabIndex = 5;
            this.AjouterNew.Text = "Ajouter de Nouveau";
            this.AjouterNew.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AjouterNew.UseVisualStyleBackColor = false;
            this.AjouterNew.Click += new System.EventHandler(this.AjouterNew_Click);
            // 
            // Prénom
            // 
            // 
            // 
            // 
            this.Prénom.CustomButton.Image = null;
            this.Prénom.CustomButton.Location = new System.Drawing.Point(175, 1);
            this.Prénom.CustomButton.Name = "";
            this.Prénom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Prénom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Prénom.CustomButton.TabIndex = 1;
            this.Prénom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Prénom.CustomButton.UseSelectable = true;
            this.Prénom.CustomButton.Visible = false;
            this.Prénom.Lines = new string[0];
            this.Prénom.Location = new System.Drawing.Point(57, 114);
            this.Prénom.MaxLength = 32767;
            this.Prénom.Name = "Prénom";
            this.Prénom.PasswordChar = '\0';
            this.Prénom.PromptText = "Prénom";
            this.Prénom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Prénom.SelectedText = "";
            this.Prénom.SelectionLength = 0;
            this.Prénom.SelectionStart = 0;
            this.Prénom.ShortcutsEnabled = true;
            this.Prénom.Size = new System.Drawing.Size(197, 23);
            this.Prénom.TabIndex = 4;
            this.Prénom.UseSelectable = true;
            this.Prénom.UseStyleColors = true;
            this.Prénom.WaterMark = "Prénom";
            this.Prénom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Prénom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(69, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(124, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Informations Client";
            // 
            // Recherchetxt
            // 
            // 
            // 
            // 
            this.Recherchetxt.CustomButton.Image = null;
            this.Recherchetxt.CustomButton.Location = new System.Drawing.Point(261, 1);
            this.Recherchetxt.CustomButton.Name = "";
            this.Recherchetxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Recherchetxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Recherchetxt.CustomButton.TabIndex = 1;
            this.Recherchetxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Recherchetxt.CustomButton.UseSelectable = true;
            this.Recherchetxt.CustomButton.Visible = false;
            this.Recherchetxt.Lines = new string[0];
            this.Recherchetxt.Location = new System.Drawing.Point(26, 18);
            this.Recherchetxt.MaxLength = 32767;
            this.Recherchetxt.Name = "Recherchetxt";
            this.Recherchetxt.PasswordChar = '\0';
            this.Recherchetxt.PromptText = "Rechercher Client...";
            this.Recherchetxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Recherchetxt.SelectedText = "";
            this.Recherchetxt.SelectionLength = 0;
            this.Recherchetxt.SelectionStart = 0;
            this.Recherchetxt.ShortcutsEnabled = true;
            this.Recherchetxt.Size = new System.Drawing.Size(283, 23);
            this.Recherchetxt.TabIndex = 12;
            this.Recherchetxt.UseSelectable = true;
            this.Recherchetxt.UseStyleColors = true;
            this.Recherchetxt.WaterMark = "Rechercher Client...";
            this.Recherchetxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Recherchetxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Recherchetxt.TextChanged += new System.EventHandler(this.Recherchetxt_TextChanged);
            // 
            // DataFournisseur
            // 
            this.DataFournisseur.AllowUserToResizeColumns = false;
            this.DataFournisseur.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DataFournisseur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataFournisseur.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataFournisseur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataFournisseur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataFournisseur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataFournisseur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataFournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataFournisseur.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataFournisseur.EnableHeadersVisualStyles = false;
            this.DataFournisseur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DataFournisseur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataFournisseur.Location = new System.Drawing.Point(324, 12);
            this.DataFournisseur.Name = "DataFournisseur";
            this.DataFournisseur.ReadOnly = true;
            this.DataFournisseur.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataFournisseur.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataFournisseur.RowHeadersWidth = 51;
            this.DataFournisseur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataFournisseur.RowTemplate.Height = 24;
            this.DataFournisseur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataFournisseur.Size = new System.Drawing.Size(476, 426);
            this.DataFournisseur.Style = MetroFramework.MetroColorStyle.Silver;
            this.DataFournisseur.TabIndex = 11;
            this.DataFournisseur.DoubleClick += new System.EventHandler(this.DataFournisseur_DoubleClick);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.Recherchetxt);
            this.Controls.Add(this.DataFournisseur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataFournisseur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        public MetroFramework.Controls.MetroTextBox Nom;
        public MetroFramework.Controls.MetroTextBox PhoneFour;
        public System.Windows.Forms.Button AjouterNew;
        public MetroFramework.Controls.MetroTextBox Prénom;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTextBox Recherchetxt;
        public MetroFramework.Controls.MetroGrid DataFournisseur;
        public System.Windows.Forms.Button button1;
    }
}