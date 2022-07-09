using System;

namespace ATM
{
    class Program
    {
        private string name;
        private int age;
        private string accountID;
        private Double balance;

        public Program(string name, int age, string accountID, double balance)
        {
            this.name = name;
            this.age = age;
            this.accountID = accountID;
            this.balance = balance;
        }

        static void Main(string[] args)
        {
            Program customer = new Program("Vernon Ong", 19, "ver2002", 5000);
            Program customer2 = new Program("John Yeo", 22, "johnny99", 6100.50);
            Program customer3 = new Program("David Tan", 32, "Dav2321", 13442.10);
            Program customer4 = new Program("Mary", 24, "Mar1154", 20396);
            Program customer5 = new Program("Nate", 43, "nathan4012", 172365);

            Program[] accounts = new Program[5];

            accounts[0] = customer;
            accounts[1] = customer2;
            accounts[2] = customer3;
            accounts[3] = customer4;
            accounts[4] = customer5;

            int option = -1;

            while (option != 4)
            {

                Menu();
                Console.WriteLine("Enter option > ");
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    viewBalance();
                } else if (option == 2)
                {
                    deposit();
                } else if (option == 3)
                {
                    withdraw();
                } else if (option == 4)
                {
                    Console.WriteLine("Closing ATM.....");
                } else
                {
                    Console.WriteLine("Invalid Option!");
                }
            }

            static void Menu()
            {
                Console.WriteLine("======================================");
                Console.WriteLine("ATM Machine");
                Console.WriteLine("======================================");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Deposit Into Account");
                Console.WriteLine("3. Withdraw From Account");
                Console.WriteLine("4. Quit");
            }

            void viewBalance()
            {
                Boolean isTrue = false;
                Console.WriteLine("Enter account ID > ");
                string? accID = Console.ReadLine();
                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accID.Equals(accounts[i].accountID))
                    {
                        Console.WriteLine("Name: " + accounts[i].name);
                        Console.WriteLine("Age: " + accounts[i].age);
                        Console.WriteLine("Balance " + accounts[i].balance);
                        isTrue = true;
                    }
                }
                if (isTrue == false)
                {
                    Console.WriteLine("Invalid accountID");
                }           
            }

            void deposit()
            {
                Console.WriteLine("Enter account ID > ");

                String accDepo = Console.ReadLine();

                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accDepo.Equals(accounts[i].accountID))
                    {
                        Console.WriteLine("Enter amount to deposit > ");
                        Double deposit = Convert.ToDouble(Console.ReadLine());
                        accounts[i].balance = accounts[i].balance + deposit;

                        Console.WriteLine("\nNew Balance: " + accounts[i].balance);
                    }
                }
            }

            void withdraw()
            {
                Console.WriteLine("Enter account ID > ");

                String accWith = Console.ReadLine();

                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accWith.Equals(accounts[i].accountID))
                    {
                        Console.WriteLine("Enter amount to withdraw >");
                        Double withdraw = Convert.ToDouble(Console.ReadLine());
                        accounts[i].balance = accounts[i].balance - withdraw;

                        Console.WriteLine(withdraw + " have been withdrawn.");
                        Console.WriteLine("Remaining balance: " + accounts[i].balance);
                    }
                }
            }


        }
    }
}
