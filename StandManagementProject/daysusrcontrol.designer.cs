namespace StandManagementProject
{
    partial class daysusrcontrol
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labeldays = new System.Windows.Forms.Label();
            this.eventlbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labeldays
            // 
            this.labeldays.AutoSize = true;
            this.labeldays.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldays.Location = new System.Drawing.Point(12, 13);
            this.labeldays.Name = "labeldays";
            this.labeldays.Size = new System.Drawing.Size(31, 19);
            this.labeldays.TabIndex = 0;
            this.labeldays.Text = "00";
            // 
            // eventlbl
            // 
            this.eventlbl.Location = new System.Drawing.Point(9, 54);
            this.eventlbl.Name = "eventlbl";
            this.eventlbl.Size = new System.Drawing.Size(131, 54);
            this.eventlbl.TabIndex = 1;
            this.eventlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // daysusrcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.eventlbl);
            this.Controls.Add(this.labeldays);
            this.Name = "daysusrcontrol";
            this.Size = new System.Drawing.Size(150, 108);
            this.Load += new System.EventHandler(this.daysusrcontrol_Load);
            this.Click += new System.EventHandler(this.daysusrcontrol_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldays;
        private System.Windows.Forms.Label eventlbl;
        private System.Windows.Forms.Timer timer1;
    }
}
