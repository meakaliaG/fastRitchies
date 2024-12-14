namespace fastRitchies
{
    partial class Checkout
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
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.cartItems = new System.Windows.Forms.ListBox();
            this.cartPrices = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.placeOrderLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderButton.Location = new System.Drawing.Point(97, 339);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(195, 72);
            this.placeOrderButton.TabIndex = 0;
            this.placeOrderButton.Text = "place order!";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // cartItems
            // 
            this.cartItems.FormattingEnabled = true;
            this.cartItems.Location = new System.Drawing.Point(8, 33);
            this.cartItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cartItems.Name = "cartItems";
            this.cartItems.Size = new System.Drawing.Size(199, 212);
            this.cartItems.TabIndex = 2;
            // 
            // cartPrices
            // 
            this.cartPrices.FormattingEnabled = true;
            this.cartPrices.Location = new System.Drawing.Point(210, 33);
            this.cartPrices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cartPrices.Name = "cartPrices";
            this.cartPrices.Size = new System.Drawing.Size(83, 212);
            this.cartPrices.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cart Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 55);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total:";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(221, 259);
            this.totalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(215, 82);
            this.totalPriceLabel.TabIndex = 7;
            this.totalPriceLabel.Text = "$0.00";
            // 
            // placeOrderLabel
            // 
            this.placeOrderLabel.AutoSize = true;
            this.placeOrderLabel.Location = new System.Drawing.Point(112, 429);
            this.placeOrderLabel.Name = "placeOrderLabel";
            this.placeOrderLabel.Size = new System.Drawing.Size(0, 13);
            this.placeOrderLabel.TabIndex = 8;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 812);
            this.Controls.Add(this.placeOrderLabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cartPrices);
            this.Controls.Add(this.cartItems);
            this.Controls.Add(this.placeOrderButton);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.ListBox cartItems;
        private System.Windows.Forms.ListBox cartPrices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label placeOrderLabel;
    }
}