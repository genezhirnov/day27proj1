using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Animal
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public string Type { get; set; }
        public double WeightInLbs { get; set; }

        private string AgeInYears()
        {
            var intAge = Math.Floor(Age);
            var monthCount = Math.Floor((Age - intAge) * 12);
            return $"{intAge:N0} years, {monthCount:N0} months old";
        }

        public override string ToString()
        {
            return $"I'm {Name} and I'm a {Type}. I weigh {Math.Round(WeightInLbs, 2):N2} lbs and I'm {AgeInYears()}; thank you for asking.";
        }
        //private int _age;
        //public int Age
        //{
        //    get
        //    {
        //        return _age;
        //    }
        //    private set
        //    {
        //        if (value <= 120 && value > 0)
        //        {
        //            _age = value;
        //        }
        //    }
        //}
    }
}
