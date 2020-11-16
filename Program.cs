using System;

namespace E_ATM
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuClass menuClass = new MenuClass();
            //test
            LoginClass loginClass = new LoginClass();
            loginClass.cardNum = 123;
            loginClass.pinNum = 111;
            Console.WriteLine("Skriv in ditt kortnummer");
            int pin = int.Parse(Console.ReadLine());
            bool isPinCorrect = loginClass.VerifyCardNumber(pin);

            if(isPinCorrect)
            {
                //Console.WriteLine("Rätt kod");
                

  Console.WriteLine ("\nAnge ditt val : 1-3 :\n");
		 menuClass.choice = Console.ReadLine ();
                
                
            }else
            {
                Console.WriteLine("Fel kod");
            }

            




/*             Console.WriteLine("Välkommen till E-ATM");
            Console.WriteLine("Ange ditt kortnummer");
            int input = Convert.ToInt32(Console.ReadLine()); */

            //Metod som kollar ifall kortnummer finns

/*             Console.WriteLine("Ange PIN: ");
            input = Convert.ToInt32(Console.ReadLine()); */

            //Metod som kollar ifall pin är rätt


            /*public void Menu()
            {
                Console.WriteLine("1. Ta ut pengar");
                Console.WriteLine("2. Visa transaktionshistorik");
                Console.WriteLine("3. Logga ut");
            }
            */


        }
    }
}


