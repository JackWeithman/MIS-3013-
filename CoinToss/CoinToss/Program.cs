using System;

namespace CoinToss
{
    class Program
        
    {
        static void Main(string[] args)
        {
            const string DEVELOPER = "Jack Weithman";
            const int Heads = 1;
            const int Tails = 0;
            Console.WriteLine("Heads or Tails?");
            string answer = Convert.ToString(Console.ReadLine());

            Random rnd = new Random();
            int result = rnd.Next(0, 2);

            if (result == Heads && answer == "Heads")
            {
                Console.WriteLine("It was Heads");
            }
            else if (result == Tails && answer == "Tails")
            {
                Console.WriteLine("It was Tails");
            }
            else
            {
                Console.WriteLine("You were WRONG");
            }
            Console.WriteLine(DEVELOPER);
        }
    }
}
