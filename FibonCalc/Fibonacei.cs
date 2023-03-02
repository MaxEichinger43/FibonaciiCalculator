using System;


namespace FibonCalc
{
        class Fibonacei
        {
            static void Main(string[] args)
            {

                List<int> Fibonaceifolge = new List<int>();
                Fibonaceifolge.Add(1);
                Fibonaceifolge.Add(1);
                

                Console.WriteLine("Hallo! Welche Stelle der Fibonacei Folge möchtest du wissen?");
                int n = Convert.ToInt32(Console.ReadLine());


                for (int i = 2; i == (n+1); i++ )
                {
                    Fibonaceifolge.Add(Fibonaceifolge[0] + Fibonaceifolge[1]);
                }


                Console.WriteLine(Fibonaceifolge[n-1]);
                
                Console.ReadKey();
            }
        }
}