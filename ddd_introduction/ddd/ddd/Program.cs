using ddd.Entity;
using ddd.Value;
using System;

namespace ddd
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value
            TestValue();

            // Entity
            TestEntity();
        }

        private static void TestValue()
        {
            var fullName = new FullName(new Value.Name("Yusuke"), new Value.Name("XXX"), new Value.Name("Katsuragawa"));
            Console.WriteLine(fullName.ToString());

            var myMoney = new Money(1000, "JPY");
            var allowance = new Money(3000, "JPY");
            var result = myMoney.Add(allowance);
        }

        private static void TestEntity() 
        {
            var user = new User(new Entity.UserId("0"), new Entity.Name("Kaleidot725"));
            Console.WriteLine(user.ToString());

            user.changeName(new Entity.Name("function725"));
            Console.WriteLine(user.ToString());
        }
    }
}
