using System;
using System.Diagnostics;


namespace PadraoMatriz
{
    class FindMatrix
    {
        static void Main(string[] args)
        {
            
            Stopwatch sw = Stopwatch.StartNew();
            Random rnd = new Random();
            int[,] matrix = CreateMatrix(100, 100);
            int[,] padrao = new int[3,3]
            {
                {0, 1, 0},
                {1, 1, 1},
                {0, 1, 0}
            };
        

            int[,] CreateMatrix(int x, int y)
            {
                int[,] matrixtemp = new int[x, y];
                for (int i = 0; i < x; i++)
                {

                    for (int l = 0; l < y; l++)
                    {
                        matrixtemp[i, l] = (rnd.Next(0, 2));
                    }
                }

                return matrixtemp;
            }
            
            
             static void printMatrix(int[,] matrix, int x, int y) {
                for(int i = 0; i < x; i++) {
                    for (int l = 0; l < y; l++) {
                        Console.Write(" | " + matrix[i,l]);
                    }
                    Console.WriteLine(" |");
                }
            }
            
             
            
            int counter = 0;
             void getPadrao(int[,] matrix, int[,] padrao, int x, int y)
            {
                
                for (int i = 0; i < y; i++)
                {
                    for (int l = 0; l < x; l++)
                    {
                        if (matrix[l, i] == padrao[0, 0] && l < (x - padrao.Length + 1) && i < (y - padrao.Length + 1))
                        {
                            if (matrix[l, i + 1] == padrao[0, 1])
                            {
                                if (matrix[l, i + 2] == padrao[0, 2])
                                {
                                    if (matrix[l + 1, i] == padrao[1, 0])
                                    {
                                        if (matrix[l + 1, i + 1] == padrao[1, 1])
                                        {
                                            if (matrix[l + 1, i + 2] == padrao[1, 2])
                                            {
                                                if (matrix[l + 2, i] == padrao[2, 0])
                                                {
                                                    if (matrix[l + 2, i + 1] == padrao[2, 1])
                                                    {
                                                        if (matrix[l + 2, i + 2] == padrao[2, 2])
                                                        {
                                                            counter++;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
             getPadrao(matrix, padrao, 100, 100);
             Console.WriteLine(counter+" foram padrões achados");
             sw.Stop();
             Console.WriteLine("duração foi {0}ms", sw.Elapsed.TotalMilliseconds);
        }
    }
}