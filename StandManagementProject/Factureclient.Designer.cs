
namespace StandManagementProject
{
    partial class Factureclient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FacturClientGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.FacturClientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(335, 18);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(404, 44);
            this.bunifuDatepicker1.TabIndex = 0;
            this.bunifuDatepicker1.Value = new System.DateTime(2022, 3, 6, 20, 50, 23, 859);
            this.bunifuDatepicker1.onValueChanged += new System.EventHandler(this.bunifuDatepicker2_onValueChanged);
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker2.BorderRadius = 0;
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker2.FormatCustom = null;
            this.bunifuDatepicker2.Location = new System.Drawing.Point(851, 18);
            this.bunifuDatepicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(404, 44);
            this.bunifuDatepicker2.TabIndex = 1;
            this.bunifuDatepicker2.Value = new System.DateTime(2022, 3, 6, 20, 50, 23, 859);
            this.bunifuDatepicker2.onValueChanged += new System.EventHandler(this.bunifuDatepicker2_onValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 27);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(178, 27);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Liste Des Ventes";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(269, 27);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(40, 27);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "De";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(766, 18);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(62, 44);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "à";
            this.bunifuCustomLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FacturClientGrid
            // 
            this.FacturClientGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FacturClientGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.FacturClientGrid.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.FacturClientGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FacturClientGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FacturClientGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.FacturClientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FacturClientGrid.DoubleBuffered = true;
            this.FacturClientGrid.EnableHeadersVisualStyles = false;
            this.FacturClientGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FacturClientGrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.FacturClientGrid.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.FacturClientGrid.Location = new System.Drawing.Point(5, 89);
            this.FacturClientGrid.Name = "FacturClientGrid";
            this.FacturClientGrid.ReadOnly = true;
            this.FacturClientGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FacturClientGrid.RowHeadersWidth = 51;
            this.FacturClientGrid.RowTemplate.Height = 24;
            this.FacturClientGrid.Size = new System.Drawing.Size(1250, 456);
            this.FacturClientGrid.TabIndex = 5;
            this.FacturClientGrid.DoubleClick += new System.EventHandler(this.FacturClientGrid_DoubleClick);
            // 
            // Factureclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1262, 553);
            this.Controls.Add(this.FacturClientGrid);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuDatepicker2);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Name = "Factureclient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.FacturClientGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid FacturClientGrid;
    }
}