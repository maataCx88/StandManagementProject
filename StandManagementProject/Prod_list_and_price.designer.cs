namespace StandManagementProject
{
    partial class Prod_list_and_price
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prod_list_and_price));
            this.ProduitSansCodeGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.RechercheSansCode = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ProduitSansCodeGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProduitSansCodeGrid
            // 
            this.ProduitSansCodeGrid.AllowUserToAddRows = false;
            this.ProduitSansCodeGrid.AllowUserToDeleteRows = false;
            this.ProduitSansCodeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProduitSansCodeGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProduitSansCodeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProduitSansCodeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProduitSansCodeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProduitSansCodeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProduitSansCodeGrid.Location = new System.Drawing.Point(0, 0);
            this.ProduitSansCodeGrid.Name = "ProduitSansCodeGrid";
            this.ProduitSansCodeGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProduitSansCodeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProduitSansCodeGrid.RowHeadersWidth = 51;
            this.ProduitSansCodeGrid.RowTemplate.Height = 30;
            this.ProduitSansCodeGrid.Size = new System.Drawing.Size(900, 531);
            this.ProduitSansCodeGrid.TabIndex = 11;
            this.ProduitSansCodeGrid.DoubleClick += new System.EventHandler(this.ProduitSansCodeGrid_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.RechercheSansCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 38);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "F2 : Ajouter Nouveau produit";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(52)))), ((int)(((byte)(169)))));
            this.button1.HoverState.Parent = this.button1;
            this.button1.IconColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(854, 0);
            this.button1.Name = "button1";
            this.button1.ShadowDecoration.Parent = this.button1;
            this.button1.Size = new System.Drawing.Size(46, 38);
            this.button1.TabIndex = 13;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RechercheSansCode
            // 
            // 
            // 
            // 
            this.RechercheSansCode.CustomButton.Image = null;
            this.RechercheSansCode.CustomButton.Location = new System.Drawing.Point(310, 2);
            this.RechercheSansCode.CustomButton.Name = "";
            this.RechercheSansCode.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.RechercheSansCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RechercheSansCode.CustomButton.TabIndex = 1;
            this.RechercheSansCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RechercheSansCode.CustomButton.UseSelectable = true;
            this.RechercheSansCode.CustomButton.Visible = false;
            this.RechercheSansCode.DisplayIcon = true;
            this.RechercheSansCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.RechercheSansCode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.RechercheSansCode.Icon = global::StandManagementProject.Properties.Resources.google_web_search_208px;
            this.RechercheSansCode.IconRight = true;
            this.RechercheSansCode.Lines = new string[0];
            this.RechercheSansCode.Location = new System.Drawing.Point(0, 0);
            this.RechercheSansCode.MaxLength = 50;
            this.RechercheSansCode.Name = "RechercheSansCode";
            this.RechercheSansCode.PasswordChar = '\0';
            this.RechercheSansCode.PromptText = "Rechercher Par  Désignation ...";
            this.RechercheSansCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RechercheSansCode.SelectedText = "";
            this.RechercheSansCode.SelectionLength = 0;
            this.RechercheSansCode.SelectionStart = 0;
            this.RechercheSansCode.ShortcutsEnabled = true;
            this.RechercheSansCode.Size = new System.Drawing.Size(346, 38);
            this.RechercheSansCode.TabIndex = 12;
            this.RechercheSansCode.UseSelectable = true;
            this.RechercheSansCode.WaterMark = "Rechercher Par  Désignation ...";
            this.RechercheSansCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RechercheSansCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RechercheSansCode.TextChanged += new System.EventHandler(this.RechercheSansCode_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProduitSansCodeGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 531);
            this.panel2.TabIndex = 14;
            // 
            // Prod_list_and_price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 569);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Prod_list_and_price";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des Article";
            ((System.ComponentModel.ISupportInitialize)(this.ProduitSansCodeGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox RechercheSansCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ControlBox button1;
        private System.Windows.Forms.DataGridView ProduitSansCodeGrid;
        private System.Windows.Forms.Label label1;
    }
}