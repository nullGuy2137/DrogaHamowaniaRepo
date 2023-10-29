using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrogaHamowania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int predkosc = 12;
        bool rozpoczete;
        int interwal = 30;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //to jest od animacji ruszania się samochodu, odpala się przez bool rozpoczete a ten się zemienia przez przyciski Start i stop
        private void timerAnimacjaHamowania_Tick(object sender, EventArgs e)
        {

            if (rozpoczete == true && samochod.Left < 723)
            {
                samochod.Left += predkosc;
                if (predkosc > 1 && interwal > 80)
                {
                    predkosc = predkosc - 1;

                }
                //predkosc = predkosc - 1;
                interwal = interwal + 1;
                timerAnimacjaHamowania.Interval = interwal;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            interwal = 30;
            rozpoczete = true;
            timerAnimacjaHamowania.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            predkosc = 12;
            samochod.Left = 0;
            rozpoczete = false;
            timerAnimacjaHamowania.Enabled = false;
        }
    }
}
