﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalisanIslem form = new CalisanIslem();
            form.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeIslem form = new UyeIslem();
            form.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KitapIslem form = new KitapIslem();
            form.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmanetIslemleri form = new EmanetIslemleri();
            form.Visible = true;
        }
    }
}
