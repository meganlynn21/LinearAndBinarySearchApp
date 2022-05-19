namespace Linear_and_Binary_Search_App
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
            this.LinearBtn = new System.Windows.Forms.Button();
            this.BinaryBtn = new System.Windows.Forms.Button();
            this.ArraySizeLabel = new System.Windows.Forms.Label();
            this.ArrayTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.SetUpBtn = new System.Windows.Forms.Button();
            this.SearchForNumLbl = new System.Windows.Forms.Label();
            this.lblArray = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LinearBtn
            // 
            this.LinearBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LinearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LinearBtn.Location = new System.Drawing.Point(89, 173);
            this.LinearBtn.Name = "LinearBtn";
            this.LinearBtn.Size = new System.Drawing.Size(158, 45);
            this.LinearBtn.TabIndex = 5;
            this.LinearBtn.Text = "Linear Search";
            this.LinearBtn.UseVisualStyleBackColor = false;
            this.LinearBtn.Click += new System.EventHandler(this.LinearBtn_Click);
            // 
            // BinaryBtn
            // 
            this.BinaryBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BinaryBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BinaryBtn.Location = new System.Drawing.Point(270, 173);
            this.BinaryBtn.Name = "BinaryBtn";
            this.BinaryBtn.Size = new System.Drawing.Size(166, 45);
            this.BinaryBtn.TabIndex = 6;
            this.BinaryBtn.Text = "Binary Search";
            this.BinaryBtn.UseVisualStyleBackColor = false;
            // 
            // ArraySizeLabel
            // 
            this.ArraySizeLabel.AutoSize = true;
            this.ArraySizeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ArraySizeLabel.Location = new System.Drawing.Point(56, 37);
            this.ArraySizeLabel.Name = "ArraySizeLabel";
            this.ArraySizeLabel.Size = new System.Drawing.Size(129, 25);
            this.ArraySizeLabel.TabIndex = 7;
            this.ArraySizeLabel.Text = "Size of Array?";
            // 
            // ArrayTextBox
            // 
            this.ArrayTextBox.Location = new System.Drawing.Point(242, 36);
            this.ArrayTextBox.Name = "ArrayTextBox";
            this.ArrayTextBox.Size = new System.Drawing.Size(125, 31);
            this.ArrayTextBox.TabIndex = 9;
            this.ArrayTextBox.TextChanged += new System.EventHandler(this.ArrayTextBox_TextChanged);
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(242, 90);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(125, 31);
            this.NumberTextBox.TabIndex = 10;
            // 
            // SetUpBtn
            // 
            this.SetUpBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SetUpBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SetUpBtn.Location = new System.Drawing.Point(421, 37);
            this.SetUpBtn.Name = "SetUpBtn";
            this.SetUpBtn.Size = new System.Drawing.Size(109, 34);
            this.SetUpBtn.TabIndex = 11;
            this.SetUpBtn.Text = "Set Up";
            this.SetUpBtn.UseVisualStyleBackColor = false;
            this.SetUpBtn.Click += new System.EventHandler(this.SetUpBtn_Click);
            // 
            // SearchForNumLbl
            // 
            this.SearchForNumLbl.AutoSize = true;
            this.SearchForNumLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchForNumLbl.Location = new System.Drawing.Point(56, 96);
            this.SearchForNumLbl.Name = "SearchForNumLbl";
            this.SearchForNumLbl.Size = new System.Drawing.Size(120, 25);
            this.SearchForNumLbl.TabIndex = 12;
            this.SearchForNumLbl.Text = "Search for #:";
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(105, 235);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(0, 25);
            this.lblArray.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(580, 442);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.SearchForNumLbl);
            this.Controls.Add(this.SetUpBtn);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.ArrayTextBox);
            this.Controls.Add(this.ArraySizeLabel);
            this.Controls.Add(this.BinaryBtn);
            this.Controls.Add(this.LinearBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button LinearBtn;
        private Button BinaryBtn;
        private Label ArraySizeLabel;
        private TextBox ArrayTextBox;
        private TextBox NumberTextBox;
        private Button SetUpBtn;
        private Label SearchForNumLbl;
        private Label lblArray;
    }
}