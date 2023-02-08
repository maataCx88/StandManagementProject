namespace StandManagementProject
{
    partial class achat_and_vente_détails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(achat_and_vente_détails));
            this.dataGridViewAchat = new System.Windows.Forms.DataGridView();
            this.dataGridViewVente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAchat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVente)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAchat
            // 
            this.dataGridViewAchat.AllowUserToAddRows = false;
            this.dataGridViewAchat.AllowUserToDeleteRows = false;
            this.dataGridViewAchat.AllowUserToResizeColumns = false;
            this.dataGridViewAchat.AllowUserToResizeRows = false;
            this.dataGridViewAchat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAchat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewAchat, "dataGridViewAchat");
            this.dataGridViewAchat.Name = "dataGridViewAchat";
            this.dataGridViewAchat.ReadOnly = true;
            this.dataGridViewAchat.RowTemplate.Height = 24;
            // 
            // dataGridViewVente
            // 
            this.dataGridViewVente.AllowUserToAddRows = false;
            this.dataGridViewVente.AllowUserToDeleteRows = false;
            this.dataGridViewVente.AllowUserToResizeColumns = false;
            this.dataGridViewVente.AllowUserToResizeRows = false;
            this.dataGridViewVente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridViewVente, "dataGridViewVente");
            this.dataGridViewVente.Name = "dataGridViewVente";
            this.dataGridViewVente.ReadOnly = true;
            this.dataGridViewVente.RowTemplate.Height = 24;
            // 
            // achat_and_vente_détails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewVente);
            this.Controls.Add(this.dataGridViewAchat);
            this.Name = "achat_and_vente_détails";
            this.Resizable = false;
            this.ShowIcon = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.achat_and_vente_détails_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAchat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAchat;
        private System.Windows.Forms.DataGridView dataGridViewVente;
    }
}