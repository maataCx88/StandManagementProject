namespace StandManagementProject
{
    partial class Add_worker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_worker));
            this.buttonadd = new System.Windows.Forms.Button();
            this.comboBoxrole = new MetroFramework.Controls.MetroComboBox();
            this.labelworkinformation = new System.Windows.Forms.Label();
            this.panelworkinformation = new System.Windows.Forms.Panel();
            this.textBoxdate = new System.Windows.Forms.TextBox();
            this.textBoxrole = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.labelpassword = new System.Windows.Forms.Label();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.dateTimePickerdateofjoin = new System.Windows.Forms.DateTimePicker();
            this.labelrole = new System.Windows.Forms.Label();
            this.labeldateofjoin = new System.Windows.Forms.Label();
            this.textBoxbasesalary = new System.Windows.Forms.TextBox();
            this.labelbasesalary = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxfirstname = new System.Windows.Forms.TextBox();
            this.labelfirstname = new System.Windows.Forms.Label();
            this.pictureandname = new System.Windows.Forms.Panel();
            this.closeprgrm = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labellastname = new System.Windows.Forms.Label();
            this.labelworkerpersonalinformations = new System.Windows.Forms.Label();
            this.panelpersonalinformation = new System.Windows.Forms.Panel();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.panelworkinformation.SuspendLayout();
            this.pictureandname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeprgrm)).BeginInit();
            this.panelpersonalinformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.buttonadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadd.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.ForeColor = System.Drawing.Color.White;
            this.buttonadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonadd.Location = new System.Drawing.Point(555, 281);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(150, 40);
            this.buttonadd.TabIndex = 31;
            this.buttonadd.Text = "Ajouter";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // comboBoxrole
            // 
            this.comboBoxrole.FormattingEnabled = true;
            this.comboBoxrole.ItemHeight = 23;
            this.comboBoxrole.Items.AddRange(new object[] {
            "Administrateur",
            "Vendeur"});
            this.comboBoxrole.Location = new System.Drawing.Point(77, 29);
            this.comboBoxrole.Name = "comboBoxrole";
            this.comboBoxrole.PromptText = "-choisir-";
            this.comboBoxrole.Size = new System.Drawing.Size(100, 29);
            this.comboBoxrole.TabIndex = 3;
            this.comboBoxrole.UseSelectable = true;
            // 
            // labelworkinformation
            // 
            this.labelworkinformation.AutoSize = true;
            this.labelworkinformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.labelworkinformation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelworkinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelworkinformation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelworkinformation.Location = new System.Drawing.Point(42, 146);
            this.labelworkinformation.Name = "labelworkinformation";
            this.labelworkinformation.Size = new System.Drawing.Size(237, 24);
            this.labelworkinformation.TabIndex = 28;
            this.labelworkinformation.Text = "Informations sur l\'emploi";
            // 
            // panelworkinformation
            // 
            this.panelworkinformation.BackColor = System.Drawing.SystemColors.Control;
            this.panelworkinformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelworkinformation.Controls.Add(this.comboBoxrole);
            this.panelworkinformation.Controls.Add(this.textBoxdate);
            this.panelworkinformation.Controls.Add(this.textBoxrole);
            this.panelworkinformation.Controls.Add(this.textBoxpassword);
            this.panelworkinformation.Controls.Add(this.labelpassword);
            this.panelworkinformation.Controls.Add(this.textBoxusername);
            this.panelworkinformation.Controls.Add(this.labelusername);
            this.panelworkinformation.Controls.Add(this.dateTimePickerdateofjoin);
            this.panelworkinformation.Controls.Add(this.labelrole);
            this.panelworkinformation.Controls.Add(this.labeldateofjoin);
            this.panelworkinformation.Controls.Add(this.textBoxbasesalary);
            this.panelworkinformation.Controls.Add(this.labelbasesalary);
            this.panelworkinformation.Controls.Add(this.textBox2);
            this.panelworkinformation.Controls.Add(this.textBox3);
            this.panelworkinformation.Location = new System.Drawing.Point(12, 156);
            this.panelworkinformation.Name = "panelworkinformation";
            this.panelworkinformation.Size = new System.Drawing.Size(693, 119);
            this.panelworkinformation.TabIndex = 33;
            // 
            // textBoxdate
            // 
            this.textBoxdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxdate.Location = new System.Drawing.Point(556, 31);
            this.textBoxdate.MaxLength = 30;
            this.textBoxdate.Name = "textBoxdate";
            this.textBoxdate.ReadOnly = true;
            this.textBoxdate.Size = new System.Drawing.Size(115, 26);
            this.textBoxdate.TabIndex = 29;
            this.textBoxdate.Visible = false;
            // 
            // textBoxrole
            // 
            this.textBoxrole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxrole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxrole.Location = new System.Drawing.Point(77, 31);
            this.textBoxrole.MaxLength = 30;
            this.textBoxrole.Name = "textBoxrole";
            this.textBoxrole.ReadOnly = true;
            this.textBoxrole.Size = new System.Drawing.Size(100, 26);
            this.textBoxrole.TabIndex = 28;
            this.textBoxrole.Visible = false;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpassword.Location = new System.Drawing.Point(467, 75);
            this.textBoxpassword.MaxLength = 30;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(120, 26);
            this.textBoxpassword.TabIndex = 7;
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelpassword.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(355, 74);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(106, 26);
            this.labelpassword.TabIndex = 0;
            this.labelpassword.Text = "Password :";
            // 
            // textBoxusername
            // 
            this.textBoxusername.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxusername.Location = new System.Drawing.Point(226, 75);
            this.textBoxusername.MaxLength = 30;
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(120, 26);
            this.textBoxusername.TabIndex = 6;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelusername.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.Location = new System.Drawing.Point(107, 74);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(113, 26);
            this.labelusername.TabIndex = 0;
            this.labelusername.Text = "Username :";
            // 
            // dateTimePickerdateofjoin
            // 
            this.dateTimePickerdateofjoin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerdateofjoin.Location = new System.Drawing.Point(556, 33);
            this.dateTimePickerdateofjoin.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerdateofjoin.Name = "dateTimePickerdateofjoin";
            this.dateTimePickerdateofjoin.Size = new System.Drawing.Size(115, 20);
            this.dateTimePickerdateofjoin.TabIndex = 5;
            this.dateTimePickerdateofjoin.Value = new System.DateTime(2020, 6, 17, 0, 0, 0, 0);
            // 
            // labelrole
            // 
            this.labelrole.AutoSize = true;
            this.labelrole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelrole.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelrole.Location = new System.Drawing.Point(8, 30);
            this.labelrole.Name = "labelrole";
            this.labelrole.Size = new System.Drawing.Size(63, 26);
            this.labelrole.TabIndex = 0;
            this.labelrole.Text = "Role :";
            // 
            // labeldateofjoin
            // 
            this.labeldateofjoin.AutoSize = true;
            this.labeldateofjoin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labeldateofjoin.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldateofjoin.Location = new System.Drawing.Point(418, 29);
            this.labeldateofjoin.Name = "labeldateofjoin";
            this.labeldateofjoin.Size = new System.Drawing.Size(132, 26);
            this.labeldateofjoin.TabIndex = 0;
            this.labeldateofjoin.Text = "Date d\'ajout :";
            // 
            // textBoxbasesalary
            // 
            this.textBoxbasesalary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxbasesalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxbasesalary.Location = new System.Drawing.Point(285, 30);
            this.textBoxbasesalary.MaxLength = 30;
            this.textBoxbasesalary.Name = "textBoxbasesalary";
            this.textBoxbasesalary.Size = new System.Drawing.Size(120, 26);
            this.textBoxbasesalary.TabIndex = 4;
            this.textBoxbasesalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.just_numbers);
            // 
            // labelbasesalary
            // 
            this.labelbasesalary.AutoSize = true;
            this.labelbasesalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelbasesalary.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelbasesalary.Location = new System.Drawing.Point(195, 30);
            this.labelbasesalary.Name = "labelbasesalary";
            this.labelbasesalary.Size = new System.Drawing.Size(84, 26);
            this.labelbasesalary.TabIndex = 0;
            this.labelbasesalary.Text = "Salaire :";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(722, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(150, 26);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(745, 69);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(150, 26);
            this.textBox3.TabIndex = 11;
            // 
            // textBoxfirstname
            // 
            this.textBoxfirstname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfirstname.Location = new System.Drawing.Point(137, 23);
            this.textBoxfirstname.MaxLength = 30;
            this.textBoxfirstname.Name = "textBoxfirstname";
            this.textBoxfirstname.Size = new System.Drawing.Size(150, 26);
            this.textBoxfirstname.TabIndex = 1;
            this.textBoxfirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.just_letters);
            // 
            // labelfirstname
            // 
            this.labelfirstname.AutoSize = true;
            this.labelfirstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelfirstname.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfirstname.Location = new System.Drawing.Point(64, 22);
            this.labelfirstname.Name = "labelfirstname";
            this.labelfirstname.Size = new System.Drawing.Size(67, 26);
            this.labelfirstname.TabIndex = 0;
            this.labelfirstname.Text = "Nom :";
            // 
            // pictureandname
            // 
            this.pictureandname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.pictureandname.Controls.Add(this.closeprgrm);
            this.pictureandname.Controls.Add(this.label1);
            this.pictureandname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureandname.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureandname.Location = new System.Drawing.Point(0, 0);
            this.pictureandname.Name = "pictureandname";
            this.pictureandname.Size = new System.Drawing.Size(717, 50);
            this.pictureandname.TabIndex = 29;
            this.pictureandname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureandname_MouseDown);
            // 
            // closeprgrm
            // 
            this.closeprgrm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeprgrm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeprgrm.Image = ((System.Drawing.Image)(resources.GetObject("closeprgrm.Image")));
            this.closeprgrm.Location = new System.Drawing.Point(684, 10);
            this.closeprgrm.Name = "closeprgrm";
            this.closeprgrm.Size = new System.Drawing.Size(30, 30);
            this.closeprgrm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.closeprgrm.TabIndex = 6;
            this.closeprgrm.TabStop = false;
            this.closeprgrm.Click += new System.EventHandler(this.closeprgrm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(250, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajouter un employé";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureandname_MouseDown);
            // 
            // labellastname
            // 
            this.labellastname.AutoSize = true;
            this.labellastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labellastname.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellastname.Location = new System.Drawing.Point(377, 22);
            this.labellastname.Name = "labellastname";
            this.labellastname.Size = new System.Drawing.Size(93, 26);
            this.labellastname.TabIndex = 0;
            this.labellastname.Text = "Prenom :";
            // 
            // labelworkerpersonalinformations
            // 
            this.labelworkerpersonalinformations.AutoSize = true;
            this.labelworkerpersonalinformations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.labelworkerpersonalinformations.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labelworkerpersonalinformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelworkerpersonalinformations.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelworkerpersonalinformations.Location = new System.Drawing.Point(32, 59);
            this.labelworkerpersonalinformations.Name = "labelworkerpersonalinformations";
            this.labelworkerpersonalinformations.Size = new System.Drawing.Size(233, 24);
            this.labelworkerpersonalinformations.TabIndex = 30;
            this.labelworkerpersonalinformations.Text = "Informations personnels";
            // 
            // panelpersonalinformation
            // 
            this.panelpersonalinformation.BackColor = System.Drawing.SystemColors.Control;
            this.panelpersonalinformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelpersonalinformation.Controls.Add(this.textBoxlastname);
            this.panelpersonalinformation.Controls.Add(this.labellastname);
            this.panelpersonalinformation.Controls.Add(this.textBoxfirstname);
            this.panelpersonalinformation.Controls.Add(this.labelfirstname);
            this.panelpersonalinformation.Location = new System.Drawing.Point(12, 69);
            this.panelpersonalinformation.Name = "panelpersonalinformation";
            this.panelpersonalinformation.Size = new System.Drawing.Size(693, 66);
            this.panelpersonalinformation.TabIndex = 32;
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxlastname.Location = new System.Drawing.Point(476, 23);
            this.textBoxlastname.MaxLength = 30;
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(150, 26);
            this.textBoxlastname.TabIndex = 2;
            this.textBoxlastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.just_letters);
            // 
            // Add_worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 325);
            this.Controls.Add(this.buttonadd);
            this.Controls.Add(this.labelworkinformation);
            this.Controls.Add(this.panelworkinformation);
            this.Controls.Add(this.pictureandname);
            this.Controls.Add(this.labelworkerpersonalinformations);
            this.Controls.Add(this.panelpersonalinformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_worker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_worker";
            this.panelworkinformation.ResumeLayout(false);
            this.panelworkinformation.PerformLayout();
            this.pictureandname.ResumeLayout(false);
            this.pictureandname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeprgrm)).EndInit();
            this.panelpersonalinformation.ResumeLayout(false);
            this.panelpersonalinformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonadd;
        private MetroFramework.Controls.MetroComboBox comboBoxrole;
        private System.Windows.Forms.Label labelworkinformation;
        private System.Windows.Forms.Panel panelworkinformation;
        private System.Windows.Forms.TextBox textBoxdate;
        private System.Windows.Forms.TextBox textBoxrole;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.DateTimePicker dateTimePickerdateofjoin;
        private System.Windows.Forms.Label labelrole;
        private System.Windows.Forms.Label labeldateofjoin;
        private System.Windows.Forms.TextBox textBoxbasesalary;
        private System.Windows.Forms.Label labelbasesalary;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxfirstname;
        private System.Windows.Forms.Label labelfirstname;
        private System.Windows.Forms.Panel pictureandname;
        private System.Windows.Forms.PictureBox closeprgrm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labellastname;
        private System.Windows.Forms.Label labelworkerpersonalinformations;
        private System.Windows.Forms.Panel panelpersonalinformation;
        private System.Windows.Forms.TextBox textBoxlastname;
    }
}