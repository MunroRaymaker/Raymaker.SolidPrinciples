using System.Collections.Generic;
using Console.OpenClose.MonitorExample;
using Console.OpenClose.MonitorExample.Completed;
using Console.OpenClose.SalaryExample;
using Console.OpenClose.SalaryExample.Completed;

using SalaryCalculator = Console.OpenClose.SalaryExample.Start.SalaryCalculator;

namespace Console.OpenClose
{
    internal class ProgramRefact
    {
        // private static void Main(string[] args)
        // {
        //     var p = new ProgramRefact();
        //     p.RunSalaryExample();
        //     p.RunMonitorExample();
        // }

        void RunSalaryExample()
        {
            // After refactoring
            var devs = new List<BaseSalaryCalculator>
            {
                new SeniorDeveloperSalaryCalculator(new DeveloperReport
                    {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160}),
                new JuniorDeveloperSalaryCalculator(new DeveloperReport
                    {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150}),
                new SeniorDeveloperSalaryCalculator(new DeveloperReport
                    {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180})
            };

            var calculator2 = new SalaryExample.Completed.SalaryCalculator(devs);
            System.Console.WriteLine(
                $"Sum of all the developer salaries is {calculator2.CalculateTotalSalaries()} dollars");
        }

        void RunMonitorExample()
        {
            // Start
            var monitors = new List<ComputerMonitor>
            {
                new ComputerMonitor { Name = "Samsung S345", Screen = ScreenType.CurvedScreen, Type = MonitorType.OLED },
                new ComputerMonitor { Name = "Philips P532", Screen = ScreenType.WideScreen, Type = MonitorType.LCD },
                new ComputerMonitor { Name = "LG L888", Screen = ScreenType.WideScreen, Type = MonitorType.LED },
                new ComputerMonitor { Name = "Samsung S999", Screen = ScreenType.WideScreen, Type = MonitorType.OLED },
                new ComputerMonitor { Name = "Dell D2J47", Screen = ScreenType.CurvedScreen, Type = MonitorType.LCD }
            };
            
            // Completed
            var filter2 = new Console.OpenClose.MonitorExample.Completed.MonitorFilter();

            var lcdMonitors2 = filter2.Filter(monitors, new MonitorTypeSpecification(MonitorType.LCD));
            System.Console.WriteLine("All LCD monitors");
            foreach (var monitor in lcdMonitors2)
            {
                System.Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            }
        }
    }
}