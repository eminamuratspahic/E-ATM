using System;

namespace E_ATM
{
    public class LoginClass : ILogin
    {
        public int pinNum { get; set; }
        public int cardNum { get; set; }
        public int amountOfTries { get; set; }

        public LoginClass()
        {
        }

        public bool VerifyCardNumber(int cardNum)
        {
            if (this.cardNum == cardNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerifyPin()
        {

            if (pinNum == pinNum)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string CheckAmountOfTries(int pin)
        {

            amountOfTries = 0;


            while (true)
            {
                pin = int.Parse(Console.ReadLine());

                if (amountOfTries < 3 && pinNum == pin)
                {
                    return "Grattis du kom in";

                }
                else if (amountOfTries > 3)
                {
                    return "För många misslyckade försök! Ditt kort spärras";
                }
                else
                {
                    Console.WriteLine("Fel försök igen!");
                    amountOfTries++;

                }

            }


        }
    }
}