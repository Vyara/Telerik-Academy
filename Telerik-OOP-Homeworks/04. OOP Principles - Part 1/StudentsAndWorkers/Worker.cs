namespace StudentsAndWorkers
{
    using System.Text;

   public class Worker : Human
    {
        //fields

        //constructors
        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
            :base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        //properties
        public double WeekSalary { get; private set; }

        public int WorkHoursPerDay { get; private set; }

        //methods
        public double MoneyPerHour()
        {
            return this.WeekSalary / (double)(5 * this.WorkHoursPerDay); // 5 days a week
        }

        public override string ToString()
        {
            var worker = new StringBuilder();
            worker.AppendFormat("Money per hour: {0:F2}", this.MoneyPerHour());
            worker.AppendLine();
            return base.ToString() + worker;
        }
    }
}
