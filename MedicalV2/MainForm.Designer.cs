namespace MedicalV2
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CureFirstBtn = new System.Windows.Forms.Button();
            this.SearchUpdateBtn = new System.Windows.Forms.Button();
            this.SearchFollowVisitBtn = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CureFirstBtn
            // 
            this.CureFirstBtn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CureFirstBtn.Location = new System.Drawing.Point(172, 73);
            this.CureFirstBtn.Name = "CureFirstBtn";
            this.CureFirstBtn.Size = new System.Drawing.Size(147, 47);
            this.CureFirstBtn.TabIndex = 0;
            this.CureFirstBtn.Text = "初治";
            this.CureFirstBtn.UseVisualStyleBackColor = true;
            this.CureFirstBtn.Click += new System.EventHandler(this.CureFirstBtn_Click);
            // 
            // SearchUpdateBtn
            // 
            this.SearchUpdateBtn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchUpdateBtn.Location = new System.Drawing.Point(172, 126);
            this.SearchUpdateBtn.Name = "SearchUpdateBtn";
            this.SearchUpdateBtn.Size = new System.Drawing.Size(147, 47);
            this.SearchUpdateBtn.TabIndex = 1;
            this.SearchUpdateBtn.Text = "复治";
            this.SearchUpdateBtn.UseVisualStyleBackColor = true;
            this.SearchUpdateBtn.Click += new System.EventHandler(this.RandomVisitBtn_Click);
            // 
            // SearchFollowVisitBtn
            // 
            this.SearchFollowVisitBtn.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchFollowVisitBtn.Location = new System.Drawing.Point(172, 179);
            this.SearchFollowVisitBtn.Name = "SearchFollowVisitBtn";
            this.SearchFollowVisitBtn.Size = new System.Drawing.Size(147, 47);
            this.SearchFollowVisitBtn.TabIndex = 2;
            this.SearchFollowVisitBtn.Text = "随访";
            this.SearchFollowVisitBtn.UseVisualStyleBackColor = true;
            this.SearchFollowVisitBtn.Click += new System.EventHandler(this.SearchFollowVisitBtn_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.Font = new System.Drawing.Font("微软雅黑", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MainLabel.Image = ((System.Drawing.Image)(resources.GetObject("MainLabel.Image")));
            this.MainLabel.Location = new System.Drawing.Point(1, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(506, 50);
            this.MainLabel.TabIndex = 3;
            this.MainLabel.Text = "Graves  甲  亢  病  历  管  理  系  统             ";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(508, 229);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.SearchFollowVisitBtn);
            this.Controls.Add(this.SearchUpdateBtn);
            this.Controls.Add(this.CureFirstBtn);
            this.Name = "MainForm";
            this.Text = "病历系统";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CureFirstBtn;
        private System.Windows.Forms.Button SearchUpdateBtn;
        private System.Windows.Forms.Button SearchFollowVisitBtn;
        private System.Windows.Forms.Label MainLabel;
    }
}