using System;
using AutoPoco.Engine;

namespace Datasources
{
    public class DateTimeSource : DatasourceBase<DateTime>
    {
        private readonly DateTime _min;
        private readonly DateTime _max;
        private readonly Random _random = new Random(1337);
        
        public DateTimeSource()
        {
            _min = DateTime.MinValue;
            _max = DateTime.MaxValue;
        }

        public DateTimeSource(DateTime min, DateTime max)
        {
            _min = min;
            _max = max;
        }
        
        public override DateTime Next(IGenerationContext context)
        {
            var range = (_max - _min).Ticks;
            var ticks = (long)(_random.NextDouble() * range);
            return _min.AddTicks(ticks);
        }
    }
}
