namespace Assignment8_IliaBogatyrev
{
    partial class Form1
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
            this.boyNameTextBox = new System.Windows.Forms.TextBox();
            this.girlNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(286, 255);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(123, 23);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Check";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // boyNameTextBox
            // 
            this.boyNameTextBox.Location = new System.Drawing.Point(201, 198);
            this.boyNameTextBox.Name = "boyNameTextBox";
            this.boyNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.boyNameTextBox.TabIndex = 1;
            this.boyNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // girlNameTextBox
            // 
            this.girlNameTextBox.Location = new System.Drawing.Point(405, 198);
            this.girlNameTextBox.Name = "girlNameTextBox";
            this.girlNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.girlNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type male name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type female name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.girlNameTextBox);
            this.Controls.Add(this.boyNameTextBox);
            this.Controls.Add(this.searchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button searchButton;
        private TextBox boyNameTextBox;
        private TextBox girlNameTextBox;
        private Label label1;
        private Label label2;
    }
}