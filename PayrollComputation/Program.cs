using System;
using System.Globalization;

namespace PayrollComputation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] employees=
            {
                "H 500 10",
                "S 40000",
                "C 8000 20000"
            };
            decimal totalPay=ComputeTotalPayroll(employees);
            Console.WriteLine($"Total Payroll: {totalPay}");
        }
        public static decimal ComputeTotalPayroll(string[] employees)
    {
        if(employees ==null)
        {
            throw new ArgumentNullException(nameof(employees));

        }
        decimal total=0;

        foreach(string emp in employees)
        {
            if(string.IsNullOrWhiteSpace(emp))
            {
                continue;
            }

            Employee employee=EmployeeFactory.Create(emp);
            total+=employee.GetPay();
        }
        return Math.Round(total,2,MidpointRounding.AwayFromZero);
    }
    }
    public abstract class Employee
    {
        public abstract decimal GetPay();
    }

    public class HourlyEmployee:Employee

    {
        private readonly decimal _rate;
        private readonly decimal _hours;

        public HourlyEmployee(decimal rate, decimal hours)
        {
            _rate=rate;
            _hours=hours;
        }
        public override decimal GetPay()
        {
            return _rate * _hours;
        }
    }

    public class SalariedEmployee : Employee
    {
        private readonly decimal _monthlySalary;

        public SalariedEmployee(decimal monthlySalary)
        {
            _monthlySalary=monthlySalary;
        }

        public override decimal GetPay()
        {
            return _monthlySalary;
        }
    }

    public class CommissionEmployee : Employee
    {
        private readonly decimal _commission;
        private readonly decimal _baseSalary;

        public CommissionEmployee(decimal commission, decimal baseSalary)
        {
            _commission=commission;
            _baseSalary=baseSalary;
        }

        public override decimal GetPay()
        {
            return  _baseSalary + _commission;
        }
    }

    public static class EmployeeFactory
    {
        public static Employee Create(string input)
        {
            string[] parts=input.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            char type=parts[0][0];

            return type switch
            {
                'H' => new HourlyEmployee(
                    decimal.Parse(parts[1],CultureInfo.InvariantCulture),
                    decimal.Parse(parts[2],CultureInfo.InvariantCulture)
                ),
                'S' => new SalariedEmployee(
                    decimal.Parse(parts[1],CultureInfo.InvariantCulture)
                ),
                'C' => new CommissionEmployee(
                    decimal.Parse(parts[1],CultureInfo.InvariantCulture),
                    decimal.Parse(parts[2],CultureInfo.InvariantCulture)
                ),

                _ => throw new InvalidOperationException("Invalid employee type")
            };
        }
    }
}