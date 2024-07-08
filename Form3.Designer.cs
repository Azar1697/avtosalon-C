
namespace Avtosalon
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_prod = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Cost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Probeg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prodact = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tphone = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.temail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.name_city = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.name_avtosalon = new System.Windows.Forms.TextBox();
            this.clientsTableAdapter = new Avtosalon.DataSet1TableAdapters.clientsTableAdapter();
            this.managerTableAdapter = new Avtosalon.DataSet1TableAdapters.managerTableAdapter();
            this.avtosalonsTableAdapter = new Avtosalon.DataSet1TableAdapters.AvtosalonsTableAdapter();
            this.avtoTableAdapter = new Avtosalon.DataSet1TableAdapters.AvtoTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.date_prod);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Cost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Probeg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Color);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.model);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.prodact);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // date_prod
            // 
            this.date_prod.Location = new System.Drawing.Point(175, 64);
            this.date_prod.Mask = "0000";
            this.date_prod.Name = "date_prod";
            this.date_prod.Size = new System.Drawing.Size(100, 26);
            this.date_prod.TabIndex = 14;
            this.date_prod.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Стоимость";
            // 
            // Cost
            // 
            this.Cost.Location = new System.Drawing.Point(175, 170);
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(100, 26);
            this.Cost.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Пробег";
            // 
            // Probeg
            // 
            this.Probeg.Location = new System.Drawing.Point(175, 117);
            this.Probeg.Name = "Probeg";
            this.Probeg.Size = new System.Drawing.Size(100, 26);
            this.Probeg.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цвет";
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(10, 170);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(149, 26);
            this.Color.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Год выпуска";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Модель";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(10, 117);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(149, 26);
            this.model.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Производитель";
            // 
            // prodact
            // 
            this.prodact.Location = new System.Drawing.Point(10, 64);
            this.prodact.Name = "prodact";
            this.prodact.Size = new System.Drawing.Size(149, 26);
            this.prodact.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tphone);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.temail);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tname);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 256);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // tphone
            // 
            this.tphone.Location = new System.Drawing.Point(10, 170);
            this.tphone.Mask = "8 (999) 000-00-00";
            this.tphone.Name = "tphone";
            this.tphone.Size = new System.Drawing.Size(149, 26);
            this.tphone.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Телефон";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "Email";
            // 
            // temail
            // 
            this.temail.Location = new System.Drawing.Point(10, 117);
            this.temail.Name = "temail";
            this.temail.Size = new System.Drawing.Size(149, 26);
            this.temail.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Имя";
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(10, 64);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(149, 26);
            this.tname.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.name_city);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.name_avtosalon);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(2, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 198);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 19);
            this.label17.TabIndex = 3;
            this.label17.Text = "Город";
            // 
            // name_city
            // 
            this.name_city.Location = new System.Drawing.Point(10, 117);
            this.name_city.Name = "name_city";
            this.name_city.Size = new System.Drawing.Size(149, 26);
            this.name_city.TabIndex = 2;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(153, 19);
            this.label18.TabIndex = 1;
            this.label18.Text = "Название автосалона";
            // 
            // name_avtosalon
            // 
            this.name_avtosalon.Location = new System.Drawing.Point(10, 64);
            this.name_avtosalon.Name = "name_avtosalon";
            this.name_avtosalon.Size = new System.Drawing.Size(149, 26);
            this.name_avtosalon.TabIndex = 0;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // managerTableAdapter
            // 
            this.managerTableAdapter.ClearBeforeFill = true;
            // 
            // avtosalonsTableAdapter
            // 
            this.avtosalonsTableAdapter.ClearBeforeFill = true;
            // 
            // avtoTableAdapter
            // 
            this.avtoTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(347, 274);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.Text = "Добавить";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox name_city;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox name_avtosalon;
        private DataSet1TableAdapters.clientsTableAdapter clientsTableAdapter;
        private DataSet1TableAdapters.managerTableAdapter managerTableAdapter;
        private DataSet1TableAdapters.AvtosalonsTableAdapter avtosalonsTableAdapter;
        private DataSet1TableAdapters.AvtoTableAdapter avtoTableAdapter;
        public System.Windows.Forms.TextBox prodact;
        public System.Windows.Forms.TextBox model;
        public System.Windows.Forms.TextBox Color;
        public System.Windows.Forms.TextBox Probeg;
        public System.Windows.Forms.TextBox Cost;
        public System.Windows.Forms.MaskedTextBox date_prod;
        public System.Windows.Forms.MaskedTextBox tphone;
        public System.Windows.Forms.TextBox temail;
        public System.Windows.Forms.TextBox tname;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.GroupBox groupBox3;
    }
}