using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            
        }

        private int hora = DateTime.Now.Hour;
        private int minuto = DateTime.Now.Minute;
        private int segundo = DateTime.Now.Second;

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimer.Text = $"{hora}:{minuto}:{segundo}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //incrementar as variaveis do tempo
            segundo++;
            if (minuto<60 && segundo == 60)
            {
                segundo = 0;
                minuto++;
            }
            if(minuto == 60 && segundo == 60)
            {
                segundo = 0;
                minuto = 0;
                hora++;
            }
            lblTimer.Text = $"{hora}:{minuto}:{segundo}";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txb01.Text = $"{ txb01.Text }{btn1.Text}";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txb01.Text = $"{ txb01.Text }{btn2.Text}";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txb01.Text = $"{ txb01.Text }{btn3.Text}";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txb01.Text = $"{ txb01.Text }{btn4.Text}";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txb01.Text = $"{ txb01.Text }{btn5.Text}";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txb01.Text = $"{ txb01.Text }{btn6.Text}";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txb01.Text = $"{ txb01.Text }{btn7.Text}";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txb01.Text = $"{ txb01.Text }{btn8.Text}";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txb01.Text = $"{ txb01.Text }{btn9.Text}";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txb01.Text = $"{ txb01.Text }{btnZero.Text}";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txb01.Text);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count >= 3)
            {
                var sum = 0;
                foreach (var item in listBox1.Items)
                {
                    sum += int.Parse(item.ToString());
                }
                lblTotal.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Para calcular o total deve haver pelo menos 3 itens na lista", "ERROR");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Professores")
            {
                gpbProfessores.Visible = true;
                gpbProfessoras.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Professoras")
            {
                gpbProfessoras.Visible = true;
                gpbProfessores.Visible = false;
            }
        }
    }
}
