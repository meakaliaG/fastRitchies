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
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Controls.Add(this.MainsButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SidesButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DrinkButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DessertButton, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(194, 123);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MainsButton
            // 
            this.MainsButton.Location = new System.Drawing.Point(3, 3);
            this.MainsButton.Name = "MainsButton";
            this.MainsButton.Size = new System.Drawing.Size(75, 23);
            this.MainsButton.TabIndex = 0;
            this.MainsButton.Text = "Mains";
            this.MainsButton.UseVisualStyleBackColor = true;
            this.MainsButton.Click += new System.EventHandler(this.MainsButton_Click);
            // 
            // SidesButton
            // 
            this.SidesButton.Location = new System.Drawing.Point(90, 3);
            this.SidesButton.Name = "SidesButton";
            this.SidesButton.Size = new System.Drawing.Size(75, 23);
            this.SidesButton.TabIndex = 1;
            this.SidesButton.Text = "Sides";
            this.SidesButton.UseVisualStyleBackColor = true;
            this.SidesButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DrinkButton
            // 
            this.DrinkButton.Location = new System.Drawing.Point(177, 3);
            this.DrinkButton.Name = "DrinkButton";
            this.DrinkButton.Size = new System.Drawing.Size(75, 23);
            this.DrinkButton.TabIndex = 2;
            this.DrinkButton.Text = "Drinks";
            this.DrinkButton.UseVisualStyleBackColor = true;
            // 
            // DessertButton
            // 
            this.DessertButton.Location = new System.Drawing.Point(266, 3);
            this.DessertButton.Name = "DessertButton";
            this.DessertButton.Size = new System.Drawing.Size(75, 23);
            this.DessertButton.TabIndex = 3;
            this.DessertButton.Text = "Desserts";
            this.DessertButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 74);
            this.button1.TabIndex = 1;
            this.button1.Text = "Past Orders";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
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
        private System.Windows.Forms.Button button1;
    }
}

