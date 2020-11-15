using System;

namespace E_ATM
{
    public class BankClass:IBank
    {
        public int amoountOfWithdrawn;
        public int maxAmount;
        public int amountOfMoney;

        int IBank.amoountOfWithdrawn { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        int IBank.maxAmount { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        int IBank.amountOfMoney { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }           
             


        public BankClass()
        {
        }

        public void CheckAmountOfMoney()
        {

        }

        public void Withdrawn()
        {
          //  amoountOfWithdrawn = int.Parse(Console.ReadLine());

        }

        public void CheckAmountOfWithdraw()
        {


        }
        public void CheckMaxAmount()
        {


        }



    }

}