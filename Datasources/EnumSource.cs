using System;
using System.Linq;
using AutoPoco.Engine;

namespace Datasources
{
    public class EnumSource<T> : DatasourceBase<T> where T : struct, IConvertible
    {
        private readonly Random _random = new Random(1337);

        public override T Next(IGenerationContext context)
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }
            var values = Enum.GetValues(typeof(T)).Cast<T>();
            return values.ElementAt(_random.Next(values.Count()));
        }
    }
}
