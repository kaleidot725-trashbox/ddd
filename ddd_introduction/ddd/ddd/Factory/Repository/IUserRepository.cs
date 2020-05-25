﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ddd.Factory
{
    interface IUserRepository
    {
        public void Save(User user);
        public void Delete(User user);
        public User Find(UserId id);
        public User Find(MailAddress mailAddress);
    }
}
