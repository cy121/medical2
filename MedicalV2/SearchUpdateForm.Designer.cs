namespace MedicalV2
{
    partial class SearchUpdateForm
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
            this.LogIdTextBox = new System.Windows.Forms.TextBox();
            this.LogIdLabel = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SearchBynameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogIdTextBox
            // 
            this.LogIdTextBox.Location = new System.Drawing.Point(77, 32);
            this.LogIdTextBox.Name = "LogIdTextBox";
            this.LogIdTextBox.Size = new System.Drawing.Size(150, 21);
            this.LogIdTextBox.TabIndex = 0;
            // 
            // LogIdLabel
            // 
            this.LogIdLabel.AutoSize = true;
            this.LogIdLabel.Location = new System.Drawing.Point(17, 35);
            this.LogIdLabel.Name = "LogIdLabel";
            this.LogIdLabel.Size = new System.Drawing.Size(41, 12);
            this.LogIdLabel.TabIndex = 1;
            this.LogIdLabel.Text = "登记号";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(194, 74);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "查询";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(14, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(298, 142);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SearchBtn);
            this.tabPage1.Controls.Add(this.LogIdLabel);
            this.tabPage1.Controls.Add(this.LogIdTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(290, 116);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "按登记号查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SearchBynameBtn);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.NameTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(290, 116);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "按姓名查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SearchBynameBtn
            // 
            this.SearchBynameBtn.Location = new System.Drawing.Point(201, 76);
            this.SearchBynameBtn.Name = "SearchBynameBtn";
            this.SearchBynameBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBynameBtn.TabIndex = 5;
            this.SearchBynameBtn.Text = "查询";
            this.SearchBynameBtn.UseVisualStyleBackColor = true;
            this.SearchBynameBtn.Click += new System.EventHandler(this.SearchBynameBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "姓名";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(84, 34);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 21);
            this.NameTextBox.TabIndex = 3;
            // 
            // SearchUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 165);
            this.Controls.Add(this.tabControl1);
            this.Name = "SearchUpdateForm";
            this.Text = "复治查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchUpdateForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LogIdTextBox;
        private System.Windows.Forms.Label LogIdLabel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button SearchBynameBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}