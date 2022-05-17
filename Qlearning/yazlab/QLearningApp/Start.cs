using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLearningApp.Common;
using QLearningApp.MachineLearning;

namespace QLearningApp
{
    
    public partial class Start : Form
    {
        int actionCounter = 0;
        int i, j;
        int counter = 0;
        ArrayList buttonList = new ArrayList();
        int[] blocks, actions;
        int startPoint, targetPoint;
        int[] block = EngelUret();
        public static int[] EngelUret()
        {
            Random rastgele = new Random();
            int k = 0;
            int m;
            int[] engel = new int[30];
            for (int l = 0; l < 30; l++)
            {
                engel[l] = -99;
            }
            while (k < 30)
            {
                int sayi = rastgele.Next(0, 100);
                for (m = 0; m < 30; m++)
                {
                    if (sayi == engel[m])
                    {
                        continue;
                    }
                }
                engel[k] = sayi;
                k++;
            }
            TextWriter dosya = new StreamWriter(@"D:\engeller.txt");
            for(int i=0;i<30;i++)
            {
                dosya.WriteLine(i + 1 + ". engel " + engel[i]);
            }
            dosya.Flush();
            dosya.Close();
            return engel;
        }

        public Start()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int counter = 0;
            for (j = 0; j < 10; j++)
            {
                for (i = 0; i < 10; i++)
                {
                    Button button = new Button();
                    button.Text = counter.ToString();
                    button.Name = counter.ToString();
                    button.Size = new Size(50, 50);
                    button.Location = new Point(200 + (45 * i), 100 + (45 * j));
                    Controls.Add(button);
                    if (block.Contains(counter))
                    {
                        button.BackColor = Color.Red;
                    }
                    counter++;

                }
            }
        }
    

        private void v(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ÖNEMLİ::Baslangıç,bitiş üzerinde engel koyuyor
            
            var qLearning = new QLearning(0.8, new RoomsProblem(block, Convert.ToInt32(endPointTB.Text.ToString())));
            qLearning.TrainAgent(2000, Convert.ToInt32(endPointTB.Text.ToString()));
            int initialState = 0;

            QLearningStats qLearningStats = qLearning.Run(Convert.ToInt32(startPointTB.Text.ToString()),Convert.ToInt32(endPointTB.Text.ToString()));
            var normalizedMatrix = qLearning.QTable.NormalizeMatrix();
            int sayac = 0;
            ArrayList dizi = new ArrayList();
            for(int i=0;i<100;i++)
            {
                for(int j=0;j<100;j++)
                {
                    dizi.Add(normalizedMatrix[i][j]); 
                }
                Console.Write("\n");
                sayac++;
            }
            


            Start start = new Start();
            Main main = new Main(qLearningStats.InitialState, qLearningStats.EndState, qLearningStats.Actions, block);

            int count;
            count = main.count;
            grafik grafik = new grafik(dizi,count);
            grafik.Visible = true; 
            main.Visible = true;
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
