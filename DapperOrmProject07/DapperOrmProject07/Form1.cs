using Dapper;
using DapperOrmProject;
using DapperOrmProject05.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperOrmProject07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(DBHelper.ConnString))
            {
                var sql = "select * from stuinfo inner join stumark on stuinfo.stuNo = stumark.stuNo";

                //执行查询：多表(类型一，类型二，返回值)
                var list = db.Query<StuInfo, StuMark, StuInfo>(
                    sql,
                    (students, score) => { return students; }, //变量students对应的StuInfo类型，scores对应StuMark类型
                    null,  //存储过程的参数
                    null,  //事务
                    true,  //缓存
                    splitOn: "stuNo" //该参数是用来划分查询中的字段是属于哪个表的 splitOn可以省略
                    );

                /*splitOn:stuNo 划分查询中的字段是属于哪个表的，也就是查询结构映射到哪个实体，上边的sql运行时，会从查询结果所有
                 字段列表的最后一个字段进行匹配，一直找到stuNo这个字段（大小写不计），找到的第一个stuNo字段匹配就是Query参数中
                 StuInfo类的stuNo属性，那么从stuNo到最后一个字段都属于StuInfo，StuNo以前的字段都被映射到StuMark这张表
                 通过(T,P)=>(return T)把两个类的实例解析出来*/
                this.dgvContent.DataSource = list;
            }
        }
    }
}
