using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
    
           
                int[] a = { 1, 2, 3, 4, 5, 6, 7 };
                int n = a.Length;
                Console.WriteLine(n.ToString());
                int r = 2;
                Console.WriteLine(r.ToString());
                int[] temp = new int[r];
                for (int i = 0; i < r; i++)
                {
                    temp[i] = a[i];
                    Console.WriteLine(temp[i].ToString());
                }
                for (int i = 0; i < n - r; i++)
                {
                    a[i] = a[i + r];
                    Console.WriteLine(a[i].ToString());
                }

                for (int i = n - r, j = 0; i < n; i++)
                {
                    while (j < r)
                    {
                        a[i] = temp[j];
                        j++;
                    }

                }
                foreach (int x in a)
                    Console.WriteLine("new data" + x.ToString());

                Console.ReadKey();
            }
        }
    }



