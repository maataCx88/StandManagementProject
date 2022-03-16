namespace StandManagementProject
{
    partial class Dashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelclients = new System.Windows.Forms.Panel();
            this.labelclientsnumber = new System.Windows.Forms.Label();
            this.pictureBoxclients = new System.Windows.Forms.PictureBox();
            this.labelclients = new System.Windows.Forms.Label();
            this.panelworkers = new System.Windows.Forms.Panel();
            this.labelworkersnumber = new System.Windows.Forms.Label();
            this.pictureBoxworkers = new System.Windows.Forms.PictureBox();
            this.labelworkers = new System.Windows.Forms.Label();
            this.panelclientsbill = new System.Windows.Forms.Panel();
            this.labelclientsbillnumber = new System.Windows.Forms.Label();
            this.pictureBoxclientsbill = new System.Windows.Forms.PictureBox();
            this.labelclientsbill = new System.Windows.Forms.Label();
            this.panelfournisseurbill = new System.Windows.Forms.Panel();
            this.labelfournisseurbillnumber = new System.Windows.Forms.Label();
            this.pictureBoxfournisseurbill = new System.Windows.Forms.PictureBox();
            this.labelfournisseurbill = new System.Windows.Forms.Label();
            this.panelproductsbuy = new System.Windows.Forms.Panel();
            this.labelproductsbuynumber = new System.Windows.Forms.Label();
            this.pictureBoxproductsbuy = new System.Windows.Forms.PictureBox();
            this.labelproductsbuy = new System.Windows.Forms.Label();
            this.panelproductssell = new System.Windows.Forms.Panel();
            this.labelproductssellnumber = new System.Windows.Forms.Label();
            this.pictureBoxproductssell = new System.Windows.Forms.PictureBox();
            this.labelproductssell = new System.Windows.Forms.Label();
            this.panelmain1 = new System.Windows.Forms.Panel();
            this.panelmain2 = new System.Windows.Forms.Panel();
            this.labeldate = new System.Windows.Forms.Label();
            this.labeltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelmain3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelclients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclients)).BeginInit();
            this.panelworkers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxworkers)).BeginInit();
            this.panelclientsbill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclientsbill)).BeginInit();
            this.panelfournisseurbill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfournisseurbill)).BeginInit();
            this.panelproductsbuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproductsbuy)).BeginInit();
            this.panelproductssell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproductssell)).BeginInit();
            this.panelmain1.SuspendLayout();
            this.panelmain2.SuspendLayout();
            this.panelmain3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelclients
            // 
            this.panelclients.BackColor = System.Drawing.Color.White;
            this.panelclients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelclients.Controls.Add(this.labelclientsnumber);
            this.panelclients.Controls.Add(this.pictureBoxclients);
            this.panelclients.Controls.Add(this.labelclients);
            this.panelclients.Location = new System.Drawing.Point(45, 50);
            this.panelclients.Name = "panelclients";
            this.panelclients.Size = new System.Drawing.Size(150, 200);
            this.panelclients.TabIndex = 0;
            // 
            // labelclientsnumber
            // 
            this.labelclientsnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelclientsnumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelclientsnumber.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclientsnumber.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelclientsnumber.Location = new System.Drawing.Point(0, 145);
            this.labelclientsnumber.Name = "labelclientsnumber";
            this.labelclientsnumber.Size = new System.Drawing.Size(148, 53);
            this.labelclientsnumber.TabIndex = 2;
            this.labelclientsnumber.Text = "0";
            this.labelclientsnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxclients
            // 
            this.pictureBoxclients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxclients.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxclients.Image = global::StandManagementProject.Properties.Resources.icons8_team_64;
            this.pictureBoxclients.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxclients.Name = "pictureBoxclients";
            this.pictureBoxclients.Size = new System.Drawing.Size(148, 120);
            this.pictureBoxclients.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxclients.TabIndex = 1;
            this.pictureBoxclients.TabStop = false;
            // 
            // labelclients
            // 
            this.labelclients.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelclients.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelclients.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclients.ForeColor = System.Drawing.Color.White;
            this.labelclients.Location = new System.Drawing.Point(0, 0);
            this.labelclients.Name = "labelclients";
            this.labelclients.Size = new System.Drawing.Size(148, 25);
            this.labelclients.TabIndex = 0;
            this.labelclients.Text = "CLIENTS";
            this.labelclients.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelworkers
            // 
            this.panelworkers.BackColor = System.Drawing.Color.White;
            this.panelworkers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelworkers.Controls.Add(this.labelworkersnumber);
            this.panelworkers.Controls.Add(this.pictureBoxworkers);
            this.panelworkers.Controls.Add(this.labelworkers);
            this.panelworkers.Location = new System.Drawing.Point(240, 50);
            this.panelworkers.Name = "panelworkers";
            this.panelworkers.Size = new System.Drawing.Size(150, 200);
            this.panelworkers.TabIndex = 1;
            // 
            // labelworkersnumber
            // 
            this.labelworkersnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelworkersnumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelworkersnumber.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelworkersnumber.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelworkersnumber.Location = new System.Drawing.Point(0, 145);
            this.labelworkersnumber.Name = "labelworkersnumber";
            this.labelworkersnumber.Size = new System.Drawing.Size(148, 53);
            this.labelworkersnumber.TabIndex = 2;
            this.labelworkersnumber.Text = "0";
            this.labelworkersnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxworkers
            // 
            this.pictureBoxworkers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxworkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxworkers.Image = global::StandManagementProject.Properties.Resources.icons8_name_tag_64;
            this.pictureBoxworkers.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxworkers.Name = "pictureBoxworkers";
            this.pictureBoxworkers.Size = new System.Drawing.Size(148, 120);
            this.pictureBoxworkers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxworkers.TabIndex = 1;
            this.pictureBoxworkers.TabStop = false;
            // 
            // labelworkers
            // 
            this.labelworkers.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelworkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelworkers.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelworkers.ForeColor = System.Drawing.Color.White;
            this.labelworkers.Location = new System.Drawing.Point(0, 0);
            this.labelworkers.Name = "labelworkers";
            this.labelworkers.Size = new System.Drawing.Size(148, 25);
            this.labelworkers.TabIndex = 0;
            this.labelworkers.Text = "EMPLOYES";
            this.labelworkers.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelclientsbill
            // 
            this.panelclientsbill.BackColor = System.Drawing.Color.White;
            this.panelclientsbill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelclientsbill.Controls.Add(this.labelclientsbillnumber);
            this.panelclientsbill.Controls.Add(this.pictureBoxclientsbill);
            this.panelclientsbill.Controls.Add(this.labelclientsbill);
            this.panelclientsbill.Location = new System.Drawing.Point(435, 50);
            this.panelclientsbill.Name = "panelclientsbill";
            this.panelclientsbill.Size = new System.Drawing.Size(150, 200);
            this.panelclientsbill.TabIndex = 2;
            // 
            // labelclientsbillnumber
            // 
            this.labelclientsbillnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelclientsbillnumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelclientsbillnumber.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclientsbillnumber.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelclientsbillnumber.Location = new System.Drawing.Point(0, 145);
            this.labelclientsbillnumber.Name = "labelclientsbillnumber";
            this.labelclientsbillnumber.Size = new System.Drawing.Size(148, 53);
            this.labelclientsbillnumber.TabIndex = 2;
            this.labelclientsbillnumber.Text = "0";
            this.labelclientsbillnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxclientsbill
            // 
            this.pictureBoxclientsbill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxclientsbill.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxclientsbill.Image = global::StandManagementProject.Properties.Resources.icons8_bill_64;
            this.pictureBoxclientsbill.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxclientsbill.Name = "pictureBoxclientsbill";
            this.pictureBoxclientsbill.Size = new System.Drawing.Size(148, 120);
            this.pictureBoxclientsbill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxclientsbill.TabIndex = 1;
            this.pictureBoxclientsbill.TabStop = false;
            // 
            // labelclientsbill
            // 
            this.labelclientsbill.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelclientsbill.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelclientsbill.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelclientsbill.ForeColor = System.Drawing.Color.White;
            this.labelclientsbill.Location = new System.Drawing.Point(0, 0);
            this.labelclientsbill.Name = "labelclientsbill";
            this.labelclientsbill.Size = new System.Drawing.Size(148, 25);
            this.labelclientsbill.TabIndex = 0;
            this.labelclientsbill.Text = "FACTURES C";
            this.labelclientsbill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelfournisseurbill
            // 
            this.panelfournisseurbill.BackColor = System.Drawing.Color.White;
            this.panelfournisseurbill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelfournisseurbill.Controls.Add(this.labelfournisseurbillnumber);
            this.panelfournisseurbill.Controls.Add(this.pictureBoxfournisseurbill);
            this.panelfournisseurbill.Controls.Add(this.labelfournisseurbill);
            this.panelfournisseurbill.Location = new System.Drawing.Point(630, 50);
            this.panelfournisseurbill.Name = "panelfournisseurbill";
            this.panelfournisseurbill.Size = new System.Drawing.Size(150, 200);
            this.panelfournisseurbill.TabIndex = 3;
            // 
            // labelfournisseurbillnumber
            // 
            this.labelfournisseurbillnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelfournisseurbillnumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelfournisseurbillnumber.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfournisseurbillnumber.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelfournisseurbillnumber.Location = new System.Drawing.Point(0, 145);
            this.labelfournisseurbillnumber.Name = "labelfournisseurbillnumber";
            this.labelfournisseurbillnumber.Size = new System.Drawing.Size(148, 53);
            this.labelfournisseurbillnumber.TabIndex = 2;
            this.labelfournisseurbillnumber.Text = "0";
            this.labelfournisseurbillnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxfournisseurbill
            // 
            this.pictureBoxfournisseurbill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxfournisseurbill.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxfournisseurbill.Image = global::StandManagementProject.Properties.Resources.icons8_bill_64;
            this.pictureBoxfournisseurbill.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxfournisseurbill.Name = "pictureBoxfournisseurbill";
            this.pictureBoxfournisseurbill.Size = new System.Drawing.Size(148, 120);
            this.pictureBoxfournisseurbill.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxfournisseurbill.TabIndex = 1;
            this.pictureBoxfournisseurbill.TabStop = false;
            // 
            // labelfournisseurbill
            // 
            this.labelfournisseurbill.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelfournisseurbill.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelfournisseurbill.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfournisseurbill.ForeColor = System.Drawing.Color.White;
            this.labelfournisseurbill.Location = new System.Drawing.Point(0, 0);
            this.labelfournisseurbill.Name = "labelfournisseurbill";
            this.labelfournisseurbill.Size = new System.Drawing.Size(148, 25);
            this.labelfournisseurbill.TabIndex = 0;
            this.labelfournisseurbill.Text = "FACTURES F";
            this.labelfournisseurbill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelproductsbuy
            // 
            this.panelproductsbuy.BackColor = System.Drawing.Color.White;
            this.panelproductsbuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelproductsbuy.Controls.Add(this.labelproductsbuynumber);
            this.panelproductsbuy.Controls.Add(this.pictureBoxproductsbuy);
            this.panelproductsbuy.Controls.Add(this.labelproductsbuy);
            this.panelproductsbuy.Location = new System.Drawing.Point(825, 50);
            this.panelproductsbuy.Name = "panelproductsbuy";
            this.panelproductsbuy.Size = new System.Drawing.Size(150, 200);
            this.panelproductsbuy.TabIndex = 4;
            // 
            // labelproductsbuynumber
            // 
            this.labelproductsbuynumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelproductsbuynumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelproductsbuynumber.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductsbuynumber.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelproductsbuynumber.Location = new System.Drawing.Point(0, 145);
            this.labelproductsbuynumber.Name = "labelproductsbuynumber";
            this.labelproductsbuynumber.Size = new System.Drawing.Size(148, 53);
            this.labelproductsbuynumber.TabIndex = 2;
            this.labelproductsbuynumber.Text = "0";
            this.labelproductsbuynumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxproductsbuy
            // 
            this.pictureBoxproductsbuy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxproductsbuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxproductsbuy.Image = global::StandManagementProject.Properties.Resources.icons8_product_main_64;
            this.pictureBoxproductsbuy.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxproductsbuy.Name = "pictureBoxproductsbuy";
            this.pictureBoxproductsbuy.Size = new System.Drawing.Size(148, 120);
            this.pictureBoxproductsbuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxproductsbuy.TabIndex = 1;
            this.pictureBoxproductsbuy.TabStop = false;
            // 
            // labelproductsbuy
            // 
            this.labelproductsbuy.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelproductsbuy.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelproductsbuy.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductsbuy.ForeColor = System.Drawing.Color.White;
            this.labelproductsbuy.Location = new System.Drawing.Point(0, 0);
            this.labelproductsbuy.Name = "labelproductsbuy";
            this.labelproductsbuy.Size = new System.Drawing.Size(148, 25);
            this.labelproductsbuy.TabIndex = 0;
            this.labelproductsbuy.Text = "PRODUITS AC";
            this.labelproductsbuy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelproductssell
            // 
            this.panelproductssell.BackColor = System.Drawing.Color.White;
            this.panelproductssell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelproductssell.Controls.Add(this.labelproductssellnumber);
            this.panelproductssell.Controls.Add(this.pictureBoxproductssell);
            this.panelproductssell.Controls.Add(this.labelproductssell);
            this.panelproductssell.Location = new System.Drawing.Point(1020, 50);
            this.panelproductssell.Name = "panelproductssell";
            this.panelproductssell.Size = new System.Drawing.Size(150, 200);
            this.panelproductssell.TabIndex = 5;
            // 
            // labelproductssellnumber
            // 
            this.labelproductssellnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelproductssellnumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelproductssellnumber.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductssellnumber.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelproductssellnumber.Location = new System.Drawing.Point(0, 145);
            this.labelproductssellnumber.Name = "labelproductssellnumber";
            this.labelproductssellnumber.Size = new System.Drawing.Size(148, 53);
            this.labelproductssellnumber.TabIndex = 2;
            this.labelproductssellnumber.Text = "0";
            this.labelproductssellnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxproductssell
            // 
            this.pictureBoxproductssell.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxproductssell.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxproductssell.Image = global::StandManagementProject.Properties.Resources.icons8_sell_stock_main_64;
            this.pictureBoxproductssell.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxproductssell.Name = "pictureBoxproductssell";
            this.pictureBoxproductssell.Size = new System.Drawing.Size(148, 120);
            this.pictureBoxproductssell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxproductssell.TabIndex = 1;
            this.pictureBoxproductssell.TabStop = false;
            // 
            // labelproductssell
            // 
            this.labelproductssell.BackColor = System.Drawing.Color.MidnightBlue;
            this.labelproductssell.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelproductssell.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductssell.ForeColor = System.Drawing.Color.White;
            this.labelproductssell.Location = new System.Drawing.Point(0, 0);
            this.labelproductssell.Name = "labelproductssell";
            this.labelproductssell.Size = new System.Drawing.Size(148, 25);
            this.labelproductssell.TabIndex = 0;
            this.labelproductssell.Text = "PRODUITS VT";
            this.labelproductssell.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelmain1
            // 
            this.panelmain1.Controls.Add(this.panelclients);
            this.panelmain1.Controls.Add(this.panelproductssell);
            this.panelmain1.Controls.Add(this.panelworkers);
            this.panelmain1.Controls.Add(this.panelproductsbuy);
            this.panelmain1.Controls.Add(this.panelclientsbill);
            this.panelmain1.Controls.Add(this.panelfournisseurbill);
            this.panelmain1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelmain1.Location = new System.Drawing.Point(0, 0);
            this.panelmain1.Name = "panelmain1";
            this.panelmain1.Size = new System.Drawing.Size(1215, 300);
            this.panelmain1.TabIndex = 6;
            // 
            // panelmain2
            // 
            this.panelmain2.Controls.Add(this.labeldate);
            this.panelmain2.Controls.Add(this.labeltime);
            this.panelmain2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelmain2.Location = new System.Drawing.Point(615, 300);
            this.panelmain2.Name = "panelmain2";
            this.panelmain2.Size = new System.Drawing.Size(600, 308);
            this.panelmain2.TabIndex = 7;
            // 
            // labeldate
            // 
            this.labeldate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldate.ForeColor = System.Drawing.Color.SlateGray;
            this.labeldate.Location = new System.Drawing.Point(0, 154);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(600, 154);
            this.labeldate.TabIndex = 1;
            this.labeldate.Text = "label2";
            this.labeldate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labeltime
            // 
            this.labeltime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labeltime.Location = new System.Drawing.Point(0, 0);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(600, 154);
            this.labeltime.TabIndex = 0;
            this.labeltime.Text = "label1";
            this.labeltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelmain3
            // 
            this.panelmain3.Controls.Add(this.chart1);
            this.panelmain3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelmain3.Location = new System.Drawing.Point(0, 300);
            this.panelmain3.Name = "panelmain3";
            this.panelmain3.Size = new System.Drawing.Size(615, 308);
            this.panelmain3.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.MidnightBlue;
            series1.Legend = "Legend1";
            series1.Name = "NUMBER";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(615, 308);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "PRODUITS VENDUS";
            this.chart1.Titles.Add(title1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 608);
            this.Controls.Add(this.panelmain3);
            this.Controls.Add(this.panelmain2);
            this.Controls.Add(this.panelmain1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Dashboard";
            this.panelclients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclients)).EndInit();
            this.panelworkers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxworkers)).EndInit();
            this.panelclientsbill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxclientsbill)).EndInit();
            this.panelfournisseurbill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfournisseurbill)).EndInit();
            this.panelproductsbuy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproductsbuy)).EndInit();
            this.panelproductssell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxproductssell)).EndInit();
            this.panelmain1.ResumeLayout(false);
            this.panelmain2.ResumeLayout(false);
            this.panelmain3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelclients;
        private System.Windows.Forms.Label labelclientsnumber;
        private System.Windows.Forms.PictureBox pictureBoxclients;
        private System.Windows.Forms.Label labelclients;
        private System.Windows.Forms.Panel panelworkers;
        private System.Windows.Forms.Label labelworkersnumber;
        private System.Windows.Forms.PictureBox pictureBoxworkers;
        private System.Windows.Forms.Label labelworkers;
        private System.Windows.Forms.Panel panelclientsbill;
        private System.Windows.Forms.Label labelclientsbillnumber;
        private System.Windows.Forms.PictureBox pictureBoxclientsbill;
        private System.Windows.Forms.Label labelclientsbill;
        private System.Windows.Forms.Panel panelfournisseurbill;
        private System.Windows.Forms.Label labelfournisseurbillnumber;
        private System.Windows.Forms.PictureBox pictureBoxfournisseurbill;
        private System.Windows.Forms.Label labelfournisseurbill;
        private System.Windows.Forms.Panel panelproductsbuy;
        private System.Windows.Forms.Label labelproductsbuynumber;
        private System.Windows.Forms.PictureBox pictureBoxproductsbuy;
        private System.Windows.Forms.Label labelproductsbuy;
        private System.Windows.Forms.Panel panelproductssell;
        private System.Windows.Forms.Label labelproductssellnumber;
        private System.Windows.Forms.PictureBox pictureBoxproductssell;
        private System.Windows.Forms.Label labelproductssell;
        private System.Windows.Forms.Panel panelmain1;
        private System.Windows.Forms.Panel panelmain2;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelmain3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}