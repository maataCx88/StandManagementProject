namespace StandManagementProject
{
    partial class play
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
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            catch { }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(play));
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.trackList = new System.Windows.Forms.ListBox();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTrackStart = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.albumArt = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPrevious.Location = new System.Drawing.Point(18, 407);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(88, 25);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "Retour";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNext.Location = new System.Drawing.Point(116, 407);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(88, 25);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Suivant";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPlay.Location = new System.Drawing.Point(219, 407);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(88, 25);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPause.Location = new System.Drawing.Point(326, 407);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(88, 25);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStop.Location = new System.Drawing.Point(430, 407);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 25);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnOpen.Location = new System.Drawing.Point(565, 378);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(146, 38);
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Ouvrir";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Red;
            this.progressBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progressBar.Location = new System.Drawing.Point(12, 332);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(655, 20);
            this.progressBar.TabIndex = 6;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            this.progressBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progressBar_MouseDown);
            // 
            // trackList
            // 
            this.trackList.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.trackList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trackList.ForeColor = System.Drawing.Color.Black;
            this.trackList.FormattingEnabled = true;
            this.trackList.Location = new System.Drawing.Point(271, 118);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(396, 208);
            this.trackList.TabIndex = 7;
            this.trackList.SelectedIndexChanged += new System.EventHandler(this.trackList_SelectedIndexChanged);
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(683, 122);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVolume.Size = new System.Drawing.Size(45, 188);
            this.trackVolume.TabIndex = 10;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(680, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Volume";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.Black;
            this.lblVolume.Location = new System.Drawing.Point(689, 106);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(27, 13);
            this.lblVolume.TabIndex = 12;
            this.lblVolume.Text = "50%";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTrackStart
            // 
            this.lblTrackStart.AutoSize = true;
            this.lblTrackStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.lblTrackStart.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackStart.ForeColor = System.Drawing.Color.Black;
            this.lblTrackStart.Location = new System.Drawing.Point(3, 9);
            this.lblTrackStart.Name = "lblTrackStart";
            this.lblTrackStart.Size = new System.Drawing.Size(89, 37);
            this.lblTrackStart.TabIndex = 13;
            this.lblTrackStart.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTrackStart);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 46);
            this.panel1.TabIndex = 15;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseUp);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(234)))));
            this.guna2Panel1.Controls.Add(this.label17);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox3);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox4);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 46);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(747, 32);
            this.guna2Panel1.TabIndex = 33;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseDown);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseMove);
            this.guna2Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(4, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(394, 19);
            this.label17.TabIndex = 8;
            this.label17.Text = "DZOFTWARE STORE MANAGEMENT APP - LECTEUR MUSIQUE";
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox3.Location = new System.Drawing.Point(680, 0);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(31, 29);
            this.guna2ControlBox3.TabIndex = 3;
            // 
            // guna2ControlBox4
            // 
            this.guna2ControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox4.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox4.HoverState.Parent = this.guna2ControlBox4;
            this.guna2ControlBox4.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox4.Location = new System.Drawing.Point(716, 0);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.ShadowDecoration.Parent = this.guna2ControlBox4;
            this.guna2ControlBox4.Size = new System.Drawing.Size(31, 29);
            this.guna2ControlBox4.TabIndex = 2;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(747, 46);
            this.player.TabIndex = 9;
            this.player.Visible = false;
            // 
            // albumArt
            // 
            this.albumArt.BackColor = System.Drawing.Color.Transparent;
            this.albumArt.Image = global::StandManagementProject.Properties.Resources.cd_480px;
            this.albumArt.Location = new System.Drawing.Point(12, 90);
            this.albumArt.Name = "albumArt";
            this.albumArt.Size = new System.Drawing.Size(253, 237);
            this.albumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumArt.TabIndex = 42;
            this.albumArt.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::StandManagementProject.Properties.Resources.stop_squared_480px;
            this.pictureBox5.Location = new System.Drawing.Point(448, 357);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 44);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 49;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::StandManagementProject.Properties.Resources.pause_squared_480px;
            this.pictureBox4.Location = new System.Drawing.Point(344, 357);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(53, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::StandManagementProject.Properties.Resources.next_480px;
            this.pictureBox3.Location = new System.Drawing.Point(237, 357);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 44);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 51;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::StandManagementProject.Properties.Resources.last_480px;
            this.pictureBox2.Location = new System.Drawing.Point(134, 357);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StandManagementProject.Properties.Resources.previous_480px;
            this.pictureBox1.Location = new System.Drawing.Point(36, 357);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(747, 437);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.albumArt);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.trackList);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lecteur Musique";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Devis_to_Facture_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox trackList;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTrackStart;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private System.Windows.Forms.PictureBox albumArt;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}

