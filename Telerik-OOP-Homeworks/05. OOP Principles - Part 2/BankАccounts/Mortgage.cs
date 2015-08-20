namespace BankАccounts
{


    public class Mortgage : Account, IDepositable
    {
        //fields

        //constructors
        public Mortgage(Customer customer, decimal balance, decimal intererstRate)
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
            if (this.Customer is Individual)
            {
                if (numberOfMonths <= 6)
                {
                    return 0;
                }

                else
                {
                    return base.CalculateInterestAmount(numberOfMonths - 6);
                }

            }

            else if (this.Customer is Company)
            {
                if (numberOfMonths <= 12)
                {
                    return 0.5M * base.CalculateInterestAmount(numberOfMonths);
                }

                else
                {
                    return 0.5M * base.CalculateInterestAmount(12) + base.CalculateInterestAmount(numberOfMonths - 12);
                }

            }
            return base.CalculateInterestAmount(numberOfMonths);
        }

    }
}
