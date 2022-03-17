
namespace StandManagementProject
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.closeprgrm = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labeldate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelfullname = new System.Windows.Forms.Label();
            this.pictureBoxuser = new System.Windows.Forms.PictureBox();
            this.pictureBoxlogo = new System.Windows.Forms.PictureBox();
            this.labelcompanyname = new System.Windows.Forms.Label();
            this.panelus = new System.Windows.Forms.Panel();
            this.panelbuttons = new System.Windows.Forms.Panel();
            this.buttonfees = new System.Windows.Forms.Button();
            this.buttonclient = new System.Windows.Forms.Button();
            this.buttonfournisseur = new System.Windows.Forms.Button();
            this.buttonworkers = new System.Windows.Forms.Button();
            this.buttonstock = new System.Windows.Forms.Button();
            this.buttonproduct = new System.Windows.Forms.Button();
            this.buttonbuy = new System.Windows.Forms.Button();
            this.buttonsale = new System.Windows.Forms.Button();
            this.buttonhome = new System.Windows.Forms.Button();
            this.panelmain = new System.Windows.Forms.Panel();
            this.panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeprgrm)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).BeginInit();
            this.panelbuttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.panelmenu.Controls.Add(this.closeprgrm);
            this.panelmenu.Controls.Add(this.tableLayoutPanel1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(1215, 50);
            this.panelmenu.TabIndex = 2;
            // 
            // closeprgrm
            // 
            this.closeprgrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeprgrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeprgrm.Image = ((System.Drawing.Image)(resources.GetObject("closeprgrm.Image")));
            this.closeprgrm.Location = new System.Drawing.Point(1182, 6);
            this.closeprgrm.Name = "closeprgrm";
            this.closeprgrm.Size = new System.Drawing.Size(30, 30);
            this.closeprgrm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeprgrm.TabIndex = 5;
            this.closeprgrm.TabStop = false;
            this.closeprgrm.Click += new System.EventHandler(this.closeprgrm_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.98326F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.6834F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.labeldate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelcompanyname, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-65, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1280, 50);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // labeldate
            // 
            this.labeldate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labeldate.AutoSize = true;
            this.labeldate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labeldate.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldate.ForeColor = System.Drawing.Color.White;
            this.labeldate.Location = new System.Drawing.Point(1032, 0);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(68, 32);
            this.labeldate.TabIndex = 11;
            this.labeldate.Text = "Date";
            this.labeldate.Click += new System.EventHandler(this.labeldate_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelfullname);
            this.panel2.Controls.Add(this.pictureBoxuser);
            this.panel2.Controls.Add(this.pictureBoxlogo);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 46);
            this.panel2.TabIndex = 12;
            // 
            // labelfullname
            // 
            this.labelfullname.AutoSize = true;
            this.labelfullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelfullname.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfullname.ForeColor = System.Drawing.Color.White;
            this.labelfullname.Location = new System.Drawing.Point(127, 8);
            this.labelfullname.Name = "labelfullname";
            this.labelfullname.Size = new System.Drawing.Size(112, 21);
            this.labelfullname.TabIndex = 9;
            this.labelfullname.Text = "Nom Pranom";
            // 
            // pictureBoxuser
            // 
            this.pictureBoxuser.Image = global::StandManagementProject.Properties.Resources.icons8_user_male_32;
            this.pictureBoxuser.Location = new System.Drawing.Point(104, 3);
            this.pictureBoxuser.Name = "pictureBoxuser";
            this.pictureBoxuser.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxuser.TabIndex = 8;
            this.pictureBoxuser.TabStop = false;
            // 
            // pictureBoxlogo
            // 
            this.pictureBoxlogo.Image = global::StandManagementProject.Properties.Resources._131486753_112111957417061_7269385043977104766_n;
            this.pictureBoxlogo.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxlogo.Name = "pictureBoxlogo";
            this.pictureBoxlogo.Size = new System.Drawing.Size(100, 38);
            this.pictureBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxlogo.TabIndex = 6;
            this.pictureBoxlogo.TabStop = false;
            // 
            // labelcompanyname
            // 
            this.labelcompanyname.AutoSize = true;
            this.labelcompanyname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelcompanyname.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcompanyname.ForeColor = System.Drawing.Color.White;
            this.labelcompanyname.Location = new System.Drawing.Point(463, 0);
            this.labelcompanyname.Name = "labelcompanyname";
            this.labelcompanyname.Size = new System.Drawing.Size(273, 32);
            this.labelcompanyname.TabIndex = 10;
            this.labelcompanyname.Text = "GYA AUTO Accessoires";
            // 
            // panelus
            // 
            this.panelus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelus.Location = new System.Drawing.Point(0, 708);
            this.panelus.Name = "panelus";
            this.panelus.Size = new System.Drawing.Size(1215, 40);
            this.panelus.TabIndex = 3;
            // 
            // panelbuttons
            // 
            this.panelbuttons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.panelbuttons.Controls.Add(this.buttonfees);
            this.panelbuttons.Controls.Add(this.buttonclient);
            this.panelbuttons.Controls.Add(this.buttonfournisseur);
            this.panelbuttons.Controls.Add(this.buttonworkers);
            this.panelbuttons.Controls.Add(this.buttonstock);
            this.panelbuttons.Controls.Add(this.buttonproduct);
            this.panelbuttons.Controls.Add(this.buttonbuy);
            this.panelbuttons.Controls.Add(this.buttonsale);
            this.panelbuttons.Controls.Add(this.buttonhome);
            this.panelbuttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelbuttons.Location = new System.Drawing.Point(0, 658);
            this.panelbuttons.Name = "panelbuttons";
            this.panelbuttons.Size = new System.Drawing.Size(1215, 50);
            this.panelbuttons.TabIndex = 4;
            // 
            // buttonfees
            // 
            this.buttonfees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonfees.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonfees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfees.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfees.ForeColor = System.Drawing.Color.White;
            this.buttonfees.Image = global::StandManagementProject.Properties.Resources.icons8_expensive_32;
            this.buttonfees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonfees.Location = new System.Drawing.Point(1126, 0);
            this.buttonfees.Name = "buttonfees";
            this.buttonfees.Size = new System.Drawing.Size(154, 50);
            this.buttonfees.TabIndex = 9;
            this.buttonfees.Text = "   Frais";
            this.buttonfees.UseVisualStyleBackColor = true;
            // 
            // buttonclient
            // 
            this.buttonclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonclient.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonclient.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclient.ForeColor = System.Drawing.Color.White;
            this.buttonclient.Image = global::StandManagementProject.Properties.Resources.icons8_client_management_32;
            this.buttonclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonclient.Location = new System.Drawing.Point(972, 0);
            this.buttonclient.Name = "buttonclient";
            this.buttonclient.Size = new System.Drawing.Size(154, 50);
            this.buttonclient.TabIndex = 8;
            this.buttonclient.Text = "   Client";
            this.buttonclient.UseVisualStyleBackColor = true;
            // 
            // buttonfournisseur
            // 
            this.buttonfournisseur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonfournisseur.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonfournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonfournisseur.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonfournisseur.ForeColor = System.Drawing.Color.White;
            this.buttonfournisseur.Image = global::StandManagementProject.Properties.Resources.icons8_user_groups_32;
            this.buttonfournisseur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonfournisseur.Location = new System.Drawing.Point(815, 0);
            this.buttonfournisseur.Name = "buttonfournisseur";
            this.buttonfournisseur.Size = new System.Drawing.Size(157, 50);
            this.buttonfournisseur.TabIndex = 7;
            this.buttonfournisseur.Text = "      Fournisseur";
            this.buttonfournisseur.UseVisualStyleBackColor = true;
            // 
            // buttonworkers
            // 
            this.buttonworkers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonworkers.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonworkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonworkers.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonworkers.ForeColor = System.Drawing.Color.White;
            this.buttonworkers.Image = global::StandManagementProject.Properties.Resources.icons8_user_groups_32;
            this.buttonworkers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonworkers.Location = new System.Drawing.Point(661, 0);
            this.buttonworkers.Name = "buttonworkers";
            this.buttonworkers.Size = new System.Drawing.Size(154, 50);
            this.buttonworkers.TabIndex = 6;
            this.buttonworkers.Text = "      Employee";
            this.buttonworkers.UseVisualStyleBackColor = true;
            // 
            // buttonstock
            // 
            this.buttonstock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonstock.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonstock.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonstock.ForeColor = System.Drawing.Color.White;
            this.buttonstock.Image = global::StandManagementProject.Properties.Resources.icons8_warehouse_32;
            this.buttonstock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonstock.Location = new System.Drawing.Point(507, 0);
            this.buttonstock.Name = "buttonstock";
            this.buttonstock.Size = new System.Drawing.Size(154, 50);
            this.buttonstock.TabIndex = 5;
            this.buttonstock.Text = "   Stock";
            this.buttonstock.UseVisualStyleBackColor = true;
            // 
            // buttonproduct
            // 
            this.buttonproduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonproduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonproduct.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonproduct.ForeColor = System.Drawing.Color.White;
            this.buttonproduct.Image = global::StandManagementProject.Properties.Resources.icons8_product_32;
            this.buttonproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonproduct.Location = new System.Drawing.Point(353, 0);
            this.buttonproduct.Name = "buttonproduct";
            this.buttonproduct.Size = new System.Drawing.Size(154, 50);
            this.buttonproduct.TabIndex = 4;
            this.buttonproduct.Text = "   Produit";
            this.buttonproduct.UseVisualStyleBackColor = true;
            // 
            // buttonbuy
            // 
            this.buttonbuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonbuy.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonbuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonbuy.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbuy.ForeColor = System.Drawing.Color.White;
            this.buttonbuy.Image = global::StandManagementProject.Properties.Resources.icons8_buy_32;
            this.buttonbuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonbuy.Location = new System.Drawing.Point(199, 0);
            this.buttonbuy.Name = "buttonbuy";
            this.buttonbuy.Size = new System.Drawing.Size(154, 50);
            this.buttonbuy.TabIndex = 3;
            this.buttonbuy.Text = "   Achat";
            this.buttonbuy.UseVisualStyleBackColor = true;
            // 
            // buttonsale
            // 
            this.buttonsale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonsale.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonsale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsale.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsale.ForeColor = System.Drawing.Color.White;
            this.buttonsale.Image = global::StandManagementProject.Properties.Resources.icons8_sell_stock_321;
            this.buttonsale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsale.Location = new System.Drawing.Point(45, 0);
            this.buttonsale.Name = "buttonsale";
            this.buttonsale.Size = new System.Drawing.Size(154, 50);
            this.buttonsale.TabIndex = 2;
            this.buttonsale.Text = "   Vente";
            this.buttonsale.UseVisualStyleBackColor = true;
            // 
            // buttonhome
            // 
            this.buttonhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonhome.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonhome.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonhome.ForeColor = System.Drawing.Color.White;
            this.buttonhome.Image = global::StandManagementProject.Properties.Resources.icons8_home_321;
            this.buttonhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonhome.Location = new System.Drawing.Point(0, 0);
            this.buttonhome.Name = "buttonhome";
            this.buttonhome.Size = new System.Drawing.Size(45, 50);
            this.buttonhome.TabIndex = 1;
            this.buttonhome.UseVisualStyleBackColor = true;
            // 
            // panelmain
            // 
            this.panelmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain.Location = new System.Drawing.Point(0, 50);
            this.panelmain.Name = "panelmain";
            this.panelmain.Size = new System.Drawing.Size(1215, 608);
            this.panelmain.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 748);
            this.Controls.Add(this.panelmain);
            this.Controls.Add(this.panelbuttons);
            this.Controls.Add(this.panelus);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeprgrm)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxlogo)).EndInit();
            this.panelbuttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.PictureBox closeprgrm;
        private System.Windows.Forms.PictureBox pictureBoxlogo;
        private System.Windows.Forms.PictureBox pictureBoxuser;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labelcompanyname;
        private System.Windows.Forms.Label labelfullname;
        private System.Windows.Forms.Panel panelus;
        private System.Windows.Forms.Panel panelbuttons;
        private System.Windows.Forms.Panel panelmain;
        private System.Windows.Forms.Button buttonhome;
        private System.Windows.Forms.Button buttonsale;
        private System.Windows.Forms.Button buttonbuy;
        private System.Windows.Forms.Button buttonproduct;
        private System.Windows.Forms.Button buttonstock;
        private System.Windows.Forms.Button buttonworkers;
        private System.Windows.Forms.Button buttonclient;
        private System.Windows.Forms.Button buttonfournisseur;
        private System.Windows.Forms.Button buttonfees;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}