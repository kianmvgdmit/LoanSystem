using System;

namespace LoanSystem
{
    class Program
    {
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
            Console.WriteLine("[3]Housing Loan");
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
                housingloan();
            }


        }
        public static void gadgetloan()
        {
            Console.Clear();
            Console.WriteLine("You choose gadget loan");
            Console.WriteLine("To Calculate your interest for your loan press ENTER:") ;
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
        public static void housingloan()
        {
            Console.Clear();
            Console.WriteLine("You choose housing loan");
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
