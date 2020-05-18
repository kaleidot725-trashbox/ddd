using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.Repository
{
    interface IUserRepository
    {
        public void Save(User user);
        public User Find(Name name);
        public bool Exists(User user);
    }
}
