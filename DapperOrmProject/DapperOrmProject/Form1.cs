using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper; //导入Dapper框架
using DapperOrmProject.Model;
using DapperOrmProject.Service;

namespace DapperOrmProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            PersonService service = new PersonService();
            string lastName = this.searchTbox.Text.Trim();
            List<Person> pList = service.FindListByLastName(lastName);
            this.listBox1.DataSource = pList;
            this.listBox1.DisplayMember = "email";
        }
    }
}
