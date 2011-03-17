using System;
using AutoPoco.Engine;

namespace Datasources
{
    public class DutchCitySource : DatasourceBase<String>
    {
        private readonly Random _random = new Random(1337);

        public override string Next(IGenerationContext context)
        {
            return DutchCities[_random.Next(0, DutchCities.Length)];
        }

        private static readonly string[] DutchCities = new[]{
            "Amsterdam",
            "Rotterdam",
            "The Hague",
            "Utrecht",
            "Eindhoven",
            "Tilburg",
            "Groningen",
            "Almere",
            "Breda",
            "Nijmegen",
            "Apeldoorn",
            "Enschede",
            "Haarlem",
            "Arnhem",
            "Zaanstad",
            "s-Hertogenbosch",
            "Amersfoort",
            "Haarlemmermeer",
            "Maastricht",
            "Leiden"
        };
    }           
}



