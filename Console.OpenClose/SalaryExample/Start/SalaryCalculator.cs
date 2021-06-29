using System.Collections.Generic;

namespace Console.OpenClose.SalaryExample.Start
{
    public class SalaryCalculator
    {
        private readonly IEnumerable<DeveloperReport> _developerReports;

        public SalaryCalculator(List<DeveloperReport> developerReports)
        {
            this._developerReports = developerReports;
        }

        public double CalculateTotalSalaries()
        {
            var totalSalaries = 0D;

            foreach (var devReport in this._developerReports)
            {
                if (devReport.Level == "Senior developer")
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours * 1.2;
                else
                    totalSalaries += devReport.HourlyRate * devReport.WorkingHours;
            }

            return totalSalaries;
        }
    }
}