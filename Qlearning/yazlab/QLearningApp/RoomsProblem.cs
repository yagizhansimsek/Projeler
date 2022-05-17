using QLearningApp.MachineLearning;
using System.Collections.Generic;
using System;
using System.Collections;

namespace QLearningApp
{
    
    class RoomsProblem : IQLearningProblem
    {
        int sayac = 0;
        int[] engel;
        int endState;
        public RoomsProblem(int[] engel,int endState){
            this.engel = engel;
            this.endState = endState;
        }
        
        public int[,] Rmatrisiuret(int[] engel)
        {
            int[,] matris = new int[10, 10];
            int[,] matris2 = new int[100, 100];
            int x = 0;
            int kutunumara;
            int kutunumara2;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    kutunumara = (i * 10) + j;
                    kutunumara2 = (i * 10) + j;

                    for (int y = 0; y < 100; y++)
                    {
                        matris2[x, y] = -1;
                    }
                    if (kutunumara + 1 < 100 && kutunumara%10!=9)
                    {
                        matris2[x, kutunumara + 1] = +3;
                        if (kutunumara + 1 == this.endState)
                        {
                            matris2[x, kutunumara + 1] = 5;
                        }
                        for (int gama = 0; gama < 30; gama++)
                        {
                            if (kutunumara + 1 == engel[gama])
                            {
                                matris2[x, kutunumara + 1] = -5;
                            }
                        }

                    }
                    if (kutunumara - 1 >= 0 && kutunumara%10!=0)
                    {
                        matris2[x, kutunumara - 1] = 3;
                        if (kutunumara - 1 == this.endState)
                        {
                            matris2[x, kutunumara - 1] = 5;
                        }
                        for (int gama = 0; gama < 30; gama++)
                        {
                            if (kutunumara - 1 == engel[gama])
                            {
                                matris2[x, kutunumara - 1] = -5;
                            }
                        }
                    }
                    if (kutunumara + 10 < 100 && kutunumara<90)
                    {
                        matris2[x, kutunumara + 10] = 3;
                        if (kutunumara + 10 == this.endState)
                        {
                            matris2[x, kutunumara + 10] = 5;
                        }
                        for (int gama = 0; gama < 30; gama++)
                        {
                            if (kutunumara + 10 == engel[gama])
                            {
                                matris2[x, kutunumara + 10] = -5;
                            }
                        }
                    }
                    if (kutunumara - 10 >= 0 && kutunumara>9)
                    {
                        matris2[x, kutunumara - 10] = 3;
                        if (kutunumara - 10 == this.endState)
                        {
                            matris2[x, kutunumara - 10] = 5;
                        }
                        for (int gama = 0; gama < 30; gama++)
                        {
                            if (kutunumara - 10 == engel[gama])
                            {
                                matris2[x, kutunumara - 10] = -5;
                            }
                        }
                    }
                    if (kutunumara2 - 9 >= 0 && kutunumara2 > 9 && kutunumara2 % 10 != 9) //sağ üst çapraz
                    {
                        matris2[x, kutunumara2 - 9] = 3;
                        if (kutunumara2 - 9 == this.endState)
                        {
                            matris2[x, kutunumara2 - 9] = 5;
                        }
                        for (int gama = 0; gama < 30; gama++)
                        {
                            if (kutunumara2 - 9 == engel[gama])
                            {
                                matris2[x, kutunumara2 - 9] = -5;
                            }
                        }
                    }
                    if (kutunumara2 - 11 >= 0 && kutunumara2 != 0 && kutunumara2 > 9 && kutunumara2 % 10 != 0) //sol üst çapraz
                    {
                        matris2[x, kutunumara2 - 11] = 3;
                        if (kutunumara2 - 11 == this.endState)
                        {
                            matris2[x, kutunumara2 - 11] = 5;
                        }
                        for (int gama = 0; gama < 30; gama++)
                        {
                            if (kutunumara2 - 11 == engel[gama])
                            {
                                matris2[x, kutunumara2 - 11] = -5;
                            }
                        }
                    }
                    if (kutunumara2 + 11 < 100 && kutunumara2 % 10 != 9 && kutunumara2 < 90)//sağ alt çapraz
                    {
                        matris2[x, kutunumara2 + 11] = 3;//sol alt çapraz
                        if (kutunumara2 + 11 == this.endState)
                        {
                            matris2[x, kutunumara2 + 11] = 5;
                        }
                        for (int gama = 0; gama < 30; gama++)
                        {
                            if (kutunumara2 + 11 == engel[gama])
                            {
                                matris2[x, kutunumara2 + 11] = -5;
                            }
                        }
                    }
                    if (kutunumara2 + 9 < 100 && kutunumara2 % 10 != 0 && kutunumara2 < 90)
                    {
                        matris2[x, kutunumara2 + 9] = 3;
                        if (kutunumara2 + 9 == this.endState)
                        {
                            matris2[x, kutunumara2 + 9] = 5;
                        }
                        for (int gama = 0; gama < 30; gama++)
                        {
                            if (kutunumara2 + 9 == engel[gama])
                            {
                                matris2[x, kutunumara2 + 9] = -5;
                            }
                        }
                    }
                    x++;


                }
                /* Console.WriteLine(deneme);
                 deneme++;*/
            }


            return matris2;
        }

        public int NumberOfStates => 100;

        public int NumberOfActions => 100;

        public double GetReward(int currentState, int action)
        {

            int[,] matris2 =Rmatrisiuret(this.engel);
            return matris2[currentState,action];
        } 

        public int[] GetValidActions(int currentState,grafik2 g2)
        {
            sayac = 0;
            
            int[,] matris2 = Rmatrisiuret(this.engel);
            List<int> validActions = new List<int>();
            for (int i = 0; i < matris2.GetLength(1); i++)
            {
                if (matris2[currentState,i] != -1)
                {
                    validActions.Add(i);
                    g2.chart(sayac,i);
                    sayac++;
                }
                    
            }
            
            
            return validActions.ToArray();
        }

        public bool GoalStateIsReached(int currentState,int endState)
        {
            return currentState == endState;
        }
    }
}
