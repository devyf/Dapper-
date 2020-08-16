using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperOrmProject.Model
{
    public class Person
    {
        public int ID { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
