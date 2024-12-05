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
            this.label1 = new System.Windows.Forms.Label();
            this.newAccountButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.newAccountButton);
            this.splitContainer1.Panel1.Controls.Add(this.loginButton);
            this.splitContainer1.Panel1.Controls.Add(this.usernameInput);
            this.splitContainer1.Size = new System.Drawing.Size(1126, 531);
            this.splitContainer1.SplitterDistance = 374;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login below with your username.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // newAccountButton
            // 
            this.newAccountButton.Location = new System.Drawing.Point(105, 311);
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
            this.usernameInput.TextChanged += new System.EventHandler(this.usernameInput_TextChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newAccountButton;
        private System.Windows.Forms.Button loginButton;
    }
}