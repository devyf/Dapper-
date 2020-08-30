namespace DapperOrmProject05
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.writeLev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labLev = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.nopassNum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(57, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "无参数存储过程调用";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "未通过考试学生名单";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(260, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 28);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nopassNum);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.labLev);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.writeLev);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(57, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 217);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "有参数存储过程调用";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "笔试及格线：";
            // 
            // writeLev
            // 
            this.writeLev.Location = new System.Drawing.Point(167, 63);
            this.writeLev.Name = "writeLev";
            this.writeLev.Size = new System.Drawing.Size(107, 28);
            this.writeLev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "机试及格线：";
            // 
            // labLev
            // 
            this.labLev.Location = new System.Drawing.Point(458, 63);
            this.labLev.Name = "labLev";
            this.labLev.Size = new System.Drawing.Size(117, 28);
            this.labLev.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "未通过考试学生人数";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nopassNum
            // 
            this.nopassNum.Location = new System.Drawing.Point(260, 144);
            this.nopassNum.Name = "nopassNum";
            this.nopassNum.Size = new System.Drawing.Size(118, 28);
            this.nopassNum.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 612);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "使用Dapper调用数据库存储过程";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox writeLev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox labLev;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nopassNum;
    }
}

