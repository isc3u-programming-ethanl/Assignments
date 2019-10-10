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
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblPST = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
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
            this.lblLargePizzaText.Location = new System.Drawing.Point(61, 94);
            this.lblLargePizzaText.Name = "lblLargePizzaText";
            this.lblLargePizzaText.Size = new System.Drawing.Size(177, 25);
            this.lblLargePizzaText.TabIndex = 1;
            this.lblLargePizzaText.Text = "Large Pizza = 1";
            this.lblLargePizzaText.Click += new System.EventHandler(this.LblLargePizzaText_Click);
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
            this.lblExtraLargePizzaText.Click += new System.EventHandler(this.LblExtraLargePizzaText_Click);
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
            this.lblToppingsChoiceText.Click += new System.EventHandler(this.LblToppingsChoiceText_Click);
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
            this.lblSubtotalText.Click += new System.EventHandler(this.LblSubtotalText_Click);
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
            this.lblPstText.Click += new System.EventHandler(this.LblPstText_Click);
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
            this.lblGSTText.Click += new System.EventHandler(this.LblGSTText_Click);
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
            this.lblTotalText.Click += new System.EventHandler(this.LblTotalText_Click);
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
            this.nupTypePizza.ValueChanged += new System.EventHandler(this.NupTypePizza_ValueChanged);
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
            this.nupToppingsChoice.ValueChanged += new System.EventHandler(this.NupToppingsChoice_ValueChanged);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(265, 241);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(25, 25);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "?";
            this.lblSubtotal.Click += new System.EventHandler(this.LblSubtotal_Click);
            // 
            // lblPST
            // 
            this.lblPST.AutoSize = true;
            this.lblPST.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPST.Location = new System.Drawing.Point(265, 279);
            this.lblPST.Name = "lblPST";
            this.lblPST.Size = new System.Drawing.Size(25, 25);
            this.lblPST.TabIndex = 11;
            this.lblPST.Text = "?";
            this.lblPST.Click += new System.EventHandler(this.LblPST_Click);
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGST.Location = new System.Drawing.Point(265, 316);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(25, 25);
            this.lblGST.TabIndex = 12;
            this.lblGST.Text = "?";
            this.lblGST.Click += new System.EventHandler(this.LblGST_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(265, 358);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(25, 25);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "?";
            this.lblTotal.Click += new System.EventHandler(this.LblTotal_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(555, 310);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(157, 31);
            this.btnCalculate.TabIndex = 14;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.lblPST);
            this.Controls.Add(this.lblSubtotal);
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
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblPST;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
    }
}

