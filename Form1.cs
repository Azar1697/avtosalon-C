using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Odbc;

namespace Avtosalon
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.vxod". При необходимости она может быть перемещена или удалена.
            this.vxodTableAdapter.Fill(this.dataSet11.vxod);
            // = vxodTableAdapter.GetData();
            comboBox1.Items.Clear();
            for (int i = 0; i < vxodTableAdapter.GetData().Rows.Count; i++) {
                comboBox1.Items.Add(vxodTableAdapter.GetData().Rows[i].ItemArray[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            for (int i = 0; i < vxodTableAdapter.GetData().Rows.Count; i++)
            {
                
                if(textBox1.Text == vxodTableAdapter.GetData().Rows[i].ItemArray[1].ToString())
                {
                    k = 1;
                }
            }
            if (k == 1)
            {
                this.Visible = false;
                Form2 F = new Form2();
                if (comboBox1.SelectedItem.ToString() == "admin")
                    F.key_prav = true;
                F.Show();
            }
            else {
                MessageBox.Show("Неправильный пароль!!!");
            }
        }
    }
}