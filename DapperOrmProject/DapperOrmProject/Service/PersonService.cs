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
        /// 根据用户姓氏查询用户集合
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public List<Person> FindListByLastName(string lastName)
        {
            //IDbConnection由于Dapper ORM的操作实际上是对IDbConnection类的扩展，所有的方法都是该类的扩展方法。
            using (IDbConnection db = new SqlConnection(DBHelper.ConnString))
            {
                //C#6的语法：容易引起sql注入的问题,如：select * from Person where last_name = 'Crevy' or '1' = '1'; 
                string sql = $"select * from Person where last_name = '{lastName}'";
                //解决sql注入的问题，注意以下的参数对应关系
                string sqlQuery = $"select * from Person where last_name = @tempName";
                return db.Query<Person>(sqlQuery, new { tempName = lastName }).ToList();
                // return db.Query<Person>(sqlQuery).ToList();  //转化为List的类型返回
            }
        }
    }
}
