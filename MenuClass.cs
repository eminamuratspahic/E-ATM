using System;

namespace E_ATM {

    public class MenuClass {

        BankClass bankClass = new BankClass();

        public enum MenuChoices {

            UTTAG = 1,
            TRANSAKTIONSHISTORIK,
            AVSLUTA

        }
        public void Menu () {
            while (true) {

                Console.Clear ();
                int index = 0;
                Console.WriteLine ("E-ATM\n");

                foreach (string str in Enum.GetNames (typeof (MenuChoices))) {
                    index++;

                    Console.WriteLine (index + ": " + str);
                }

                Console.WriteLine ("\nAnge ditt val : 1-3 :\n");
                string value = Console.ReadLine ();

                if (!int.TryParse (value, out int output)) {

                    Console.WriteLine ("Valet ska anges i siffervärde, möjliga val 1-2-3.");
                    Console.WriteLine ("Tryck valfitt knapp får att gå vidare...");
                    Console.ReadKey ();
                } else {
                    MenuChoices MenuChoice = (MenuChoices) Enum.Parse (typeof (MenuChoices), value);

                    switch (MenuChoice) {
                        case MenuChoices.UTTAG:
                            Console.WriteLine ("UTTAG");

                            bankClass.Withdrawn();
                            Console.WriteLine ("Tryck valfitt knapp får att gå vidare...");
                            Console.ReadKey ();
                            break;

                        case MenuChoices.TRANSAKTIONSHISTORIK:
                            Console.WriteLine ("TRANSAKTIONSHISTORIK");
                            Console.WriteLine ("Tryck valfitt knapp får att gå vidare...");
                            Console.ReadKey ();
                            break;

                        case MenuChoices.AVSLUTA:
                            Console.WriteLine ("LOGGA UT");
                            Environment.Exit (0);
                            break;

                        default:
                            Console.WriteLine ("Felaktig val, försök igen.");
                            Console.WriteLine ("Tryck valfitt knapp får att gå vidare...");
                            Console.ReadKey ();
                            break;
                    }
                }
            }

        }

    }
}