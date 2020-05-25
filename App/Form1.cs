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

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
