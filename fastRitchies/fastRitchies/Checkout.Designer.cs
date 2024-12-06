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
            this.orderWindow = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderButton.Location = new System.Drawing.Point(593, 366);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(195, 72);
            this.placeOrderButton.TabIndex = 0;
            this.placeOrderButton.Text = "place order!";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // orderWindow
            // 
            this.orderWindow.HideSelection = false;
            this.orderWindow.Location = new System.Drawing.Point(0, 0);
            this.orderWindow.Name = "orderWindow";
            this.orderWindow.Size = new System.Drawing.Size(587, 372);
            this.orderWindow.TabIndex = 1;
            this.orderWindow.UseCompatibleStateImageBehavior = false;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderWindow);
            this.Controls.Add(this.placeOrderButton);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.ListView orderWindow;
    }
}