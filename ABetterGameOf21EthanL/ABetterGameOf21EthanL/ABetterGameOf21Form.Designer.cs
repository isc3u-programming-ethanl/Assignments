namespace ABetterGameOf21EthanL
{
    partial class frmABetterGameOf21
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
            this.lblPlayerTotal = new System.Windows.Forms.Label();
            this.lblDealerTotal = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblYouWin = new System.Windows.Forms.Label();
            this.lblYouLose = new System.Windows.Forms.Label();
            this.lblYouTie = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.picPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.picDealerCard1 = new System.Windows.Forms.PictureBox();
            this.picDealerCard2 = new System.Windows.Forms.PictureBox();
            this.picDealerCard3 = new System.Windows.Forms.PictureBox();
            this.lblCardTotal = new System.Windows.Forms.Label();
            this.mniMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.nudBet = new System.Windows.Forms.NumericUpDown();
            this.btnBet = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).BeginInit();
            this.mniMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.AutoSize = true;
            this.lblPlayerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTotal.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblPlayerTotal.Location = new System.Drawing.Point(179, 10);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(95, 20);
            this.lblPlayerTotal.TabIndex = 3;
            this.lblPlayerTotal.Text = "Player Total:";
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerTotal.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblDealerTotal.Location = new System.Drawing.Point(396, 9);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(99, 20);
            this.lblDealerTotal.TabIndex = 4;
            this.lblDealerTotal.Text = "Dealer Total:";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(305, 204);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(114, 58);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // lblYouWin
            // 
            this.lblYouWin.AutoSize = true;
            this.lblYouWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouWin.ForeColor = System.Drawing.Color.Lime;
            this.lblYouWin.Location = new System.Drawing.Point(299, 114);
            this.lblYouWin.Name = "lblYouWin";
            this.lblYouWin.Size = new System.Drawing.Size(123, 31);
            this.lblYouWin.TabIndex = 9;
            this.lblYouWin.Text = "You Win!";
            // 
            // lblYouLose
            // 
            this.lblYouLose.AutoSize = true;
            this.lblYouLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouLose.ForeColor = System.Drawing.Color.Red;
            this.lblYouLose.Location = new System.Drawing.Point(300, 114);
            this.lblYouLose.Name = "lblYouLose";
            this.lblYouLose.Size = new System.Drawing.Size(136, 31);
            this.lblYouLose.TabIndex = 10;
            this.lblYouLose.Text = "You Lose!";
            // 
            // lblYouTie
            // 
            this.lblYouTie.AutoSize = true;
            this.lblYouTie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouTie.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblYouTie.Location = new System.Drawing.Point(330, 114);
            this.lblYouTie.Name = "lblYouTie";
            this.lblYouTie.Size = new System.Drawing.Size(60, 31);
            this.lblYouTie.TabIndex = 11;
            this.lblYouTie.Text = "Tie!";
            // 
            // btnHit
            // 
            this.btnHit.BackColor = System.Drawing.Color.DarkRed;
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.ForeColor = System.Drawing.Color.White;
            this.btnHit.Location = new System.Drawing.Point(59, 369);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(114, 58);
            this.btnHit.TabIndex = 12;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = false;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.ForeColor = System.Drawing.Color.White;
            this.btnStay.Location = new System.Drawing.Point(564, 369);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(114, 58);
            this.btnStay.TabIndex = 13;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = false;
            this.btnStay.Click += new System.EventHandler(this.BtnStay_Click);
            // 
            // picPlayerCard3
            // 
            this.picPlayerCard3.Image = global::ABetterGameOf21EthanL.Properties.Resources.red_back;
            this.picPlayerCard3.Location = new System.Drawing.Point(69, 249);
            this.picPlayerCard3.Name = "picPlayerCard3";
            this.picPlayerCard3.Size = new System.Drawing.Size(93, 114);
            this.picPlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCard3.TabIndex = 16;
            this.picPlayerCard3.TabStop = false;
            // 
            // picPlayerCard2
            // 
            this.picPlayerCard2.Image = global::ABetterGameOf21EthanL.Properties.Resources.red_back;
            this.picPlayerCard2.Location = new System.Drawing.Point(69, 135);
            this.picPlayerCard2.Name = "picPlayerCard2";
            this.picPlayerCard2.Size = new System.Drawing.Size(93, 108);
            this.picPlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCard2.TabIndex = 17;
            this.picPlayerCard2.TabStop = false;
            // 
            // picPlayerCard1
            // 
            this.picPlayerCard1.Image = global::ABetterGameOf21EthanL.Properties.Resources.red_back;
            this.picPlayerCard1.Location = new System.Drawing.Point(69, 21);
            this.picPlayerCard1.Name = "picPlayerCard1";
            this.picPlayerCard1.Size = new System.Drawing.Size(93, 108);
            this.picPlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCard1.TabIndex = 18;
            this.picPlayerCard1.TabStop = false;
            // 
            // picDealerCard1
            // 
            this.picDealerCard1.Image = global::ABetterGameOf21EthanL.Properties.Resources.red_back;
            this.picDealerCard1.Location = new System.Drawing.Point(573, 21);
            this.picDealerCard1.Name = "picDealerCard1";
            this.picDealerCard1.Size = new System.Drawing.Size(93, 108);
            this.picDealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealerCard1.TabIndex = 19;
            this.picDealerCard1.TabStop = false;
            // 
            // picDealerCard2
            // 
            this.picDealerCard2.Image = global::ABetterGameOf21EthanL.Properties.Resources.red_back;
            this.picDealerCard2.Location = new System.Drawing.Point(573, 135);
            this.picDealerCard2.Name = "picDealerCard2";
            this.picDealerCard2.Size = new System.Drawing.Size(93, 108);
            this.picDealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealerCard2.TabIndex = 20;
            this.picDealerCard2.TabStop = false;
            // 
            // picDealerCard3
            // 
            this.picDealerCard3.Image = global::ABetterGameOf21EthanL.Properties.Resources.red_back;
            this.picDealerCard3.Location = new System.Drawing.Point(573, 249);
            this.picDealerCard3.Name = "picDealerCard3";
            this.picDealerCard3.Size = new System.Drawing.Size(93, 114);
            this.picDealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealerCard3.TabIndex = 21;
            this.picDealerCard3.TabStop = false;
            // 
            // lblCardTotal
            // 
            this.lblCardTotal.AutoSize = true;
            this.lblCardTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTotal.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblCardTotal.Location = new System.Drawing.Point(302, 393);
            this.lblCardTotal.Name = "lblCardTotal";
            this.lblCardTotal.Size = new System.Drawing.Size(91, 20);
            this.lblCardTotal.TabIndex = 22;
            this.lblCardTotal.Text = "Cards Left: ";
            // 
            // mniMenu
            // 
            this.mniMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mniMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMenu});
            this.mniMenu.Location = new System.Drawing.Point(0, 0);
            this.mniMenu.Name = "mniMenu";
            this.mniMenu.Size = new System.Drawing.Size(41, 30);
            this.mniMenu.TabIndex = 23;
            this.mniMenu.Text = "Menu";
            // 
            // mnuMenu
            // 
            this.mnuMenu.BackColor = System.Drawing.Color.DarkGreen;
            this.mnuMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNewGame,
            this.mniExit});
            this.mnuMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMenu.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.mnuMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnuMenu.ImageTransparentColor = System.Drawing.Color.DarkGreen;
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(33, 26);
            this.mnuMenu.Text = "...";
            this.mnuMenu.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.mnuMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.mnuMenu.ToolTipText = "Menu";
            // 
            // mniNewGame
            // 
            this.mniNewGame.BackColor = System.Drawing.Color.DarkGreen;
            this.mniNewGame.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniNewGame.ForeColor = System.Drawing.Color.SpringGreen;
            this.mniNewGame.Name = "mniNewGame";
            this.mniNewGame.Size = new System.Drawing.Size(163, 26);
            this.mniNewGame.Text = "New Game";
            this.mniNewGame.Click += new System.EventHandler(this.MniNewGame_Click);
            // 
            // mniExit
            // 
            this.mniExit.BackColor = System.Drawing.Color.Maroon;
            this.mniExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniExit.ForeColor = System.Drawing.Color.Red;
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(163, 26);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // nudBet
            // 
            this.nudBet.BackColor = System.Drawing.SystemColors.HotTrack;
            this.nudBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBet.ForeColor = System.Drawing.Color.White;
            this.nudBet.Location = new System.Drawing.Point(287, 341);
            this.nudBet.Name = "nudBet";
            this.nudBet.Size = new System.Drawing.Size(83, 38);
            this.nudBet.TabIndex = 24;
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.ForeColor = System.Drawing.Color.White;
            this.btnBet.Location = new System.Drawing.Point(376, 341);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(52, 38);
            this.btnBet.TabIndex = 25;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.BtnBet_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblBalance.Location = new System.Drawing.Point(288, 318);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(109, 20);
            this.lblBalance.TabIndex = 26;
            this.lblBalance.Text = "Your Balance:";
            // 
            // frmABetterGameOf21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.nudBet);
            this.Controls.Add(this.lblCardTotal);
            this.Controls.Add(this.picDealerCard3);
            this.Controls.Add(this.picDealerCard2);
            this.Controls.Add(this.picDealerCard1);
            this.Controls.Add(this.picPlayerCard1);
            this.Controls.Add(this.picPlayerCard2);
            this.Controls.Add(this.picPlayerCard3);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.lblYouTie);
            this.Controls.Add(this.lblYouLose);
            this.Controls.Add(this.lblYouWin);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblDealerTotal);
            this.Controls.Add(this.lblPlayerTotal);
            this.Controls.Add(this.mniMenu);
            this.MainMenuStrip = this.mniMenu;
            this.Name = "frmABetterGameOf21";
            this.Text = "A Better Game Of 21 by Ethan";
            this.Load += new System.EventHandler(this.FrmABetterGameOf21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).EndInit();
            this.mniMenu.ResumeLayout(false);
            this.mniMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.Label lblDealerTotal;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblYouWin;
        private System.Windows.Forms.Label lblYouLose;
        private System.Windows.Forms.Label lblYouTie;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.PictureBox picPlayerCard3;
        private System.Windows.Forms.PictureBox picPlayerCard2;
        private System.Windows.Forms.PictureBox picPlayerCard1;
        private System.Windows.Forms.PictureBox picDealerCard1;
        private System.Windows.Forms.PictureBox picDealerCard2;
        private System.Windows.Forms.PictureBox picDealerCard3;
        private System.Windows.Forms.Label lblCardTotal;
        private System.Windows.Forms.MenuStrip mniMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniNewGame;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.NumericUpDown nudBet;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Label lblBalance;
    }
}

