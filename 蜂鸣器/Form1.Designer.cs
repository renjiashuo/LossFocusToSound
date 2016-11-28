namespace 蜂鸣器
{
    partial class 失去焦点发声
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.开始 = new System.Windows.Forms.Button();
            this.频率textbox = new System.Windows.Forms.TextBox();
            this.时间textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 开始
            // 
            this.开始.Location = new System.Drawing.Point(123, 159);
            this.开始.Name = "开始";
            this.开始.Size = new System.Drawing.Size(75, 23);
            this.开始.TabIndex = 0;
            this.开始.Text = "声音测试";
            this.开始.UseVisualStyleBackColor = true;
            this.开始.Click += new System.EventHandler(this.开始_Click);
            // 
            // 频率textbox
            // 
            this.频率textbox.Location = new System.Drawing.Point(98, 31);
            this.频率textbox.Name = "频率textbox";
            this.频率textbox.Size = new System.Drawing.Size(100, 21);
            this.频率textbox.TabIndex = 1;
            // 
            // 时间textbox
            // 
            this.时间textbox.Location = new System.Drawing.Point(98, 74);
            this.时间textbox.Name = "时间textbox";
            this.时间textbox.Size = new System.Drawing.Size(100, 21);
            this.时间textbox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "频率(HZ)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "时间(ms)";
            // 
            // 失去焦点发声
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.时间textbox);
            this.Controls.Add(this.频率textbox);
            this.Controls.Add(this.开始);
            this.Name = "失去焦点发声";
            this.Text = "失去焦点发声";
            this.Deactivate += new System.EventHandler(this.失去焦点发声_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 开始;
        private System.Windows.Forms.TextBox 频率textbox;
        private System.Windows.Forms.TextBox 时间textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

