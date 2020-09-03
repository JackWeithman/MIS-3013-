using System;

namespace ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 0;
            double distance = 0;
            string hazardousResponse = " ";
            bool containsHazardous = false;

            Console.WriteLine(" what is the weight of you shipment? >>");
            string response = Console.ReadLine();
            weight = Convert.ToDouble(response);

            Console.WriteLine("What is the distance of your shipment? >>");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Does your shipment contain hazardous material, yes or no? >>");
            response = Console.ReadLine();

            if (response == "yes")
            {
                containsHazardous = true;
            }
            else
            {
                Console.WriteLine("INVALID INPUT. GOODBYE");
                return;
            }

            double quote = (0.55 * distance) + (.73 * weight);
            double hazardousCost = 0;

            if (containsHazardous == true)
            {
                hazardousCost = 0.15 * weight;

            }
            else
            {
                hazardousCost = 0;
            }

            double netTotal = quote + hazardousCost;
            double discount = 0;

            if (distance < 150 && weight > 500)
            {
                discount = netTotal * .10;
            }

            Console.WriteLine("quote: " + quote);
            Console.WriteLine("hazardousCost: " + hazardousCost);
            Console.WriteLine("NetTotel: " + netTotal);
            Console.WriteLine("Discount: " + discount);

        }
    }
}
