using System;
using System.Collections.Generic;
using System.Linq;

namespace ATM
{
    public class Cardholder
    {
        string cardNum;
        int pin;
        string firstName;
        string lastName;
        double balance;

        public Cardholder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public string GetCardNum()
        {
            return cardNum;
        }

        public int GetPin()
        {
            return pin;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void SetCardNum(string newCardNum)
        {
            cardNum = newCardNum;
        }

        public void SetPin(int newPin)
        {
            pin = newPin;
        }

        public void SetFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }

        public void SetLastName(string newLastName)
        {
            lastName = newLastName;
        }

        public void SetBalance(double newBalance)
        {
            balance = newBalance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            void PrintOptions()
            {
                Console.WriteLine("Please select one of the following options:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
            }

            void Deposit(Cardholder currentUser)
            {
                Console.WriteLine("Enter the amount you want to deposit: ");
                double deposit = double.Parse(Console.ReadLine());
                currentUser.SetBalance(currentUser.GetBalance() + deposit);
                Console.WriteLine("Your new balance is: " + currentUser.GetBalance());
            }

            void Withdraw(Cardholder currentUser)
            {
                Console.WriteLine("Enter the amount you want to withdraw: ");
                double withdrawal = double.Parse(Console.ReadLine());

                if (currentUser.GetBalance() < withdrawal)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    currentUser.SetBalance(currentUser.GetBalance() - withdrawal);
                    Console.WriteLine("You are good to go!");
                }
            }

            void CheckBalance(Cardholder currentUser)
            {
                Console.WriteLine("Current balance: " + currentUser.GetBalance());
            }

            List<Cardholder> cardholders = new List<Cardholder>();
            cardholders.Add(new Cardholder("1111", 1234, "Kartik", "Nerkar", 201.2));
            cardholders.Add(new Cardholder("2222", 2134, "Atul", "Nerkar", 301.2));
            cardholders.Add(new Cardholder("3333", 3124, "Anita", "Nerkar", 401.2));
            cardholders.Add(new Cardholder("4444", 4123, "Dhanashree", "Nerkar", 501.2));
            cardholders.Add(new Cardholder("5555", 1423, "Riddhi", "Sanghvi", 601.2));

            Console.WriteLine("Welcome to the Simple ATM:");
            Console.WriteLine("Please insert your card number:");

            string debitCardNum = "";
            Cardholder currentUser;

            while (true)
            {
                try
                {
                    debitCardNum = Console.ReadLine();
                    currentUser = cardholders.FirstOrDefault(a => a.GetCardNum() == debitCardNum);
                    if (currentUser != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Card not recognized. Please try again!");
                    }
                }
                catch
                {
                    Console.WriteLine("Card not recognized. Please try again!");
                }
            }

            Console.WriteLine("Enter your PIN: ");
            int userPin = 0;

            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    if (currentUser.GetPin() == userPin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect PIN. Please try again!");
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect PIN. Please try again!");
                }
            }

            Console.WriteLine("Welcome!");

            while (true)
            {
                PrintOptions();
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Deposit(currentUser);
                        break;
                    case 2:
                        Withdraw(currentUser);
                        break;
                    case 3:
                        CheckBalance(currentUser);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again!");
                        break;
                }
            }
        }
    }
}
