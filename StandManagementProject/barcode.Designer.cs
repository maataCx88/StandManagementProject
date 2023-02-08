namespace StandManagementProject
{
    partial class barcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barcode));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonprint = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelcodebarre = new System.Windows.Forms.Label();
            this.CodeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.Codelabel = new System.Windows.Forms.Label();
            this.paneltop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.metroProdSansCode = new MetroFramework.Controls.MetroRadioButton();
            this.metroToutProduit = new MetroFramework.Controls.MetroRadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RechercheSansCode = new MetroFramework.Controls.MetroTextBox();
            this.labeltable = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ProduitSansCodeGrid = new MetroFramework.Controls.MetroGrid();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneltop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProduitSansCodeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonprint);
            this.panel1.Controls.Add(this.buttonadd);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelcodebarre);
            this.panel1.Controls.Add(this.CodeTextBox);
            this.panel1.Controls.Add(this.Codelabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 150);
            this.panel1.TabIndex = 4;
            // 
            // buttonprint
            // 
            this.buttonprint.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonprint.Enabled = false;
            this.buttonprint.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonprint.Location = new System.Drawing.Point(558, 96);
            this.buttonprint.Name = "buttonprint";
            this.buttonprint.Size = new System.Drawing.Size(203, 42);
            this.buttonprint.TabIndex = 7;
            this.buttonprint.Text = "Imprimer Reference";
            this.buttonprint.UseVisualStyleBackColor = true;
            this.buttonprint.Click += new System.EventHandler(this.buttonprint_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonadd.Enabled = false;
            this.buttonadd.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.Location = new System.Drawing.Point(558, 32);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(203, 42);
            this.buttonadd.TabIndex = 6;
            this.buttonadd.Text = "Ajouter Reference";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Location = new System.Drawing.Point(212, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelcodebarre
            // 
            this.labelcodebarre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelcodebarre.AutoSize = true;
            this.labelcodebarre.BackColor = System.Drawing.Color.Transparent;
            this.labelcodebarre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelcodebarre.Location = new System.Drawing.Point(307, 4);
            this.labelcodebarre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcodebarre.Name = "labelcodebarre";
            this.labelcodebarre.Size = new System.Drawing.Size(106, 25);
            this.labelcodebarre.TabIndex = 4;
            this.labelcodebarre.Text = "Code Barre";
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.CodeTextBox.CustomButton.Image = null;
            this.CodeTextBox.CustomButton.Location = new System.Drawing.Point(161, 2);
            this.CodeTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.CodeTextBox.CustomButton.Name = "";
            this.CodeTextBox.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.CodeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CodeTextBox.CustomButton.TabIndex = 1;
            this.CodeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CodeTextBox.CustomButton.UseSelectable = true;
            this.CodeTextBox.CustomButton.Visible = false;
            this.CodeTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.CodeTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.CodeTextBox.Lines = new string[0];
            this.CodeTextBox.Location = new System.Drawing.Point(30, 56);
            this.CodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CodeTextBox.MaxLength = 32767;
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.PasswordChar = '\0';
            this.CodeTextBox.ReadOnly = true;
            this.CodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CodeTextBox.SelectedText = "";
            this.CodeTextBox.SelectionLength = 0;
            this.CodeTextBox.SelectionStart = 0;
            this.CodeTextBox.ShortcutsEnabled = true;
            this.CodeTextBox.Size = new System.Drawing.Size(201, 42);
            this.CodeTextBox.TabIndex = 3;
            this.CodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CodeTextBox.UseSelectable = true;
            this.CodeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CodeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Codelabel
            // 
            this.Codelabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Codelabel.AutoSize = true;
            this.Codelabel.BackColor = System.Drawing.Color.Transparent;
            this.Codelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Codelabel.Location = new System.Drawing.Point(59, 27);
            this.Codelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Codelabel.Name = "Codelabel";
            this.Codelabel.Size = new System.Drawing.Size(146, 25);
            this.Codelabel.TabIndex = 2;
            this.Codelabel.Text = "Code Reference";
            // 
            // paneltop
            // 
            this.paneltop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paneltop.Controls.Add(this.panel3);
            this.paneltop.Controls.Add(this.labeltable);
            this.paneltop.Controls.Add(this.panel5);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(800, 128);
            this.paneltop.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(231, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 43);
            this.panel3.TabIndex = 21;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.metroProdSansCode);
            this.panel8.Controls.Add(this.metroToutProduit);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(-198, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel8.Size = new System.Drawing.Size(416, 43);
            this.panel8.TabIndex = 21;
            // 
            // metroProdSansCode
            // 
            this.metroProdSansCode.AutoSize = true;
            this.metroProdSansCode.BackColor = System.Drawing.Color.Transparent;
            this.metroProdSansCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroProdSansCode.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroProdSansCode.Location = new System.Drawing.Point(227, 12);
            this.metroProdSansCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroProdSansCode.Name = "metroProdSansCode";
            this.metroProdSansCode.Size = new System.Drawing.Size(174, 19);
            this.metroProdSansCode.TabIndex = 15;
            this.metroProdSansCode.Text = "Produit Sans Code Barre";
            this.metroProdSansCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroProdSansCode.UseCustomBackColor = true;
            this.metroProdSansCode.UseCustomForeColor = true;
            this.metroProdSansCode.UseSelectable = true;
            this.metroProdSansCode.CheckedChanged += new System.EventHandler(this.metroProdSansCode_CheckedChanged);
            // 
            // metroToutProduit
            // 
            this.metroToutProduit.AutoSize = true;
            this.metroToutProduit.BackColor = System.Drawing.Color.Transparent;
            this.metroToutProduit.Checked = true;
            this.metroToutProduit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroToutProduit.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.metroToutProduit.Location = new System.Drawing.Point(25, 12);
            this.metroToutProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroToutProduit.Name = "metroToutProduit";
            this.metroToutProduit.Size = new System.Drawing.Size(175, 19);
            this.metroToutProduit.TabIndex = 16;
            this.metroToutProduit.TabStop = true;
            this.metroToutProduit.Text = "Produit Avec Code Barre";
            this.metroToutProduit.UseCustomBackColor = true;
            this.metroToutProduit.UseCustomForeColor = true;
            this.metroToutProduit.UseSelectable = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.RechercheSansCode);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(218, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel4.Size = new System.Drawing.Size(351, 43);
            this.panel4.TabIndex = 19;
            // 
            // RechercheSansCode
            // 
            // 
            // 
            // 
            this.RechercheSansCode.CustomButton.Image = null;
            this.RechercheSansCode.CustomButton.Location = new System.Drawing.Point(299, 1);
            this.RechercheSansCode.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.RechercheSansCode.CustomButton.Name = "";
            this.RechercheSansCode.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.RechercheSansCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RechercheSansCode.CustomButton.TabIndex = 1;
            this.RechercheSansCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RechercheSansCode.CustomButton.UseSelectable = true;
            this.RechercheSansCode.CustomButton.Visible = false;
            this.RechercheSansCode.DisplayIcon = true;
            this.RechercheSansCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RechercheSansCode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.RechercheSansCode.IconRight = true;
            this.RechercheSansCode.Lines = new string[0];
            this.RechercheSansCode.Location = new System.Drawing.Point(10, 0);
            this.RechercheSansCode.Margin = new System.Windows.Forms.Padding(4);
            this.RechercheSansCode.MaxLength = 50;
            this.RechercheSansCode.Name = "RechercheSansCode";
            this.RechercheSansCode.PasswordChar = '\0';
            this.RechercheSansCode.PromptText = "Rechercher Par  Désignation ...";
            this.RechercheSansCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RechercheSansCode.SelectedText = "";
            this.RechercheSansCode.SelectionLength = 0;
            this.RechercheSansCode.SelectionStart = 0;
            this.RechercheSansCode.ShortcutsEnabled = true;
            this.RechercheSansCode.Size = new System.Drawing.Size(341, 43);
            this.RechercheSansCode.TabIndex = 1;
            this.RechercheSansCode.UseSelectable = true;
            this.RechercheSansCode.WaterMark = "Rechercher Par  Désignation ...";
            this.RechercheSansCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RechercheSansCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RechercheSansCode.TextChanged += new System.EventHandler(this.RechercheSansCode_TextChanged);
            // 
            // labeltable
            // 
            this.labeltable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labeltable.AutoSize = true;
            this.labeltable.BackColor = System.Drawing.Color.Transparent;
            this.labeltable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labeltable.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.labeltable.ForeColor = System.Drawing.Color.Black;
            this.labeltable.Location = new System.Drawing.Point(494, 1);
            this.labeltable.Name = "labeltable";
            this.labeltable.Size = new System.Drawing.Size(303, 37);
            this.labeltable.TabIndex = 20;
            this.labeltable.Text = "Generateur Codebarre";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(231, 128);
            this.panel5.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::StandManagementProject.Properties.Resources.barcode_512px5;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.ProduitSansCodeGrid);
            this.panel2.Controls.Add(this.vScrollBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 130, 0, 0);
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 5;
            // 
            // ProduitSansCodeGrid
            // 
            this.ProduitSansCodeGrid.AllowUserToAddRows = false;
            this.ProduitSansCodeGrid.AllowUserToDeleteRows = false;
            this.ProduitSansCodeGrid.AllowUserToOrderColumns = true;
            this.ProduitSansCodeGrid.AllowUserToResizeRows = false;
            this.ProduitSansCodeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProduitSansCodeGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ProduitSansCodeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProduitSansCodeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProduitSansCodeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProduitSansCodeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProduitSansCodeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProduitSansCodeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProduitSansCodeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProduitSansCodeGrid.EnableHeadersVisualStyles = false;
            this.ProduitSansCodeGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ProduitSansCodeGrid.GridColor = System.Drawing.Color.Gainsboro;
            this.ProduitSansCodeGrid.Location = new System.Drawing.Point(0, 130);
            this.ProduitSansCodeGrid.Margin = new System.Windows.Forms.Padding(2);
            this.ProduitSansCodeGrid.MultiSelect = false;
            this.ProduitSansCodeGrid.Name = "ProduitSansCodeGrid";
            this.ProduitSansCodeGrid.ReadOnly = true;
            this.ProduitSansCodeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProduitSansCodeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProduitSansCodeGrid.RowHeadersWidth = 51;
            this.ProduitSansCodeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ProduitSansCodeGrid.RowTemplate.Height = 35;
            this.ProduitSansCodeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProduitSansCodeGrid.Size = new System.Drawing.Size(800, 220);
            this.ProduitSansCodeGrid.TabIndex = 18;
            this.ProduitSansCodeGrid.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ProduitSansCodeGrid_Scroll);
            this.ProduitSansCodeGrid.Click += new System.EventHandler(this.ProduitSansCodeGrid_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(746, 169);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(72, 30);
            this.vScrollBar1.TabIndex = 17;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.paneltop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "barcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "barcode";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProduitSansCodeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonprint;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelcodebarre;
        private MetroFramework.Controls.MetroTextBox CodeTextBox;
        private System.Windows.Forms.Label Codelabel;
        private System.Windows.Forms.Panel paneltop;
        private MetroFramework.Controls.MetroRadioButton metroToutProduit;
        private MetroFramework.Controls.MetroRadioButton metroProdSansCode;
        private MetroFramework.Controls.MetroTextBox RechercheSansCode;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private MetroFramework.Controls.MetroGrid ProduitSansCodeGrid;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labeltable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
    }
}