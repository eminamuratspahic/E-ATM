using System;

namespace E_ATM
{
    public class BankClass : IBank
    {

<<<<<<< HEAD
        //public int amountOfWithdrawnsLeft = 5;
=======
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        public int amountOfWithdrawn { get; set; }
>>>>>>> parent of 0c56fa6... Commit changes
=======
        public int amountOfWithdrawn { get; set; }
>>>>>>> parent of 0c56fa6... Commit changes
=======
        public int amountOfWithdrawn { get; set; }
>>>>>>> parent of 0c56fa6... Commit changes
=======
        public int amountOfWithdrawn { get; set; }
>>>>>>> parent of 0c56fa6... Commit changes
=======
        public int amountOfWithdrawn { get; set; }
>>>>>>> parent of 0c56fa6... Commit changes
>>>>>>> e988461e5da731bd33e9205e5fbf6e4c668c502c
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

        public bool Withdrawn(double amount)
        {

<<<<<<< HEAD
             try
=======
            try
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> e988461e5da731bd33e9205e5fbf6e4c668c502c
            {
             
             if (amount <= amountOfExistingMoney)
            {
<<<<<<< HEAD
                amountOfExistingMoney -= amount;
=======
                amountOfMoney -= amount;
            }
            catch (Exception e)
            { throw new Exception(e.Message); }


            if (amount <= amountOfMoney)
            {
>>>>>>> parent of 0c56fa6... Commit changes
=======
            {
                amountOfMoney -= amount;
            }
            catch (Exception e)
            { throw new Exception(e.Message); }


            if (amount <= amountOfMoney)
            {
>>>>>>> parent of 0c56fa6... Commit changes
=======
            {
                amountOfMoney -= amount;
            }
            catch (Exception e)
            { throw new Exception(e.Message); }


            if (amount <= amountOfMoney)
            {
>>>>>>> parent of 0c56fa6... Commit changes
                amountOfMoney -= amount;
>>>>>>> e988461e5da731bd33e9205e5fbf6e4c668c502c
                return true;
            }
            else
            {
                return false;
<<<<<<< HEAD
            } 
            }
            catch (Exception e)
            { 
                throw new Exception(e.Message);
            } 
       
=======
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
         
       
=======
            }

>>>>>>> parent of 0c56fa6... Commit changes
=======
            }

>>>>>>> parent of 0c56fa6... Commit changes
=======
            }

>>>>>>> parent of 0c56fa6... Commit changes
=======
            }

>>>>>>> parent of 0c56fa6... Commit changes
=======
            }

>>>>>>> parent of 0c56fa6... Commit changes
>>>>>>> e988461e5da731bd33e9205e5fbf6e4c668c502c

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