using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtosalon
{
    public partial class Form3 : Form
    {
        public bool key_m;

        public bool key_Up;
        public string prod ;
        public string mod ;
        public int date;
        public string color;
        public decimal price;
        public string probeg;
        public string nam;
        public string em;
        public string ph;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key_Up == false)
            {
                if (tname.Text != "" && temail.Text != "" && tphone.Text != "")
                {
                    if (key_m == false)
                    {
                        clientsTableAdapter.InsertQuery(tname.Text, temail.Text, tphone.Text);
                        MessageBox.Show("Добавленно");
                    }
                    else
                    {
                        managerTableAdapter.InsertQuery(tname.Text, temail.Text, tphone.Text);
                        MessageBox.Show("Добавленно");
                    }
                }
                else MessageBox.Show("Введите данные");
            }
            else {
                if (tname.Text != "" && temail.Text != "" && tphone.Text != "")
                {
                    if (key_m == false)
                    {
                        clientsTableAdapter.UpdateQuery(tname.Text, temail.Text, tphone.Text,nam,em,ph);
                        MessageBox.Show("Изменено");
                    }
                    else
                    {
                        managerTableAdapter.UpdateQuery(tname.Text, temail.Text, tphone.Text, nam, em, ph);
                        MessageBox.Show("Изменено");
                    }
                }
                else MessageBox.Show("Введите данные");

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
         



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (name_city.Text != "" && name_avtosalon.Text != "")
            {
                avtosalonsTableAdapter.InsertQuery(name_city.Text, name_avtosalon.Text);
                MessageBox.Show("Добавленно");
            }
            else MessageBox.Show("Введите данные");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (key_Up == false)
            {
                if (prodact.Text != "" && model.Text != "" && date_prod.Text != "" && Color.Text != "" && Cost.Text != "" && Probeg.Text != "")
                {
                    avtoTableAdapter.InsertQuery(prodact.Text, model.Text, date_prod.Text, Color.Text, Cost.Text, Probeg.Text);
                    MessageBox.Show("Добавленно");
                }
                else MessageBox.Show("Введите данные");
            }
            else
            {
                if (prodact.Text != "" && model.Text != "" && date_prod.Text != "" && Color.Text != "" && Cost.Text != "" && Probeg.Text != "")
                {
                    avtoTableAdapter.UpdateQuery(prodact.Text, model.Text, Convert.ToInt32(date_prod.Text), Color.Text, Convert.ToDecimal(Cost.Text), Probeg.Text,prod, mod, date, color, price,probeg);
                    MessageBox.Show("Изменено");
                }
                else MessageBox.Show("Введите данные");
            }
        }
    }
}
