using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                //list collection for details of cardholders
                List<CardHolder> CardHolders = new List<CardHolder>();
                CardHolders.Add(new CardHolder("2346543897065438", 3452, "Ram", "Surj", 567489));
                CardHolders.Add(new CardHolder("3467889065476432", 5678, "Aman", "Mohmed", 7654390));
                CardHolders.Add(new CardHolder("4509876543245890", 6709, "Sona", "Sin", 348876));
                CardHolders.Add(new CardHolder("2345612980765486", 4502, "Sharmila", "sun", 54389));
                CardHolders.Add(new CardHolder("1289765432098765", 6589, "Binoy", "Roy", 5678320));

                Console.WriteLine("Welcome to ATM");
                Console.WriteLine("Please insert your Depit Card");
                string debitCardNumber = "";
                CardHolder currentUser;
                while (true)
                {
                    try
                    {
                        debitCardNumber = Console.ReadLine();
                        currentUser = CardHolders.FirstOrDefault(a => a.cardNumber == debitCardNumber);
                        if (currentUser != null)
                            break;
                        else { Console.WriteLine("card can't recognized. \nPlease Try again."); }
                    }
                    catch
                    {
                        Console.WriteLine("card can't recognized. \nPlease Try again.");
                    }
                }
                //pin checking
                Console.WriteLine("Please Enter your PIN: ");
                int userPin = 0;
                while (true)
                {
                    try
                    {
                        userPin = int.Parse(Console.ReadLine());
                        if (currentUser.GetPin() == userPin)
                            break;
                        else { Console.WriteLine("Incorrect PIN. \nPlease Try again."); }
                    }
                    catch
                    {
                        Console.WriteLine("Incorrect PIN. \nPlease Try again.");
                    }
                }

                Console.WriteLine("Welcome" + currentUser.GetFirstName() + currentUser.GetLastName());
                int option = 0;
                do
                {
                    currentUser.PrintOptions();
                    try
                    {
                        option = int.Parse(Console.ReadLine());
                    }
                    catch
                    {

                    }
                    if (option == 1)
                        currentUser.Deposit(currentUser);
                    else if (option == 2)
                        currentUser.Withdraw(currentUser);
                    else if (option == 3)
                        currentUser.Balance1(currentUser);
                    else if (option == 4)
                        break;
                    else { option = 0; }
                }
                while (option != 4);
                Console.WriteLine("Thank You..!Have a nice Day");

            }
        }
    }
}
