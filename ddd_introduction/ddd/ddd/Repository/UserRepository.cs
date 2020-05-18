using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.Repository
{
    class UserRepository : IUserRepository
    {
        public void Save(User user)
        {
            Console.WriteLine("UserRepository Save");
        }

        public User Find(Name name) 
        {
            return null;
        }

        public bool Exists(User user)
        {
            return false;
        }
    }
}
