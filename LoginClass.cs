namespace E_ATM
{
    public class LoginClass:ILogin
    {
        public int pinNum{get; set;}
        public int cardNum{get; set;}
        public int amountOfTries{get; set;}

        public LoginClass()
        {
        }

        public bool VerifyCardNumber(int cardNum)
        {
            if(this.cardNum == cardNum)
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
            if(pinNum==pinNum)
            {
            return true;
            }
            else
            {
                return false;
            }       
        }

        public void CheckAmountOfTries()
        {


        }
    }
}