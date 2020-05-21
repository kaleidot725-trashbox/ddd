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
            return list.FirstOrDefault(it => it.UserId.value == id.value);
        }

        public User Find(Name name) 
        {
            Console.WriteLine("UserRepository Find");
            return list.FirstOrDefault(it => it.Name.Value == name.Value);
        }

        public bool Exists(User user)
        {
            Console.WriteLine("UserRepository Exists");
            return list.Any(it => it.UserId.value == user.UserId.value);
        }
    }
}
