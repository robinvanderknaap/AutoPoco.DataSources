using System;
using AutoPoco.Engine;

namespace Datasources
{
    public class TimeSpanSource : DatasourceBase<TimeSpan>
    {
        private readonly TimeSpan _min;
        private readonly TimeSpan _max;
        private readonly Random _random = new Random(1337);
        
        public TimeSpanSource(TimeSpan min, TimeSpan max)
        {
            _min = min;
            _max = max;
        }
        public override TimeSpan Next(IGenerationContext context)
        {
            var range = (_max - _min).Ticks;
            var ticks = (long)(_random.NextDouble() * range);
            return _min.Add(TimeSpan.FromTicks(ticks));
        }
    }
}
