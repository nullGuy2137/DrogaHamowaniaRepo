using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DrogaHamowania
{
    public partial class Form1 : Form
    {
        public static string ConnectionString => @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+ System.IO.Directory.GetCurrentDirectory() +@"\DBwyniki.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        bool rozpoczete;
        int interwal = 60;
        float calkowitaDrogaHamowania;
        float predkosc;
        float nachylenie, tarcie, reakcja;
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dBwynikiDataSet.Wyniki' . Możesz go przenieść lub usunąć.
            this.wynikiTableAdapter.Fill(this.dBwynikiDataSet.Wyniki);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'dBwynikiDataSet.Wyniki' . Możesz go przenieść lub usunąć.

        }


        //to jest od animacji ruszania się samochodu, odpala się przez bool rozpoczete a ten się zemienia przez przyciski Start i stop
        private void timerAnimacjaHamowania_Tick(object sender, EventArgs e)
        {
            if (rozpoczete == true && (samochod.Left + predkosc) <= Convert.ToInt32((calkowitaDrogaHamowania*1000)/800))
            {
                
                if (predkosc >= 0)
                {
                    samochod.Left += Convert.ToInt32(predkosc);
                    predkosc -= 1;

                }
                //predkosc = predkosc - 1;
                timerAnimacjaHamowania.Interval = interwal;
            }
            

        }

        private void wynikiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wynikiBindingSource.EndEdit();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            predkosc = (float)(numPredkosc.Value);
            nachylenie = (float)(numNachylenie.Value / 100);
            tarcie = (float)(numTarcie.Value);
            reakcja = (float)(numReakcja.Value);
            calkowitaDrogaHamowania = (float)(0.278 * reakcja * predkosc) + (predkosc * predkosc) / (254 * (tarcie + nachylenie));
            AdddataToDatabase(predkosc, nachylenie, tarcie, reakcja, calkowitaDrogaHamowania.ToString("0.00"));
            interwal = 60;
            rozpoczete = true;
            lblwynik.Text = "Calkowita droga hamowania wynosi: " + calkowitaDrogaHamowania.ToString("0.00")+"m";
            timerAnimacjaHamowania.Enabled = true;
        }

        private void wynikiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdddataToDatabase(float predkosc, float nachylenie, float tarcie, float reakcja, string calkowitaDrogaHamowania)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                string query = "INSERT INTO Wyniki (predkosc, nachylenie, tarcie, reakcja, droga) " +
                               "VALUES (@predkosc, @nachylenie, @tarcie, @czasReakcji, @drogaHamowania)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@predkosc", predkosc);
                command.Parameters.AddWithValue("@nachylenie", nachylenie);
                command.Parameters.AddWithValue("@tarcie", tarcie);
                command.Parameters.AddWithValue("@czasReakcji", reakcja);
                command.Parameters.AddWithValue("@drogaHamowania", calkowitaDrogaHamowania);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                this.wynikiTableAdapter.Fill(this.dBwynikiDataSet.Wyniki);
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            samochod.Left = 12;
            rozpoczete = false;
            timerAnimacjaHamowania.Enabled = false;
        }
    }
}
