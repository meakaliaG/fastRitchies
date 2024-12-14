namespace fastRitchies
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainsButton = new System.Windows.Forms.Button();
            this.SidesButton = new System.Windows.Forms.Button();
            this.DrinkButton = new System.Windows.Forms.Button();
            this.DessertButton = new System.Windows.Forms.Button();
            this.pastOrdersButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cartCountLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.MainsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SidesButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DrinkButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DessertButton, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 575);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MainsButton
            // 
            this.MainsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainsButton.Image = ((System.Drawing.Image)(resources.GetObject("MainsButton.Image")));
            this.MainsButton.Location = new System.Drawing.Point(3, 3);
            this.MainsButton.Name = "MainsButton";
            this.MainsButton.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.MainsButton.Size = new System.Drawing.Size(162, 92);
            this.MainsButton.TabIndex = 0;
            this.MainsButton.Text = "Mains";
            this.MainsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.MainsButton.UseVisualStyleBackColor = true;
            this.MainsButton.Click += new System.EventHandler(this.ShowMains);
            // 
            // SidesButton
            // 
            this.SidesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SidesButton.Image = ((System.Drawing.Image)(resources.GetObject("SidesButton.Image")));
            this.SidesButton.Location = new System.Drawing.Point(171, 3);
            this.SidesButton.Name = "SidesButton";
            this.SidesButton.Padding = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.SidesButton.Size = new System.Drawing.Size(162, 92);
            this.SidesButton.TabIndex = 1;
            this.SidesButton.Text = "Sides";
            this.SidesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SidesButton.UseVisualStyleBackColor = true;
            this.SidesButton.Click += new System.EventHandler(this.ShowSides);
            // 
            // DrinkButton
            // 
            this.DrinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinkButton.Image = ((System.Drawing.Image)(resources.GetObject("DrinkButton.Image")));
            this.DrinkButton.Location = new System.Drawing.Point(339, 3);
            this.DrinkButton.Name = "DrinkButton";
            this.DrinkButton.Padding = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.DrinkButton.Size = new System.Drawing.Size(162, 92);
            this.DrinkButton.TabIndex = 2;
            this.DrinkButton.Text = "Drinks";
            this.DrinkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DrinkButton.UseVisualStyleBackColor = true;
            this.DrinkButton.Click += new System.EventHandler(this.ShowDrinks);
            // 
            // DessertButton
            // 
            this.DessertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DessertButton.Image = ((System.Drawing.Image)(resources.GetObject("DessertButton.Image")));
            this.DessertButton.Location = new System.Drawing.Point(507, 3);
            this.DessertButton.Name = "DessertButton";
            this.DessertButton.Size = new System.Drawing.Size(163, 92);
            this.DessertButton.TabIndex = 3;
            this.DessertButton.Text = "Desserts";
            this.DessertButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DessertButton.UseVisualStyleBackColor = true;
            this.DessertButton.Click += new System.EventHandler(this.ShowDesserts);
            // 
            // pastOrdersButton
            // 
            this.pastOrdersButton.Location = new System.Drawing.Point(706, 93);
            this.pastOrdersButton.Name = "pastOrdersButton";
            this.pastOrdersButton.Size = new System.Drawing.Size(82, 74);
            this.pastOrdersButton.TabIndex = 1;
            this.pastOrdersButton.Text = "Past Orders";
            this.pastOrdersButton.UseVisualStyleBackColor = true;
            this.pastOrdersButton.Visible = false;
            this.pastOrdersButton.Click += new System.EventHandler(this.pastOrdersButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GoToCart);
            // 
            // cartCountLabel
            // 
            this.cartCountLabel.AutoSize = true;
            this.cartCountLabel.Location = new System.Drawing.Point(796, 30);
            this.cartCountLabel.Name = "cartCountLabel";
            this.cartCountLabel.Size = new System.Drawing.Size(31, 31);
            this.cartCountLabel.TabIndex = 3;
            this.cartCountLabel.Text = "0";
            this.cartCountLabel.Click += new System.EventHandler(this.cartCountLabel_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 612);
            this.Controls.Add(this.cartCountLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pastOrdersButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button MainsButton;
        private System.Windows.Forms.Button SidesButton;
        private System.Windows.Forms.Button DrinkButton;
        private System.Windows.Forms.Button DessertButton;
        private System.Windows.Forms.Button pastOrdersButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cartCountLabel;
    }
}

