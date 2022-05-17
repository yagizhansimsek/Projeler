using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static Button[,] Button_Array1 = new Button[9, 9];
        static Button[,] Button_Array2 = new Button[9, 9];
        static Button[,] Button_Array5 = new Button[9, 9];
        static Button[,] Button_Array3 = new Button[9, 9];
        static Button[,] Button_Array4 = new Button[9, 9];
        static int[] deneme_array = new int[81];
        public static long[] chart = new long[5];
        static long second = DateTime.Now.Millisecond;
        static String text;
        public Form1()
        {
            InitializeComponent();
        }

        private static bool Canbe(int[,] map, int row, int col, int num)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                if (map[row, i] == num)
                {
                    return false;
                }
            }
            for (int i = 0; i < map.GetLength(0); i++)
            {
                if (map[i, col] == num)
                {
                    return false;
                }
            }
            int squareroot = (int)Math.Sqrt(map.GetLength(0));
            int rowStart = row - row % squareroot;
            int colStart = col - col % squareroot;
            for (int i = rowStart; i < rowStart + squareroot; i++)
            {
                for (int j = colStart; j < colStart + squareroot; j++)
                {
                    if (map[i, j] == num)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool Control(int[,] map, int m)
        {
            int row = 0;
            int col = 0;
            bool isempty = true;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (map[i, j] == 0)
                    {
                        row = i;
                        col = j;
                        isempty = false;
                        break;
                    }
                }
                if (!isempty)
                {
                    break;
                }
            }
            if (isempty)
            {
                return true;

            }
            for (int num = 1; num <= m; num++)
            {
                if (Canbe(map, row, col, num))
                {

                    map[row, col] = num;

                    if (Control(map, m))
                    {

                        return true;

                    }
                    else
                    {
                        map[row, col] = 0;
                    }
                }
            }
            return false;
        }
        private static void print(int[,] map, int k)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false; // hocam biz de bilmiyoruz internette bulduk bu satırı


            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {

                

                    Button_Array1[i, j].Text = "" + map[i, j];
                    for (int a = 0; a < 9; a++)
                    {
                        for (int b = 0; b < 9; b++)
                        {
                            if (!Button_Array1[a, b].Text.Equals("0"))
                            {

                            }
                        }
                    }
                }
             
            }

        }

        private static void print2(int[,] map, int k)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false; // hocam valla bilmiyoz biz de (çapraz iş parçacığı bilmemne falanı)
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                  

                    Button_Array2[i, j].Text = "" + map[i, j];

                }
             
            }
        }
        private static void print3(int[,] map, int k)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false; // hocam valla bilmiyoz biz de (çapraz iş parçacığı bilmemne falanı)
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                  

                    Button_Array3[i, j].Text = "" + map[i, j];

                }
               
            }
        }
        private static void print4(int[,] map, int k)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false; 
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                  

                    Button_Array4[i, j].Text = "" + map[i, j];

                }
         
            }
        }
        private static void print5(int[,] map, int k)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false; // hocam valla bilmiyoz biz de (çapraz iş parçacığı bilmemne falanı)
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
              

                    Button_Array5[i, j].Text = "" + map[i, j];

                }
             
            }
        }
        public static void function1(int[,] board)
        {
            int p = board.GetLength(0);
            second = DateTime.Now.Millisecond;
            if (Control(board, p))
            {
                chart[0] = DateTime.Now.Millisecond - second;
                print(board, p);
            }
          
        }
        static void function2(int[,] board)
        {
            int p = board.GetLength(0);
            second = DateTime.Now.Millisecond;
            if (Control(board, p))
            {
                chart[1] = DateTime.Now.Millisecond - second;
            
                print2(board, p);
            }
   
        }
        static void function3(int[,] board)
        {
            int p = board.GetLength(0);
            second = DateTime.Now.Millisecond;
            if (Control(board, p))
            {
                chart[2] = DateTime.Now.Millisecond - second;
          
                print3(board, p);
            }
          
        }
        static void function4(int[,] board)
        {
            int p = board.GetLength(0);
            second = DateTime.Now.Millisecond;
            if (Control(board, p))
            {
                chart[3] = DateTime.Now.Millisecond - second;
                print4(board, p);
            }
           
        }
        static void function5(int[,] board)
        {
            int p = board.GetLength(0);
            second = DateTime.Now.Millisecond;
            if (Control(board, p))
            {
                chart[4] = DateTime.Now.Millisecond - second;
                Debug.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa   " + (chart[4]));
                print5(board, p);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string file_location = @"C:\oku.txt";
            FileStream fs = new FileStream(file_location, FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string Writeing = sw.ReadLine();
            while (Writeing != null)
            {
                text += Writeing;
                Writeing = sw.ReadLine();
            }
            sw.Close();
            fs.Close();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button_Array1[i, j] = new Button();
                    this.Controls.Add(Button_Array1[i, j]);
                    Button_Array1[i, j].Text = "";
                    Button_Array1[i, j].Location = new Point(25 * j, 25 * i);
                    Button_Array1[i, j].Size = new Size(25, 25);

                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button_Array2[i, j] = new Button();
                    this.Controls.Add(Button_Array2[i, j]);
                    Button_Array2[i, j].Text = "";
                    Button_Array2[i, j].Location = new Point(300 + (25 * j), 25 * i);
                    Button_Array2[i, j].Size = new Size(25, 25);

                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button_Array3[i, j] = new Button();
                    this.Controls.Add(Button_Array3[i, j]);
                    Button_Array3[i, j].Text = "";
                    Button_Array3[i, j].Location = new Point(150 + (25 * j), 150 + (25 * i));
                    Button_Array3[i, j].Size = new Size(25, 25);

                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button_Array4[i, j] = new Button();
                    this.Controls.Add(Button_Array4[i, j]);
                    Button_Array4[i, j].Text = "";
                    Button_Array4[i, j].Location = new Point((25 * j), 300 + (25 * i));
                    Button_Array4[i, j].Size = new Size(25, 25);

                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button_Array5[i, j] = new Button();
                    this.Controls.Add(Button_Array5[i, j]);
                    Button_Array5[i, j].Text = "";
                    Button_Array5[i, j].Location = new Point(300 + (25 * j), 300 + (25 * i));
                    Button_Array5[i, j].Size = new Size(25, 25);

                }
            }

            Button_Array1[0, 0].Text = "" + text[0];
            Button_Array1[0, 1].Text = "" + text[1];
            Button_Array1[0, 2].Text = "" + text[2];
            Button_Array1[0, 3].Text = "" + text[3];
            Button_Array1[0, 4].Text = "" + text[4];
            Button_Array1[0, 5].Text = "" + text[5];
            Button_Array1[0, 6].Text = "" + text[6];
            Button_Array1[0, 7].Text = "" + text[7];
            Button_Array1[0, 8].Text = "" + text[8];

            Button_Array2[0, 0].Text = "" + text[9];
            Button_Array2[0, 1].Text = "" + text[10];
            Button_Array2[0, 2].Text = "" + text[11];
            Button_Array2[0, 3].Text = "" + text[12];
            Button_Array2[0, 4].Text = "" + text[13];
            Button_Array2[0, 5].Text = "" + text[14];
            Button_Array2[0, 6].Text = "" + text[15];
            Button_Array2[0, 7].Text = "" + text[16];
            Button_Array2[0, 8].Text = "" + text[17];

            Button_Array1[1, 0].Text = "" + text[18];
            Button_Array1[1, 1].Text = "" + text[19];
            Button_Array1[1, 2].Text = "" + text[20];
            Button_Array1[1, 3].Text = "" + text[21];
            Button_Array1[1, 4].Text = "" + text[22];
            Button_Array1[1, 5].Text = "" + text[23];
            Button_Array1[1, 6].Text = "" + text[24];
            Button_Array1[1, 7].Text = "" + text[25];
            Button_Array1[1, 8].Text = "" + text[26];

            Button_Array2[1, 0].Text = "" + text[27];
            Button_Array2[1, 1].Text = "" + text[28];
            Button_Array2[1, 2].Text = "" + text[29];
            Button_Array2[1, 3].Text = "" + text[30];
            Button_Array2[1, 4].Text = "" + text[31];
            Button_Array2[1, 5].Text = "" + text[32];
            Button_Array2[1, 6].Text = "" + text[33];
            Button_Array2[1, 7].Text = "" + text[34];
            Button_Array2[1, 8].Text = "" + text[35];

            Button_Array1[2, 0].Text = "" + text[36];
            Button_Array1[2, 1].Text = "" + text[37];
            Button_Array1[2, 2].Text = "" + text[38];
            Button_Array1[2, 3].Text = "" + text[39];
            Button_Array1[2, 4].Text = "" + text[40];
            Button_Array1[2, 5].Text = "" + text[41];
            Button_Array1[2, 6].Text = "" + text[42];
            Button_Array1[2, 7].Text = "" + text[43];
            Button_Array1[2, 8].Text = "" + text[44];

            Button_Array2[2, 0].Text = "" + text[45];
            Button_Array2[2, 1].Text = "" + text[46];
            Button_Array2[2, 2].Text = "" + text[47];
            Button_Array2[2, 3].Text = "" + text[48];
            Button_Array2[2, 4].Text = "" + text[49];
            Button_Array2[2, 5].Text = "" + text[50];
            Button_Array2[2, 6].Text = "" + text[51];
            Button_Array2[2, 7].Text = "" + text[52];
            Button_Array2[2, 8].Text = "" + text[53];

            Button_Array1[3, 0].Text = "" + text[54];
            Button_Array1[3, 1].Text = "" + text[55];
            Button_Array1[3, 2].Text = "" + text[56];
            Button_Array1[3, 3].Text = "" + text[57];
            Button_Array1[3, 4].Text = "" + text[58];
            Button_Array1[3, 5].Text = "" + text[59];
            Button_Array1[3, 6].Text = "" + text[60];
            Button_Array1[3, 7].Text = "" + text[61];
            Button_Array1[3, 8].Text = "" + text[62];

            Button_Array2[3, 0].Text = "" + text[63];
            Button_Array2[3, 1].Text = "" + text[64];
            Button_Array2[3, 2].Text = "" + text[65];
            Button_Array2[3, 3].Text = "" + text[66];
            Button_Array2[3, 4].Text = "" + text[67];
            Button_Array2[3, 5].Text = "" + text[68];
            Button_Array2[3, 6].Text = "" + text[69];
            Button_Array2[3, 7].Text = "" + text[70];
            Button_Array2[3, 8].Text = "" + text[71];

            Button_Array1[4, 0].Text = "" + text[72];
            Button_Array1[4, 1].Text = "" + text[73];
            Button_Array1[4, 2].Text = "" + text[74];
            Button_Array1[4, 3].Text = "" + text[75];
            Button_Array1[4, 4].Text = "" + text[76];
            Button_Array1[4, 5].Text = "" + text[77];
            Button_Array1[4, 6].Text = "" + text[78];
            Button_Array1[4, 7].Text = "" + text[79];
            Button_Array1[4, 8].Text = "" + text[80];

            Button_Array2[4, 0].Text = "" + text[81];
            Button_Array2[4, 1].Text = "" + text[82];
            Button_Array2[4, 2].Text = "" + text[83];
            Button_Array2[4, 3].Text = "" + text[84];
            Button_Array2[4, 4].Text = "" + text[85];
            Button_Array2[4, 5].Text = "" + text[86];
            Button_Array2[4, 6].Text = "" + text[87];
            Button_Array2[4, 7].Text = "" + text[88];
            Button_Array2[4, 8].Text = "" + text[89];

            Button_Array1[5, 0].Text = "" + text[90];
            Button_Array1[5, 1].Text = "" + text[91];
            Button_Array1[5, 2].Text = "" + text[92];
            Button_Array1[5, 3].Text = "" + text[93];
            Button_Array1[5, 4].Text = "" + text[94];
            Button_Array1[5, 5].Text = "" + text[95];
            Button_Array1[5, 6].Text = "" + text[96];
            Button_Array1[5, 7].Text = "" + text[97];
            Button_Array1[5, 8].Text = "" + text[98];

            Button_Array2[5, 0].Text = "" + text[99];
            Button_Array2[5, 1].Text = "" + text[100];
            Button_Array2[5, 2].Text = "" + text[101];
            Button_Array2[5, 3].Text = "" + text[102];
            Button_Array2[5, 4].Text = "" + text[103];
            Button_Array2[5, 5].Text = "" + text[104];
            Button_Array2[5, 6].Text = "" + text[105];
            Button_Array2[5, 7].Text = "" + text[106];
            Button_Array2[5, 8].Text = "" + text[107];

            Button_Array1[6, 0].Text = "" + text[108];
            Button_Array1[6, 1].Text = "" + text[109];
            Button_Array1[6, 2].Text = "" + text[110];
            Button_Array1[6, 3].Text = "" + text[111];
            Button_Array1[6, 4].Text = "" + text[112];
            Button_Array1[6, 5].Text = "" + text[113];
            Button_Array1[6, 6].Text = "" + text[114];
            Button_Array1[6, 7].Text = "" + text[115];
            Button_Array1[6, 8].Text = "" + text[116];

            Button_Array1[6, 0].Text = "" + text[108];
            Button_Array1[6, 1].Text = "" + text[109];
            Button_Array1[6, 2].Text = "" + text[110];
            Button_Array1[6, 3].Text = "" + text[111];
            Button_Array1[6, 4].Text = "" + text[112];
            Button_Array1[6, 5].Text = "" + text[113];
            Button_Array1[6, 6].Text = "" + text[114];
            Button_Array1[6, 7].Text = "" + text[115];
            Button_Array1[6, 8].Text = "" + text[116];

            Button_Array3[0, 0].Text = "" + text[114];
            Button_Array3[0, 1].Text = "" + text[115];
            Button_Array3[0, 2].Text = "" + text[116];
            Button_Array3[0, 3].Text = "" + text[117];
            Button_Array3[0, 4].Text = "" + text[118];
            Button_Array3[0, 5].Text = "" + text[119];
            Button_Array3[0, 6].Text = "" + text[120];
            Button_Array3[0, 7].Text = "" + text[121];
            Button_Array3[0, 8].Text = "" + text[122];

            Button_Array2[6, 0].Text = "" + text[120];
            Button_Array2[6, 1].Text = "" + text[121];
            Button_Array2[6, 2].Text = "" + text[122];
            Button_Array2[6, 3].Text = "" + text[123];
            Button_Array2[6, 4].Text = "" + text[124];
            Button_Array2[6, 5].Text = "" + text[125];
            Button_Array2[6, 6].Text = "" + text[126];
            Button_Array2[6, 7].Text = "" + text[127];
            Button_Array2[6, 8].Text = "" + text[128];

            Button_Array1[7, 0].Text = "" + text[129];
            Button_Array1[7, 1].Text = "" + text[130];
            Button_Array1[7, 2].Text = "" + text[131];
            Button_Array1[7, 3].Text = "" + text[132];
            Button_Array1[7, 4].Text = "" + text[133];
            Button_Array1[7, 5].Text = "" + text[134];
            Button_Array1[7, 6].Text = "" + text[135];
            Button_Array1[7, 7].Text = "" + text[136];
            Button_Array1[7, 8].Text = "" + text[137];

            Button_Array3[1, 0].Text = "" + text[135];
            Button_Array3[1, 1].Text = "" + text[136];
            Button_Array3[1, 2].Text = "" + text[137];
            Button_Array3[1, 3].Text = "" + text[138];
            Button_Array3[1, 4].Text = "" + text[139];
            Button_Array3[1, 5].Text = "" + text[140];
            Button_Array3[1, 6].Text = "" + text[141];
            Button_Array3[1, 7].Text = "" + text[142];
            Button_Array3[1, 8].Text = "" + text[143];

            Button_Array2[7, 0].Text = "" + text[141];
            Button_Array2[7, 1].Text = "" + text[142];
            Button_Array2[7, 2].Text = "" + text[143];
            Button_Array2[7, 3].Text = "" + text[144];
            Button_Array2[7, 4].Text = "" + text[145];
            Button_Array2[7, 5].Text = "" + text[146];
            Button_Array2[7, 6].Text = "" + text[147];
            Button_Array2[7, 7].Text = "" + text[148];
            Button_Array2[7, 8].Text = "" + text[149];

            Button_Array1[8, 0].Text = "" + text[150];
            Button_Array1[8, 1].Text = "" + text[151];
            Button_Array1[8, 2].Text = "" + text[152];
            Button_Array1[8, 3].Text = "" + text[153];
            Button_Array1[8, 4].Text = "" + text[154];
            Button_Array1[8, 5].Text = "" + text[155];
            Button_Array1[8, 6].Text = "" + text[156];
            Button_Array1[8, 7].Text = "" + text[157];
            Button_Array1[8, 8].Text = "" + text[158];

            Button_Array3[2, 0].Text = "" + text[156];
            Button_Array3[2, 1].Text = "" + text[157];
            Button_Array3[2, 2].Text = "" + text[158];
            Button_Array3[2, 3].Text = "" + text[159];
            Button_Array3[2, 4].Text = "" + text[160];
            Button_Array3[2, 5].Text = "" + text[161];
            Button_Array3[2, 6].Text = "" + text[162];
            Button_Array3[2, 7].Text = "" + text[163];
            Button_Array3[2, 8].Text = "" + text[164];

            Button_Array2[8, 0].Text = "" + text[162];
            Button_Array2[8, 1].Text = "" + text[163];
            Button_Array2[8, 2].Text = "" + text[164];
            Button_Array2[8, 3].Text = "" + text[165];
            Button_Array2[8, 4].Text = "" + text[166];
            Button_Array2[8, 5].Text = "" + text[167];
            Button_Array2[8, 6].Text = "" + text[168];
            Button_Array2[8, 7].Text = "" + text[169];
            Button_Array2[8, 8].Text = "" + text[170];

            Button_Array3[3, 0].Text = "" + text[171];
            Button_Array3[3, 1].Text = "" + text[172];
            Button_Array3[3, 2].Text = "" + text[173];
            Button_Array3[3, 3].Text = "" + text[174];
            Button_Array3[3, 4].Text = "" + text[175];
            Button_Array3[3, 5].Text = "" + text[176];
            Button_Array3[3, 6].Text = "" + text[177];
            Button_Array3[3, 7].Text = "" + text[178];
            Button_Array3[3, 8].Text = "" + text[179];

            Button_Array3[4, 0].Text = "" + text[180];
            Button_Array3[4, 1].Text = "" + text[181];
            Button_Array3[4, 2].Text = "" + text[182];
            Button_Array3[4, 3].Text = "" + text[183];
            Button_Array3[4, 4].Text = "" + text[184];
            Button_Array3[4, 5].Text = "" + text[185];
            Button_Array3[4, 6].Text = "" + text[186];
            Button_Array3[4, 7].Text = "" + text[187];
            Button_Array3[4, 8].Text = "" + text[188];

            Button_Array3[5, 0].Text = "" + text[189];
            Button_Array3[5, 1].Text = "" + text[190];
            Button_Array3[5, 2].Text = "" + text[191];
            Button_Array3[5, 3].Text = "" + text[192];
            Button_Array3[5, 4].Text = "" + text[193];
            Button_Array3[5, 5].Text = "" + text[194];
            Button_Array3[5, 6].Text = "" + text[195];
            Button_Array3[5, 7].Text = "" + text[196];
            Button_Array3[5, 8].Text = "" + text[197];


            Button_Array4[0, 0].Text = "" + text[198];
            Button_Array4[0, 1].Text = "" + text[199];
            Button_Array4[0, 2].Text = "" + text[200];
            Button_Array4[0, 3].Text = "" + text[201];
            Button_Array4[0, 4].Text = "" + text[202];
            Button_Array4[0, 5].Text = "" + text[203];
            Button_Array4[0, 6].Text = "" + text[204];
            Button_Array4[0, 7].Text = "" + text[205];
            Button_Array4[0, 8].Text = "" + text[206];

            Button_Array3[6, 0].Text = "" + text[204];
            Button_Array3[6, 1].Text = "" + text[205];
            Button_Array3[6, 2].Text = "" + text[206];
            Button_Array3[6, 3].Text = "" + text[207];
            Button_Array3[6, 4].Text = "" + text[208];
            Button_Array3[6, 5].Text = "" + text[209];
            Button_Array3[6, 6].Text = "" + text[210];
            Button_Array3[6, 7].Text = "" + text[211];
            Button_Array3[6, 8].Text = "" + text[212];

            Button_Array5[0, 0].Text = "" + text[210];
            Button_Array5[0, 1].Text = "" + text[211];
            Button_Array5[0, 2].Text = "" + text[212];
            Button_Array5[0, 3].Text = "" + text[213];
            Button_Array5[0, 4].Text = "" + text[214];
            Button_Array5[0, 5].Text = "" + text[215];
            Button_Array5[0, 6].Text = "" + text[216];
            Button_Array5[0, 7].Text = "" + text[217];
            Button_Array5[0, 8].Text = "" + text[218];

            Button_Array4[1, 0].Text = "" + text[219];
            Button_Array4[1, 1].Text = "" + text[220];
            Button_Array4[1, 2].Text = "" + text[221];
            Button_Array4[1, 3].Text = "" + text[222];
            Button_Array4[1, 4].Text = "" + text[223];
            Button_Array4[1, 5].Text = "" + text[224];
            Button_Array4[1, 6].Text = "" + text[225];
            Button_Array4[1, 7].Text = "" + text[226];
            Button_Array4[1, 8].Text = "" + text[227];

            Button_Array3[7, 0].Text = "" + text[225];
            Button_Array3[7, 1].Text = "" + text[226];
            Button_Array3[7, 2].Text = "" + text[227];
            Button_Array3[7, 3].Text = "" + text[228];
            Button_Array3[7, 4].Text = "" + text[229];
            Button_Array3[7, 5].Text = "" + text[230];
            Button_Array3[7, 6].Text = "" + text[231];
            Button_Array3[7, 7].Text = "" + text[232];
            Button_Array3[7, 8].Text = "" + text[233];

            Button_Array5[1, 0].Text = "" + text[231];
            Button_Array5[1, 1].Text = "" + text[232];
            Button_Array5[1, 2].Text = "" + text[233];
            Button_Array5[1, 3].Text = "" + text[234];
            Button_Array5[1, 4].Text = "" + text[235];
            Button_Array5[1, 5].Text = "" + text[236];
            Button_Array5[1, 6].Text = "" + text[237];
            Button_Array5[1, 7].Text = "" + text[238];
            Button_Array5[1, 8].Text = "" + text[239];

            Button_Array4[2, 0].Text = "" + text[240];
            Button_Array4[2, 1].Text = "" + text[241];
            Button_Array4[2, 2].Text = "" + text[242];
            Button_Array4[2, 3].Text = "" + text[243];
            Button_Array4[2, 4].Text = "" + text[244];
            Button_Array4[2, 5].Text = "" + text[245];
            Button_Array4[2, 6].Text = "" + text[246];
            Button_Array4[2, 7].Text = "" + text[247];
            Button_Array4[2, 8].Text = "" + text[248];

            Button_Array3[8, 0].Text = "" + text[246];
            Button_Array3[8, 1].Text = "" + text[247];
            Button_Array3[8, 2].Text = "" + text[248];
            Button_Array3[8, 3].Text = "" + text[249];
            Button_Array3[8, 4].Text = "" + text[250];
            Button_Array3[8, 5].Text = "" + text[251];
            Button_Array3[8, 6].Text = "" + text[252];
            Button_Array3[8, 7].Text = "" + text[253];
            Button_Array3[8, 8].Text = "" + text[254];

            Button_Array5[2, 0].Text = "" + text[252];
            Button_Array5[2, 1].Text = "" + text[253];
            Button_Array5[2, 2].Text = "" + text[254];
            Button_Array5[2, 3].Text = "" + text[255];
            Button_Array5[2, 4].Text = "" + text[256];
            Button_Array5[2, 5].Text = "" + text[257];
            Button_Array5[2, 6].Text = "" + text[258];
            Button_Array5[2, 7].Text = "" + text[259];
            Button_Array5[2, 8].Text = "" + text[260];

            Button_Array4[3, 0].Text = "" + text[261];
            Button_Array4[3, 1].Text = "" + text[262];
            Button_Array4[3, 2].Text = "" + text[263];
            Button_Array4[3, 3].Text = "" + text[264];
            Button_Array4[3, 4].Text = "" + text[265];
            Button_Array4[3, 5].Text = "" + text[266];
            Button_Array4[3, 6].Text = "" + text[267];
            Button_Array4[3, 7].Text = "" + text[268];
            Button_Array4[3, 8].Text = "" + text[269];

            Button_Array5[3, 0].Text = "" + text[270];
            Button_Array5[3, 1].Text = "" + text[271];
            Button_Array5[3, 2].Text = "" + text[272];
            Button_Array5[3, 3].Text = "" + text[273];
            Button_Array5[3, 4].Text = "" + text[274];
            Button_Array5[3, 5].Text = "" + text[275];
            Button_Array5[3, 6].Text = "" + text[276];
            Button_Array5[3, 7].Text = "" + text[277];
            Button_Array5[3, 8].Text = "" + text[278];

            Button_Array4[4, 0].Text = "" + text[279];
            Button_Array4[4, 1].Text = "" + text[280];
            Button_Array4[4, 2].Text = "" + text[281];
            Button_Array4[4, 3].Text = "" + text[282];
            Button_Array4[4, 4].Text = "" + text[283];
            Button_Array4[4, 5].Text = "" + text[284];
            Button_Array4[4, 6].Text = "" + text[285];
            Button_Array4[4, 7].Text = "" + text[286];
            Button_Array4[4, 8].Text = "" + text[287];

            Button_Array5[4, 0].Text = "" + text[288];
            Button_Array5[4, 1].Text = "" + text[289];
            Button_Array5[4, 2].Text = "" + text[290];
            Button_Array5[4, 3].Text = "" + text[291];
            Button_Array5[4, 4].Text = "" + text[292];
            Button_Array5[4, 5].Text = "" + text[293];
            Button_Array5[4, 6].Text = "" + text[294];
            Button_Array5[4, 7].Text = "" + text[295];
            Button_Array5[4, 8].Text = "" + text[296];

            Button_Array4[5, 0].Text = "" + text[297];
            Button_Array4[5, 1].Text = "" + text[298];
            Button_Array4[5, 2].Text = "" + text[299];
            Button_Array4[5, 3].Text = "" + text[300];
            Button_Array4[5, 4].Text = "" + text[301];
            Button_Array4[5, 5].Text = "" + text[302];
            Button_Array4[5, 6].Text = "" + text[303];
            Button_Array4[5, 7].Text = "" + text[304];
            Button_Array4[5, 8].Text = "" + text[305];

            Button_Array5[5, 0].Text = "" + text[306];
            Button_Array5[5, 1].Text = "" + text[307];
            Button_Array5[5, 2].Text = "" + text[308];
            Button_Array5[5, 3].Text = "" + text[309];
            Button_Array5[5, 4].Text = "" + text[310];
            Button_Array5[5, 5].Text = "" + text[311];
            Button_Array5[5, 6].Text = "" + text[312];
            Button_Array5[5, 7].Text = "" + text[313];
            Button_Array5[5, 8].Text = "" + text[314];

            Button_Array4[6, 0].Text = "" + text[315];
            Button_Array4[6, 1].Text = "" + text[316];
            Button_Array4[6, 2].Text = "" + text[317];
            Button_Array4[6, 3].Text = "" + text[318];
            Button_Array4[6, 4].Text = "" + text[319];
            Button_Array4[6, 5].Text = "" + text[320];
            Button_Array4[6, 6].Text = "" + text[321];
            Button_Array4[6, 7].Text = "" + text[322];
            Button_Array4[6, 8].Text = "" + text[323];

            Button_Array5[6, 0].Text = "" + text[324];
            Button_Array5[6, 1].Text = "" + text[325];
            Button_Array5[6, 2].Text = "" + text[326];
            Button_Array5[6, 3].Text = "" + text[327];
            Button_Array5[6, 4].Text = "" + text[328];
            Button_Array5[6, 5].Text = "" + text[329];
            Button_Array5[6, 6].Text = "" + text[330];
            Button_Array5[6, 7].Text = "" + text[331];
            Button_Array5[6, 8].Text = "" + text[332];

            Button_Array4[7, 0].Text = "" + text[333];
            Button_Array4[7, 1].Text = "" + text[334];
            Button_Array4[7, 2].Text = "" + text[335];
            Button_Array4[7, 3].Text = "" + text[336];
            Button_Array4[7, 4].Text = "" + text[337];
            Button_Array4[7, 5].Text = "" + text[338];
            Button_Array4[7, 6].Text = "" + text[339];
            Button_Array4[7, 7].Text = "" + text[340];
            Button_Array4[7, 8].Text = "" + text[341];

            Button_Array5[7, 0].Text = "" + text[342];
            Button_Array5[7, 1].Text = "" + text[343];
            Button_Array5[7, 2].Text = "" + text[344];
            Button_Array5[7, 3].Text = "" + text[345];
            Button_Array5[7, 4].Text = "" + text[346];
            Button_Array5[7, 5].Text = "" + text[347];
            Button_Array5[7, 6].Text = "" + text[348];
            Button_Array5[7, 7].Text = "" + text[349];
            Button_Array5[7, 8].Text = "" + text[350];

            Button_Array4[8, 0].Text = "" + text[351];
            Button_Array4[8, 1].Text = "" + text[352];
            Button_Array4[8, 2].Text = "" + text[353];
            Button_Array4[8, 3].Text = "" + text[354];
            Button_Array4[8, 4].Text = "" + text[355];
            Button_Array4[8, 5].Text = "" + text[356];
            Button_Array4[8, 6].Text = "" + text[357];
            Button_Array4[8, 7].Text = "" + text[358];
            Button_Array4[8, 8].Text = "" + text[359];

            Button_Array5[8, 0].Text = "" + text[360];
            Button_Array5[8, 1].Text = "" + text[361];
            Button_Array5[8, 2].Text = "" + text[362];
            Button_Array5[8, 3].Text = "" + text[363];
            Button_Array5[8, 4].Text = "" + text[364];
            Button_Array5[8, 5].Text = "" + text[365];
            Button_Array5[8, 6].Text = "" + text[366];
            Button_Array5[8, 7].Text = "" + text[367];
            Button_Array5[8, 8].Text = "" + text[368];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Button_Array1[i, j].Text.Equals("*"))
                    {
                        Button_Array1[i, j].Text = "0";
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Button_Array2[i, j].Text.Equals("*"))
                    {
                        Button_Array2[i, j].Text = "0";
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Button_Array3[i, j].Text.Equals("*"))
                    {
                        Button_Array3[i, j].Text = "0";
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Button_Array4[i, j].Text.Equals("*"))
                    {
                        Button_Array4[i, j].Text = "0";
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (Button_Array5[i, j].Text.Equals("*"))
                    {
                        Button_Array5[i, j].Text = "0";
                    }
                }
            }

            int[,] matris1 = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matris1[i, j] = Convert.ToInt32(Button_Array1[i, j].Text);
                }
            }
            int[,] matris2 = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matris2[i, j] = Convert.ToInt32(Button_Array2[i, j].Text);
                }
            }
            int[,] matris3 = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matris3[i, j] = Convert.ToInt32(Button_Array3[i, j].Text);
                }
            }
            int[,] matris4 = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matris4[i, j] = Convert.ToInt32(Button_Array4[i, j].Text);
                }
            }
            int[,] matris5 = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matris5[i, j] = Convert.ToInt32(Button_Array5[i, j].Text);
                }
            }
            


            Thread thread1 = new Thread(new ThreadStart(() => function1(matris1)));
   
            thread1.Start();

            Thread thread2 = new Thread(new ThreadStart(() => function2(matris2)));
  
            thread2.Start();
            Thread thread3 = new Thread(new ThreadStart(() => function3(matris3)));
        
            thread3.Start();
            Thread thread4 = new Thread(new ThreadStart(() => function4(matris4)));

            thread4.Start();
            Thread thread5 = new Thread(new ThreadStart(() => function5(matris5)));
        
            thread5.Start();
            

            Thread.Sleep(3000);

      

            this.chart1.Series["Kutu / MiliSaniye"].Points.AddXY("" + 81, Math.Abs(chart[0]));
            this.chart1.Series["Kutu / MiliSaniye"].Points.AddXY("" + 81 * 2, Math.Abs(chart[1]));
            this.chart1.Series["Kutu / MiliSaniye"].Points.AddXY("" + 81 * 3, Math.Abs(chart[2]));
            this.chart1.Series["Kutu / MiliSaniye"].Points.AddXY("" + 81 * 4, Math.Abs(chart[3]));
            this.chart1.Series["Kutu / MiliSaniye"].Points.AddXY("" + 81 * 5, Math.Abs(chart[4]));



        }
    }
}
