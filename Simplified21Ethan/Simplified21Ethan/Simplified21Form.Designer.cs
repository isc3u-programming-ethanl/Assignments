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
            this.lblTitleText = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.lblPlayerCard1 = new System.Windows.Forms.Label();
            this.lblPlayerCard2 = new System.Windows.Forms.Label();
            this.lblPlayerCard3 = new System.Windows.Forms.Label();
            this.lblDealerCard1 = new System.Windows.Forms.Label();
            this.lblDealerCard2 = new System.Windows.Forms.Label();
            this.lblDealerCard3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitleText
            // 
            this.lblTitleText.AutoSize = true;
            this.lblTitleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleText.Location = new System.Drawing.Point(261, 68);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(243, 42);
            this.lblTitleText.TabIndex = 0;
            this.lblTitleText.Text = "Simplified 21";
            this.lblTitleText.Click += new System.EventHandler(this.LblTitleText_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(268, 147);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(221, 91);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(12, 366);
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
            this.btnStay.Location = new System.Drawing.Point(687, 366);
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
            this.lblPlayerCard1.Size = new System.Drawing.Size(122, 24);
            this.lblPlayerCard1.TabIndex = 4;
            this.lblPlayerCard1.Text = "Player Card 1";
            // 
            // lblPlayerCard2
            // 
            this.lblPlayerCard2.AutoSize = true;
            this.lblPlayerCard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard2.Location = new System.Drawing.Point(56, 185);
            this.lblPlayerCard2.Name = "lblPlayerCard2";
            this.lblPlayerCard2.Size = new System.Drawing.Size(122, 24);
            this.lblPlayerCard2.TabIndex = 5;
            this.lblPlayerCard2.Text = "Player Card 2";
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
            this.lblDealerCard1.Location = new System.Drawing.Point(633, 68);
            this.lblDealerCard1.Name = "lblDealerCard1";
            this.lblDealerCard1.Size = new System.Drawing.Size(125, 24);
            this.lblDealerCard1.TabIndex = 7;
            this.lblDealerCard1.Text = "Dealer Card 1";
            // 
            // lblDealerCard2
            // 
            this.lblDealerCard2.AutoSize = true;
            this.lblDealerCard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard2.Location = new System.Drawing.Point(633, 185);
            this.lblDealerCard2.Name = "lblDealerCard2";
            this.lblDealerCard2.Size = new System.Drawing.Size(125, 24);
            this.lblDealerCard2.TabIndex = 8;
            this.lblDealerCard2.Text = "Dealer Card 2";
            // 
            // lblDealerCard3
            // 
            this.lblDealerCard3.AutoSize = true;
            this.lblDealerCard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard3.Location = new System.Drawing.Point(633, 292);
            this.lblDealerCard3.Name = "lblDealerCard3";
            this.lblDealerCard3.Size = new System.Drawing.Size(125, 24);
            this.lblDealerCard3.TabIndex = 9;
            this.lblDealerCard3.Text = "Dealer Card 3";
            // 
            // frmSimplified21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDealerCard3);
            this.Controls.Add(this.lblDealerCard2);
            this.Controls.Add(this.lblDealerCard1);
            this.Controls.Add(this.lblPlayerCard3);
            this.Controls.Add(this.lblPlayerCard2);
            this.Controls.Add(this.lblPlayerCard1);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitleText);
            this.Name = "frmSimplified21";
            this.Text = "Simplified 21 by Ethan";
            this.Load += new System.EventHandler(this.FrmSimplified21_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleText;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.Label lblPlayerCard1;
        private System.Windows.Forms.Label lblPlayerCard2;
        private System.Windows.Forms.Label lblPlayerCard3;
        private System.Windows.Forms.Label lblDealerCard1;
        private System.Windows.Forms.Label lblDealerCard2;
        private System.Windows.Forms.Label lblDealerCard3;
    }
}

