using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //要访问App.config中的节点，就必须添加这个引用

namespace DapperOrmProject
{
    //数据访问助手类
    public static class DBHelper
    {
        /// <summary>
        /// 从配置文件中读取数据库连接字符串
        /// </summary>
        public static string ConnString
        {
            //只读访问器
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            }
        }
    }
}
