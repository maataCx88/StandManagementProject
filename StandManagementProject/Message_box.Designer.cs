namespace StandManagementProject
{
    partial class Message_box
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message_box));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButtonyes = new MetroFramework.Controls.MetroButton();
            this.metroButtonno = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.metroButtonyes);
            this.panel2.Controls.Add(this.metroButtonno);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 105);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "          ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroButtonyes
            // 
            this.metroButtonyes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonyes.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonyes.ForeColor = System.Drawing.SystemColors.Control;
            this.metroButtonyes.Location = new System.Drawing.Point(222, 76);
            this.metroButtonyes.Name = "metroButtonyes";
            this.metroButtonyes.Size = new System.Drawing.Size(75, 23);
            this.metroButtonyes.TabIndex = 2;
            this.metroButtonyes.TabStop = false;
            this.metroButtonyes.Text = "YES";
            this.metroButtonyes.UseSelectable = true;
            this.metroButtonyes.Click += new System.EventHandler(this.metroButtonyes_Click);
            // 
            // metroButtonno
            // 
            this.metroButtonno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonno.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButtonno.ForeColor = System.Drawing.SystemColors.Control;
            this.metroButtonno.Location = new System.Drawing.Point(49, 76);
            this.metroButtonno.Name = "metroButtonno";
            this.metroButtonno.Size = new System.Drawing.Size(75, 23);
            this.metroButtonno.TabIndex = 1;
            this.metroButtonno.TabStop = false;
            this.metroButtonno.Text = "NO";
            this.metroButtonno.UseSelectable = true;
            this.metroButtonno.Click += new System.EventHandler(this.metroButtonno_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 16);
            this.panel1.TabIndex = 4;
            // 
            // Message_box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 120);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Message_box";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message DZOFTWARE";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        public MetroFramework.Controls.MetroButton metroButtonyes;
        public MetroFramework.Controls.MetroButton metroButtonno;
        private System.Windows.Forms.Panel panel1;
    }
}