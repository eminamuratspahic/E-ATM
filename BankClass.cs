using System;

namespace E_ATM
{
    public class BankClass : IBank
    {

        public int maxAmount { get; set; }
        public double amountOfExistingMoney = 10000;
        public double amount { get; set; }
        public double amountOfExisting {get; set;}



        public BankClass()
        {
        }

        public double CheckAmountOfExistingMoney()
        {
            return amountOfExistingMoney;
        }

        public double Withdrawn(double amount)
        {

             try
            {
                amountOfExistingMoney -= amount;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


            if (amount <= amountOfExistingMoney)
             
             if (amount <= amountOfExistingMoney)
            {
                amountOfExistingMoney -= amount;
                return true;
            }
            else
            {
                return false;
         
       

        }
        public double Deposit(double amount)
        {
            try
            {
                amountOfExistingMoney += amount;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return amountOfExistingMoney;
 
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