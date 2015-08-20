namespace BankАccounts
{

    public class Deposit : Account, IDepositable, IWithdrawable
    {
        //fields

        //constructors
        public Deposit(Customer customer, decimal balance, decimal intererstRate)
            : base(customer, balance, intererstRate)
        {

        }

        //properties

        //methods
        public void MakeADeposit(decimal depositAmount)
        {
            this.Balance += depositAmount;
        }

        public void MakeAWithdraw(decimal withdrawAmount)
        {
            this.Balance -= withdrawAmount;
        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestAmount(numberOfMonths);
        }

    }
}
