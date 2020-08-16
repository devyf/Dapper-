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
        /// 根据传入的ID进行数据删除
        /// </summary>
        /// <param name="person"></param>
        public bool DeleteDataById(int id)
        {
            //IDbConnection由于Dapper ORM的操作实际上是对IDbConnection类的扩展，所有的方法都是该类的扩展方法。
            using (IDbConnection db = new SqlConnection(DBHelper.ConnString))
            {
                string delSql = "delete from person where id = @ID";
                //类中的属性一致
                int exeRes = db.Execute(delSql, new { ID = id});

                return exeRes > 0;
            }
        }
    }
}
