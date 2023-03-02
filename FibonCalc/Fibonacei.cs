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
                
                int a = 2;
                while (a < n)
                {
                    Fibonaceifolge.Add(Fibonaceifolge[a-1] + Fibonaceifolge[a-2]);
                    a++;
                }

//                for (int i = 1; i < Fibonaceifolge.Count; i++)
//                {
//                Console.WriteLine(Fibonaceifolge[i-1]);
//                }

                Console.WriteLine("Die " + n + ". Stelle ist eine " + Fibonaceifolge[n - 1]);
                
            }
        }
}