using System;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class BooleanSource : DatasourceBase<bool>
    {
        private readonly Random _random = new Random(1337);

        public override bool Next(IGenerationContext context)
        {
            return _random.Next(2) == 1;
        }
    }
}
