using ddd.DomainService;
using ddd.Entity;
using ddd.Repository;
using ddd.Value;
using System;

namespace ddd
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestValue();
            //TestEntity();
            //TestDomainService();
            //TestRepository();
            TestApplicationService();
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

            user.ChangeName(new Entity.Name("function725"));
            Console.WriteLine(user.ToString());
        }

        private static void TestDomainService()
        {
            var user = new DomainService.User(new DomainService.UserId("0"), new DomainService.Name("Kaleidot725"));
            Console.WriteLine(user.ToString());

            var domainService = new DomainService.UserService();
            Console.WriteLine(domainService.Exists(user));
        }

        private static void TestRepository()
        {
            var user = new Repository.User(new Repository.UserId("0"), new Repository.Name("Kaleidot725"));
            Console.WriteLine(user.ToString());

            var userService = new Repository.UserService(new Repository.UserRepository());
            if (!userService.Exists(user))
            {
                IUserRepository repository = new Repository.UserRepository();
                repository.Save(user);
                Console.WriteLine($"{user.Name}は存在していないので、保存しました");
            }
            else 
            {
                Console.Write($"{user.Name}は既に存在しています。");

            }
        }

        private static void TestApplicationService()
        {
            var defaultId = "0";
            var defaultName = "Kaleidot725";
            var defaultMailAddress = "good@mail.com";
            var nextName = "Kaleidot888";
            var nextMailAddress = "bad@mail.com";

            var repository = new ApplicationService.UserRepository();
            var applicationService = new ApplicationService.UserApplicationService(
                new ApplicationService.UserGetInfoService(repository),
                new ApplicationService.UserRegisterService(repository),
                new ApplicationService.UserDeleteService(repository),
                new ApplicationService.UserUpdateService(repository)
            );

            var registerCommand = new ApplicationService.UserRegisterCommand(defaultId, defaultName, defaultMailAddress);
            applicationService.Register(registerCommand);
            var newUserData = applicationService.Get(defaultId);
            Console.WriteLine(newUserData.Id + " " + newUserData.Name + " " + newUserData.MailAddress);

            var updateCommand = new ApplicationService.UserUpdateCommand(defaultId, nextName, nextMailAddress);
            applicationService.Update(updateCommand);
            var updateUserData = applicationService.Get(defaultId);
            Console.WriteLine(updateUserData.Id + " " + updateUserData.Name + " " + updateUserData.MailAddress);

            var deleteCommand = new ApplicationService.UserDeleteCommand(defaultId);
            applicationService.Delete(deleteCommand);
            var deleteUserData = applicationService.Get(defaultId);
            Console.WriteLine(deleteUserData == null ? "Null" : "Not Null");

        }
    }
}
