using System;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class IntegerSource : DatasourceBase<int>
    {
        private readonly int _min;
        private readonly int _max;
        private readonly Random _random = new Random(1337);

        public IntegerSource()
        {
            _min = int.MinValue;
            _max = int.MaxValue;
        }

        public IntegerSource(int min, int max)
        {
            _min = min;
            _max = max;
        }
        
        public override int Next(IGenerationContext context)
        {
            return _random.Next(_min, _max);
        }
    }
}
