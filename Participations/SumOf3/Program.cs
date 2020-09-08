using System;

namespace SumOf3
{
    class Program
    {
        const double LUCKY_NUMBER = 7.777;
        string Numb1 = "";
        string Numb2 = "";
        string Numb3 = "";

        static void Main(string[] args)
        {
            Console.WriteLine("What is the first number that you choose? ");
            double Numb1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the second number that you choose? ");
            double Numb2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the third number that you choose? ");
            double Numb3 = Convert.ToDouble(Console.ReadLine());

            double sum = Numb1 + Numb2 + Numb3;
            Console.WriteLine(sum.ToString("N3"));

            double endTotal = sum * LUCKY_NUMBER;
            Console.WriteLine(endTotal.ToString("N3"));


        }
    }
}
