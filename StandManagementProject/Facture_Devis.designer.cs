﻿namespace StandManagementProject
{
    partial class Facture_Devis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDatepicker2 = new MetroFramework.Controls.MetroDateTime();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new MetroFramework.Controls.MetroDateTime();
            this.FacturClientGrid = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.searchfourn = new MetroFramework.Controls.MetroTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacturClientGrid)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(123)))));
            this.bunifuCustomLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(1192, 28);
            this.bunifuCustomLabel4.TabIndex = 35;
            this.bunifuCustomLabel4.Text = "Historique des Devis";
            this.bunifuCustomLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1192, 85);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bunifuDatepicker2);
            this.panel3.Location = new System.Drawing.Point(599, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 58);
            this.panel3.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "A";
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuDatepicker2.Location = new System.Drawing.Point(0, 24);
            this.bunifuDatepicker2.MinimumSize = new System.Drawing.Size(0, 29);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(377, 34);
            this.bunifuDatepicker2.TabIndex = 29;
            this.bunifuDatepicker2.ValueChanged += new System.EventHandler(this.bunifuDatepicker2_onValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bunifuDatepicker1);
            this.panel2.Location = new System.Drawing.Point(261, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 58);
            this.panel2.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "De";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(0, 24);
            this.bunifuDatepicker1.MinimumSize = new System.Drawing.Size(0, 29);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(332, 34);
            this.bunifuDatepicker1.TabIndex = 28;
            this.bunifuDatepicker1.ValueChanged += new System.EventHandler(this.bunifuDatepicker2_onValueChanged);
            // 
            // FacturClientGrid
            // 
            this.FacturClientGrid.AllowUserToAddRows = false;
            this.FacturClientGrid.AllowUserToDeleteRows = false;
            this.FacturClientGrid.AllowUserToResizeColumns = false;
            this.FacturClientGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FacturClientGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FacturClientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FacturClientGrid.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.FacturClientGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(107)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(18)))), ((int)(((byte)(181)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FacturClientGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FacturClientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(28)))), ((int)(((byte)(191)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FacturClientGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.FacturClientGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FacturClientGrid.EnableHeadersVisualStyles = false;
            this.FacturClientGrid.GridColor = System.Drawing.Color.White;
            this.FacturClientGrid.Location = new System.Drawing.Point(0, 0);
            this.FacturClientGrid.Name = "FacturClientGrid";
            this.FacturClientGrid.ReadOnly = true;
            this.FacturClientGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FacturClientGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FacturClientGrid.RowHeadersVisible = false;
            this.FacturClientGrid.RowHeadersWidth = 51;
            this.FacturClientGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(28)))), ((int)(((byte)(191)))));
            this.FacturClientGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.FacturClientGrid.RowTemplate.Height = 40;
            this.FacturClientGrid.Size = new System.Drawing.Size(1192, 530);
            this.FacturClientGrid.TabIndex = 39;
            this.FacturClientGrid.DoubleClick += new System.EventHandler(this.FacturClientGrid_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.searchfourn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 113);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1192, 45);
            this.panel4.TabIndex = 38;
            // 
            // searchfourn
            // 
            // 
            // 
            // 
            this.searchfourn.CustomButton.Image = null;
            this.searchfourn.CustomButton.Location = new System.Drawing.Point(1158, 1);
            this.searchfourn.CustomButton.Name = "";
            this.searchfourn.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.searchfourn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchfourn.CustomButton.TabIndex = 1;
            this.searchfourn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchfourn.CustomButton.UseSelectable = true;
            this.searchfourn.CustomButton.Visible = false;
            this.searchfourn.DisplayIcon = true;
            this.searchfourn.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchfourn.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.searchfourn.Icon = global::StandManagementProject.Properties.Resources.google_web_search_208px;
            this.searchfourn.IconRight = true;
            this.searchfourn.Lines = new string[0];
            this.searchfourn.Location = new System.Drawing.Point(0, 0);
            this.searchfourn.MaxLength = 50;
            this.searchfourn.Name = "searchfourn";
            this.searchfourn.PasswordChar = '\0';
            this.searchfourn.PromptText = "Rechercher par clients ou numéro du ticket";
            this.searchfourn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchfourn.SelectedText = "";
            this.searchfourn.SelectionLength = 0;
            this.searchfourn.SelectionStart = 0;
            this.searchfourn.ShortcutsEnabled = true;
            this.searchfourn.Size = new System.Drawing.Size(1192, 35);
            this.searchfourn.TabIndex = 22;
            this.searchfourn.UseSelectable = true;
            this.searchfourn.WaterMark = "Rechercher par clients ou numéro du ticket";
            this.searchfourn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchfourn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchfourn.TextChanged += new System.EventHandler(this.searchfourn_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.FacturClientGrid);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 158);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1192, 530);
            this.panel5.TabIndex = 39;
            // 
            // Facture_Devis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1192, 688);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Facture_Devis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Factureclient_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacturClientGrid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView FacturClientGrid;
        private MetroFramework.Controls.MetroTextBox searchfourn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        public MetroFramework.Controls.MetroDateTime bunifuDatepicker2;
        public MetroFramework.Controls.MetroDateTime bunifuDatepicker1;
    }
}