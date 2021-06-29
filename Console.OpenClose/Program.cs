using System.Collections.Generic;
using Console.OpenClose.MonitorExample;
using Console.OpenClose.SalaryExample;

using SalaryCalculator = Console.OpenClose.SalaryExample.Start.SalaryCalculator;

namespace Console.OpenClose
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var p = new Program();
            p.RunSalaryExample();
            p.RunMonitorExample();
        }

        void RunSalaryExample()
        {
            // Start
            var devReports = new List<DeveloperReport>
            {
                new DeveloperReport
                    {Id = 1, Name = "Dev1", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 160},
                new DeveloperReport
                    {Id = 2, Name = "Dev2", Level = "Junior developer", HourlyRate = 20, WorkingHours = 150},
                new DeveloperReport
                    {Id = 3, Name = "Dev3", Level = "Senior developer", HourlyRate = 30.5, WorkingHours = 180}
            };

            var calculator = new SalaryCalculator(devReports);
            System.Console.WriteLine(
                $"Sum of all the developer salaries is {calculator.CalculateTotalSalaries()} dollars");
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
            var filter = new Console.OpenClose.MonitorExample.Start.MonitorFilter();
            
            var lcdMonitors = filter.FilterByType(monitors, MonitorType.LCD);
            System.Console.WriteLine("All LCD monitors");
            foreach (var monitor in lcdMonitors)
            {
                System.Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            }

            var widescreenMonitors = filter.FilterByScreen(monitors, ScreenType.WideScreen);
            System.Console.WriteLine("All Wide Screen monitors");
            foreach (var monitor in widescreenMonitors)
            {
                System.Console.WriteLine($"Name: {monitor.Name}, Type: {monitor.Type}, Screen: {monitor.Screen}");
            }
        }
    }
}