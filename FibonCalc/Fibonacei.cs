using System;


namespace FibonCalc
{
        class Fibonacei
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Wie viele Versuche möchtest du?");

                int a = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < a; i++)
                {
                    Program();
                }


                Console.WriteLine("Alle Versuche verbraucht!");
                Console.ReadKey();
            }

            static void Program()
            {

                Console.WriteLine("\nHallo! Welche Stelle der Fibonacei Folge möchtest du wissen?");
                int n = Convert.ToInt32(Console.ReadLine());


                List<int> Fibonaceifolge = new List<int>();
                Fibonaceifolge.Add(1);
                Fibonaceifolge.Add(1);

                for (int i = 2; i == (n + 1); i++)
                {
                    Fibonaceifolge.Add(Fibonaceifolge[i-1] + Fibonaceifolge[i-2]);
                }


                Console.WriteLine("Die " + n + ". Stelle ist eine " + Fibonaceifolge[n - 1]);
                
            }
        }
}