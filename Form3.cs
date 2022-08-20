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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {

        }

        private void Bought_Lessons_Click(object sender, EventArgs e)
        {

        }

        private void Type_of_Lesson_Click(object sender, EventArgs e)
        {

        }

        private void Discount_code_Click(object sender, EventArgs e)
        {

        }

        private void chkIndividual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBought_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
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

            bool hasStudies = false;
            int yearsOfExperience = Convert.ToInt32(txtYears.Text);
            int lessonsPerWeek = Convert.ToInt32(txtPerw.Text);


            if (chkhasst.Checked == true)
            {
                hasStudies = true;
            }
            if (chkStu.Checked == true)
            {
                studentUniversity = true;
            }
            Teacher t1 = new Teacher(pesel, name, surname, yearBirthday, email, address, studentUniversity, numberOfLessons, bankAccount, languageLevel, yearsOfExperience, hasStudies, lessonsPerWeek, (Bitmap)pictureBox1.Image);
            t1.Write(listView1, pictureBox1);
            Person.personList.Add(t1);
            //listView1.Items.Clear();
            //Person.personList[Person.personList.Count - 1].Write(listView1, pictureBox1);

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
