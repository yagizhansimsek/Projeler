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
    public partial class grafik2 : Form
    {
        
        public grafik2()
        {
            InitializeComponent();
            
            
        }

        private void grafik2_Load(object sender, EventArgs e)
        {
            
        }
        public void chart(int adımSayısı,int sayac)
        {
            chart1.Series["Bölüm Adım Sayısı"].Points.AddXY(sayac,adımSayısı);
        }
    }
}
