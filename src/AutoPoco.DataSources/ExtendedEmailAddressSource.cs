using System;
using AutoPoco.Engine;

namespace AutoPoco.DataSources
{
    public class ExtendedEmailAddressSource : DatasourceBase<String>
    {
        private readonly Random _random = new Random(1337);
        private int _index;
        private readonly string _domain = "";

        public ExtendedEmailAddressSource() { }

        public ExtendedEmailAddressSource(string domain)
        {
            _domain = domain ?? "";
        }

        public override string Next(IGenerationContext context)
        {
            return string.Format("{0}{1}@{2}", FirstNames[_random.Next(0, FirstNames.Length)], _index++, string.IsNullOrEmpty(_domain.Trim()) ? Domains[_random.Next(0, Domains.Length)] : _domain.Trim());
        }

        private static readonly string[] Domains = new[]
                                                       {
                                                           "google.com",
                                                           "msn.nl",
                                                           "paspar.nl",
                                                           "hotmail.com",
                                                           "aol.com",
                                                           "webpirates.nl",
                                                           "skaele.nl",
                                                           "yahoo.com"
                                                       };

        private static readonly string[] FirstNames = new[]{
            "Jack",	
            "Thomas",	
            "Oliver",	
            "Joshua",
            "Harry",
            "Charlie",
            "Daniel",
            "William",
            "James",
            "Alfie",
            "Samuel",
            "George",
            "Joseph",
            "Benjamin",
            "Ethan",
            "Lewis",
            "Mohammed",
            "Jake",
            "Dylan",
            "Jacob",
            "Ruby",	
            "Olivia",	
            "Grace",	
            "Emily",
            "Jessica",
            "Chloe",
            "Lily",
            "Mia",
            "Lucy",
            "Amelia",
            "Evie",
            "Ella",
            "Katie",
            "Ellie",
            "Charlotte",
            "Summer",
            "Mohammed",
            "Megan",
            "Hannah",
            "Ava"
        };
    }
}
