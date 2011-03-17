using System;
using AutoPoco.Engine;

namespace Datasources
{
    public class DutchMobileSource : DatasourceBase<String>
    {
        private readonly Random _random = new Random(1337);

        public override string Next(IGenerationContext context)
        {
            var mobileNumber = "06";
            for (var ctr = 0; ctr < 8; ctr++)
            {
                mobileNumber += _random.Next(1, 9);
            }
            return mobileNumber;
        }
    }
}
