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
        /// 根据界面输入ID查询出Person信息
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public Person QueryPersonById(int id)
        {
            Person person = null;
            //IDbConnection由于Dapper ORM的操作实际上是对IDbConnection类的扩展，所有的方法都是该类的扩展方法。
            using (IDbConnection db = new SqlConnection(DBHelper.ConnString))
            {
                string querySql = "select * from Person where id = @tempId";
                person = db.Query<Person>(querySql, new { tempId = id }).FirstOrDefault();
            }

            return person;
        }

        /// <summary>
        /// 根据传入的Person更新数据库表中数据
        /// </summary>
        /// <param name="person"></param>
        public bool UpdatePerson(Person person)
        {
            //IDbConnection由于Dapper ORM的操作实际上是对IDbConnection类的扩展，所有的方法都是该类的扩展方法。
            using (IDbConnection db = new SqlConnection(DBHelper.ConnString))
            {
                string updateSql = "update Person set " +
                    "first_name = @First_Name, last_name = @Last_Name, email = @Email, gender = @Gender " +
                    "where id = @ID";
                //注意：这里的First_Name、Last_Name等这些字段都是person赋值的，所以必须和Person
                //类中的属性一致
                int exeRes = db.Execute(updateSql, person);

                return exeRes > 0;
            }
        }
    }
}
