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
        Form3 teacher = new Form3();
        Form2 student = new Form2();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            string name = txtName.Text;
            string surname = txtSurname.Text;
            int yearBirthday = Convert.ToInt32(txtAge.Text);
            string email = txtEmail.Text;
            int pesel = Convert.ToInt32(txtPesel.Text);
            string address = txtAdress.Text;
            bool studentUniversity;
            float numberOfLessons = Convert.ToSingle(txtNumber.Text);
            string bankAccount = txtBank.Text;
            string languageLevel = txtLanguage.Text;
            DateTime dateBirthday = Convert.ToDateTime(dateTimePicker1.Value);

            //personList.Write(listView1);


            if (chkStu.Checked == true)
            {
                studentUniversity = true;
            }

            //Person p1 = new Person();
            //p1.Write(listView1);

            //Person p2 = new Person(pesel, name, surname,yearBirthday,email, address, studentUniversity,  numberOfLessons,bankAccount,languageLevel, dateBirthday);
            //p2.Write(listView1);

            //Person p3 = new Person(p2);
            //p3.Write(listView1);


            //p1.numberOfLessons = Convert.ToInt32(txtnumberlessons.Text);

            //txtName.Text = String.Empty;
            //txtSurname.Text = String.Empty;
            //txtAge.Text = String.Empty;
            //txtEmail.Text = String.Empty;
            //txtID.Text = String.Empty;

            //p1.Write(listView1);
            //Student s2 = new Student("juan", "saugar", "4878", "juank987", 24, 20);
        }

        private void button1_Click(object sender, EventArgs e)      //Students
        {
            new Form2().Show();
        }

        private void button2_Click(object sender, EventArgs e)      //Teachers
        {
            new Form3().Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            new ViewObj().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                    Bitmap b = new Bitmap(openFileDialog1.OpenFile());
                    pictureBox1.Image = b;
            }
            
        }
    }
}
