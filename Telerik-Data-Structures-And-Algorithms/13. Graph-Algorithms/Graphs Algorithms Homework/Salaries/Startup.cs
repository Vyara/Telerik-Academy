namespace Salaries
{
    using System;

    public class Startup
    {
        private static bool[,] employees;
        private static int employeesCount;
        private static long[] salaries;

        public static void Main()
        {
            employeesCount = int.Parse(Console.ReadLine());
            employees = new bool[employeesCount, employeesCount];
            salaries = new long[employeesCount];

            for (int i = 0; i < employeesCount; i++)
            {
                var input = Console.ReadLine();

                for (int j = 0; j < employeesCount; j++)
                {
                    if (input[j] == 'Y')
                    {
                        employees[i, j] = true;
                    }
                }
            }

            long totalSalary = 0;
            for (int i = 0; i < employeesCount; i++)
            {
                totalSalary += GetSalary(i);
            }

            Console.WriteLine(totalSalary);
        }

        private static long GetSalary(int employee)
        {
            if (salaries[employee] > 0)
            {
                return salaries[employee];
            }

            long salary = 0;
            for (int i = 0; i < employeesCount; i++)
            {
                if (employees[employee, i])
                {
                    salary += GetSalary(i);
                }
            }

            salary = salary != 0 ? salary : 1;

            salaries[employee] = salary;
            return salary;
        }
    }
}
