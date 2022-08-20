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
    public partial class ViewObj : Form
    {
        int index = -1;
        public ViewObj()
        {
            InitializeComponent();
            index = -1;
            RefreshObj();
        }

        private void RefreshObj()
        {
            if (index == 0) //jeżeli wyświetlamy pierwszy element na liście
                btnPrevious.Enabled = false;
            else
                btnPrevious.Enabled = true;
            if (index >= Person.personList.Count - 1) //jeżeli wyświetlamy ostatni element na liście
                btnNext.Enabled = false;
            else
                btnNext.Enabled = true;
            if (index < 0) //nic nie wyświetlamy
            {
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
            }
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            if (Person.personList.Count > 0) 
            {
                index = 0;                 
                listView1.Items.Clear();
                listBox1.Items.Clear();

                Person.personList[index].Write(listView1, pictureBox1);
                Person.personList[index].Write(listBox1);
                RefreshObj();

            }
            else
                MessageBox.Show("Lista jest pusta!");

            //for (int i = 0; i < personList.Count; i++)
            //    personList[i].Write(lv, pb);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index--;
            listView1.Items.Clear();
            listBox1.Items.Clear();
            Person.personList[index].Write(listView1, pictureBox1);
            Person.personList[index].Write(listBox1);
            RefreshObj();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;
            listView1.Items.Clear();
            listBox1.Items.Clear();

            Person.personList[index].Write(listView1, pictureBox1);
            Person.personList[index].Write(listBox1);
            RefreshObj();
        }
        private void ViewObj_Shown(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            pictureBox1.Image = null;
            index = -1;
            RefreshObj();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
//bitmapy i daty
//metody
//lista