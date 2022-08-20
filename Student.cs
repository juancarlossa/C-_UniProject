using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_4
{
    class Student : Person
    {
        int studentID;
        static int _studentID = 2;

        string levelOfLanguage;
        bool hasDiscount = false;
        static double pricePerHour = 100;

        double finalPrice = pricePerHour;           //por defecto 100zl
        int boughtLessons;
        string discountCode = "";
        string typeLesson;
        public bool individualLessons;

        double[] payments1 = new double[5];
        public double[] grades1 = new double[4];


        //Konstruktory
        public Student(int pesel, string name, string surname, int yearBirthday, string email, string address, bool studentUniversity, float numberOfLessons, string bankAccount, string languageLevel, int boughtLessons, string typeOfLesson, bool individualLessons, double[] grades1, Bitmap foto):base(pesel,name, surname,yearBirthday, email, address,studentUniversity,numberOfLessons, bankAccount,languageLevel, foto)
        {
            _studentID += 2;
            studentID = _studentID;
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

            this.boughtLessons = boughtLessons;
            this.typeLesson = typeOfLesson;
            this.individualLessons = individualLessons;

            this.grades1 = grades1;
            finalPrice = pricePerHour;
            //this.discountCode = discountCode;

        }
        public Student():base()
        {
            studentID = _studentID;
            studentUniversity = false;
        }
        public Student(Student s):base(s)
        {
            studentID = _studentID;
            levelOfLanguage = s.levelOfLanguage;
            boughtLessons = s.boughtLessons;
        }

        //Metodos

        private double StudentPrice()
        {
            if (studentUniversity == true)
            {
                finalPrice = finalPrice - 10;           //90zl
                return finalPrice;
            }
            else { return finalPrice; }
        }

        private double ApplyDiscount()
        {
            GetsDiscount();
            if (hasDiscount == true)
            {
                double amountDiscount;
                amountDiscount = 20;
                finalPrice = StudentPrice() - amountDiscount;
                if (studentUniversity == true)
                {
                    amountDiscount += 10;
                }
                return amountDiscount;
            }
            else { return 0; }
        }

        private double TotalDiscount()
        {
            return ApplyDiscount() * boughtLessons;
        }

        private double CalculatePrice()
        {
            ApplyDiscount();
            return finalPrice * boughtLessons;
        }

        private string GetsDiscount()
        {
            if (boughtLessons >= 10 || discountCode == "12345" || studentUniversity == true)
            { hasDiscount = true; return "Yes"; }
            else { hasDiscount = false;  return "No"; }
        }
        protected string IsIndividual()
        {
            if (individualLessons == true)
            { return "Yes"; }
            else { return "No"; }
        }

        public override void Write(ListView lw, PictureBox pb)
        {
            ListViewItem item = new ListViewItem();
            item = lw.Items.Add(studentID.ToString());
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

            item.SubItems.Add(CalculatePrice().ToString());     //price
            item.SubItems.Add(ApplyDiscount().ToString());      //discount
            item.SubItems.Add(TotalDiscount().ToString());

            item.SubItems.Add(boughtLessons.ToString());
            item.SubItems.Add(typeLesson);
            item.SubItems.Add(IsIndividual());

            item.SubItems.Add(grades1[0].ToString());
            item.SubItems.Add(grades1[1].ToString());
            item.SubItems.Add(grades1[2].ToString());
            item.SubItems.Add(grades1[3].ToString());
            item.SubItems.Add(now.ToString());
            pb.Image = foto;
            //personList.Add(new Student(pesel,name,surname,yearBirthday,email,address,studentUniversity,numberOfLessons,bankAccount,languageLevel,boughtLessons,typeLesson,individualLessons,grades1));
        }
        public override void Write(ListBox b)
        {
            // base.Write(b);
            //b.Items.Add("Calculate Price: \t\t" + CalculatePrice().ToString() + "zł");
            b.Items.Add("Apply Discount: \t" + ApplyDiscount().ToString() + "zł");
            b.Items.Add("Total Discount:\t\t\t" + TotalDiscount().ToString() + "zl");
            b.Items.Add("Bought Lessons:\t\t\t" + boughtLessons.ToString());
            b.Items.Add("Type of Lesson:\t\t\t" + typeLesson);
            b.Items.Add("Individual lessons:\t\t\t" + IsIndividual());

            b.Items.Add("Grade 1:\t\t\t" + grades1[0].ToString());
            b.Items.Add("Grade 2:\t\t\t" + grades1[1].ToString());
            b.Items.Add("Grade 3:\t\t\t" + grades1[2].ToString());
            b.Items.Add("Grade 4:\t\t\t" + grades1[3].ToString());


            b.Items.Add("Data:\t\t " + now.ToString());
        }

        public override void SeeObj(ListView lv, PictureBox pb)
        {

        }
    }
}
