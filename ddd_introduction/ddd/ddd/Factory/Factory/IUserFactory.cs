using System;
namespace ddd.Factory
{
    interface IUserFactory
    {
        public User Create(Name name, MailAddress address);
    }
}
