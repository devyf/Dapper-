using Dapper;
using DapperOrmProject;
using DapperOrmProject08.Model;
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

namespace DapperOrmProject08
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
                List<Customer> userList = new List<Customer>();
                string sql = @"select u.*, r.* from UserInfo u 
                               inner join UserRole ur on ur.UserId = u.UserId
                               inner join Role r on r.RoleId = ur.RoleId";
                userList = db.Query<Customer, Role, Customer>( //第三个参数是返回值类型
                    sql,
                    (user, role) => { user.Role = role; return user; },
                    null,
                    null,
                    true,
                    "RoleId",   //分割数据列字符串
                    null,
                    null
                    ).ToList();
                this.dataGridView1.DataSource = userList;
                //打印其中单个字符
                if (userList.Count > 0)
                {
                    userList.ForEach(item => Console.WriteLine("userName:" + item.Username + "passWord:" + item.PasswordHash +
                        "Role:" + item.Role));
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(DBHelper.ConnString))
            {
                List<User> userList = new List<User>();
                string sql = @"select u.UserId, u.UserName, u.PasswordHash, r.RoleId, r.RoleName from UserInfo u
                               inner join UserRole ur on ur.UserId = u.UserId
                               inner join Role r on r.RoleId = ur.RoleId";
                Dictionary<int, User> dic = new Dictionary<int, User>();
               
                userList = db.Query<User, Role, User>(
                    sql,
                    (user, role) => 
                    {
                        User tempUser;
                        if (!dic.TryGetValue(user.UserId, out tempUser))
                        {
                            tempUser = user;
                            dic.Add(user.UserId, tempUser);
                        }
                        tempUser.Role.Add(role);
                        return user;
                    },
                    null,
                    null,
                    true,
                    "RoleId",
                    null,
                    null
                    ).ToList();

                    this.dataGridView2.DataSource = userList;
                //打印其中单个字符
                if (userList.Count > 0)
                {
                    userList.ForEach(item => Console.WriteLine("userName:" + item.Username + "passWord:" + item.PasswordHash +
                        "Role:" + item.Role.First().RoleName));
                }
            }
        }
    }
}
