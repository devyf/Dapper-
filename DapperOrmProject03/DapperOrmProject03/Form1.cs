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

namespace DapperOrmProject03
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
            string idStr = this.searchID.Text;
            if (!int.TryParse(idStr, out int id))
            {
                MessageBox.Show("ID必须为正整数", "警告");
                return;
            }

            Person person = service.QueryPersonById(id);
            this.tb_firstName.Text = person.First_Name;
            this.tb_lastName.Text = person.Last_Name;
            this.tb_Email.Text = person.Email;
            this.tb_Gender.Text = person.Gender;
        }

        private void update_Btn_Click(object sender, EventArgs e)
        {
            PersonService service = new PersonService();
            bool updateRes = service.UpdatePerson(new Person
            {
                ID = Convert.ToInt32(this.searchID.Text),
                First_Name = this.tb_firstName.Text,
                Last_Name = this.tb_lastName.Text,
                Email = this.tb_Email.Text,
                Gender = this.tb_Gender.Text
            });

            MessageBox.Show(updateRes ? "数据更新成功" : "数据更新失败");
        }
    }
}
