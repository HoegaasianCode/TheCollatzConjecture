using System;

namespace TheCollatzConjecture
{
    class Program
    {

        // https://edabit.com/challenge/F6m5ZRyzK5fmqTrBG
        // SOLVED

        static void Main(string[] args)
        {
            var collatz = new Calc(10);
            Console.Write(collatz.CollatzCalc());
        }
    }
}
