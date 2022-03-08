namespace StandManagementProject
{
    partial class View_prodcut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_prodcut));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureandname = new System.Windows.Forms.Panel();
            this.closeprgrm = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTextBoxsearch = new MetroFramework.Controls.MetroTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureandname.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeprgrm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.pictureandname.TabIndex = 32;
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
            this.label1.Location = new System.Drawing.Point(285, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voir produit";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureandname_MouseDown);
            // 
            // metroTextBoxsearch
            // 
            // 
            // 
            // 
            this.metroTextBoxsearch.CustomButton.Image = null;
            this.metroTextBoxsearch.CustomButton.Location = new System.Drawing.Point(659, 1);
            this.metroTextBoxsearch.CustomButton.Name = "";
            this.metroTextBoxsearch.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxsearch.CustomButton.TabIndex = 1;
            this.metroTextBoxsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxsearch.CustomButton.UseSelectable = true;
            this.metroTextBoxsearch.CustomButton.Visible = false;
            this.metroTextBoxsearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxsearch.Lines = new string[0];
            this.metroTextBoxsearch.Location = new System.Drawing.Point(12, 62);
            this.metroTextBoxsearch.MaxLength = 50;
            this.metroTextBoxsearch.Name = "metroTextBoxsearch";
            this.metroTextBoxsearch.PasswordChar = '\0';
            this.metroTextBoxsearch.PromptText = "SEARCH";
            this.metroTextBoxsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxsearch.SelectedText = "";
            this.metroTextBoxsearch.SelectionLength = 0;
            this.metroTextBoxsearch.SelectionStart = 0;
            this.metroTextBoxsearch.ShortcutsEnabled = true;
            this.metroTextBoxsearch.Size = new System.Drawing.Size(693, 35);
            this.metroTextBoxsearch.TabIndex = 1;
            this.metroTextBoxsearch.UseSelectable = true;
            this.metroTextBoxsearch.WaterMark = "SEARCH";
            this.metroTextBoxsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxsearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxsearch.TextChanged += new System.EventHandler(this.metroTextBoxsearch_TextChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
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
            this.dataGridView1.Size = new System.Drawing.Size(693, 591);
            this.dataGridView1.TabIndex = 2;
            // 
            // View_prodcut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 700);
            this.Controls.Add(this.pictureandname);
            this.Controls.Add(this.metroTextBoxsearch);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_prodcut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_prodcut";
            this.pictureandname.ResumeLayout(false);
            this.pictureandname.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeprgrm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pictureandname;
        private System.Windows.Forms.PictureBox closeprgrm;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}