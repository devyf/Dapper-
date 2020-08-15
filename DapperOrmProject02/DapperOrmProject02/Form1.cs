using DapperOrmProject.Model;
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

namespace DapperOrmProject02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            PersonService personService = new PersonService();
            Person person = new Person();
            person.First_Name = this.textBox1.Text;
            person.Last_Name = this.textBox2.Text;
            person.Email = this.textBox3.Text;
            person.Gender = this.textBox4.Text;
            bool res = personService.InsertPersonData(person);

            MessageBox.Show(res ? "数据插入成功" : "数据插入失败", "提示");
        }
    }
}
