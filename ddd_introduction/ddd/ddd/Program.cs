using ddd.DomainService;
using ddd.Entity;
using ddd.Value;
using System;

namespace ddd
{
    class Program
    {
        static void Main(string[] args)
        {
            TestValue();
            TestEntity();
            TestDomainService();
        }

        private static void TestValue()
        {
            var fullName = new Value.FullName(new Value.Name("Yusuke"), new Value.Name("XXX"), new Value.Name("Katsuragawa"));
            Console.WriteLine(fullName.ToString());

            var myMoney = new Value.Money(1000, "JPY");
            var allowance = new Value.Money(3000, "JPY");
            var result = myMoney.Add(allowance);
        }

        private static void TestEntity() 
        {
            var user = new Entity.User(new Entity.UserId("0"), new Entity.Name("Kaleidot725"));
            Console.WriteLine(user.ToString());

            user.changeName(new Entity.Name("function725"));
            Console.WriteLine(user.ToString());
        }

        private static void TestDomainService()
        {
            var user = new DomainService.User(new DomainService.UserId("0"), new DomainService.Name("Kaleidot725"));
            Console.WriteLine(user.ToString());

            var domainService = new DomainService.UserService();
            Console.WriteLine(domainService.Exists(user));
        }
    }
}
