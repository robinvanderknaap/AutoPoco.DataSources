using System;
using AutoPoco.Engine;

namespace Datasources
{
    public class DutchMiddlenameSource : DatasourceBase<String>
    {
        private readonly Random _random = new Random(1337);

        public override string Next(IGenerationContext context)
        {
            return Middlenames[_random.Next(0, Middlenames.Length)];
        }

        private static readonly string[] Middlenames = new[]{
            "van",	
            "van de",	
            "van der",	
            "de",
            "le",
            "la",
            "den",
            "der",
            "d'",
            "het",
            "'t",
            "in",
            "onder",
            "op",
            "over",
            "'s",
            "'t",
            "te",
            "ten",
            "ter",
            "tot",
            "uit",
            "uijt",
            "ver",
            "voor"
        };
    }

}