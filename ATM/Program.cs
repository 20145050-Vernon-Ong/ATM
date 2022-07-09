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

            while (option != 2)
            {

                LoginMenu();
                Console.WriteLine("Enter option > ");
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Program accountLog = getLogin(accounts);
                    
                    if (accountLog != null)
                    {
                        savingProcess(accountLog);
                    }
                } else if (option == 2)
                {
                    Console.WriteLine("Closing ATM.....");
                } else
                {
                    Console.WriteLine("Invalid Option!");
                }
            }

            static void LoginMenu()
            {
                Console.WriteLine("======================================");
                Console.WriteLine("ATM Machine");
                Console.WriteLine("======================================");
                Console.WriteLine("1. Log In");
                Console.WriteLine("2. Quit");
            }

            static void Menu()
            {
                Console.WriteLine("======================================");
                Console.WriteLine("ATM Machine");
                Console.WriteLine("======================================");
                Console.WriteLine("1. ViewBalance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Log out");
            }

            static void viewBalance(Program i)
            {
                Console.WriteLine("Name: " +  i.name);
                Console.WriteLine("Age: " + i.age);
                Console.WriteLine("Balance: " + i.balance);
            }

            void deposit(Program i)
            {
                Console.WriteLine("Enter amount to deposit > ");
                Double deposit = Convert.ToDouble(Console.ReadLine());
                i.balance = i.balance + deposit;
                Console.WriteLine("\nNew Balance: " + i.balance);
            }

            void withdraw(Program i)
            {
                Console.WriteLine("Enter amount to withdraw >");
                Double withdraw = Convert.ToDouble(Console.ReadLine());
                i.balance = i.balance - withdraw;
                Console.WriteLine(withdraw + " have been withdrawn.");
                Console.WriteLine("Remaining balance: " + i.balance);
            }
            
            static Program getLogin(Program[] accounts)
            {
                Program logging = null;

                while (logging == null)
                {
                    Console.WriteLine("Enter account ID > ");
                    string accID = Console.ReadLine();
                    foreach (Program i in accounts) {
                        if (i.accountID.Equals(accID) == true) {
                            logging = i;
                            Console.WriteLine("Login successfully!");
                        }
                    }
                }

                if (logging == null)
                {
                    Console.WriteLine("Incorrect account ID");
                }

                return logging;
            }

            void savingProcess(Program accountLog)
            {
                int choose = -1;

                while (choose != 4)
                {
                    Menu();
                    Console.WriteLine("Enter option > ");
                    choose = Convert.ToInt32(Console.ReadLine());

                    if (choose == 1)
                    {
                        viewBalance(accountLog);
                    } else if (choose == 2)
                    {
                        deposit(accountLog);
                    } else if (choose == 3)
                    {
                        withdraw(accountLog);
                    } else if (choose == 4)
                    {
                        Console.WriteLine("Logging out...");
                    }
                }
            }
        }
    }
}

