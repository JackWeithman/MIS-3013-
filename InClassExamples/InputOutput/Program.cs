/*
*
*@Author:Professor Ackerman
*Collaboration with: the class
*/
using System;

namespace InputOutput
{
    class Program
    {
        const string CLASS_NAME = "MIS 3013";

        static void Main(string[] args)
        {
            // this wont work bc its a constant CLASS_NAME = "MIS 3353";
            //string firstname, lastname; 
            string firstname = "Jack";
            string lastname = "Weithman";

            Console.WriteLine("Please enter your first name >>");
            firstname = Console.ReadLine();

            Console.WriteLine("Please enter your last name >>");
            lastname = Console.ReadLine();

            Console.WriteLine("What is your GPA? >>");
            string gpaInput = Console.ReadLine();
            double gpa = Convert.ToDouble(gpaInput);

            //This doesn't make sence BUT shows the calculations
            double gpaEnhanced = gpa + 1.5;

            Console.WriteLine(firstname + " " + lastname +
                " is learning " + CLASS_NAME + " with a GPA of " + gpa.ToString("N2"));
        }
    }
}
