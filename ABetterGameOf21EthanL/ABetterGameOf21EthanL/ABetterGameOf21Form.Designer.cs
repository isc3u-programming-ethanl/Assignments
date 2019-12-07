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
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.AutoSize = true;
            this.lblPlayerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTotal.Location = new System.Drawing.Point(207, 9);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(95, 20);
            this.lblPlayerTotal.TabIndex = 3;
            this.lblPlayerTotal.Text = "Player Total:";
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerTotal.Location = new System.Drawing.Point(419, 9);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(99, 20);
            this.lblDealerTotal.TabIndex = 4;
            this.lblDealerTotal.Text = "Dealer Total:";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(305, 204);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(114, 58);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // lblYouWin
            // 
            this.lblYouWin.AutoSize = true;
            this.lblYouWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblYouLose.Location = new System.Drawing.Point(299, 114);
            this.lblYouLose.Name = "lblYouLose";
            this.lblYouLose.Size = new System.Drawing.Size(136, 31);
            this.lblYouLose.TabIndex = 10;
            this.lblYouLose.Text = "You Lose!";
            // 
            // lblYouTie
            // 
            this.lblYouTie.AutoSize = true;
            this.lblYouTie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouTie.Location = new System.Drawing.Point(330, 114);
            this.lblYouTie.Name = "lblYouTie";
            this.lblYouTie.Size = new System.Drawing.Size(60, 31);
            this.lblYouTie.TabIndex = 11;
            this.lblYouTie.Text = "Tie!";
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(28, 369);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(114, 58);
            this.btnHit.TabIndex = 12;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(607, 369);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(114, 58);
            this.btnStay.TabIndex = 13;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
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
            this.picDealerCard3.Size = new System.Drawing.Size(93, 108);
            this.picDealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealerCard3.TabIndex = 21;
            this.picDealerCard3.TabStop = false;
            // 
            // lblCardTotal
            // 
            this.lblCardTotal.AutoSize = true;
            this.lblCardTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardTotal.Location = new System.Drawing.Point(302, 393);
            this.lblCardTotal.Name = "lblCardTotal";
            this.lblCardTotal.Size = new System.Drawing.Size(91, 20);
            this.lblCardTotal.TabIndex = 22;
            this.lblCardTotal.Text = "Cards Left: ";
            // 
            // frmABetterGameOf21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(751, 450);
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
            this.Name = "frmABetterGameOf21";
            this.Text = "A Better Game Of 21 by Ethan";
            this.Load += new System.EventHandler(this.FrmABetterGameOf21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).EndInit();
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
    }
}

