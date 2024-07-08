using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Avtosalon
{
    public partial class Form2 : Form
    {
        public bool key_prav;
        public string[] clients_name;
        public string[] clients_email;
        public string[] clients_phone;
        public string[] manager_name;
        public string[] manager_email;
        public string[] manager_phone;
        public string[] avtosalons_name;
        public string[] avtosalons_city;
        public int id_car;

        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.dataSet1.sales);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this.dataSet1.cars);
            if (key_prav == false)
            {
                добавитьToolStripMenuItem.Visible = false;
                Manager.Items[1].Visible = false;
                Manager.Items[2].Visible = false;
                Clients.Items[0].Visible = false;
                Clients.Items[1].Visible = false;
                Cars.Items[1].Visible = false;
                Cars.Items[2].Visible = false;
            }
            Obnovlen();
        }
        void Obnovlen()
        {
            this.clientsTableAdapter.Fill(this.dataSet1.clients);
            this.avto_salesTableAdapter.Fill(this.dataSet11.Avto_sales);
            this.avto_salesTableAdapter.Fill(this.dataSet1.Avto_sales);
            this.managerTableAdapter.Fill(this.dataSet1.manager);
            this.avto_salesTableAdapter.Fill(this.dataSet1.Avto_sales);
            this.avtoTableAdapter.Fill(this.dataSet1.Avto);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.avtoTableAdapter.FillProd(dataSet1.Avto, textBox1.Text);
            }
            if (radioButton2.Checked == true)
            {
                this.avtoTableAdapter.FillModel(dataSet1.Avto, textBox1.Text);
            }
            if (radioButton3.Checked == true)
            {
                this.avtoTableAdapter.Filldate(dataSet1.Avto, Convert.ToInt32(textBox1.Text));
            }
            if (radioButton4.Checked == true) {
                this.avtoTableAdapter.FillColor(dataSet1.Avto,textBox1.Text);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void клиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.groupBox2.Visible = true;
            f.key_m = false;
            f.key_Up = false;
            f.ShowDialog();
            Obnovlen();

        }

        private void менаджераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.groupBox2.Visible = true;
            f.key_m = true;
            f.key_Up = false;
            f.ShowDialog();
            Obnovlen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.avtoTableAdapter.Fill(this.dataSet1.Avto);
            label1.Text = "";
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            label1.Text = "Производитель";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Модель";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Год выпуска";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Цвет";
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Clients_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Del_car_Click(object sender, EventArgs e)
        {
            string prod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string model = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int date = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            string color = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            double price = Convert.ToDouble(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            string probeg = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            avtoTableAdapter.DeleteQuery(prod, model,date,color,price,probeg);
            Obnovlen();
            MessageBox.Show("Удалено");
        }

        private void Del_man_Click(object sender, EventArgs e)
        {
            string name = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            string email = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            string phone = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            clientsTableAdapter.DeleteQuery(name, email, phone);
            Obnovlen();
            MessageBox.Show("Удалено");
        }

        private void Del_manager_Click(object sender, EventArgs e)
        {
            string name = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            string email = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            string phone = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            managerTableAdapter.DeleteQuery(name, email, phone);
            Obnovlen();
            MessageBox.Show("Удалено");
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            comboBox1.Items.Clear();
            int manager_lenght = managerTableAdapter.GetData().Rows.Count;
            int clients_lenght = clientsTableAdapter.GetData().Rows.Count;
            int avtosalons_lenght = avtosalonsTableAdapter.GetData().Rows.Count;
            manager_name = new string[manager_lenght];
            manager_email = new string[manager_lenght];
            manager_phone = new string[manager_lenght];
            clients_name = new string[clients_lenght];
            clients_email = new string[clients_lenght];
            clients_phone = new string[clients_lenght];
            avtosalons_name = new string[avtosalons_lenght];
            avtosalons_city = new string[avtosalons_lenght];
            DataSet1.managerDataTable manag = managerTableAdapter.GetData();
            DataSet1.clientsDataTable client = clientsTableAdapter.GetData();
            DataSet1.AvtosalonsDataTable avtosalon = avtosalonsTableAdapter.GetData();
            string prod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string mod = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int date = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            string color = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            decimal price = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            int probeg = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            id_car = Convert.ToInt32(carsTableAdapter.GetDataBy(prod,mod,date,color,price,probeg).Rows[0].ItemArray[0].ToString());
            for (int i = 0; i < manager_lenght; i++)
            {
                comboBox1.Items.Add(manag.Rows[i].ItemArray[0] + " " + manag.Rows[i].ItemArray[1]);
                manager_name[i] = manag.Rows[i].ItemArray[0].ToString();
                manager_email[i] = manag.Rows[i].ItemArray[1].ToString();
                manager_phone[i] = manag.Rows[i].ItemArray[2].ToString();
            }
           
            comboBox2.Items.Clear();
            for (int i = 0; i < clients_lenght; i++)
            {
                comboBox2.Items.Add(client.Rows[i].ItemArray[0] + " " + client.Rows[i].ItemArray[1]);
                clients_name[i] = client.Rows[i].ItemArray[0].ToString();
                clients_email[i] = client.Rows[i].ItemArray[1].ToString();
                clients_phone[i] = client.Rows[i].ItemArray[2].ToString();
            }
            comboBox3.Items.Clear();
            for (int i = 0; i < avtosalons_lenght; i++)
            {
                comboBox3.Items.Add(avtosalon.Rows[i].ItemArray[0] + " " + avtosalon.Rows[i].ItemArray[1]);
                avtosalons_name[i] = avtosalon.Rows[i].ItemArray[0].ToString();
                avtosalons_city[i] = avtosalon.Rows[i].ItemArray[1].ToString();
            }

        }

        private void Up_car_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.key_m = true;
            f.groupBox1.Visible = true;
            f.prod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.mod = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f.date = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            f.color = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f.price = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            f.probeg = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f.prodact.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.model.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f.date_prod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f.Color.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f.Cost.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f.Probeg.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f.key_Up = true;    
            f.ShowDialog();
            Obnovlen();
        }

        private void Up_man_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.groupBox2.Visible = true;
            f.key_m = false;
            f.nam = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            f.em = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            f.ph = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            f.tname.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            f.temail.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            f.tphone.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            f.key_Up = true;
            f.ShowDialog();
            Obnovlen();
        }

        private void машинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.groupBox1.Visible = true;
            f.key_Up = false;
            f.ShowDialog();
            Obnovlen();
        }

        private void автосалонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.groupBox3.Visible = true;
            f.key_Up = false;
            f.ShowDialog();
            Obnovlen();
        }

        private void Up_manager_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.groupBox2.Visible = true;
            f.key_m = true;
            f.nam = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            f.em = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            f.ph = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            f.tname.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            f.temail.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            f.tphone.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            f.key_Up = true;
            f.ShowDialog();
            Obnovlen();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_Click(object sender, EventArgs e)
        {
            label6.Text = "Имя";
            tphone.Visible = false;
            textBox2.Visible = true ;
        }

        private void radioButton6_Click(object sender, EventArgs e)
        {
            label6.Text = "Email";
            tphone.Visible = false;
            textBox2.Visible = true;
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            label6.Text = "Телефон";
            textBox2.Visible = false;
            tphone.Visible = true;
        }

        private void radioButton10_Click(object sender, EventArgs e)
        {
            label7.Text = "Имя";
            maskedTextBox2.Visible = false;
            textBox3.Visible = true;
        }

        private void radioButton9_Click(object sender, EventArgs e)
        {
            label7.Text = "Email";
            maskedTextBox2.Visible = false;
            textBox3.Visible = true;
        }

        private void radioButton8_Click(object sender, EventArgs e)
        {
            label7.Text = "Телефон";
            maskedTextBox2.Visible = true;
            textBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text != "" && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1)
            {
                int id_manager  = Convert.ToInt32(carsTableAdapter.Getid_manager(manager_name[comboBox1.SelectedIndex], manager_email[comboBox1.SelectedIndex], manager_phone[comboBox1.SelectedIndex]).Rows[0].ItemArray[0].ToString());
                int id_client = Convert.ToInt32(carsTableAdapter.GetId_client(clients_name[comboBox2.SelectedIndex], clients_email[comboBox2.SelectedIndex], clients_phone[comboBox2.SelectedIndex]).Rows[0].ItemArray[0].ToString());
                int id_avtosalon = Convert.ToInt32(carsTableAdapter.GetId_avtosalons(avtosalons_name[comboBox3.SelectedIndex], avtosalons_city[comboBox3.SelectedIndex]).Rows[0].ItemArray[0].ToString());
                salesTableAdapter.InsertQuery(id_car, id_manager, id_client, id_avtosalon, Convert.ToDateTime(maskedTextBox1.Text));
                carsTableAdapter.Updatecars(id_car);
                carsTableAdapter.InsertQuery(id_client, id_car, Convert.ToDateTime(maskedTextBox1.Text));
                MessageBox.Show("Продано");
                Obnovlen();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Obnovlen();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Obnovlen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                managerTableAdapter.FillByname(dataSet1.manager, textBox2.Text);
            }
            if (radioButton6.Checked == true)
            {
                managerTableAdapter.FillByemail(dataSet1.manager, textBox2.Text);
            }
            if (radioButton5.Checked == true)
            {
                managerTableAdapter.FillByphone(dataSet1.manager, tphone.Text);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true)
            {
                clientsTableAdapter.Fillname(dataSet1.clients, textBox3.Text);
            }
            if (radioButton6.Checked == true)
            {
                clientsTableAdapter.FillByemail(dataSet1.clients, textBox3.Text);
            }
            if (radioButton5.Checked == true)
            {
                clientsTableAdapter.FillByPhone(dataSet1.clients, maskedTextBox2.Text);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Diag_Click(object sender, EventArgs e)
        {
            int id_manager = Convert.ToInt32(carsTableAdapter.Getid_manager(dataGridView3.CurrentRow.Cells[0].Value.ToString(), dataGridView3.CurrentRow.Cells[1].Value.ToString(), dataGridView3.CurrentRow.Cells[2].Value.ToString()).Rows[0].ItemArray[0].ToString());
            int size = salesTableAdapter.GetDataBy1(id_manager).Rows.Count;
            DataSet1.salesDataTable sale = salesTableAdapter.GetDataBy1(id_manager);
            
            string[] dat = new string[size];
            int[] id_cars = new int[size];
            double[] price_cars = new double[size];
            for (int i = 0; i<size;i++)
            {
                dat[i] = sale.Rows[i].ItemArray[5].ToString().Substring(0,10);
                id_cars[i] = Convert.ToInt32(sale.Rows[i].ItemArray[2].ToString());
                price_cars[i] = Convert.ToDouble(dataTable1TableAdapter.GetData(id_cars[i]).Rows[0].ItemArray[0].ToString());
            }
            chart1.Series[0].Points.Clear();
           for(int i = 0; i < size; i++)
            {
                int kkey = -1;
                for (int k = 0; k < chart1.Series[0].Points.Count; k++)
                    if (dat[k]== dat[i])
                        kkey = k;
                if (kkey != -1 )
                {
                    chart1.Series[0].Points[kkey].XValue += price_cars[i];
                }
                else { chart1.Series[0].Points.AddXY(dat[i], price_cars[i]); }
            }


        }

        private void getDataToolStripButton_Click(object sender, EventArgs e)
        {
         

        }
    }
}
