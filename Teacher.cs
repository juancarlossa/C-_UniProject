using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Lista_4
{
    class Teacher : Person
    {
        int teacherID;
        static int _teacherID = 1;

        //heredar
        
        string levelOfTeaching;
        int yearsOfExperience;
        public bool hasStudies = false;

        static double _salaryPerHour = 70;
        double salaryPerHour = _salaryPerHour;
        int lessonsPerWeek;
        double weeklyBruttoSalary;
        double weeklyNettoSalary;

        public Teacher(int pesel, string name, string surname, int yearBirthday, string email, string address, bool studentUniversity, float numberOfLessons, string bankAccount, string languageLevel, int yearsOfExperience, bool hasStudies, int lessonsPerWeek, Bitmap foto) : base(pesel, name, surname, yearBirthday, email, address, studentUniversity, numberOfLessons, bankAccount, languageLevel, foto)
        {
            _teacherID += 2;
            teacherID = _teacherID;

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

            this.yearsOfExperience = yearsOfExperience;
            this.hasStudies = hasStudies;
            this.lessonsPerWeek = lessonsPerWeek;
            salaryPerHour = _salaryPerHour;

        }
        public Teacher()
        {
            teacherID = _teacherID;
            studentUniversity = false;
        }
        public Teacher(Teacher s)
        {
            teacherID = _teacherID;
        }

        private string CalculateWorkerExperience()
        {
            if (yearsOfExperience <= 1)
            {
                levelOfTeaching = "Beginner";
                return "Beginner";
            }
            else if (yearsOfExperience > 1 && yearsOfExperience < 3)
            {
                levelOfTeaching = "Medium";
                return "Medium";
            }
            else
            {
                levelOfTeaching = "Advanced";
                return "Advanced";
            }
        }
        private double CalculateSalary()
        {
            CalculateWorkerExperience();
            switch (levelOfTeaching)
            {
                case "Advanced":
                    salaryPerHour = 70;
                    break;
                case "Medium":
                    salaryPerHour = 60;
                    break;
                case "Beginner":
                    salaryPerHour = 50;
                    break;
            }
            if (hasStudies == true)
            {
                salaryPerHour += 10;
            }
            weeklyBruttoSalary = salaryPerHour * lessonsPerWeek;
            return weeklyBruttoSalary;
        }
        private double CalculateNettoSalary()
        {
            HasStudies();

            if (studentUniversity == true)
            {
                return weeklyNettoSalary = weeklyBruttoSalary;
            }
            else
            {
                return weeklyNettoSalary = weeklyBruttoSalary * 0.75;
            }                                  //Taxes and expenses
        }

        protected string HasStudies()
        {
            if (hasStudies == true)
            {
                return "Yes"; 
            }
            else {
                return "No"; 
            }
        }

        public override void Write(ListView lw, PictureBox pb)
        {
            ListViewItem item = new ListViewItem();
            item = lw.Items.Add(teacherID.ToString());
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

            item.SubItems.Add(yearsOfExperience.ToString());
            item.SubItems.Add(CalculateSalary().ToString());
            item.SubItems.Add(CalculateNettoSalary().ToString());
            item.SubItems.Add(HasStudies());
            item.SubItems.Add(CalculateWorkerExperience());
            item.SubItems.Add(IsStudent());
            item.SubItems.Add(now.ToString());
            pb.Image = foto;
            //personList.Add(this); //dodać do konstruktora
        }
        public override void Write(ListBox b)
        {
           // base.Write(b);
            b.Items.Add("Years Of Experience:\t\t" + yearsOfExperience.ToString());
            b.Items.Add("Calculate Salary\t" + CalculateSalary().ToString() + "zł");
            b.Items.Add("Calculate Netto Salary:\t\t\t" + CalculateNettoSalary().ToString() + "zl");
            b.Items.Add("Has Studies:\t\t\t" + HasStudies());
            b.Items.Add("Calculate Worker Experience:\t\t\t" + CalculateWorkerExperience());
            b.Items.Add("Is Student\t\t\t" + IsStudent());

            b.Items.Add("Data:\t\t " + now.ToString());
        }

        public override void SeeObj(ListView lv, PictureBox pb)
        {
            for (int i = 0; i < personList.Count; i++)
                personList[i].Write(lv, pb);
        }
    }
}
