using System;
using System.Collections.Generic;

namespace LoanSystem
{
    class Program
    {
        public static List<string> products = new List<string> { "IPHONE === ₱45,000","SMARTWATCH === ₱15,000","GOPRO === ₱20,000",
                                                                 "TOYOTA WIGO === ₱650,000  ","HONDA CIVIC === ₱700,000","FORD FIESTA === ₱500,000"
                                                                   ,"SMART TV === ₱20,000","AIRCON === ₱10,000","DINING TABLE === ₱5,000"};


        static void Main(string[] args)
        {

            Console.Title = "LoanSystem";
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Welcome to Loan System");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Choose your desired loan");
            Console.WriteLine("***************");
            Console.WriteLine("[1]Gadget Loan");
            Console.WriteLine("[2]Car Loan");
            Console.WriteLine("[3]Appliances Loan");
            Console.WriteLine("***************");

            string input = Console.ReadLine();

            if (input == "1")
            {
                gadgetloan();
            }
            else if (input == "2")
            {
                carloan();
            }
            else if (input == "3")
            {
                appliancesloan();
            }


        }
        static void gadgetloan()
        {


            Console.Clear();
            Console.WriteLine("You choose gadget loan");
            Console.WriteLine();

            Console.WriteLine("Available Gadgets:");
            Console.WriteLine("**********************");
            Console.WriteLine(products[0]);
            Console.WriteLine(products[1]);
            Console.WriteLine(products[2]);
            Console.WriteLine("**********************");
            Console.WriteLine();
            Console.WriteLine("To Calculate your interest for your loan press ENTER");
            Console.ReadLine();

            Console.Write("Enter the total amount:");
            double amount = double.Parse(Console.ReadLine());


            Console.Write("Enter the interest rate (per year):");
            double intrate = double.Parse(Console.ReadLine());


            Console.Write("Enter the duration(in months):");
            int months = int.Parse(Console.ReadLine());

            double totalInt = ((amount / 12)) * ((intrate / 100)) * months;


            Console.WriteLine("-------------------------------");
            Console.WriteLine("Total Interest for {0} Months is {1}", months, totalInt);
            Console.WriteLine("-------------------------------");

            Console.Read();

        }
        public static void carloan()
        {

            Console.Clear();
            Console.WriteLine("You choose car loan");
            Console.WriteLine();
            Console.WriteLine("Available Vehicles:");
            Console.WriteLine("**********************");
            Console.WriteLine(products[3]);
            Console.WriteLine(products[4]);
            Console.WriteLine(products[5]);
            Console.WriteLine("**********************");
            Console.WriteLine("To Calculate your interest for your loan press ENTER:");
            Console.ReadLine();

            Console.Write("Enter the total amount:");
            double amount = double.Parse(Console.ReadLine());


            Console.Write("Enter the interest rate (per year):");
            double intrate = double.Parse(Console.ReadLine());


            Console.Write("Enter the duration(in months):");
            int months = int.Parse(Console.ReadLine());

            double totalInt = ((amount / 12)) * ((intrate / 100)) * months;


            Console.WriteLine("-------------------------------");
            Console.WriteLine("Total Interest for {0} Months is {1}", months, totalInt);
            Console.WriteLine("-------------------------------");

            Console.Read();

        }
        public static void appliancesloan()

        {


            Console.Clear();
            Console.WriteLine("You choose appliances loan");
            Console.WriteLine("Available Appliances:");
            Console.WriteLine("**********************");
            Console.WriteLine(products[6]);
            Console.WriteLine(products[7]);
            Console.WriteLine(products[8]);
            Console.WriteLine("**********************");
            Console.WriteLine("To Calculate your interest for your loan press ENTER:");
            Console.ReadLine();

            Console.Write("Enter the total amount:");
            double amount = double.Parse(Console.ReadLine());


            Console.Write("Enter the interest rate (per year):");
            double intrate = double.Parse(Console.ReadLine());


            Console.Write("Enter the duration(in months):");
            int months = int.Parse(Console.ReadLine());

            double totalInt = ((amount / 12)) * ((intrate / 100)) * months;


            Console.WriteLine("-------------------------------");
            Console.WriteLine("Total Interest for {0} Months is {1}", months, totalInt);
            Console.WriteLine("-------------------------------");

            Console.Read();





        }
    }
}
