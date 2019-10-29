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
            this.lblGSTText = new System.Windows.Forms.Label();
            this.lblTotalText = new System.Windows.Forms.Label();
            this.nupTypePizza = new System.Windows.Forms.NumericUpDown();
            this.nupToppingsChoice = new System.Windows.Forms.NumericUpDown();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblHST = new System.Windows.Forms.Label();
            this.lblSmallPizzaText = new System.Windows.Forms.Label();
            this.lblMediumPizzaText = new System.Windows.Forms.Label();
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
            this.lblSelectSizeText.Click += new System.EventHandler(this.LblSelectSizeText_Click);
            // 
            // lblLargePizzaText
            // 
            this.lblLargePizzaText.AutoSize = true;
            this.lblLargePizzaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargePizzaText.Location = new System.Drawing.Point(59, 250);
            this.lblLargePizzaText.Name = "lblLargePizzaText";
            this.lblLargePizzaText.Size = new System.Drawing.Size(177, 25);
            this.lblLargePizzaText.TabIndex = 1;
            this.lblLargePizzaText.Text = "Large Pizza = 3";
            this.lblLargePizzaText.Click += new System.EventHandler(this.LblLargePizzaText_Click);
            // 
            // lblExtraLargePizzaText
            // 
            this.lblExtraLargePizzaText.AutoSize = true;
            this.lblExtraLargePizzaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraLargePizzaText.Location = new System.Drawing.Point(59, 317);
            this.lblExtraLargePizzaText.Name = "lblExtraLargePizzaText";
            this.lblExtraLargePizzaText.Size = new System.Drawing.Size(239, 25);
            this.lblExtraLargePizzaText.TabIndex = 2;
            this.lblExtraLargePizzaText.Text = "Extra Large Pizza = 4";
            this.lblExtraLargePizzaText.Click += new System.EventHandler(this.LblExtraLargePizzaText_Click);
            // 
            // lblToppingsChoiceText
            // 
            this.lblToppingsChoiceText.AutoSize = true;
            this.lblToppingsChoiceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppingsChoiceText.Location = new System.Drawing.Point(53, 376);
            this.lblToppingsChoiceText.Name = "lblToppingsChoiceText";
            this.lblToppingsChoiceText.Size = new System.Drawing.Size(458, 25);
            this.lblToppingsChoiceText.TabIndex = 3;
            this.lblToppingsChoiceText.Text = "Select how many toppings you would like: ";
            this.lblToppingsChoiceText.Click += new System.EventHandler(this.LblToppingsChoiceText_Click);
            // 
            // lblSubtotalText
            // 
            this.lblSubtotalText.AutoSize = true;
            this.lblSubtotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotalText.Location = new System.Drawing.Point(109, 451);
            this.lblSubtotalText.Name = "lblSubtotalText";
            this.lblSubtotalText.Size = new System.Drawing.Size(119, 25);
            this.lblSubtotalText.TabIndex = 4;
            this.lblSubtotalText.Text = "Subtotal =";
            this.lblSubtotalText.Click += new System.EventHandler(this.LblSubtotalText_Click);
            // 
            // lblGSTText
            // 
            this.lblGSTText.AutoSize = true;
            this.lblGSTText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGSTText.Location = new System.Drawing.Point(151, 506);
            this.lblGSTText.Name = "lblGSTText";
            this.lblGSTText.Size = new System.Drawing.Size(77, 25);
            this.lblGSTText.TabIndex = 6;
            this.lblGSTText.Text = "HST =";
            this.lblGSTText.Click += new System.EventHandler(this.LblGSTText_Click);
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalText.Location = new System.Drawing.Point(143, 560);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(85, 25);
            this.lblTotalText.TabIndex = 7;
            this.lblTotalText.Text = "Total =";
            this.lblTotalText.Click += new System.EventHandler(this.LblTotalText_Click);
            // 
            // nupTypePizza
            // 
            this.nupTypePizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupTypePizza.Location = new System.Drawing.Point(523, 38);
            this.nupTypePizza.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nupTypePizza.Name = "nupTypePizza";
            this.nupTypePizza.Size = new System.Drawing.Size(54, 24);
            this.nupTypePizza.TabIndex = 8;
            this.nupTypePizza.ValueChanged += new System.EventHandler(this.NupTypePizza_ValueChanged);
            // 
            // nupToppingsChoice
            // 
            this.nupToppingsChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupToppingsChoice.Location = new System.Drawing.Point(538, 379);
            this.nupToppingsChoice.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nupToppingsChoice.Name = "nupToppingsChoice";
            this.nupToppingsChoice.Size = new System.Drawing.Size(54, 24);
            this.nupToppingsChoice.TabIndex = 9;
            this.nupToppingsChoice.ValueChanged += new System.EventHandler(this.NupToppingsChoice_ValueChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(265, 451);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(25, 25);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "?";
            this.lblSubtotal.Click += new System.EventHandler(this.LblSubtotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(265, 560);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 25);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "?";
            this.lblTotal.Click += new System.EventHandler(this.LblTotal_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(560, 500);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(157, 31);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHST.Location = new System.Drawing.Point(265, 506);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(25, 25);
            this.lblHST.TabIndex = 12;
            this.lblHST.Text = "?";
            this.lblHST.Click += new System.EventHandler(this.LblHST_Click);
            // 
            // lblSmallPizzaText
            // 
            this.lblSmallPizzaText.AutoSize = true;
            this.lblSmallPizzaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmallPizzaText.Location = new System.Drawing.Point(61, 99);
            this.lblSmallPizzaText.Name = "lblSmallPizzaText";
            this.lblSmallPizzaText.Size = new System.Drawing.Size(175, 25);
            this.lblSmallPizzaText.TabIndex = 15;
            this.lblSmallPizzaText.Text = "Small Pizza = 1";
            // 
            // lblMediumPizzaText
            // 
            this.lblMediumPizzaText.AutoSize = true;
            this.lblMediumPizzaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediumPizzaText.Location = new System.Drawing.Point(59, 176);
            this.lblMediumPizzaText.Name = "lblMediumPizzaText";
            this.lblMediumPizzaText.Size = new System.Drawing.Size(199, 25);
            this.lblMediumPizzaText.TabIndex = 16;
            this.lblMediumPizzaText.Text = "Medium Pizza = 2";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.lblMediumPizzaText);
            this.Controls.Add(this.lblSmallPizzaText);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblHST);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.nupToppingsChoice);
            this.Controls.Add(this.nupTypePizza);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.lblGSTText);
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
        private System.Windows.Forms.Label lblGSTText;
        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.NumericUpDown nupTypePizza;
        private System.Windows.Forms.NumericUpDown nupToppingsChoice;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblHST;
        private System.Windows.Forms.Label lblSmallPizzaText;
        private System.Windows.Forms.Label lblMediumPizzaText;
    }
}

