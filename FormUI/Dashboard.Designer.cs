namespace FormUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchButton = new System.Windows.Forms.Button();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.peopleFoundListBox = new System.Windows.Forms.ListBox();
            this.firstNameInsText = new System.Windows.Forms.TextBox();
            this.firstNameInsLabel = new System.Windows.Forms.Label();
            this.lastNameInsText = new System.Windows.Forms.TextBox();
            this.lastNameInsLabel = new System.Windows.Forms.Label();
            this.emailInsText = new System.Windows.Forms.TextBox();
            this.emailInsLabel = new System.Windows.Forms.Label();
            this.phoneInsText = new System.Windows.Forms.TextBox();
            this.phoneInsLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(81, 129);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 46);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(81, 41);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(150, 23);
            this.lastNameText.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 44);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "Last Name";
            // 
            // peopleFoundListBox
            // 
            this.peopleFoundListBox.FormattingEnabled = true;
            this.peopleFoundListBox.ItemHeight = 15;
            this.peopleFoundListBox.Location = new System.Drawing.Point(12, 196);
            this.peopleFoundListBox.Name = "peopleFoundListBox";
            this.peopleFoundListBox.Size = new System.Drawing.Size(509, 229);
            this.peopleFoundListBox.TabIndex = 3;
            // 
            // firstNameInsText
            // 
            this.firstNameInsText.Location = new System.Drawing.Point(371, 12);
            this.firstNameInsText.Name = "firstNameInsText";
            this.firstNameInsText.Size = new System.Drawing.Size(150, 23);
            this.firstNameInsText.TabIndex = 1;
            // 
            // firstNameInsLabel
            // 
            this.firstNameInsLabel.AutoSize = true;
            this.firstNameInsLabel.Location = new System.Drawing.Point(301, 15);
            this.firstNameInsLabel.Name = "firstNameInsLabel";
            this.firstNameInsLabel.Size = new System.Drawing.Size(64, 15);
            this.firstNameInsLabel.TabIndex = 2;
            this.firstNameInsLabel.Text = "First Name";
            // 
            // lastNameInsText
            // 
            this.lastNameInsText.Location = new System.Drawing.Point(371, 41);
            this.lastNameInsText.Name = "lastNameInsText";
            this.lastNameInsText.Size = new System.Drawing.Size(150, 23);
            this.lastNameInsText.TabIndex = 1;
            // 
            // lastNameInsLabel
            // 
            this.lastNameInsLabel.AutoSize = true;
            this.lastNameInsLabel.Location = new System.Drawing.Point(302, 44);
            this.lastNameInsLabel.Name = "lastNameInsLabel";
            this.lastNameInsLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameInsLabel.TabIndex = 2;
            this.lastNameInsLabel.Text = "Last Name";
            // 
            // emailInsText
            // 
            this.emailInsText.Location = new System.Drawing.Point(370, 70);
            this.emailInsText.Name = "emailInsText";
            this.emailInsText.Size = new System.Drawing.Size(150, 23);
            this.emailInsText.TabIndex = 1;
            // 
            // emailInsLabel
            // 
            this.emailInsLabel.AutoSize = true;
            this.emailInsLabel.Location = new System.Drawing.Point(301, 73);
            this.emailInsLabel.Name = "emailInsLabel";
            this.emailInsLabel.Size = new System.Drawing.Size(36, 15);
            this.emailInsLabel.TabIndex = 2;
            this.emailInsLabel.Text = "Email";
            // 
            // phoneInsText
            // 
            this.phoneInsText.Location = new System.Drawing.Point(370, 99);
            this.phoneInsText.Name = "phoneInsText";
            this.phoneInsText.Size = new System.Drawing.Size(150, 23);
            this.phoneInsText.TabIndex = 1;
            // 
            // phoneInsLabel
            // 
            this.phoneInsLabel.AutoSize = true;
            this.phoneInsLabel.Location = new System.Drawing.Point(301, 102);
            this.phoneInsLabel.Name = "phoneInsLabel";
            this.phoneInsLabel.Size = new System.Drawing.Size(41, 15);
            this.phoneInsLabel.TabIndex = 2;
            this.phoneInsLabel.Text = "Phone";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(370, 129);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 46);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(533, 444);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameInsText);
            this.Controls.Add(this.lastNameInsText);
            this.Controls.Add(this.emailInsText);
            this.Controls.Add(this.phoneInsText);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.phoneInsLabel);
            this.Controls.Add(this.emailInsLabel);
            this.Controls.Add(this.lastNameInsLabel);
            this.Controls.Add(this.firstNameInsLabel);
            this.Controls.Add(this.peopleFoundListBox);
            this.Name = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.ListBox peopleFoundListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label firstNameInsLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label lastNameInsLabel;
        private System.Windows.Forms.Label emailInsLabel;
        private System.Windows.Forms.Label phoneInsLabel;
        private System.Windows.Forms.TextBox firstNameInsText;
        private System.Windows.Forms.TextBox lastNameInsText;
        private System.Windows.Forms.TextBox emailInsText;
        private System.Windows.Forms.TextBox phoneInsText;
    }
}

