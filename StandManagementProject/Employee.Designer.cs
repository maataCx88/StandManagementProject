
namespace StandManagementProject
{
    partial class Employee
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroComboBoxstatus = new MetroFramework.Controls.MetroComboBox();
            this.labeltable = new System.Windows.Forms.Label();
            this.metroTextBoxsearch = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paneltable = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.guna2ButtonSTAT = new Guna.UI2.WinForms.Guna2Button();
            this.buttondelete = new Guna.UI2.WinForms.Guna2Button();
            this.buttonadd = new Guna.UI2.WinForms.Guna2Button();
            this.buttondateofdep = new Guna.UI2.WinForms.Guna2Button();
            this.buttonview = new Guna.UI2.WinForms.Guna2Button();
            this.buttonviewusrpwd = new Guna.UI2.WinForms.Guna2Button();
            this.buttonmodify = new Guna.UI2.WinForms.Guna2Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.paneltable.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            this.panel3.Controls.Add(this.textBoxusername);
            this.panel3.Controls.Add(this.textBoxpassword);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(360, 670);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 50);
            this.panel3.TabIndex = 5;
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(41, 3);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(25, 20);
            this.textBoxusername.TabIndex = 0;
            this.textBoxusername.Visible = false;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(41, 29);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(25, 20);
            this.textBoxpassword.TabIndex = 0;
            this.textBoxpassword.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DES EMPLOYES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroComboBoxstatus
            // 
            this.metroComboBoxstatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroComboBoxstatus.FormattingEnabled = true;
            this.metroComboBoxstatus.ItemHeight = 23;
            this.metroComboBoxstatus.Items.AddRange(new object[] {
            "TOUT",
            "OUI",
            "NON"});
            this.metroComboBoxstatus.Location = new System.Drawing.Point(0, 0);
            this.metroComboBoxstatus.Name = "metroComboBoxstatus";
            this.metroComboBoxstatus.PromptText = "Statut";
            this.metroComboBoxstatus.Size = new System.Drawing.Size(121, 29);
            this.metroComboBoxstatus.TabIndex = 8;
            this.metroComboBoxstatus.UseSelectable = true;
            this.metroComboBoxstatus.TextChanged += new System.EventHandler(this.metroComboBoxstatus_TextChanged);
            // 
            // labeltable
            // 
            this.labeltable.AutoSize = true;
            this.labeltable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            this.labeltable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labeltable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeltable.Location = new System.Drawing.Point(4, 9);
            this.labeltable.Name = "labeltable";
            this.labeltable.Size = new System.Drawing.Size(193, 24);
            this.labeltable.TabIndex = 0;
            this.labeltable.Text = "Liste Des Employes";
            // 
            // metroTextBoxsearch
            // 
            // 
            // 
            // 
            this.metroTextBoxsearch.CustomButton.Image = null;
            this.metroTextBoxsearch.CustomButton.Location = new System.Drawing.Point(451, 1);
            this.metroTextBoxsearch.CustomButton.Name = "";
            this.metroTextBoxsearch.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.metroTextBoxsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxsearch.CustomButton.TabIndex = 1;
            this.metroTextBoxsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxsearch.CustomButton.UseSelectable = true;
            this.metroTextBoxsearch.CustomButton.Visible = false;
            this.metroTextBoxsearch.DisplayIcon = true;
            this.metroTextBoxsearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTextBoxsearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxsearch.Icon = global::StandManagementProject.Properties.Resources.google_web_search_208px;
            this.metroTextBoxsearch.IconRight = true;
            this.metroTextBoxsearch.Lines = new string[0];
            this.metroTextBoxsearch.Location = new System.Drawing.Point(0, 0);
            this.metroTextBoxsearch.MaxLength = 50;
            this.metroTextBoxsearch.Name = "metroTextBoxsearch";
            this.metroTextBoxsearch.PasswordChar = '\0';
            this.metroTextBoxsearch.PromptText = "SEARCH";
            this.metroTextBoxsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxsearch.SelectedText = "";
            this.metroTextBoxsearch.SelectionLength = 0;
            this.metroTextBoxsearch.SelectionStart = 0;
            this.metroTextBoxsearch.ShortcutsEnabled = true;
            this.metroTextBoxsearch.Size = new System.Drawing.Size(483, 33);
            this.metroTextBoxsearch.TabIndex = 7;
            this.metroTextBoxsearch.UseSelectable = true;
            this.metroTextBoxsearch.WaterMark = "SEARCH";
            this.metroTextBoxsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxsearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxsearch.TextChanged += new System.EventHandler(this.metroTextBoxsearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.paneltable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(360, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 720);
            this.panel2.TabIndex = 4;
            // 
            // paneltable
            // 
            this.paneltable.BackColor = System.Drawing.Color.White;
            this.paneltable.Controls.Add(this.panel6);
            this.paneltable.Controls.Add(this.panel5);
            this.paneltable.Controls.Add(this.panel4);
            this.paneltable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltable.Location = new System.Drawing.Point(0, 0);
            this.paneltable.Name = "paneltable";
            this.paneltable.Size = new System.Drawing.Size(853, 718);
            this.paneltable.TabIndex = 16;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 61);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(853, 571);
            this.panel6.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(853, 571);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(853, 33);
            this.panel5.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.metroComboBoxstatus);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(853, 28);
            this.panel4.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 720);
            this.panel1.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.guna2ButtonSTAT);
            this.panel8.Controls.Add(this.buttondelete);
            this.panel8.Controls.Add(this.buttonadd);
            this.panel8.Controls.Add(this.buttondateofdep);
            this.panel8.Controls.Add(this.buttonview);
            this.panel8.Controls.Add(this.buttonviewusrpwd);
            this.panel8.Controls.Add(this.buttonmodify);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 197);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(358, 522);
            this.panel8.TabIndex = 1;
            // 
            // guna2ButtonSTAT
            // 
            this.guna2ButtonSTAT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2ButtonSTAT.BorderRadius = 7;
            this.guna2ButtonSTAT.CheckedState.Parent = this.guna2ButtonSTAT;
            this.guna2ButtonSTAT.CustomImages.Image = global::StandManagementProject.Properties.Resources.statistics_480px;
            this.guna2ButtonSTAT.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonSTAT.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ButtonSTAT.CustomImages.Parent = this.guna2ButtonSTAT;
            this.guna2ButtonSTAT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            this.guna2ButtonSTAT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2ButtonSTAT.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.guna2ButtonSTAT.HoverState.Parent = this.guna2ButtonSTAT;
            this.guna2ButtonSTAT.Location = new System.Drawing.Point(26, 449);
            this.guna2ButtonSTAT.Name = "guna2ButtonSTAT";
            this.guna2ButtonSTAT.ShadowDecoration.Parent = this.guna2ButtonSTAT;
            this.guna2ButtonSTAT.Size = new System.Drawing.Size(300, 49);
            this.guna2ButtonSTAT.TabIndex = 12;
            this.guna2ButtonSTAT.Text = "Statistique sur l\'employée";
            this.guna2ButtonSTAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ButtonSTAT.TextOffset = new System.Drawing.Point(50, 0);
            this.guna2ButtonSTAT.Click += new System.EventHandler(this.guna2ButtonSTAT_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttondelete.BorderRadius = 7;
            this.buttondelete.CheckedState.Parent = this.buttondelete;
            this.buttondelete.CustomImages.Image = global::StandManagementProject.Properties.Resources.icons8_delete_file_32;
            this.buttondelete.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttondelete.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttondelete.CustomImages.Parent = this.buttondelete;
            this.buttondelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            this.buttondelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttondelete.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.buttondelete.HoverState.Parent = this.buttondelete;
            this.buttondelete.Location = new System.Drawing.Point(26, 386);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.ShadowDecoration.Parent = this.buttondelete;
            this.buttondelete.Size = new System.Drawing.Size(300, 49);
            this.buttondelete.TabIndex = 12;
            this.buttondelete.Text = "Supprimer un employé";
            this.buttondelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttondelete.TextOffset = new System.Drawing.Point(50, 0);
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonadd.BorderRadius = 7;
            this.buttonadd.CheckedState.Parent = this.buttonadd;
            this.buttonadd.CustomImages.Image = global::StandManagementProject.Properties.Resources.icons8_add_user_male_32;
            this.buttonadd.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonadd.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonadd.CustomImages.Parent = this.buttonadd;
            this.buttonadd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(48)))), ((int)(((byte)(88)))));
            this.buttonadd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonadd.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonadd.HoverState.Parent = this.buttonadd;
            this.buttonadd.Location = new System.Drawing.Point(26, 25);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.ShadowDecoration.Parent = this.buttonadd;
            this.buttonadd.Size = new System.Drawing.Size(300, 49);
            this.buttonadd.TabIndex = 12;
            this.buttonadd.Text = "Ajouter un employé";
            this.buttonadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonadd.TextOffset = new System.Drawing.Point(50, 0);
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // buttondateofdep
            // 
            this.buttondateofdep.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttondateofdep.BorderRadius = 7;
            this.buttondateofdep.CheckedState.Parent = this.buttondateofdep;
            this.buttondateofdep.CustomImages.Image = global::StandManagementProject.Properties.Resources.icons8_leaving_queue_32;
            this.buttondateofdep.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttondateofdep.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttondateofdep.CustomImages.Parent = this.buttondateofdep;
            this.buttondateofdep.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
            this.buttondateofdep.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttondateofdep.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.buttondateofdep.HoverState.Parent = this.buttondateofdep;
            this.buttondateofdep.Location = new System.Drawing.Point(26, 314);
            this.buttondateofdep.Name = "buttondateofdep";
            this.buttondateofdep.ShadowDecoration.Parent = this.buttondateofdep;
            this.buttondateofdep.Size = new System.Drawing.Size(300, 49);
            this.buttondateofdep.TabIndex = 12;
            this.buttondateofdep.Text = "Date de départ";
            this.buttondateofdep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttondateofdep.TextOffset = new System.Drawing.Point(50, 0);
            this.buttondateofdep.Click += new System.EventHandler(this.buttondateofdep_Click);
            // 
            // buttonview
            // 
            this.buttonview.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonview.BorderRadius = 7;
            this.buttonview.CheckedState.Parent = this.buttonview;
            this.buttonview.CustomImages.Image = global::StandManagementProject.Properties.Resources.icons8_view_32;
            this.buttonview.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonview.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonview.CustomImages.Parent = this.buttonview;
            this.buttonview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(47)))));
            this.buttonview.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonview.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonview.HoverState.Parent = this.buttonview;
            this.buttonview.Location = new System.Drawing.Point(26, 98);
            this.buttonview.Name = "buttonview";
            this.buttonview.ShadowDecoration.Parent = this.buttonview;
            this.buttonview.Size = new System.Drawing.Size(300, 49);
            this.buttonview.TabIndex = 12;
            this.buttonview.Text = " Voir les informations";
            this.buttonview.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonview.TextOffset = new System.Drawing.Point(50, 0);
            this.buttonview.Click += new System.EventHandler(this.buttonview_Click);
            // 
            // buttonviewusrpwd
            // 
            this.buttonviewusrpwd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonviewusrpwd.BorderRadius = 7;
            this.buttonviewusrpwd.CheckedState.Parent = this.buttonviewusrpwd;
            this.buttonviewusrpwd.CustomImages.Image = global::StandManagementProject.Properties.Resources.icons8_view_more_32;
            this.buttonviewusrpwd.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonviewusrpwd.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonviewusrpwd.CustomImages.Parent = this.buttonviewusrpwd;
            this.buttonviewusrpwd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.buttonviewusrpwd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonviewusrpwd.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonviewusrpwd.HoverState.Parent = this.buttonviewusrpwd;
            this.buttonviewusrpwd.Location = new System.Drawing.Point(26, 241);
            this.buttonviewusrpwd.Name = "buttonviewusrpwd";
            this.buttonviewusrpwd.ShadowDecoration.Parent = this.buttonviewusrpwd;
            this.buttonviewusrpwd.Size = new System.Drawing.Size(300, 49);
            this.buttonviewusrpwd.TabIndex = 12;
            this.buttonviewusrpwd.Text = "Voir Username et Password";
            this.buttonviewusrpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonviewusrpwd.TextOffset = new System.Drawing.Point(50, 0);
            this.buttonviewusrpwd.Click += new System.EventHandler(this.buttonviewusrpwd_Click);
            // 
            // buttonmodify
            // 
            this.buttonmodify.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonmodify.BorderRadius = 7;
            this.buttonmodify.CheckedState.Parent = this.buttonmodify;
            this.buttonmodify.CustomImages.Image = global::StandManagementProject.Properties.Resources.icons8_edit_file_32;
            this.buttonmodify.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonmodify.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonmodify.CustomImages.Parent = this.buttonmodify;
            this.buttonmodify.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.buttonmodify.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonmodify.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.buttonmodify.HoverState.Parent = this.buttonmodify;
            this.buttonmodify.Location = new System.Drawing.Point(26, 170);
            this.buttonmodify.Name = "buttonmodify";
            this.buttonmodify.ShadowDecoration.Parent = this.buttonmodify;
            this.buttonmodify.Size = new System.Drawing.Size(300, 49);
            this.buttonmodify.TabIndex = 12;
            this.buttonmodify.Text = "Modifier les informations";
            this.buttonmodify.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.buttonmodify.TextOffset = new System.Drawing.Point(50, 0);
            this.buttonmodify.Click += new System.EventHandler(this.buttonmodify_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(358, 160);
            this.panel7.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::StandManagementProject.Properties.Resources.businessman_208px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.metroTextBoxsearch);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(370, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(483, 33);
            this.panel10.TabIndex = 20;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.labeltable);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel11.Size = new System.Drawing.Size(203, 33);
            this.panel11.TabIndex = 21;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1215, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Employee";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.paneltable.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox metroComboBoxstatus;
        private System.Windows.Forms.Label labeltable;
        private MetroFramework.Controls.MetroTextBox metroTextBoxsearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel paneltable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2Button buttondelete;
        private Guna.UI2.WinForms.Guna2Button buttonadd;
        private Guna.UI2.WinForms.Guna2Button buttondateofdep;
        private Guna.UI2.WinForms.Guna2Button buttonview;
        private Guna.UI2.WinForms.Guna2Button buttonviewusrpwd;
        private Guna.UI2.WinForms.Guna2Button buttonmodify;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button guna2ButtonSTAT;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
    }
}