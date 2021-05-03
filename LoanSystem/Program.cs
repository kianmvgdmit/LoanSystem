using System;
using System.Collections.Generic;

namespace LoanSystem
{
    class Program
    {
        public static List<string> ProductName = new List<string> { "IPHONE === ₱45,000","SMARTWATCH === ₱15,000","GOPRO === ₱20,000",
                                                                 "TOYOTA WIGO === ₱650,000  ","HONDA CIVIC === ₱700,000","FORD FIESTA === ₱500,000"
                                                                   ,"SMART TV === ₱20,000","AIRCON === ₱10,000","DINING TABLE === ₱5,000"};


        static void Main(string[] args)
        {

            Console.Title = "LoanSystem";
            Console.WriteLine("===============================");
            Console.WriteLine("\n Welcome to Loan System \n");
            Console.WriteLine("===============================");
            Console.WriteLine("Press [0] to enter your information");
            Console.WriteLine("LOAN MENU");
            Console.WriteLine("===============================");
            Console.WriteLine("\n [1]Gadget Loan     \n");
            Console.WriteLine("\n [2]Car Loan        \n");
            Console.WriteLine("\n [3]Appliances Loan \n");
            Console.WriteLine("===============================");

            string UserInput = Console.ReadLine();

            if (UserInput == "1")
            {
                gadgetloan();
            }
            else if (UserInput == "2")
            {
                carloan();
            }
            else if (UserInput == "3")
            {
                appliancesloan();
            }
            else if (UserInput == "0")
            {
                UserInfo();
            }


            static void UserInfo()
            {

                Console.Clear();
                
                Console.WriteLine("Enter your FullName:");
                var name = Console.ReadLine();
                
                Console.WriteLine("Enter your Age:");
                var age = Console.ReadLine();

                Console.WriteLine("Enter your Occupation:");
                var occupation = Console.ReadLine();

                Console.WriteLine("\n Here are your details \n");
                Console.WriteLine($"Name:         {name}        ");
                Console.WriteLine($"Age:          {age}         ");
                Console.WriteLine($"Occupation:   {occupation}  ");
            }


        }
            static void  gadgetloan()
        {


            Console.Clear();
            Console.WriteLine("\n You choose gadget loan \n");
            Console.WriteLine();

            Console.WriteLine("Available Gadgets:");
            Console.WriteLine("===============================");
            Console.WriteLine(ProductName[0]);
            Console.WriteLine(ProductName[1]);
            Console.WriteLine(ProductName[2]);
            Console.WriteLine("===============================");
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
            Console.WriteLine("===============================");
            Console.WriteLine(ProductName[3]);
            Console.WriteLine(ProductName[4]);
            Console.WriteLine(ProductName[5]);
            Console.WriteLine("===============================");
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
            Console.WriteLine("===============================");
            Console.WriteLine(ProductName[6]);
            Console.WriteLine(ProductName[7]);
            Console.WriteLine(ProductName[8]);
            Console.WriteLine("===============================");
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
