namespace Simplified21Ethan
{
    partial class frmSimplified21
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
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.lblPlayerCard1 = new System.Windows.Forms.Label();
            this.lblPlayerCard2 = new System.Windows.Forms.Label();
            this.lblPlayerCard3 = new System.Windows.Forms.Label();
            this.lblDealerCard1 = new System.Windows.Forms.Label();
            this.lblDealerCard2 = new System.Windows.Forms.Label();
            this.lblDealerCard3 = new System.Windows.Forms.Label();
            this.lblYouWin = new System.Windows.Forms.Label();
            this.lblYouLose = new System.Windows.Forms.Label();
            this.lblYouTie = new System.Windows.Forms.Label();
            this.lblPlayerTotal = new System.Windows.Forms.Label();
            this.lblDealerTotal = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.picPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.picDealerCard1 = new System.Windows.Forms.PictureBox();
            this.picDealerCard2 = new System.Windows.Forms.PictureBox();
            this.picDealerCard3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(155, 380);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(92, 39);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.BtnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(533, 380);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(101, 39);
            this.btnStay.TabIndex = 3;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.BtnStay_Click);
            // 
            // lblPlayerCard1
            // 
            this.lblPlayerCard1.AutoSize = true;
            this.lblPlayerCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard1.Location = new System.Drawing.Point(56, 68);
            this.lblPlayerCard1.Name = "lblPlayerCard1";
            this.lblPlayerCard1.Size = new System.Drawing.Size(40, 24);
            this.lblPlayerCard1.TabIndex = 4;
            this.lblPlayerCard1.Text = "???";
            // 
            // lblPlayerCard2
            // 
            this.lblPlayerCard2.AutoSize = true;
            this.lblPlayerCard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard2.Location = new System.Drawing.Point(56, 185);
            this.lblPlayerCard2.Name = "lblPlayerCard2";
            this.lblPlayerCard2.Size = new System.Drawing.Size(40, 24);
            this.lblPlayerCard2.TabIndex = 5;
            this.lblPlayerCard2.Text = "???";
            // 
            // lblPlayerCard3
            // 
            this.lblPlayerCard3.AutoSize = true;
            this.lblPlayerCard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard3.Location = new System.Drawing.Point(56, 292);
            this.lblPlayerCard3.Name = "lblPlayerCard3";
            this.lblPlayerCard3.Size = new System.Drawing.Size(122, 24);
            this.lblPlayerCard3.TabIndex = 6;
            this.lblPlayerCard3.Text = "Player Card 3";
            // 
            // lblDealerCard1
            // 
            this.lblDealerCard1.AutoSize = true;
            this.lblDealerCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard1.Location = new System.Drawing.Point(654, 68);
            this.lblDealerCard1.Name = "lblDealerCard1";
            this.lblDealerCard1.Size = new System.Drawing.Size(40, 24);
            this.lblDealerCard1.TabIndex = 7;
            this.lblDealerCard1.Text = "???";
            // 
            // lblDealerCard2
            // 
            this.lblDealerCard2.AutoSize = true;
            this.lblDealerCard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard2.Location = new System.Drawing.Point(654, 185);
            this.lblDealerCard2.Name = "lblDealerCard2";
            this.lblDealerCard2.Size = new System.Drawing.Size(40, 24);
            this.lblDealerCard2.TabIndex = 8;
            this.lblDealerCard2.Text = "???";
            // 
            // lblDealerCard3
            // 
            this.lblDealerCard3.AutoSize = true;
            this.lblDealerCard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard3.Location = new System.Drawing.Point(655, 292);
            this.lblDealerCard3.Name = "lblDealerCard3";
            this.lblDealerCard3.Size = new System.Drawing.Size(40, 24);
            this.lblDealerCard3.TabIndex = 9;
            this.lblDealerCard3.Text = "???";
            // 
            // lblYouWin
            // 
            this.lblYouWin.AutoSize = true;
            this.lblYouWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouWin.Location = new System.Drawing.Point(291, 147);
            this.lblYouWin.Name = "lblYouWin";
            this.lblYouWin.Size = new System.Drawing.Size(157, 39);
            this.lblYouWin.TabIndex = 10;
            this.lblYouWin.Text = "You Win!";
            // 
            // lblYouLose
            // 
            this.lblYouLose.AutoSize = true;
            this.lblYouLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouLose.Location = new System.Drawing.Point(291, 147);
            this.lblYouLose.Name = "lblYouLose";
            this.lblYouLose.Size = new System.Drawing.Size(172, 39);
            this.lblYouLose.TabIndex = 12;
            this.lblYouLose.Text = "You Lose!";
            // 
            // lblYouTie
            // 
            this.lblYouTie.AutoSize = true;
            this.lblYouTie.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYouTie.Location = new System.Drawing.Point(344, 147);
            this.lblYouTie.Name = "lblYouTie";
            this.lblYouTie.Size = new System.Drawing.Size(75, 39);
            this.lblYouTie.TabIndex = 13;
            this.lblYouTie.Text = "Tie!";
            // 
            // lblPlayerTotal
            // 
            this.lblPlayerTotal.AutoSize = true;
            this.lblPlayerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTotal.Location = new System.Drawing.Point(241, 26);
            this.lblPlayerTotal.Name = "lblPlayerTotal";
            this.lblPlayerTotal.Size = new System.Drawing.Size(118, 24);
            this.lblPlayerTotal.TabIndex = 17;
            this.lblPlayerTotal.Text = "Player Total: ";
            // 
            // lblDealerTotal
            // 
            this.lblDealerTotal.AutoSize = true;
            this.lblDealerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerTotal.Location = new System.Drawing.Point(457, 26);
            this.lblDealerTotal.Name = "lblDealerTotal";
            this.lblDealerTotal.Size = new System.Drawing.Size(121, 24);
            this.lblDealerTotal.TabIndex = 18;
            this.lblDealerTotal.Text = "Dealer Total: ";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(300, 229);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(148, 66);
            this.btnPlay.TabIndex = 19;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // picPlayerCard1
            // 
            this.picPlayerCard1.Image = global::Simplified21Ethan.Properties.Resources.yellow_back;
            this.picPlayerCard1.Location = new System.Drawing.Point(33, 26);
            this.picPlayerCard1.Name = "picPlayerCard1";
            this.picPlayerCard1.Size = new System.Drawing.Size(116, 127);
            this.picPlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCard1.TabIndex = 20;
            this.picPlayerCard1.TabStop = false;
            // 
            // picPlayerCard2
            // 
            this.picPlayerCard2.Image = global::Simplified21Ethan.Properties.Resources.yellow_back;
            this.picPlayerCard2.Location = new System.Drawing.Point(33, 159);
            this.picPlayerCard2.Name = "picPlayerCard2";
            this.picPlayerCard2.Size = new System.Drawing.Size(116, 127);
            this.picPlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCard2.TabIndex = 21;
            this.picPlayerCard2.TabStop = false;
            // 
            // picPlayerCard3
            // 
            this.picPlayerCard3.Image = global::Simplified21Ethan.Properties.Resources.yellow_back;
            this.picPlayerCard3.Location = new System.Drawing.Point(33, 292);
            this.picPlayerCard3.Name = "picPlayerCard3";
            this.picPlayerCard3.Size = new System.Drawing.Size(116, 127);
            this.picPlayerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayerCard3.TabIndex = 22;
            this.picPlayerCard3.TabStop = false;
            // 
            // picDealerCard1
            // 
            this.picDealerCard1.Image = global::Simplified21Ethan.Properties.Resources.yellow_back;
            this.picDealerCard1.Location = new System.Drawing.Point(649, 26);
            this.picDealerCard1.Name = "picDealerCard1";
            this.picDealerCard1.Size = new System.Drawing.Size(116, 127);
            this.picDealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealerCard1.TabIndex = 23;
            this.picDealerCard1.TabStop = false;
            // 
            // picDealerCard2
            // 
            this.picDealerCard2.Image = global::Simplified21Ethan.Properties.Resources.yellow_back;
            this.picDealerCard2.Location = new System.Drawing.Point(649, 159);
            this.picDealerCard2.Name = "picDealerCard2";
            this.picDealerCard2.Size = new System.Drawing.Size(116, 127);
            this.picDealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealerCard2.TabIndex = 24;
            this.picDealerCard2.TabStop = false;
            // 
            // picDealerCard3
            // 
            this.picDealerCard3.Image = global::Simplified21Ethan.Properties.Resources.yellow_back;
            this.picDealerCard3.Location = new System.Drawing.Point(649, 292);
            this.picDealerCard3.Name = "picDealerCard3";
            this.picDealerCard3.Size = new System.Drawing.Size(116, 127);
            this.picDealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDealerCard3.TabIndex = 25;
            this.picDealerCard3.TabStop = false;
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picDealerCard3);
            this.Controls.Add(this.picDealerCard2);
            this.Controls.Add(this.picDealerCard1);
            this.Controls.Add(this.picPlayerCard3);
            this.Controls.Add(this.picPlayerCard2);
            this.Controls.Add(this.picPlayerCard1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblDealerTotal);
            this.Controls.Add(this.lblPlayerTotal);
            this.Controls.Add(this.lblYouTie);
            this.Controls.Add(this.lblYouLose);
            this.Controls.Add(this.lblYouWin);
            this.Controls.Add(this.lblDealerCard3);
            this.Controls.Add(this.lblDealerCard2);
            this.Controls.Add(this.lblDealerCard1);
            this.Controls.Add(this.lblPlayerCard3);
            this.Controls.Add(this.lblPlayerCard2);
            this.Controls.Add(this.lblPlayerCard1);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Name = "frmSimplified21";
            this.Text = "Simplified 21 by Ethan";
            this.Load += new System.EventHandler(this.FrmSimplified21_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Label lblPlayerCard1;
        private System.Windows.Forms.Label lblPlayerCard2;
        private System.Windows.Forms.Label lblPlayerCard3;
        private System.Windows.Forms.Label lblDealerCard1;
        private System.Windows.Forms.Label lblDealerCard2;
        private System.Windows.Forms.Label lblDealerCard3;
        private System.Windows.Forms.Label lblYouWin;
        private System.Windows.Forms.Label lblYouLose;
        private System.Windows.Forms.Label lblYouTie;
        private System.Windows.Forms.Label lblPlayerTotal;
        private System.Windows.Forms.Label lblDealerTotal;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox picPlayerCard1;
        private System.Windows.Forms.PictureBox picPlayerCard2;
        private System.Windows.Forms.PictureBox picPlayerCard3;
        private System.Windows.Forms.PictureBox picDealerCard1;
        private System.Windows.Forms.PictureBox picDealerCard2;
        private System.Windows.Forms.PictureBox picDealerCard3;
    }
}

