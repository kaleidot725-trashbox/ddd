using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ddd.ApplicationService
{
    class UserRepository : IUserRepository
    {
        private IList<User> list = new List<User>();

        public void Save(User user)
        {
            var existUser = Find(user.UserId);
            if (existUser != null)
            {
                Delete(existUser);
            }

            list.Add(user);
            Console.WriteLine("UserRepository Save");
        }

        public void Delete(User user)
        {
            list.Remove(user);
            Console.WriteLine("UserRepository Delete");
        }

        public User Find(UserId id)
        {
            Console.WriteLine("UserRepository Find");
            return list.FirstOrDefault(it => it.UserId.Value == id.Value);
        }

        public User Find(MailAddress mailAddress) 
        {
            Console.WriteLine("UserRepository Find");
            return list.FirstOrDefault(it => it.MailAddress.Value == mailAddress.Value);
        }
    }
}
