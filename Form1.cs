using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_4
{
    public partial class Form1 : Form
    {
        List<Student> ListOfStudents = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            //listView1.Items.Clear();
            string name = txtName.Text;
            string surname = txtSurname.Text;
            int yearBirthday = Convert.ToInt32(txtAge.Text);

            Person p1 = new Person();
            p1.Write(listView1);
            Person p2 = new Person(name, surname, yearBirthday);
            p2.Write(listView1);
            Person p3 = new Person(p2);
            p3.Write(listView1);


            //p1.numberOfLessons = Convert.ToInt32(txtnumberlessons.Text);

            //txtName.Text = String.Empty;
            //txtSurname.Text = String.Empty;
            //txtAge.Text = String.Empty;
            //txtEmail.Text = String.Empty;
            //txtID.Text = String.Empty;

            //p1.Write(listView1);
            //Student s2 = new Student("juan", "saugar", "4878", "juank987", 24, 20);
        }
    }
}
