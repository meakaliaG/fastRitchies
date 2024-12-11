namespace fastRitchies
{
    partial class LoginPage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.loginLabel = new System.Windows.Forms.Label();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.menuButton = new System.Windows.Forms.Button();
            this.pastOrdersWindow = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.loginLabel);
            this.splitContainer1.Panel1.Controls.Add(this.newAccountButton);
            this.splitContainer1.Panel1.Controls.Add(this.loginButton);
            this.splitContainer1.Panel1.Controls.Add(this.usernameInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.menuButton);
            this.splitContainer1.Panel2.Controls.Add(this.pastOrdersWindow);
            this.splitContainer1.Size = new System.Drawing.Size(1126, 531);
            this.splitContainer1.SplitterDistance = 371;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoEllipsis = true;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(51, 177);
            this.loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(296, 22);
            this.loginLabel.TabIndex = 3;
            this.loginLabel.Text = "Login below with your username.";
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(108, 280);
            this.newAccountButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newAccountButton.Name = "newAccountButton";
            this.newAccountButton.Size = new System.Drawing.Size(150, 140);
            this.newAccountButton.TabIndex = 2;
            this.newAccountButton.Text = "Click here to create account.";
            this.newAccountButton.UseVisualStyleBackColor = true;
            this.newAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(264, 240);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(81, 31);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(105, 240);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(148, 26);
            this.usernameInput.TabIndex = 0;
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(504, 429);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(226, 83);
            this.menuButton.TabIndex = 2;
            this.menuButton.Text = "menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // pastOrdersWindow
            // 
            this.pastOrdersWindow.HideSelection = false;
            this.pastOrdersWindow.Location = new System.Drawing.Point(4, 5);
            this.pastOrdersWindow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pastOrdersWindow.Name = "pastOrdersWindow";
            this.pastOrdersWindow.Size = new System.Drawing.Size(738, 413);
            this.pastOrdersWindow.TabIndex = 1;
            this.pastOrdersWindow.UseCompatibleStateImageBehavior = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 531);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.ListView pastOrdersWindow;
        public System.Windows.Forms.TextBox usernameInput;
    }
}