using System.Collections.Generic;

namespace Console.OpenClose.SalaryExample.Completed
{
    public abstract class BaseSalaryCalculator
    {
        protected BaseSalaryCalculator(DeveloperReport developerReport)
        {
            DeveloperReport = developerReport;
        }

        protected DeveloperReport DeveloperReport { get; }

        public abstract double CalculateSalary();
    }

    public class SeniorDeveloperSalaryCalculator : BaseSalaryCalculator
    {
        public SeniorDeveloperSalaryCalculator(DeveloperReport developerReport) : base(developerReport) { }

        public override double CalculateSalary()
        {
            return DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
        }
    }

    public class JuniorDeveloperSalaryCalculator : BaseSalaryCalculator
    {
        public JuniorDeveloperSalaryCalculator(DeveloperReport developerReport) : base(developerReport) { }

        public override double CalculateSalary()
        {
            return DeveloperReport.HourlyRate * DeveloperReport.WorkingHours;
        }
    }

    public class SalaryCalculator
    {
        private readonly IEnumerable<BaseSalaryCalculator> _developerCalculation;

        public SalaryCalculator(IEnumerable<BaseSalaryCalculator> developerCalculation)
        {
            this._developerCalculation = developerCalculation;
        }

        public double CalculateTotalSalaries()
        {
            var totalSalaries = 0D;

            foreach (var item in this._developerCalculation) totalSalaries += item.CalculateSalary();

            return totalSalaries;
        }
    }
}