
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
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroComboBoxstatus = new MetroFramework.Controls.MetroComboBox();
            this.labeltable = new System.Windows.Forms.Label();
            this.metroTextBoxsearch = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.paneltable = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttondateofdep = new System.Windows.Forms.Button();
            this.buttonviewusrpwd = new System.Windows.Forms.Button();
            this.buttonmodify = new System.Windows.Forms.Button();
            this.buttonview = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.paneltable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.panel3.Location = new System.Drawing.Point(0, 670);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 50);
            this.panel3.TabIndex = 5;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(22, 641);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(25, 20);
            this.textBoxpassword.TabIndex = 0;
            this.textBoxpassword.Visible = false;
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(22, 615);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(25, 20);
            this.textBoxusername.TabIndex = 0;
            this.textBoxusername.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DES EMPLOYES";
            // 
            // metroComboBoxstatus
            // 
            this.metroComboBoxstatus.FormattingEnabled = true;
            this.metroComboBoxstatus.ItemHeight = 23;
            this.metroComboBoxstatus.Items.AddRange(new object[] {
            "TOUT",
            "OUI",
            "NON"});
            this.metroComboBoxstatus.Location = new System.Drawing.Point(3, 18);
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
            this.labeltable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.labeltable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labeltable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeltable.Location = new System.Drawing.Point(3, 52);
            this.labeltable.Name = "labeltable";
            this.labeltable.Size = new System.Drawing.Size(181, 24);
            this.labeltable.TabIndex = 0;
            this.labeltable.Text = "List Des Employes";
            // 
            // metroTextBoxsearch
            // 
            // 
            // 
            // 
            this.metroTextBoxsearch.CustomButton.Image = null;
            this.metroTextBoxsearch.CustomButton.Location = new System.Drawing.Point(735, 1);
            this.metroTextBoxsearch.CustomButton.Name = "";
            this.metroTextBoxsearch.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxsearch.CustomButton.TabIndex = 1;
            this.metroTextBoxsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxsearch.CustomButton.UseSelectable = true;
            this.metroTextBoxsearch.CustomButton.Visible = false;
            this.metroTextBoxsearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxsearch.Lines = new string[0];
            this.metroTextBoxsearch.Location = new System.Drawing.Point(130, 12);
            this.metroTextBoxsearch.MaxLength = 50;
            this.metroTextBoxsearch.Name = "metroTextBoxsearch";
            this.metroTextBoxsearch.PasswordChar = '\0';
            this.metroTextBoxsearch.PromptText = "SEARCH";
            this.metroTextBoxsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxsearch.SelectedText = "";
            this.metroTextBoxsearch.SelectionLength = 0;
            this.metroTextBoxsearch.SelectionStart = 0;
            this.metroTextBoxsearch.ShortcutsEnabled = true;
            this.metroTextBoxsearch.Size = new System.Drawing.Size(769, 35);
            this.metroTextBoxsearch.TabIndex = 7;
            this.metroTextBoxsearch.UseSelectable = true;
            this.metroTextBoxsearch.WaterMark = "SEARCH";
            this.metroTextBoxsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxsearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxsearch.TextChanged += new System.EventHandler(this.metroTextBoxsearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.paneltable);
            this.panel2.Location = new System.Drawing.Point(360, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 670);
            this.panel2.TabIndex = 4;
            // 
            // paneltable
            // 
            this.paneltable.BackColor = System.Drawing.Color.White;
            this.paneltable.Controls.Add(this.metroComboBoxstatus);
            this.paneltable.Controls.Add(this.labeltable);
            this.paneltable.Controls.Add(this.metroTextBoxsearch);
            this.paneltable.Controls.Add(this.dataGridView1);
            this.paneltable.Location = new System.Drawing.Point(5, 3);
            this.paneltable.Name = "paneltable";
            this.paneltable.Size = new System.Drawing.Size(902, 654);
            this.paneltable.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 77);
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
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(894, 567);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxpassword);
            this.panel1.Controls.Add(this.textBoxusername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttondelete);
            this.panel1.Controls.Add(this.buttondateofdep);
            this.panel1.Controls.Add(this.buttonviewusrpwd);
            this.panel1.Controls.Add(this.buttonmodify);
            this.panel1.Controls.Add(this.buttonview);
            this.panel1.Controls.Add(this.buttonadd);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 670);
            this.panel1.TabIndex = 3;
            // 
            // buttondelete
            // 
            this.buttondelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.buttondelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondelete.Enabled = false;
            this.buttondelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondelete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondelete.ForeColor = System.Drawing.Color.White;
            this.buttondelete.Image = global::StandManagementProject.Properties.Resources.icons8_delete_file_32;
            this.buttondelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondelete.Location = new System.Drawing.Point(29, 530);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(300, 40);
            this.buttondelete.TabIndex = 6;
            this.buttondelete.Text = "Supprimer un employé";
            this.buttondelete.UseVisualStyleBackColor = false;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttondateofdep
            // 
            this.buttondateofdep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.buttondateofdep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttondateofdep.Enabled = false;
            this.buttondateofdep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttondateofdep.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondateofdep.ForeColor = System.Drawing.Color.White;
            this.buttondateofdep.Image = global::StandManagementProject.Properties.Resources.icons8_leaving_queue_32;
            this.buttondateofdep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttondateofdep.Location = new System.Drawing.Point(29, 450);
            this.buttondateofdep.Name = "buttondateofdep";
            this.buttondateofdep.Size = new System.Drawing.Size(300, 40);
            this.buttondateofdep.TabIndex = 5;
            this.buttondateofdep.Text = "   Date de départ";
            this.buttondateofdep.UseVisualStyleBackColor = false;
            this.buttondateofdep.Click += new System.EventHandler(this.buttondateofdep_Click);
            // 
            // buttonviewusrpwd
            // 
            this.buttonviewusrpwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.buttonviewusrpwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonviewusrpwd.Enabled = false;
            this.buttonviewusrpwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonviewusrpwd.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonviewusrpwd.ForeColor = System.Drawing.Color.White;
            this.buttonviewusrpwd.Image = global::StandManagementProject.Properties.Resources.icons8_view_more_32;
            this.buttonviewusrpwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonviewusrpwd.Location = new System.Drawing.Point(29, 370);
            this.buttonviewusrpwd.Name = "buttonviewusrpwd";
            this.buttonviewusrpwd.Size = new System.Drawing.Size(300, 40);
            this.buttonviewusrpwd.TabIndex = 4;
            this.buttonviewusrpwd.Text = "       Voir Username et Password";
            this.buttonviewusrpwd.UseVisualStyleBackColor = false;
            this.buttonviewusrpwd.Click += new System.EventHandler(this.buttonviewusrpwd_Click);
            // 
            // buttonmodify
            // 
            this.buttonmodify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.buttonmodify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonmodify.Enabled = false;
            this.buttonmodify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonmodify.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodify.ForeColor = System.Drawing.Color.White;
            this.buttonmodify.Image = global::StandManagementProject.Properties.Resources.icons8_edit_file_32;
            this.buttonmodify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonmodify.Location = new System.Drawing.Point(28, 290);
            this.buttonmodify.Name = "buttonmodify";
            this.buttonmodify.Size = new System.Drawing.Size(300, 40);
            this.buttonmodify.TabIndex = 3;
            this.buttonmodify.Text = "     Modifier les informations";
            this.buttonmodify.UseVisualStyleBackColor = false;
            this.buttonmodify.Click += new System.EventHandler(this.buttonmodify_Click);
            // 
            // buttonview
            // 
            this.buttonview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.buttonview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonview.Enabled = false;
            this.buttonview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonview.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonview.ForeColor = System.Drawing.Color.White;
            this.buttonview.Image = global::StandManagementProject.Properties.Resources.icons8_view_32;
            this.buttonview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonview.Location = new System.Drawing.Point(28, 210);
            this.buttonview.Name = "buttonview";
            this.buttonview.Size = new System.Drawing.Size(300, 40);
            this.buttonview.TabIndex = 2;
            this.buttonview.Text = "     Voir les informations";
            this.buttonview.UseVisualStyleBackColor = false;
            this.buttonview.Click += new System.EventHandler(this.buttonview_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(0)))), ((int)(((byte)(154)))));
            this.buttonadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonadd.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonadd.ForeColor = System.Drawing.Color.White;
            this.buttonadd.Image = global::StandManagementProject.Properties.Resources.icons8_add_user_male_32;
            this.buttonadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonadd.Location = new System.Drawing.Point(28, 130);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(300, 40);
            this.buttonadd.TabIndex = 1;
            this.buttonadd.Text = "Ajouter un employé";
            this.buttonadd.UseVisualStyleBackColor = false;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Employee";
            this.panel2.ResumeLayout(false);
            this.paneltable.ResumeLayout(false);
            this.paneltable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttondateofdep;
        private System.Windows.Forms.Button buttonviewusrpwd;
        private System.Windows.Forms.Button buttonmodify;
        private MetroFramework.Controls.MetroComboBox metroComboBoxstatus;
        private System.Windows.Forms.Label labeltable;
        private MetroFramework.Controls.MetroTextBox metroTextBoxsearch;
        private System.Windows.Forms.Button buttonview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel paneltable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Panel panel1;
    }
}