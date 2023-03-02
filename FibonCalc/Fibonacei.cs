using System;


namespace FibonCalc
{
        class Fibonacei
        {
            static void Main(string[] args)
            {
                Console.Title = "Fibonacei Calculator";

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Wie viele Versuche möchtest du haben?  (int)");
                Console.ForegroundColor = ConsoleColor.White;
                int a = Convert.ToInt32(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Sollen die Schritte bis zu Gesuchten auch angezeit werden?  (true/false)");
                Console.ForegroundColor = ConsoleColor.White;
                bool optionaleroutput = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("So sei es!");



                for (int i = 0; i < a; i++)
                {
                    Program(optionaleroutput);
                }


                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Alle Versuche verbraucht!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }

            static void Program(bool optionaleroutput)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nWelche Stelle der Fibonacei Folge möchtest du wissen?   (int)");
                Console.ForegroundColor = ConsoleColor.White;
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

//Falls alle Stellen bis zur gefragten Eingegebenwerden ausgegeben werden sollen
                if (optionaleroutput == true)
                {
                    Console.WriteLine("\n.......");for (int i = 1; i < Fibonaceifolge.Count; i++){Console.WriteLine(Fibonaceifolge[i-1]);}
                }
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Die " + n + ". Stelle ist eine:"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(Fibonaceifolge[n - 1]);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n-----------------------------------------------------");
            }
        }
}