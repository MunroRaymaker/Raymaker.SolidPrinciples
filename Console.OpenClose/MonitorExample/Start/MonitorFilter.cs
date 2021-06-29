using System.Collections.Generic;
using System.Linq;

namespace Console.OpenClose.MonitorExample.Start
{
    public class MonitorFilter
    {
        public List<ComputerMonitor> FilterByType(IEnumerable<ComputerMonitor> monitors, MonitorType type)
        {
            return monitors.Where(m => m.Type == type).ToList();
        }

        public List<ComputerMonitor> FilterByScreen(IEnumerable<ComputerMonitor> monitors, ScreenType screen)
        {
            return monitors.Where(m => m.Screen == screen).ToList();
        }
    }
}
