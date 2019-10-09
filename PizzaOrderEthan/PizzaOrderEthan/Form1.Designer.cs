namespace PizzaOrderEthan
{
    partial class frmPizzaOrder
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
            this.lblSelectSizeText = new System.Windows.Forms.Label();
            this.lblLargePizzaText = new System.Windows.Forms.Label();
            this.lblExtraLargePizzaText = new System.Windows.Forms.Label();
            this.lblToppingsChoiceText = new System.Windows.Forms.Label();
            this.lblSubtotalText = new System.Windows.Forms.Label();
            this.lblPstText = new System.Windows.Forms.Label();
            this.lblGSTText = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.nupTypePizza = new System.Windows.Forms.NumericUpDown();
            this.nupToppingsChoice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nupTypePizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupToppingsChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectSizeText
            // 
            this.lblSelectSizeText.AutoSize = true;
            this.lblSelectSizeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSizeText.Location = new System.Drawing.Point(59, 35);
            this.lblSelectSizeText.Name = "lblSelectSizeText";
            this.lblSelectSizeText.Size = new System.Drawing.Size(422, 25);
            this.lblSelectSizeText.TabIndex = 0;
            this.lblSelectSizeText.Text = "Select the size of pizza you would like:";
            // 
            // lblLargePizzaText
            // 
            this.lblLargePizzaText.AutoSize = true;
            this.lblLargePizzaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargePizzaText.Location = new System.Drawing.Point(61, 94);
            this.lblLargePizzaText.Name = "lblLargePizzaText";
            this.lblLargePizzaText.Size = new System.Drawing.Size(177, 25);
            this.lblLargePizzaText.TabIndex = 1;
            this.lblLargePizzaText.Text = "Large Pizza = 1";
            // 
            // lblExtraLargePizzaText
            // 
            this.lblExtraLargePizzaText.AutoSize = true;
            this.lblExtraLargePizzaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraLargePizzaText.Location = new System.Drawing.Point(61, 139);
            this.lblExtraLargePizzaText.Name = "lblExtraLargePizzaText";
            this.lblExtraLargePizzaText.Size = new System.Drawing.Size(239, 25);
            this.lblExtraLargePizzaText.TabIndex = 2;
            this.lblExtraLargePizzaText.Text = "Extra Large Pizza = 2";
            // 
            // lblToppingsChoiceText
            // 
            this.lblToppingsChoiceText.AutoSize = true;
            this.lblToppingsChoiceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsChoiceText.Location = new System.Drawing.Point(59, 195);
            this.lblToppingsChoiceText.Name = "lblToppingsChoiceText";
            this.lblToppingsChoiceText.Size = new System.Drawing.Size(458, 25);
            this.lblToppingsChoiceText.TabIndex = 3;
            this.lblToppingsChoiceText.Text = "Select how many toppings you would like: ";
            // 
            // lblSubtotalText
            // 
            this.lblSubtotalText.AutoSize = true;
            this.lblSubtotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalText.Location = new System.Drawing.Point(110, 241);
            this.lblSubtotalText.Name = "lblSubtotalText";
            this.lblSubtotalText.Size = new System.Drawing.Size(119, 25);
            this.lblSubtotalText.TabIndex = 4;
            this.lblSubtotalText.Text = "Subtotal =";
            // 
            // lblPstText
            // 
            this.lblPstText.AutoSize = true;
            this.lblPstText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPstText.Location = new System.Drawing.Point(153, 279);
            this.lblPstText.Name = "lblPstText";
            this.lblPstText.Size = new System.Drawing.Size(76, 25);
            this.lblPstText.TabIndex = 5;
            this.lblPstText.Text = "PST =";
            // 
            // lblGSTText
            // 
            this.lblGSTText.AutoSize = true;
            this.lblGSTText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGSTText.Location = new System.Drawing.Point(151, 316);
            this.lblGSTText.Name = "lblGSTText";
            this.lblGSTText.Size = new System.Drawing.Size(78, 25);
            this.lblGSTText.TabIndex = 6;
            this.lblGSTText.Text = "GST =";
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalText.Location = new System.Drawing.Point(144, 358);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(85, 25);
            this.lblTotalText.TabIndex = 7;
            this.lblTotalText.Text = "Total =";
            // 
            // nupTypePizza
            // 
            this.nupTypePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupTypePizza.Location = new System.Drawing.Point(517, 38);
            this.nupTypePizza.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nupTypePizza.Name = "nupTypePizza";
            this.nupTypePizza.Size = new System.Drawing.Size(54, 24);
            this.nupTypePizza.TabIndex = 8;
            // 
            // nupToppingsChoice
            // 
            this.nupToppingsChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupToppingsChoice.Location = new System.Drawing.Point(517, 195);
            this.nupToppingsChoice.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nupToppingsChoice.Name = "nupToppingsChoice";
            this.nupToppingsChoice.Size = new System.Drawing.Size(54, 24);
            this.nupToppingsChoice.TabIndex = 9;
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nupToppingsChoice);
            this.Controls.Add(this.nupTypePizza);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.lblGSTText);
            this.Controls.Add(this.lblPstText);
            this.Controls.Add(this.lblSubtotalText);
            this.Controls.Add(this.lblToppingsChoiceText);
            this.Controls.Add(this.lblExtraLargePizzaText);
            this.Controls.Add(this.lblLargePizzaText);
            this.Controls.Add(this.lblSelectSizeText);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order by Ethan";
            this.Load += new System.EventHandler(this.FrmPizzaOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupTypePizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupToppingsChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectSizeText;
        private System.Windows.Forms.Label lblLargePizzaText;
        private System.Windows.Forms.Label lblExtraLargePizzaText;
        private System.Windows.Forms.Label lblToppingsChoiceText;
        private System.Windows.Forms.Label lblSubtotalText;
        private System.Windows.Forms.Label lblPstText;
        private System.Windows.Forms.Label lblGSTText;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.NumericUpDown nupTypePizza;
        private System.Windows.Forms.NumericUpDown nupToppingsChoice;
    }
}

