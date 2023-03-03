using System;

namespace FibonaceiCalculator
{
    class Fibonacei
    {


        static void Main(string[] args)
        {
            Console.Title = "Fibonacei Calculator";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("This is a calculator for numbers of the Fibonacei-Row.");
            Console.WriteLine("\n\nYou can choose as many tickets as you wish Fibonacei numbers to now.");
            Console.WriteLine("\n------------Press any key to continue------------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();

            int inputcount;
            bool optionalOutput;


            InputOptions(out inputcount, out optionalOutput);

            for (int i = 0; i < inputcount; i++)
            {
                Calculator(optionalOutput);
            }

            OutOfTickets();
        }

        //Reads input parameters
        private static void InputOptions(out int inputcount, out bool optionalOutput)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nHow many tickets do you want?");
            Console.ForegroundColor = ConsoleColor.White;

            inputcount = Convert.ToInt32(Console.ReadLine());


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Do you also want to now all the steps until your asked Number?  (true/false)");
            Console.ForegroundColor = ConsoleColor.White;

            optionalOutput = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("So it is!");
        }

        //Takes Input
        private static int Input()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nWhat number of the Fibonacei-Row do you wish to now?");
            Console.ForegroundColor = ConsoleColor.White;
            int targetslot = Convert.ToInt32(Console.ReadLine());
            return targetslot;
        }

        //Caluculates Fibonacei numbers
        static void Calculator(bool optionalOutput)
        {
            int targetslot = Input();

            List<int> Fibonaceifolge = new List<int>();
            Fibonaceifolge.Add(1);
            Fibonaceifolge.Add(1);
            int currentslot = 2;
            while (currentslot < targetslot)
            {
                Fibonaceifolge.Add(Fibonaceifolge[currentslot - 1] + Fibonaceifolge[currentslot - 2]);
                currentslot++;
            }

            Output(optionalOutput, targetslot, Fibonaceifolge);
        }

        //Outputs the calculatet Result
        private static void Output(bool optionalOutput, int targetslot, List<int> Fibonaceifolge)
        {
            if (optionalOutput == true)
            {
                Console.WriteLine("\n......."); for (int i = 1; i < Fibonaceifolge.Count; i++) { Console.WriteLine(Fibonaceifolge[i - 1]); }
            }



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The " + targetslot + ". number is:"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(Fibonaceifolge[targetslot - 1]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n-----------------------------------------------------");
        }

        //Gives information about the ticketcount
        private static void OutOfTickets()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No tickets left!");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
        }
    }
}