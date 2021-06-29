using System.Collections.Generic;
using System.Linq;

namespace Console.OpenClose.MonitorExample.Completed
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }

    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
    }

    public class MonitorTypeSpecification : ISpecification<ComputerMonitor>
    {
        private readonly MonitorType _type;

        public MonitorTypeSpecification(MonitorType type)
        {
            this._type = type;
        }

        public bool IsSatisfied(ComputerMonitor item)
        {
            return this._type == item.Type;
        }
    }

    public class MonitorFilter : IFilter<ComputerMonitor>
    {
        public List<ComputerMonitor> Filter(IEnumerable<ComputerMonitor> items, ISpecification<ComputerMonitor> specification)
        {
            return items.Where(specification.IsSatisfied).ToList();
        }
    }
}
