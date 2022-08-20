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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            int yearBirthday = Convert.ToInt32(txtAge.Text);
            string email = txtEmail.Text;
            int pesel = Convert.ToInt32(txtPesel.Text);
            string address = txtAdress.Text;
            bool studentUniversity = false;
            float numberOfLessons = Convert.ToSingle(txtNumber.Text);
            string bankAccount = txtBank.Text;
            string languageLevel = txtLanguage.Text;
            bool individualLessons = false;
            int boughtLessons = Convert.ToInt32(txtBought.Text);
            string typeOfLesson = txtType.Text;

            double[] grades1 = new double[4];
            grades1[0] = Convert.ToInt32(textBox1.Text);
            grades1[1] = Convert.ToInt32(textBox2.Text);
            grades1[2] = Convert.ToInt32(textBox3.Text);
            grades1[3] = Convert.ToInt32(textBox4.Text);



            if (chkStu.Checked == true)
            {
                studentUniversity = true;
            }
            if (chkIndividual.Checked == true)
            {
                individualLessons = true;
            }

            Student s1 = new Student(pesel, name, surname, yearBirthday, email, address, studentUniversity, numberOfLessons, bankAccount, languageLevel, boughtLessons, typeOfLesson, individualLessons, grades1, (Bitmap)pictureBox1.Image);
            s1.Write(listView1, pictureBox1);
            Person.personList.Add(s1);
            //listView1.Items.Clear();
            //Person.personList[Person.personList.Count - 1].Write(listView1, pictureBox1);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Discount_code_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) // robimy tak jak w oknach modalnych
            {
                Bitmap b = new Bitmap(openFileDialog1.OpenFile());
                pictureBox1.Image = b;
            }
        }
    }
}
