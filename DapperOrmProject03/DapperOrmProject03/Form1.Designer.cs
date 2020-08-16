namespace DapperOrmProject03
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
            this.searchID = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.tb_Gender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.update_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入ID搜索：";
            // 
            // searchID
            // 
            this.searchID.Location = new System.Drawing.Point(141, 47);
            this.searchID.Name = "searchID";
            this.searchID.Size = new System.Drawing.Size(102, 28);
            this.searchID.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(259, 44);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(90, 35);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "搜索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // tb_Gender
            // 
            this.tb_Gender.Location = new System.Drawing.Point(110, 294);
            this.tb_Gender.Name = "tb_Gender";
            this.tb_Gender.Size = new System.Drawing.Size(239, 28);
            this.tb_Gender.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender：";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(111, 226);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(239, 28);
            this.tb_Email.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email：";
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(111, 164);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(239, 28);
            this.tb_lastName.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "LastName：";
            // 
            // tb_firstName
            // 
            this.tb_firstName.Location = new System.Drawing.Point(111, 105);
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(239, 28);
            this.tb_firstName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "FirstName：";
            // 
            // update_Btn
            // 
            this.update_Btn.Location = new System.Drawing.Point(247, 351);
            this.update_Btn.Name = "update_Btn";
            this.update_Btn.Size = new System.Drawing.Size(102, 41);
            this.update_Btn.TabIndex = 16;
            this.update_Btn.Text = "更新";
            this.update_Btn.UseVisualStyleBackColor = true;
            this.update_Btn.Click += new System.EventHandler(this.update_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 422);
            this.Controls.Add(this.update_Btn);
            this.Controls.Add(this.tb_Gender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_firstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchID;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox tb_Gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update_Btn;
    }
}

