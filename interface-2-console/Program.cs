using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace interface_2_console
{
    interface Loan
    {
        void loan(int month, double intrest);
    }

    class Bank
    {

        long accountID { get; set; }
        int balance { get; set; }
        string accountType { get; set; }
        string customer { get; set; }

    }
    class deposit : Bank, Loan
    {
        public long accountID { get; set; }
        public int balance { get; set; }
        public string accountType { get; set; }
        public string customer { get; set; }

        int amount;
        public void Deposit()
        {
            Console.Write("Enter the amount: ");
            amount = Convert.ToInt32(Console.ReadLine());
            balance += amount; Console.WriteLine("Your amount has been created succesully.current balance:{0}", balance);
        }
        public void withdraw()
        {
            Console.Write("Enter the amount: ");
            amount = Convert.ToInt32(Console.ReadLine());
            balance -= amount; Console.WriteLine("Your amount has been created succesully.current balance:{0}", balance);
        }

       public void loan(int month, double intrest)
        {
            if (balance > 0 && month < 1000)
            {
                Console.WriteLine("No intrest for you...");
            }
            else
            {
                double intrestRate = month * intrest;
                Console.WriteLine("The intrest is {0}", intrestRate);
            }
        }
        public void m()
        {
            Console.Write("GHJ");
        }

    }

    class loann : Bank, Loan
    {
        public long accountID { get; set; }
        public int balance { get; set; }
        public string customer { get; set; }
        public string accountType { get; set; }

        int amount;


        public void Deposit()
        {
            Console.Write("Enter the amount: ");
            amount = Convert.ToInt32(Console.ReadLine());
            balance -= amount; Console.WriteLine("Your amount has been created succesully.current balance:{0}", balance);
        }

       public void loan(int month,double intrest)
        {
            if (month > 0 && month < 4)
            {
                Console.WriteLine("No intrest for you...");
            }
            else
            {
                double intrestRate = month * intrest;
                Console.WriteLine("The intrest is {0}", intrestRate);
            }
        }

    }

    class mortage : Bank, Loan
    {
        public long accountID { get; set; }
        public string accountType { get; set; }

        public int balance { get; set; }
        public string customer { get; set; }
        public int accountcreatedMonth;
        int amount;


        public void Deposit()
        {
            Console.Write("Enter the amount: ");
            amount = Convert.ToInt32(Console.ReadLine());
            balance -= amount; Console.WriteLine("Your amount has been created succesully.current balance:{0}", balance);
        }
        public void loan(int month, double intrest)
        {
            if (accountType.ToLower() == "company" || month <= 12)
            {
                double intrestRate = (month * intrest) / 2;
                Console.WriteLine("The intrest is {0}", intrestRate);
            }
            else if (accountType.ToLower() == "individual" || month > 6)
            {
                double intrestRate = month * intrest;
                Console.WriteLine("The intrest is {0}", intrestRate);
            }
            else
            {
                Console.WriteLine("No itrest rate for you...");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your account type:");
            var table = new ConsoleTable("S.NO","Types of Account");
            table.AddRow(1, "DEPOSIT")
                 .AddRow(2, "LOAN")
                 .AddRow(3,"MORTAGE");

            table.Write(Format.Alternative);
            Console.Write("\nyour answer pls...: ");
            string account = Console.ReadLine();
            switch (account.ToLower())
            {
                case "deposit":
                    dacc();
                    break;
                case "loan":
                    loanacc();
                    break;
                case "mortage":
                    Mortageacc();
                    break;
                    
            }
            
            Console.ReadKey();
        }
        
        public static void dacc()
        {
            Console.WriteLine("Great,Welcome you...");
            Console.WriteLine("enter your name and account id:");
            Console.Write("press W for withdraw or D for deposit:");
            deposit bank = new deposit();
            bank.accountID = 987654321;
            bank.balance = 5000;
            bank.customer = "Arun";
            bank.accountType = "individual";
           





            ConsoleKeyInfo keys = Console.ReadKey();
            if (keys.Key == ConsoleKey.W)
            {
                bank.withdraw();
            }
            if (keys.Key == ConsoleKey.D)
            {
                bank.Deposit();
            }

        }

        public static void loanacc()
        {
            loann l = new loann();
            l.accountID = 123456789;
            l.balance = 76000;
            l.customer = "Arun";
            l.accountType = "individual";
            Console.Write("press L for loanintrest or D for deposit:");
            ConsoleKeyInfo keys = Console.ReadKey();
            if (keys.Key == ConsoleKey.L)
            {
                l.loan(9, 0.05);

            }
            if (keys.Key == ConsoleKey.D)
            {
                l.Deposit();
            }

           
        }

        public static void Mortageacc()
        {
            mortage Mortage = new mortage();
            Mortage.accountID = 9629794425;
            Mortage.balance = 250000;
            Mortage.customer = "Pravitha softech";
            Mortage.accountType = "company";
            Console.Write("press L for loanintrest or D for deposit:");
            ConsoleKeyInfo keys = Console.ReadKey();
            if (keys.Key == ConsoleKey.L)
            {
                Mortage.loan(9, 0.05);

            }
            if (keys.Key == ConsoleKey.D)
            {
                Mortage.Deposit();
            }
        }
    }
 
}
