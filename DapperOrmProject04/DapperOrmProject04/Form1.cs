using DapperOrmProject.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperOrmProject04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idStr = this.searchIDTb.Text;
            if (!int.TryParse(idStr, out int id))
            {
                MessageBox.Show("输入的id必须为正整数！");
                return;
            }

            PersonService service = new PersonService();
            bool res = service.DeleteDataById(id);

            MessageBox.Show(res ? "删除成功" : "删除失败");
        }
    }
}
