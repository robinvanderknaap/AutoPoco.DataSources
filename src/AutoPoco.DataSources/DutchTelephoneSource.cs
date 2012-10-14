using System;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class DutchTelephoneSource : DatasourceBase<String>
    {
        private readonly Random _random = new Random(1337);

        public override string Next(IGenerationContext context)
        {
            var phoneNumber = "0";
            for (var ctr = 0; ctr < 9; ctr++)
            {
                phoneNumber += _random.Next(1, 9);
            }
            return phoneNumber;
        }
    }
}
