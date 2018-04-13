namespace WindowsFormNotifyProperty绑定控件
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnName = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAge = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBinding = new System.Windows.Forms.TextBox();
            this.MyBindingTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(212, 12);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(75, 23);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 112);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 185);
            this.textBox1.TabIndex = 1;
            // 
            // btnAge
            // 
            this.btnAge.Location = new System.Drawing.Point(212, 68);
            this.btnAge.Name = "btnAge";
            this.btnAge.Size = new System.Drawing.Size(75, 23);
            this.btnAge.TabIndex = 2;
            this.btnAge.Text = "age";
            this.btnAge.UseVisualStyleBackColor = true;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(30, 68);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(167, 21);
            this.textBoxAge.TabIndex = 3;
            this.textBoxAge.Text = "23";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(30, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(161, 21);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.Text = "name";
            // 
            // textBoxBinding
            // 
            this.textBoxBinding.Location = new System.Drawing.Point(346, 14);
            this.textBoxBinding.Name = "textBoxBinding";
            this.textBoxBinding.Size = new System.Drawing.Size(112, 21);
            this.textBoxBinding.TabIndex = 5;
            this.textBoxBinding.Text = "name";
            // 
            // MyBindingTextBox
            // 
            this.MyBindingTextBox.Location = new System.Drawing.Point(346, 68);
            this.MyBindingTextBox.Name = "MyBindingTextBox";
            this.MyBindingTextBox.Size = new System.Drawing.Size(112, 21);
            this.MyBindingTextBox.TabIndex = 6;
            this.MyBindingTextBox.Text = "name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 309);
            this.Controls.Add(this.MyBindingTextBox);
            this.Controls.Add(this.textBoxBinding);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.btnAge);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBinding;
        private System.Windows.Forms.TextBox MyBindingTextBox;
    }
}

