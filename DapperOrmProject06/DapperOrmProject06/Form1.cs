using Dapper;
using DapperOrmProject;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DapperOrmProject06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 删除按钮点击执行事务操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delBtn_Click(object sender, EventArgs e)
        {
            //执行界面操作，根据主表学生表的ID去删除相关联的信息
            //事务操作：根据输入的学生ID编号，删除从表，删除主表中的数据信息列
            int delId = int.Parse(this.txtDelID.Text);  //取出要删除的学生表的学号
            using (IDbConnection db = new SqlConnection(DBHelper.ConnString))
            {
                db.Open(); //基于事务操作的特殊性：执行事务之前需要优先开启连接
                //try catch语句使用外侧代码：快捷键：ctrl+k、ctrl+s
                //创建事务对象
                IDbTransaction transaction = db.BeginTransaction();  //开启数据库的事务
                try
                {
                    //根据用户输入的学号ID进行删除的操作：先删除从表，再删除主表的信息
                    string delSql1 = "delete from stuinfo where stuNo = @stuNo";  //主表
                    string delSql2 = "delete from stumark where stuNo = @stuNo";  //从表

                    //执行删除操作
                    db.Execute(delSql2, new { stuNo = delId }, transaction, null, null);
                    db.Execute(delSql1, new { stuNo = delId }, transaction, null, null);

                    //提交事务
                    transaction.Commit();
                    MessageBox.Show("删除成功！");
                }
                catch (Exception ex)
                {
                    //出现异常，需要回滚事务
                    transaction.Rollback();
                    MessageBox.Show("出现异常：" + ex.Message);
                }
                finally
                {
                    db.Close();
                }
            }
        }
    }
}
