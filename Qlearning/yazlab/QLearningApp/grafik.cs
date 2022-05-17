using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLearningApp
{
    public partial class grafik : Form
    {
        public ArrayList dizi;
        public int count;
        public grafik(ArrayList dizi,int count)
        {
            InitializeComponent();
            this.dizi = dizi;
            this.count = count;
        }

        private void grafik_Load(object sender, EventArgs e)
        {
            int sayac = 0;
            foreach (double j in dizi)
            {     
                    chart1.Series["Q maaliyetleri"].Points.AddXY(sayac, j);
                sayac++;
            }
        }
    }
}
