using System;

namespace E_ATM
{
    public class BankClass : IBank
    {

        public int amountOfWithdrawn { get; set; }
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

        public bool Withdrawn(double amount)
        {

            try
            {
                amountOfMoney -= amount;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }


            if (amount <= amountOfMoney)
            {
                amountOfMoney -= amount;
                return true;
            }
            else
            {
                return false;
            }


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