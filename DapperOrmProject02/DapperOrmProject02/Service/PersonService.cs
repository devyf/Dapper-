using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperOrmProject.Model;

namespace DapperOrmProject.Service
{
    public class PersonService
    {
        /// <summary>
        /// 根据界面输入插入对应数据
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public bool InsertPersonData(Person person)
        {
            //IDbConnection由于Dapper ORM的操作实际上是对IDbConnection类的扩展，所有的方法都是该类的扩展方法。
            using (IDbConnection db = new SqlConnection(DBHelper.ConnString))
            {
                string insertSql = "insert into Person(first_name, last_name, email, gender) values " +
                    "(@First_Name, @Last_Name, @Email, @Gender)";
                int resNum = db.Execute(insertSql, new Person
                {
                    First_Name = person.First_Name,
                    Last_Name = person.Last_Name,
                    Email = person.Email,
                    Gender = person.Gender,
                });

                return resNum > 0;
            }
        }
    }
}
