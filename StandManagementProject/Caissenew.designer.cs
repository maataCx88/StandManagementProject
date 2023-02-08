
namespace StandManagementProject
{
    partial class Caissenew
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxpar = new MetroFramework.Controls.MetroComboBox();
            this.paneltop = new System.Windows.Forms.Panel();
            this.metroDateTimestartdate = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTimefinishdate = new MetroFramework.Controls.MetroDateTime();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelfill = new System.Windows.Forms.Panel();
            this.NoCode = new Guna.UI2.WinForms.Guna2Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelmarge = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelbeneficesnet = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panelbenefice = new System.Windows.Forms.Panel();
            this.labelbenefices = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.paneltotal = new System.Windows.Forms.Panel();
            this.labeltotal = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panelfacturefournisseur = new System.Windows.Forms.Panel();
            this.labeldettesfournisseur = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panelfactureclient = new System.Windows.Forms.Panel();
            this.labeldettesclient = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panelverse = new System.Windows.Forms.Panel();
            this.labelfacturefournisseur = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.paneldettesfournisseur = new System.Windows.Forms.Panel();
            this.labelfactureclient = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.paneldetteclient = new System.Windows.Forms.Panel();
            this.labelverse = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelcharges = new System.Windows.Forms.Panel();
            this.labelcharges = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelmarch = new System.Windows.Forms.Panel();
            this.labelmarch = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelcaisse = new System.Windows.Forms.Panel();
            this.labelcaisse = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.paneltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelfill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelbenefice.SuspendLayout();
            this.paneltotal.SuspendLayout();
            this.panelfacturefournisseur.SuspendLayout();
            this.panelfactureclient.SuspendLayout();
            this.panelverse.SuspendLayout();
            this.paneldettesfournisseur.SuspendLayout();
            this.paneldetteclient.SuspendLayout();
            this.panelcharges.SuspendLayout();
            this.panelmarch.SuspendLayout();
            this.panelcaisse.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Par:";
            // 
            // comboBoxpar
            // 
            this.comboBoxpar.FormattingEnabled = true;
            this.comboBoxpar.ItemHeight = 24;
            this.comboBoxpar.Items.AddRange(new object[] {
            "Journalier",
            "Mensuel",
            "Annuel"});
            this.comboBoxpar.Location = new System.Drawing.Point(104, 27);
            this.comboBoxpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxpar.Name = "comboBoxpar";
            this.comboBoxpar.Size = new System.Drawing.Size(199, 30);
            this.comboBoxpar.TabIndex = 1;
            this.comboBoxpar.UseSelectable = true;
            this.comboBoxpar.TextChanged += new System.EventHandler(this.comboBoxpar_TextChanged);
            // 
            // paneltop
            // 
            this.paneltop.Controls.Add(this.metroDateTimestartdate);
            this.paneltop.Controls.Add(this.metroDateTimefinishdate);
            this.paneltop.Controls.Add(this.pictureBox1);
            this.paneltop.Controls.Add(this.label3);
            this.paneltop.Controls.Add(this.label2);
            this.paneltop.Controls.Add(this.label1);
            this.paneltop.Controls.Add(this.comboBoxpar);
            this.paneltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltop.Location = new System.Drawing.Point(0, 0);
            this.paneltop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paneltop.Name = "paneltop";
            this.paneltop.Size = new System.Drawing.Size(1556, 84);
            this.paneltop.TabIndex = 2;
            // 
            // metroDateTimestartdate
            // 
            this.metroDateTimestartdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDateTimestartdate.Location = new System.Drawing.Point(769, 25);
            this.metroDateTimestartdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroDateTimestartdate.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTimestartdate.Name = "metroDateTimestartdate";
            this.metroDateTimestartdate.Size = new System.Drawing.Size(225, 30);
            this.metroDateTimestartdate.TabIndex = 8;
            // 
            // metroDateTimefinishdate
            // 
            this.metroDateTimefinishdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDateTimefinishdate.Location = new System.Drawing.Point(1177, 25);
            this.metroDateTimefinishdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroDateTimefinishdate.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTimefinishdate.Name = "metroDateTimefinishdate";
            this.metroDateTimefinishdate.Size = new System.Drawing.Size(225, 30);
            this.metroDateTimefinishdate.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::StandManagementProject.Properties.Resources.icons8_reset_64;
            this.pictureBox1.Location = new System.Drawing.Point(1447, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1015, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 46);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date fin:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date début:";
            // 
            // panelfill
            // 
            this.panelfill.Controls.Add(this.NoCode);
            this.panelfill.Controls.Add(this.chart1);
            this.panelfill.Controls.Add(this.panel2);
            this.panelfill.Controls.Add(this.panel1);
            this.panelfill.Controls.Add(this.panelbenefice);
            this.panelfill.Controls.Add(this.paneltotal);
            this.panelfill.Controls.Add(this.panelfacturefournisseur);
            this.panelfill.Controls.Add(this.panelfactureclient);
            this.panelfill.Controls.Add(this.panelverse);
            this.panelfill.Controls.Add(this.paneldettesfournisseur);
            this.panelfill.Controls.Add(this.paneldetteclient);
            this.panelfill.Controls.Add(this.panelcharges);
            this.panelfill.Controls.Add(this.panelmarch);
            this.panelfill.Controls.Add(this.panelcaisse);
            this.panelfill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelfill.Location = new System.Drawing.Point(0, 84);
            this.panelfill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelfill.Name = "panelfill";
            this.panelfill.Size = new System.Drawing.Size(1556, 800);
            this.panelfill.TabIndex = 3;
            // 
            // NoCode
            // 
            this.NoCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NoCode.BorderRadius = 7;
            this.NoCode.CheckedState.Parent = this.NoCode;
            this.NoCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NoCode.CustomImages.Image = global::StandManagementProject.Properties.Resources.icons8_more_details_48;
            this.NoCode.CustomImages.ImageSize = new System.Drawing.Size(35, 35);
            this.NoCode.CustomImages.Parent = this.NoCode;
            this.NoCode.FillColor = System.Drawing.Color.RoyalBlue;
            this.NoCode.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.NoCode.ForeColor = System.Drawing.Color.White;
            this.NoCode.HoverState.Parent = this.NoCode;
            this.NoCode.Location = new System.Drawing.Point(781, 725);
            this.NoCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NoCode.Name = "NoCode";
            this.NoCode.ShadowDecoration.Parent = this.NoCode;
            this.NoCode.Size = new System.Drawing.Size(755, 43);
            this.NoCode.TabIndex = 23;
            this.NoCode.Text = "Pour plus de détails cliquer ici";
            this.NoCode.Click += new System.EventHandler(this.NoCode_Click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(781, 395);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(755, 324);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Ventes des employés";
            title1.Text = "Ventes des employés";
            this.chart1.Titles.Add(title1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.labelmarge);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(400, 583);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 185);
            this.panel2.TabIndex = 20;
            // 
            // labelmarge
            // 
            this.labelmarge.AutoSize = true;
            this.labelmarge.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmarge.Location = new System.Drawing.Point(5, 63);
            this.labelmarge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmarge.Name = "labelmarge";
            this.labelmarge.Size = new System.Drawing.Size(122, 81);
            this.labelmarge.TabIndex = 2;
            this.labelmarge.Text = "0%";
            this.labelmarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 41);
            this.label6.TabIndex = 1;
            this.label6.Text = "Marge";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.labelbeneficesnet);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Location = new System.Drawing.Point(19, 583);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 185);
            this.panel1.TabIndex = 19;
            // 
            // labelbeneficesnet
            // 
            this.labelbeneficesnet.AutoSize = true;
            this.labelbeneficesnet.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbeneficesnet.Location = new System.Drawing.Point(5, 63);
            this.labelbeneficesnet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelbeneficesnet.Name = "labelbeneficesnet";
            this.labelbeneficesnet.Size = new System.Drawing.Size(70, 81);
            this.labelbeneficesnet.TabIndex = 2;
            this.labelbeneficesnet.Text = "0";
            this.labelbeneficesnet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label25.Location = new System.Drawing.Point(4, 4);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(204, 41);
            this.label25.TabIndex = 1;
            this.label25.Text = "Benefices NET";
            // 
            // panelbenefice
            // 
            this.panelbenefice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelbenefice.Controls.Add(this.labelbenefices);
            this.panelbenefice.Controls.Add(this.label21);
            this.panelbenefice.Location = new System.Drawing.Point(400, 391);
            this.panelbenefice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelbenefice.Name = "panelbenefice";
            this.panelbenefice.Size = new System.Drawing.Size(373, 185);
            this.panelbenefice.TabIndex = 18;
            // 
            // labelbenefices
            // 
            this.labelbenefices.AutoSize = true;
            this.labelbenefices.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbenefices.Location = new System.Drawing.Point(5, 63);
            this.labelbenefices.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelbenefices.Name = "labelbenefices";
            this.labelbenefices.Size = new System.Drawing.Size(70, 81);
            this.labelbenefices.TabIndex = 2;
            this.labelbenefices.Text = "0";
            this.labelbenefices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label21.Location = new System.Drawing.Point(4, 4);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(143, 41);
            this.label21.TabIndex = 1;
            this.label21.Text = "Benefices";
            // 
            // paneltotal
            // 
            this.paneltotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paneltotal.Controls.Add(this.labeltotal);
            this.paneltotal.Controls.Add(this.label23);
            this.paneltotal.Location = new System.Drawing.Point(19, 391);
            this.paneltotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paneltotal.Name = "paneltotal";
            this.paneltotal.Size = new System.Drawing.Size(373, 185);
            this.paneltotal.TabIndex = 17;
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotal.Location = new System.Drawing.Point(5, 63);
            this.labeltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(70, 81);
            this.labeltotal.TabIndex = 2;
            this.labeltotal.Text = "0";
            this.labeltotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label23.Location = new System.Drawing.Point(4, 4);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(180, 41);
            this.label23.TabIndex = 1;
            this.label23.Text = "Total facture";
            // 
            // panelfacturefournisseur
            // 
            this.panelfacturefournisseur.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelfacturefournisseur.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelfacturefournisseur.Controls.Add(this.labeldettesfournisseur);
            this.panelfacturefournisseur.Controls.Add(this.label7);
            this.panelfacturefournisseur.Location = new System.Drawing.Point(1163, 199);
            this.panelfacturefournisseur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelfacturefournisseur.Name = "panelfacturefournisseur";
            this.panelfacturefournisseur.Size = new System.Drawing.Size(373, 185);
            this.panelfacturefournisseur.TabIndex = 14;
            // 
            // labeldettesfournisseur
            // 
            this.labeldettesfournisseur.AutoSize = true;
            this.labeldettesfournisseur.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldettesfournisseur.Location = new System.Drawing.Point(5, 63);
            this.labeldettesfournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldettesfournisseur.Name = "labeldettesfournisseur";
            this.labeldettesfournisseur.Size = new System.Drawing.Size(70, 81);
            this.labeldettesfournisseur.TabIndex = 2;
            this.labeldettesfournisseur.Text = "0";
            this.labeldettesfournisseur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 41);
            this.label7.TabIndex = 1;
            this.label7.Text = "Dettes fournisseur";
            // 
            // panelfactureclient
            // 
            this.panelfactureclient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelfactureclient.Controls.Add(this.labeldettesclient);
            this.panelfactureclient.Controls.Add(this.label15);
            this.panelfactureclient.Location = new System.Drawing.Point(781, 199);
            this.panelfactureclient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelfactureclient.Name = "panelfactureclient";
            this.panelfactureclient.Size = new System.Drawing.Size(373, 185);
            this.panelfactureclient.TabIndex = 13;
            // 
            // labeldettesclient
            // 
            this.labeldettesclient.AutoSize = true;
            this.labeldettesclient.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldettesclient.Location = new System.Drawing.Point(5, 63);
            this.labeldettesclient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldettesclient.Name = "labeldettesclient";
            this.labeldettesclient.Size = new System.Drawing.Size(70, 81);
            this.labeldettesclient.TabIndex = 2;
            this.labeldettesclient.Text = "0";
            this.labeldettesclient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(4, 4);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(183, 41);
            this.label15.TabIndex = 1;
            this.label15.Text = "Dettes client";
            // 
            // panelverse
            // 
            this.panelverse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelverse.Controls.Add(this.labelfacturefournisseur);
            this.panelverse.Controls.Add(this.label17);
            this.panelverse.Location = new System.Drawing.Point(400, 199);
            this.panelverse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelverse.Name = "panelverse";
            this.panelverse.Size = new System.Drawing.Size(373, 185);
            this.panelverse.TabIndex = 12;
            // 
            // labelfacturefournisseur
            // 
            this.labelfacturefournisseur.AutoSize = true;
            this.labelfacturefournisseur.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfacturefournisseur.Location = new System.Drawing.Point(5, 63);
            this.labelfacturefournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfacturefournisseur.Name = "labelfacturefournisseur";
            this.labelfacturefournisseur.Size = new System.Drawing.Size(70, 81);
            this.labelfacturefournisseur.TabIndex = 2;
            this.labelfacturefournisseur.Text = "0";
            this.labelfacturefournisseur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(4, 4);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(269, 41);
            this.label17.TabIndex = 1;
            this.label17.Text = "Facture fournisseur";
            // 
            // paneldettesfournisseur
            // 
            this.paneldettesfournisseur.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paneldettesfournisseur.Controls.Add(this.labelfactureclient);
            this.paneldettesfournisseur.Controls.Add(this.label19);
            this.paneldettesfournisseur.Location = new System.Drawing.Point(19, 199);
            this.paneldettesfournisseur.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paneldettesfournisseur.Name = "paneldettesfournisseur";
            this.paneldettesfournisseur.Size = new System.Drawing.Size(373, 185);
            this.paneldettesfournisseur.TabIndex = 11;
            // 
            // labelfactureclient
            // 
            this.labelfactureclient.AutoSize = true;
            this.labelfactureclient.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfactureclient.Location = new System.Drawing.Point(5, 63);
            this.labelfactureclient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfactureclient.Name = "labelfactureclient";
            this.labelfactureclient.Size = new System.Drawing.Size(70, 81);
            this.labelfactureclient.TabIndex = 2;
            this.labelfactureclient.Text = "0";
            this.labelfactureclient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(4, 4);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(193, 41);
            this.label19.TabIndex = 1;
            this.label19.Text = "Facture client";
            // 
            // paneldetteclient
            // 
            this.paneldetteclient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneldetteclient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.paneldetteclient.Controls.Add(this.labelverse);
            this.paneldetteclient.Controls.Add(this.label13);
            this.paneldetteclient.Location = new System.Drawing.Point(1163, 7);
            this.paneldetteclient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.paneldetteclient.Name = "paneldetteclient";
            this.paneldetteclient.Size = new System.Drawing.Size(373, 185);
            this.paneldetteclient.TabIndex = 10;
            // 
            // labelverse
            // 
            this.labelverse.AutoSize = true;
            this.labelverse.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelverse.Location = new System.Drawing.Point(5, 63);
            this.labelverse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelverse.Name = "labelverse";
            this.labelverse.Size = new System.Drawing.Size(70, 81);
            this.labelverse.TabIndex = 2;
            this.labelverse.Text = "0";
            this.labelverse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(4, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(285, 41);
            this.label13.TabIndex = 1;
            this.label13.Text = "Verse au fournisseur";
            // 
            // panelcharges
            // 
            this.panelcharges.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelcharges.Controls.Add(this.labelcharges);
            this.panelcharges.Controls.Add(this.label11);
            this.panelcharges.Location = new System.Drawing.Point(781, 7);
            this.panelcharges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelcharges.Name = "panelcharges";
            this.panelcharges.Size = new System.Drawing.Size(373, 185);
            this.panelcharges.TabIndex = 9;
            // 
            // labelcharges
            // 
            this.labelcharges.AutoSize = true;
            this.labelcharges.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcharges.Location = new System.Drawing.Point(5, 63);
            this.labelcharges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcharges.Name = "labelcharges";
            this.labelcharges.Size = new System.Drawing.Size(70, 81);
            this.labelcharges.TabIndex = 2;
            this.labelcharges.Text = "0";
            this.labelcharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(4, 4);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 41);
            this.label11.TabIndex = 1;
            this.label11.Text = "Charges";
            // 
            // panelmarch
            // 
            this.panelmarch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelmarch.Controls.Add(this.labelmarch);
            this.panelmarch.Controls.Add(this.label9);
            this.panelmarch.Location = new System.Drawing.Point(400, 7);
            this.panelmarch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelmarch.Name = "panelmarch";
            this.panelmarch.Size = new System.Drawing.Size(373, 185);
            this.panelmarch.TabIndex = 8;
            // 
            // labelmarch
            // 
            this.labelmarch.AutoSize = true;
            this.labelmarch.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmarch.Location = new System.Drawing.Point(5, 63);
            this.labelmarch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmarch.Name = "labelmarch";
            this.labelmarch.Size = new System.Drawing.Size(70, 81);
            this.labelmarch.TabIndex = 2;
            this.labelmarch.Text = "0";
            this.labelmarch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(4, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 41);
            this.label9.TabIndex = 1;
            this.label9.Text = "Marchandise";
            // 
            // panelcaisse
            // 
            this.panelcaisse.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelcaisse.Controls.Add(this.labelcaisse);
            this.panelcaisse.Controls.Add(this.label4);
            this.panelcaisse.Location = new System.Drawing.Point(19, 7);
            this.panelcaisse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelcaisse.Name = "panelcaisse";
            this.panelcaisse.Size = new System.Drawing.Size(373, 185);
            this.panelcaisse.TabIndex = 0;
            // 
            // labelcaisse
            // 
            this.labelcaisse.AutoSize = true;
            this.labelcaisse.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcaisse.Location = new System.Drawing.Point(5, 63);
            this.labelcaisse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcaisse.Name = "labelcaisse";
            this.labelcaisse.Size = new System.Drawing.Size(70, 81);
            this.labelcaisse.TabIndex = 2;
            this.labelcaisse.Text = "0";
            this.labelcaisse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 41);
            this.label4.TabIndex = 1;
            this.label4.Text = "Caisse";
            // 
            // Caissenew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.panelfill);
            this.Controls.Add(this.paneltop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Caissenew";
            this.Text = "Caissenew";
            this.paneltop.ResumeLayout(false);
            this.paneltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelfill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelbenefice.ResumeLayout(false);
            this.panelbenefice.PerformLayout();
            this.paneltotal.ResumeLayout(false);
            this.paneltotal.PerformLayout();
            this.panelfacturefournisseur.ResumeLayout(false);
            this.panelfacturefournisseur.PerformLayout();
            this.panelfactureclient.ResumeLayout(false);
            this.panelfactureclient.PerformLayout();
            this.panelverse.ResumeLayout(false);
            this.panelverse.PerformLayout();
            this.paneldettesfournisseur.ResumeLayout(false);
            this.paneldettesfournisseur.PerformLayout();
            this.paneldetteclient.ResumeLayout(false);
            this.paneldetteclient.PerformLayout();
            this.panelcharges.ResumeLayout(false);
            this.panelcharges.PerformLayout();
            this.panelmarch.ResumeLayout(false);
            this.panelmarch.PerformLayout();
            this.panelcaisse.ResumeLayout(false);
            this.panelcaisse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox comboBoxpar;
        private System.Windows.Forms.Panel paneltop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroDateTime metroDateTimestartdate;
        private MetroFramework.Controls.MetroDateTime metroDateTimefinishdate;
        private System.Windows.Forms.Panel panelfill;
        private System.Windows.Forms.Panel panelcaisse;
        private System.Windows.Forms.Label labelcaisse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelbenefice;
        private System.Windows.Forms.Label labelbenefices;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel paneltotal;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panelfacturefournisseur;
        private System.Windows.Forms.Label labeldettesfournisseur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelfactureclient;
        private System.Windows.Forms.Label labeldettesclient;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelverse;
        private System.Windows.Forms.Label labelfacturefournisseur;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel paneldettesfournisseur;
        private System.Windows.Forms.Label labelfactureclient;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel paneldetteclient;
        private System.Windows.Forms.Label labelverse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelcharges;
        private System.Windows.Forms.Label labelcharges;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelmarch;
        private System.Windows.Forms.Label labelmarch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelbeneficesnet;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelmarge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2Button NoCode;
    }
}