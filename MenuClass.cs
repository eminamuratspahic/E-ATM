using System;

namespace E_ATM
{

    public class MenuClass
    {

        public string choice;

        BankClass bankClass = new BankClass();

        public enum MenuChoices
        {

            UTTAG = 1,
            TRANSAKTIONSHISTORIK,
            INSÄTTNING,
            AVSLUTA

        }
        public void Menu()
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            int amountOfWithdrawnsLeft = 5;
=======
>>>>>>> parent of 0c56fa6... Commit changes
=======
>>>>>>> parent of 0c56fa6... Commit changes
=======
>>>>>>> parent of 0c56fa6... Commit changes
            while (true)
            {

                Console.Clear();
                int index = 0;
                Console.WriteLine("E-ATM\n");

                foreach (string str in Enum.GetNames(typeof(MenuChoices)))
                {
                    index++;

                    Console.WriteLine(index + ": " + str);
                }

                // Console.WriteLine ("\nAnge ditt val : 1-3 :\n");
                // string value = Console.ReadLine ();

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
               int intChoice; 
                    if (!int.TryParse(choice, out intChoice))
=======
                if (!int.TryParse(choice, out int output))
>>>>>>> parent of 0c56fa6... Commit changes
=======
                if (!int.TryParse(choice, out int output))
>>>>>>> parent of 0c56fa6... Commit changes
=======
                if (!int.TryParse(choice, out int output))
>>>>>>> parent of 0c56fa6... Commit changes
                {

                    Console.WriteLine("Valet ska anges i siffervärde, möjliga val 1-2-3.");
                    Console.WriteLine("Tryck valfritt knapp får att gå vidare...");
                    Console.ReadKey();
                }
                else
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                {  // testar validering, komentera bort hit om det inte funkar
=======
                {
>>>>>>> parent of 0c56fa6... Commit changes
=======
                {
>>>>>>> parent of 0c56fa6... Commit changes
=======
                {
>>>>>>> parent of 0c56fa6... Commit changes
                    MenuChoices MenuChoice = (MenuChoices)Enum.Parse(typeof(MenuChoices), choice);

                    switch (MenuChoice)
                    {
                        case MenuChoices.UTTAG:
                            Console.WriteLine("UTTAG");

                            Console.WriteLine("Tryck valfritt knapp får att gå vidare...");
                            double money = Convert.ToDouble(Console.ReadLine());
                            bool withdraw = bankClass.Withdrawn(money);
                            if(withdraw)
                            {
                                Console.WriteLine($"Ditt tog ut {money} kr! Ditt nya belopp är {bankClass.amountOfMoney}");
                            }else
                            {
                                Console.WriteLine("Du har skrivit in ett ogiltigt belopp!");
                            }


                            break;

                        case MenuChoices.TRANSAKTIONSHISTORIK:
                            Console.WriteLine("TRANSAKTIONSHISTORIK");
                            Console.WriteLine("Tryck valfritt knapp får att gå vidare...");
                            Console.ReadKey();
                            break;

                        case MenuChoices.INSÄTTNING:
                            Console.Write("Var god och ange insättningsbeloppet:");
                            double amountOfMoney2 = double.Parse(Console.ReadLine());
                            double newBalance = bankClass.Deposit(amountOfMoney2);
                            Console.WriteLine($"Ditt nya belopp: {newBalance}");
                            break;
                            
                        case MenuChoices.AVSLUTA:
                            Console.WriteLine("LOGGA UT");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Felaktig val, försök igen.");
                            Console.WriteLine("Tryck valfritt knapp får att gå vidare...");
                            Console.ReadKey();
                            break;
                    }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
                 }
=======
                }
>>>>>>> parent of 0c56fa6... Commit changes
=======
                }
>>>>>>> parent of 0c56fa6... Commit changes
=======
                }
>>>>>>> parent of 0c56fa6... Commit changes
            }

        }

    }
}