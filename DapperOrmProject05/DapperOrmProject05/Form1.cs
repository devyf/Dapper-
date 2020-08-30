using Dapper;
using DapperOrmProject;
using DapperOrmProject05.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DapperOrmProject05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击按钮，查询未能通过考试的学生名单，调用无参数的存储过程，默认及格线为60分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<StuInfo> stuList = new List<StuInfo>();
            using (IDbConnection db = new SqlConnection(DBHelper.ConnString))
            {
                stuList = db.Query<StuInfo>("dbo.P_stuMarkInfo", //存储过程的名称
                    null, //存储过程的参数
                    null, //事务对象
                    true, //是否缓存
                    null, //获取或设置在终止执行命令的尝试并生成错误之间的等待时间
                    CommandType.StoredProcedure //指定的sql语句为存储过程类型
                    ).ToList();
            }

            if (stuList.Count > 0)
            {
                stuList.ForEach(stu => this.textBox1.Text += stu.StuName + " ");
            }
        }

        /// <summary>
        /// 点击按钮，通过设置的笔试成绩和机试成绩去动态调用带参数的存储过程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //准备存储过程的三个参数：两个是输入参数，一个是输出参数
            var param = new DynamicParameters();  //动态参数类
            try
            {
                param.Add("@writeLevel", int.Parse(this.writeLev.Text)); //存储过程的输入参数赋值
                param.Add("@labLevel", int.Parse(this.labLev.Text));
                param.Add("@examNum", 0, DbType.Int32, ParameterDirection.Output); //标注为输出参数
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

            using (IDbConnection db = new SqlConnection(DBHelper.ConnString))
            {
                db.Execute("dbo.P_stuMarkInfo1",  //指定存储过程名称
                    param,  //存储过程参数
                    null,  //存储过程事务
                    null,  //执行等待时间
                    CommandType.StoredProcedure  //指定执行为存储过程类型
                    );
                //通过参数调用Get方法来获取返回值
                int outNum = param.Get<int>("@examNum");
                //放置到文本框中
                this.nopassNum.Text = outNum.ToString();
                MessageBox.Show("存储过程执行成功！");
            }
        }
    }
}
