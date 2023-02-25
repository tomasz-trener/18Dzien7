using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02DynamiczneGenerowanieKontrolek
{
    public partial class Form1 : Form
    {
        private const int minRozm = 4;
        private const int maxRozm = 10;
        public Form1()
        {
            InitializeComponent();

            List<RozmiarPlanszy> rozmiary = new List<RozmiarPlanszy>();
            for (int i = minRozm; i <= maxRozm; i+=2)
                rozmiary.Add(new RozmiarPlanszy(i));

            cbRozmiar.DataSource = rozmiary;
            cbRozmiar.DisplayMember = "Text";
        }

        private void btnGeneruj_Click(object sender, EventArgs e)
        {
            pnlObszarGry.Controls.Clear();
            RozmiarPlanszy rp = (RozmiarPlanszy)cbRozmiar.SelectedItem;
            int liczby = 1;

            for (int w = 0; w < rp.Rozmiar; w++)
            {
                for (int k = 0; k < rp.Rozmiar; k++)
                {
                    Button b = new Button();
                    b.Name = "btnPrzycisk_" + w+"_"+k;
                    b.Text = liczby.ToString(); ;
                    b.Width = 50;
                    b.Height = 50;
                    b.Top = 20 + w * (20 + b.Height);
                    b.Left = 20 + k * (20+ b.Width);
                    pnlObszarGry.Controls.Add(b);

                    liczby++;
                }
            }


            
            
        }
    }
}
