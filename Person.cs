using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lista_4
{
    abstract class Person
    {
        int id;
        static int _id = 0;

        protected int pesel;
        protected string name;        //protected
        protected string surname;
        protected int yearBirthday;
        protected string email;
        protected string address;
        protected bool studentUniversity;
        protected float numberOfLessons;
        protected string bankAccount;
        protected string languageLevel;
        protected DateTime now = DateTime.Now; 
        protected Bitmap foto;                             //PictureBox

        public static List<Person> personList = new List<Person>();


        //Konstruktor wielo
        public Person(int pesel, string name, string surname, int yearBirthday, string email, string address, bool studentUniversity, float numberOfLessons, string bankAccount, string languageLevel, Bitmap foto)
        {
            _id += 1;
            id = _id;
            this.pesel = pesel;
            this.name = name;
            this.surname = surname;
            this.yearBirthday = yearBirthday;
            this.email = email;
            this.address = address;
            this.studentUniversity = studentUniversity;
            this.numberOfLessons = numberOfLessons;
            this.bankAccount = bankAccount;
            this.languageLevel = languageLevel;
            this.foto = foto;
        }

        //Konstruktor bezarg
        public Person()
        {
            id = _id;
            email = "-";
            numberOfLessons = 0;
            studentUniversity = false;
        }
        //Konstruktor kopiujący
        public Person(Person p)
        {
            id = _id;
            name = p.name;
            surname = p.surname;
            yearBirthday = p.yearBirthday;
        }
        //Destruktor
        ~Person()
        {
            //  MessageBox.Show("The object of the class Person is going to be removed");
        }
        //Metodos
        public virtual void Write(ListView lw, PictureBox pb)
        {
            ListViewItem item = new ListViewItem();
            item = lw.Items.Add(id.ToString());
            item.SubItems.Add(name);
            item.SubItems.Add(surname);
            item.SubItems.Add(yearBirthday.ToString());
            item.SubItems.Add(email);
            item.SubItems.Add(Adult());
            item.SubItems.Add(pesel.ToString());
            item.SubItems.Add(address);
            item.SubItems.Add(languageLevel);
            item.SubItems.Add(bankAccount);
            item.SubItems.Add(numberOfLessons.ToString());
            item.SubItems.Add(IsStudent());

            item.SubItems.Add(now.ToString());
            pb.Image = foto;
        }

        public virtual void Write(ListBox b)
        {

            b.Items.Add(name);
            b.Items.Add(surname);
            b.Items.Add(yearBirthday.ToString());
            b.Items.Add(email);
            b.Items.Add(Adult());
            b.Items.Add(pesel.ToString());
            b.Items.Add(address);
            b.Items.Add(languageLevel);
            b.Items.Add(bankAccount);
            b.Items.Add(numberOfLessons.ToString());
            b.Items.Add(IsStudent());

            b.Items.Add(now.ToString());
        }
        public string IsStudent()
        {
            if (studentUniversity == true)
            { return "Yes"; }
            else { return "No"; }
        }
        protected string Adult()
        {
            if (2022 - yearBirthday < 18)
            {
                return "No";
            }
            else
            {
                return "Yes";
            };
        }

        public virtual void SeeObj(ListView lv, PictureBox pb)
        {
            for (int i = 0; i < personList.Count; i++)
                personList[i].Write(lv, pb);
            
        }
    }
}
