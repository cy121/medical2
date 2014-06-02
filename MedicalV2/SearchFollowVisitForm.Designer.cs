namespace MedicalV2
{
    partial class SearchFollowVisitForm
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
            this.FVSearchBtn = new System.Windows.Forms.Button();
            this.LogIdLabel = new System.Windows.Forms.Label();
            this.LogIdTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.FVSearchByNameBtn = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FVSearchBtn
            // 
            this.FVSearchBtn.Location = new System.Drawing.Point(137, 86);
            this.FVSearchBtn.Name = "FVSearchBtn";
            this.FVSearchBtn.Size = new System.Drawing.Size(66, 27);
            this.FVSearchBtn.TabIndex = 5;
            this.FVSearchBtn.Text = "查询";
            this.FVSearchBtn.UseVisualStyleBackColor = true;
            this.FVSearchBtn.Click += new System.EventHandler(this.FVSearchBtn_Click);
            // 
            // LogIdLabel
            // 
            this.LogIdLabel.AutoSize = true;
            this.LogIdLabel.Location = new System.Drawing.Point(6, 49);
            this.LogIdLabel.Name = "LogIdLabel";
            this.LogIdLabel.Size = new System.Drawing.Size(41, 12);
            this.LogIdLabel.TabIndex = 4;
            this.LogIdLabel.Text = "登记号";
            // 
            // LogIdTextBox
            // 
            this.LogIdTextBox.Location = new System.Drawing.Point(53, 46);
            this.LogIdTextBox.Name = "LogIdTextBox";
            this.LogIdTextBox.Size = new System.Drawing.Size(150, 21);
            this.LogIdTextBox.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(231, 145);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LogIdLabel);
            this.tabPage1.Controls.Add(this.FVSearchBtn);
            this.tabPage1.Controls.Add(this.LogIdTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(223, 119);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "按登记号查询";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.FVSearchByNameBtn);
            this.tabPage2.Controls.Add(this.NameTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(223, 119);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "按姓名查询";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "姓名";
            // 
            // FVSearchByNameBtn
            // 
            this.FVSearchByNameBtn.Location = new System.Drawing.Point(140, 75);
            this.FVSearchByNameBtn.Name = "FVSearchByNameBtn";
            this.FVSearchByNameBtn.Size = new System.Drawing.Size(66, 27);
            this.FVSearchByNameBtn.TabIndex = 8;
            this.FVSearchByNameBtn.Text = "查询";
            this.FVSearchByNameBtn.UseVisualStyleBackColor = true;
            this.FVSearchByNameBtn.Click += new System.EventHandler(this.FVSearchByNameBtn_Click);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(56, 35);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(150, 21);
            this.NameTextBox.TabIndex = 6;
            // 
            // SearchFollowVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 173);
            this.Controls.Add(this.tabControl1);
            this.Name = "SearchFollowVisitForm";
            this.Text = "查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchFollowVisitForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FVSearchBtn;
        private System.Windows.Forms.Label LogIdLabel;
        private System.Windows.Forms.TextBox LogIdTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FVSearchByNameBtn;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}