namespace StandManagementProject
{
    partial class Détail_vente_only
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Détail_vente_only));
            this.détailsGrid = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.détailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // détailsGrid
            // 
            this.détailsGrid.AllowUserToAddRows = false;
            this.détailsGrid.AllowUserToDeleteRows = false;
            this.détailsGrid.AllowUserToResizeColumns = false;
            this.détailsGrid.AllowUserToResizeRows = false;
            this.détailsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.détailsGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.détailsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.détailsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.détailsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.détailsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.détailsGrid.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.détailsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.détailsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.détailsGrid.EnableHeadersVisualStyles = false;
            this.détailsGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.détailsGrid.GridColor = System.Drawing.Color.Gainsboro;
            this.détailsGrid.Location = new System.Drawing.Point(0, 0);
            this.détailsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.détailsGrid.Name = "détailsGrid";
            this.détailsGrid.ReadOnly = true;
            this.détailsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.détailsGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.détailsGrid.RowHeadersWidth = 51;
            this.détailsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.détailsGrid.RowTemplate.Height = 24;
            this.détailsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.détailsGrid.Size = new System.Drawing.Size(665, 356);
            this.détailsGrid.TabIndex = 3;
            // 
            // Détail_vente_only
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 356);
            this.Controls.Add(this.détailsGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(681, 395);
            this.MinimumSize = new System.Drawing.Size(681, 395);
            this.Name = "Détail_vente_only";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détails Bon";
            ((System.ComponentModel.ISupportInitialize)(this.détailsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroGrid détailsGrid;
    }
}