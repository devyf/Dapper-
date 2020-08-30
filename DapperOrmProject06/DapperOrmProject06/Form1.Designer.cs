namespace DapperOrmProject06
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDelID = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入要删除数据的ID:";
            // 
            // txtDelID
            // 
            this.txtDelID.Location = new System.Drawing.Point(271, 125);
            this.txtDelID.Name = "txtDelID";
            this.txtDelID.Size = new System.Drawing.Size(135, 28);
            this.txtDelID.TabIndex = 1;
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(427, 123);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(93, 32);
            this.delBtn.TabIndex = 2;
            this.delBtn.Text = "删除";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 303);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.txtDelID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dapper执行事务操作";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelID;
        private System.Windows.Forms.Button delBtn;
    }
}

