namespace WordCount
{
    partial class Form1
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
            this.listBoxIput = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxGet = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listBoxIput
            // 
            this.listBoxIput.FormattingEnabled = true;
            this.listBoxIput.ItemHeight = 12;
            this.listBoxIput.Location = new System.Drawing.Point(473, 33);
            this.listBoxIput.Name = "listBoxIput";
            this.listBoxIput.Size = new System.Drawing.Size(209, 328);
            this.listBoxIput.TabIndex = 0;
            this.listBoxIput.SelectedIndexChanged += new System.EventHandler(this.listBoxIput_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(285, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "开始统计";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxGet
            // 
            this.textBoxGet.Location = new System.Drawing.Point(35, 33);
            this.textBoxGet.Name = "textBoxGet";
            this.textBoxGet.Size = new System.Drawing.Size(399, 328);
            this.textBoxGet.TabIndex = 3;
            this.textBoxGet.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 429);
            this.Controls.Add(this.textBoxGet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxIput);
            this.Name = "Form1";
            this.Text = "单词统计";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox textBoxGet;
    }
}

