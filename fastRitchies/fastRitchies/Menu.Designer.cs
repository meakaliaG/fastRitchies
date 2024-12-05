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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MainsButton = new System.Windows.Forms.Button();
            this.SidesButton = new System.Windows.Forms.Button();
            this.DrinkButton = new System.Windows.Forms.Button();
            this.DessertButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.Controls.Add(this.MainsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SidesButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DrinkButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DessertButton, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(291, 189);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 308);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MainsButton
            // 
            this.MainsButton.Location = new System.Drawing.Point(4, 5);
            this.MainsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainsButton.Name = "MainsButton";
            this.MainsButton.Size = new System.Drawing.Size(112, 35);
            this.MainsButton.TabIndex = 0;
            this.MainsButton.Text = "Mains";
            this.MainsButton.UseVisualStyleBackColor = true;
            this.MainsButton.Click += new System.EventHandler(this.MainsButton_Click);
            // 
            // SidesButton
            // 
            this.SidesButton.Location = new System.Drawing.Point(134, 5);
            this.SidesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SidesButton.Name = "SidesButton";
            this.SidesButton.Size = new System.Drawing.Size(112, 35);
            this.SidesButton.TabIndex = 1;
            this.SidesButton.Text = "Sides";
            this.SidesButton.UseVisualStyleBackColor = true;
            this.SidesButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DrinkButton
            // 
            this.DrinkButton.Location = new System.Drawing.Point(264, 5);
            this.DrinkButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DrinkButton.Name = "DrinkButton";
            this.DrinkButton.Size = new System.Drawing.Size(112, 35);
            this.DrinkButton.TabIndex = 2;
            this.DrinkButton.Text = "Drinks";
            this.DrinkButton.UseVisualStyleBackColor = true;
            // 
            // DessertButton
            // 
            this.DessertButton.Location = new System.Drawing.Point(398, 5);
            this.DessertButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DessertButton.Name = "DessertButton";
            this.DessertButton.Size = new System.Drawing.Size(112, 35);
            this.DessertButton.TabIndex = 3;
            this.DessertButton.Text = "Desserts";
            this.DessertButton.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button MainsButton;
        private System.Windows.Forms.Button SidesButton;
        private System.Windows.Forms.Button DrinkButton;
        private System.Windows.Forms.Button DessertButton;
    }
}

