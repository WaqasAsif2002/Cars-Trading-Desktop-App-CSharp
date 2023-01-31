using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waqas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            choosecar.Text = "select a Car";
            choosecar.Items.Add("Toyota");
            choosecar.Items.Add("Kia");
            choosecar.Items.Add("Audi");
            choosecar.Items.Add("Mitsubish");

            mileage.Text = "select a Mileage";
            mileage.Items.Add("100-500");
            mileage.Items.Add("501-1000");
            mileage.Items.Add("1001-1500");
            mileage.Items.Add("1501-2000");



        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {




        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {





        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (choosecar.Text == "Toyota")
            {
                cost.Text = "200000";
            }
            if (choosecar.Text == "Kia")
            {
                cost.Text = "300000";
            }
            if (choosecar.Text == "Audi")
            {
                cost.Text = "3200000";
            }
            if (choosecar.Text == "Mitsubish")
            {
                cost.Text = "3500000";
            }





        }

        private void mileage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mileage.Text == "100-500")
            {
                textBox2.Text = "10000";
            }
            if (mileage.Text == "501-1000")
            {
                textBox2.Text = "12000";
            }
            if (mileage.Text == "1001-1500")
            {
                textBox2.Text = "14000";
            }
            if (mileage.Text == "1501-2000")
            {
                textBox2.Text = "18000";
            }





        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Txtresult.Text = "";
            //subtotal.Text = "";
            textBox13.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            mileage.Text = "select a Mileage";
            choosecar.Text = "select a Car";
            cost.Text = "";
            textBox2.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            int no1, no2, sum;
            no1 = Convert.ToInt32(cost.Text);
            no2 = Convert.ToInt32(textBox2.Text);
            sum = no2 + no1;
            textBox13.Text = "" + sum;


        
        }
    
        private void receipt_Click(object sender, EventArgs e)
        {
            Txtresult.Clear();
            Txtresult.Text += "****************************\n";
            Txtresult.Text += "*          RECIEPT         *\n";
            Txtresult.Text += "****************************\n";
            Txtresult.Text += "Date:" + DateTime.Now +"\n";
            Txtresult.Text += "Name:" + textBox8.Text+"\n";
            Txtresult.Text += "ADDRESS:" + textBox9.Text + "\n";
            Txtresult.Text += "PHONE:" + textBox10.Text + "\n";
            Txtresult.Text += "CAR NAME:" + choosecar.Text  + "\n";
            Txtresult.Text += "CAR COST:"  + cost.Text + "\n";
            //Txtresult.Text += "CAR COST:" + cost.Text + "\n";
            Txtresult.Text += " MILLEAGE :" + mileage.Text +"\n";
            Txtresult.Text += " MILLEAGE COST:" + textBox2.Text + "\n";
            Txtresult.Text += " TOTAL:" + textBox13.Text + "\n";
            






        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            {

                }
                
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            About_us form = new About_us();
            form.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            media form1 = new media();
            form1.Show();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Txtresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}