namespace StandManagementProject
{
    partial class Add_to_list_To_A_MultiCode
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.metroConfirm = new MetroFramework.Controls.MetroButton();
            this.metroScanAdd = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(11, 114);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liste Des Code Barres Associé";
            // 
            // metroConfirm
            // 
            this.metroConfirm.BackColor = System.Drawing.Color.Teal;
            this.metroConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroConfirm.Location = new System.Drawing.Point(378, 63);
            this.metroConfirm.Name = "metroConfirm";
            this.metroConfirm.Size = new System.Drawing.Size(178, 38);
            this.metroConfirm.TabIndex = 4;
            this.metroConfirm.Text = "Etablir Fournisseur";
            this.metroConfirm.UseCustomBackColor = true;
            this.metroConfirm.UseCustomForeColor = true;
            this.metroConfirm.UseSelectable = true;
            this.metroConfirm.UseStyleColors = true;
            this.metroConfirm.Click += new System.EventHandler(this.metroConfirm_Click);
            // 
            // metroScanAdd
            // 
            // 
            // 
            // 
            this.metroScanAdd.CustomButton.Image = null;
            this.metroScanAdd.CustomButton.Location = new System.Drawing.Point(325, 2);
            this.metroScanAdd.CustomButton.Name = "";
            this.metroScanAdd.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroScanAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroScanAdd.CustomButton.TabIndex = 1;
            this.metroScanAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroScanAdd.CustomButton.UseSelectable = true;
            this.metroScanAdd.CustomButton.Visible = false;
            this.metroScanAdd.DisplayIcon = true;
            this.metroScanAdd.Icon = global::StandManagementProject.Properties.Resources.barcode_reader_208px;
            this.metroScanAdd.Lines = new string[0];
            this.metroScanAdd.Location = new System.Drawing.Point(11, 63);
            this.metroScanAdd.MaxLength = 32767;
            this.metroScanAdd.Multiline = true;
            this.metroScanAdd.Name = "metroScanAdd";
            this.metroScanAdd.PasswordChar = '\0';
            this.metroScanAdd.PromptText = "Scanner Pour Ajouter à la liste";
            this.metroScanAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroScanAdd.SelectedText = "";
            this.metroScanAdd.SelectionLength = 0;
            this.metroScanAdd.SelectionStart = 0;
            this.metroScanAdd.ShortcutsEnabled = true;
            this.metroScanAdd.Size = new System.Drawing.Size(361, 38);
            this.metroScanAdd.TabIndex = 1;
            this.metroScanAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroScanAdd.UseCustomBackColor = true;
            this.metroScanAdd.UseCustomForeColor = true;
            this.metroScanAdd.UseSelectable = true;
            this.metroScanAdd.UseStyleColors = true;
            this.metroScanAdd.WaterMark = "Scanner Pour Ajouter à la liste";
            this.metroScanAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroScanAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroScanAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.metroScanAdd_KeyPress);
            // 
            // Add_to_list_To_A_MultiCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 468);
            this.Controls.Add(this.metroConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroScanAdd);
            this.Controls.Add(this.dataGridView1);
            this.Movable = false;
            this.Name = "Add_to_list_To_A_MultiCode";
            this.Resizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox metroScanAdd;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroConfirm;
    }
}