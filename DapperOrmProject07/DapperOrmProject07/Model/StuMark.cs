using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperOrmProject05.Model
{
    public class StuMark
    {
        public string ExamNo { get; set; }

        public int StuNo { get; set; }

        public int WrittenExam { get; set; }

        public int LabExam { get; set; }
    }
}
