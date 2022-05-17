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
    public partial class Main : Form
    {
        int i, j;
        int counter = 0;
        public int count = 0;
        ArrayList buttonList = new ArrayList();
        int[] blocks, actions;
        int startPoint,targetPoint;

        public Main(int startPoint, int targetPoint,int[] actions,int[] blocks)
        {
            InitializeComponent();
            this.startPoint = startPoint;
            this.targetPoint = targetPoint;
            this.actions = actions;
            this.blocks = blocks;
            Generate();
        }

        private void Generate()
        {
            int actionCounter = 0;
            for (j = 0; j < 10; j++)
            {
                for (i = 0; i < 10; i++)
                {
                    Button button = new Button();
                    button.Text = counter.ToString();
                    button.Name = counter.ToString();
                    button.Size = new Size(50, 50);
                    button.Location = new Point(45 * i, 45 * j);
                    Controls.Add(button);
                    buttonList.Add(button);

                    if (blocks.Contains(counter))
                    {
                        button.BackColor = (Color.Red);
                    }
                    if (counter == targetPoint)
                    {
                        actionCounter++;
                        button.BackColor = (Color.Green);
                        button.Text += "(" + actionCounter.ToString()+")";
                    }
                    if (counter == startPoint)
                    {
                        actionCounter++;
                        button.BackColor = (Color.Gold);
                        button.Text += "("+actionCounter.ToString()+")";
                    }
                    if (actions.Contains(counter) && counter != targetPoint)
                    {
                        actionCounter++;
                        count++;
                        button.BackColor = Color.Purple;
                        button.Text += "(" + actionCounter.ToString()+")";
                    }
                    counter++;
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
