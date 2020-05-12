using ddd.sample_02;
using System;

namespace ddd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chapter2
            var fullName = new FullName(new Name("Yusuke"), new Name("XXX"), new Name("Katsuragawa"));
            Console.WriteLine(fullName.ToString());

            var myMoney = new Money(1000, "JPY");
            var allowance = new Money(3000, "JPY");
            var result = myMoney.Add(allowance);
        }
    }
}
