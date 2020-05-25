using System;
namespace ddd.Factory
{
    public class UserFactory : IUserFactory
    {
        public UserFactory() { }

        public User Create(Name name, MailAddress mailAddress)
        {
            var userId = new UserId(Guid.NewGuid().ToString());
            return new User(userId, name, mailAddress);
        }
    }
}
