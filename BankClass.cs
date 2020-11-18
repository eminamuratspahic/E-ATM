using System;

namespace E_ATM
{
    public class BankClass : IBank
    {

<<<<<<< HEAD
=======
        public int amountOfWithdrawn { get; set; }
>>>>>>> parent of 0c56fa6... Commit changes
        public int maxAmount { get; set; }
        public double amountOfMoney { get; set; }
        public double amount { get; set; }

        public BankClass()
        {
        }

        public double CheckAmountOfMoney()
        {
            return amountOfMoney;
        }

        public double Withdrawn(double amount)
        {

            try
            {
<<<<<<< HEAD
                amountOfExistingMoney -= amount;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


            if (amount <= amountOfExistingMoney)
             
             if (amount <= amountOfExistingMoney)
=======
                amountOfMoney -= amount;
            }
            catch (Exception e)
            { throw new Exception(e.Message); }


            if (amount <= amountOfMoney)
>>>>>>> parent of 0c56fa6... Commit changes
            {
                amountOfMoney -= amount;
                return true;
            }
            else
            {
                return false;
<<<<<<< HEAD
         
       
=======
            }

>>>>>>> parent of 0c56fa6... Commit changes

        }
        public double Deposit(double amount)
        {

            try
            {
                amountOfMoney += amount;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return amountOfMoney;

        }

        public void CheckAmountOfWithdraw()
        {


        }
        public void CheckMaxAmount()
        {


        }



    }

}
}