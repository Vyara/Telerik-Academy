namespace BankАccounts
{

    public class Loan : Account, IDepositable
    {
        //fields

        //constructors
        public Loan(Customer customer, decimal balance, decimal intererstRate)
            : base(customer, balance, intererstRate)
        {

        }

        //properties

        //methods
        public void MakeADeposit(decimal depositAmount)
        {
            this.Balance += depositAmount;
        }

        public override decimal CalculateInterestAmount(int numberOfMonths)
        {
            if (this.Customer is Individual && numberOfMonths > 3)
            {
                if (numberOfMonths - 3 < 0)
                {
                    return 0;
                }

                return base.CalculateInterestAmount(numberOfMonths - 3);
            }

            else if (this.Customer is Company && numberOfMonths > 2)
            {
                if (numberOfMonths - 2 < 0)
                {
                    return 0;
                }

                return base.CalculateInterestAmount(numberOfMonths - 2);

            }
            return base.CalculateInterestAmount(numberOfMonths);
        }

    }
}
