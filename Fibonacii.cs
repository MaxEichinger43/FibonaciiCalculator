using System;

namespace FibonaciiCalculator
{
    public class Fibonacii
    {

        static void Main(string[] args)
        {
            Fibonacii fib = new Fibonacii();
//            Console.WriteLine(fib.Recursive(100));

            Console.Title = "Fibonacii Calculator";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("This is a calculator for numbers of the Fibonacii-Row.");
            Console.WriteLine("\n\nYou can choose as many tickets as you wish Fibonacii numbers to now.");
            Console.WriteLine("\n------------Press any key to continue------------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();

            int inputcount;
            bool optionalOutput;


            InputOptions(out inputcount, out optionalOutput);

            for (int i = 0; i < inputcount; i++)
            {
                CalculatManager(optionalOutput);
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
            Console.WriteLine("\nWhat number of the Fibonacii-Row do you wish to now?");
            Console.ForegroundColor = ConsoleColor.White;

            int targetslot = Convert.ToInt32(Console.ReadLine());
            return targetslot;
        }
        public long?[] cache = new long?[10000000];

        //Manages Calculation
        static void CalculatManager(bool optionalOutput)
        {
            int targetslot = Input();
            Fibonacii fib = new Fibonacii();
//            Console.WriteLine(fib.FibonacciRecursiv(targetslot));

            if (outputIsOptional)
            {
                Console.WriteLine("\n......."); for (int i = 1; i < cache.Length; i++) { Console.WriteLine(cache[i - 1]); }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The " + targetslot + ". number is:"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(fib.FibonacciRecursiv(targetslot));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n-----------------------------------------------------");

        }


        //Caluculates Fibonacii numbers with array. Will be changed to list later

        public long? FibonacciRecursiv(int targetslot) {
            if (targetslot == 1 || targetslot == 2) {
                return 1;
            }
            
            if (cache[targetslot-1] == null) {
                cache[targetslot-1] = FibonacciRecursiv(targetslot - 1) + FibonacciRecursiv(targetslot - 2);
            }
            return cache[targetslot-1];
        }

//        private static List<int> Fibonacci(int targetslot)
//        {
//            List<int> Fibonaciifolge = ListGen();
//            int currentslot = 2;
//            while (currentslot < targetslot)
//            {
//                Fibonaciifolge.Add(Fibonaciifolge[currentslot - 1] + Fibonaciifolge[currentslot - 2]);
//                currentslot++;
//            }
//
//            return Fibonaciifolge;
//        }
//
//        private static List<int> ListGen()
//        {
//            List<int> Fibonaciifolge = new List<int>();
//            Fibonaciifolge.Add(1);
//            Fibonaciifolge.Add(1);
//            return Fibonaciifolge;
//        }

        //Outputs the calculatet Result
//        private static void Output(bool outputIsOptional, int targetSlot,long[] cache)
//        {
//            if (outputIsOptional)
//            {
//                Console.WriteLine("\n......."); for (int i = 1; i < cache.Length; i++) { Console.WriteLine(cache[i - 1]); }
//            }
//
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine("The " + targetSlot + ". number is:"); Console.ForegroundColor = ConsoleColor.Green; Console.Write(cache[targetSlot - 1]);
//            Console.ForegroundColor = ConsoleColor.White;
//            Console.WriteLine("\n\n-----------------------------------------------------");
//        }

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