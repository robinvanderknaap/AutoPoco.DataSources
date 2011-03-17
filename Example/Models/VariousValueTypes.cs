using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.Models
{
    public class PocoLoco
    {
        public int SomeInt { get; set; }
        public float SomeFloat { get; set; }
        public double SomeDouble { get; set; }
        public decimal SomeDecimal { get; set; }
        public DateTime SomeDateTime { get; set; }
        public TimeSpan SomeTimeSpan { get; set; }
        public bool SomeBool { get; set; }
    }
}