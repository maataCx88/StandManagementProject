
namespace StandManagementProject
{
    partial class Stock
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.paneltable = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labeltable = new System.Windows.Forms.Label();
            this.metroComboBoxstatus = new MetroFramework.Controls.MetroComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroTextBoxsearch = new MetroFramework.Controls.MetroTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.paneltable.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.paneltable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 670);
            this.panel2.TabIndex = 4;
            // 
            // paneltable
            // 
            this.paneltable.BackColor = System.Drawing.Color.White;
            this.paneltable.Controls.Add(this.panel7);
            this.paneltable.Controls.Add(this.panel1);
            this.paneltable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneltable.Location = new System.Drawing.Point(0, 0);
            this.paneltable.Name = "paneltable";
            this.paneltable.Size = new System.Drawing.Size(1278, 668);
            this.paneltable.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 58);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1278, 579);
            this.panel7.TabIndex = 19;
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
            this.dataGridView1.Size = new System.Drawing.Size(1278, 579);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 58);
            this.panel1.TabIndex = 17;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labeltable);
            this.panel5.Controls.Add(this.metroComboBoxstatus);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(204, 58);
            this.panel5.TabIndex = 18;
            // 
            // labeltable
            // 
            this.labeltable.AutoSize = true;
            this.labeltable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.labeltable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.labeltable.Dock = System.Windows.Forms.DockStyle.Top;
            this.labeltable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltable.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeltable.Location = new System.Drawing.Point(0, 0);
            this.labeltable.Name = "labeltable";
            this.labeltable.Size = new System.Drawing.Size(171, 24);
            this.labeltable.TabIndex = 16;
            this.labeltable.Text = "List Des Produits ";
            // 
            // metroComboBoxstatus
            // 
            this.metroComboBoxstatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroComboBoxstatus.FormattingEnabled = true;
            this.metroComboBoxstatus.ItemHeight = 23;
            this.metroComboBoxstatus.Items.AddRange(new object[] {
            "DISPONIBLE",
            "FINI",
            "TOUT"});
            this.metroComboBoxstatus.Location = new System.Drawing.Point(0, 29);
            this.metroComboBoxstatus.Name = "metroComboBoxstatus";
            this.metroComboBoxstatus.PromptText = "Statut";
            this.metroComboBoxstatus.Size = new System.Drawing.Size(204, 29);
            this.metroComboBoxstatus.TabIndex = 2;
            this.metroComboBoxstatus.UseSelectable = true;
            this.metroComboBoxstatus.TextChanged += new System.EventHandler(this.metroComboBoxstatus_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.metroTextBoxsearch);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(210, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1068, 58);
            this.panel4.TabIndex = 18;
            // 
            // metroTextBoxsearch
            // 
            // 
            // 
            // 
            this.metroTextBoxsearch.CustomButton.Image = null;
            this.metroTextBoxsearch.CustomButton.Location = new System.Drawing.Point(1034, 1);
            this.metroTextBoxsearch.CustomButton.Name = "";
            this.metroTextBoxsearch.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.metroTextBoxsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxsearch.CustomButton.TabIndex = 1;
            this.metroTextBoxsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxsearch.CustomButton.UseSelectable = true;
            this.metroTextBoxsearch.CustomButton.Visible = false;
            this.metroTextBoxsearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroTextBoxsearch.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBoxsearch.Lines = new string[0];
            this.metroTextBoxsearch.Location = new System.Drawing.Point(0, 23);
            this.metroTextBoxsearch.MaxLength = 50;
            this.metroTextBoxsearch.Name = "metroTextBoxsearch";
            this.metroTextBoxsearch.PasswordChar = '\0';
            this.metroTextBoxsearch.PromptText = "SEARCH";
            this.metroTextBoxsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxsearch.SelectedText = "";
            this.metroTextBoxsearch.SelectionLength = 0;
            this.metroTextBoxsearch.SelectionStart = 0;
            this.metroTextBoxsearch.ShortcutsEnabled = true;
            this.metroTextBoxsearch.Size = new System.Drawing.Size(1068, 35);
            this.metroTextBoxsearch.TabIndex = 1;
            this.metroTextBoxsearch.UseSelectable = true;
            this.metroTextBoxsearch.WaterMark = "SEARCH";
            this.metroTextBoxsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxsearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxsearch.TextChanged += new System.EventHandler(this.metroTextBoxsearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 670);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 50);
            this.panel3.TabIndex = 5;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Stock";
            this.panel2.ResumeLayout(false);
            this.paneltable.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel paneltable;
        private MetroFramework.Controls.MetroComboBox metroComboBoxstatus;
        private System.Windows.Forms.Label labeltable;
        private MetroFramework.Controls.MetroTextBox metroTextBoxsearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
    }
}