using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace ddd.Entity
{
    class User
    {
        public readonly UserId UserId;
        public Name Name;

        public User(UserId userId, Name name)
        {
            if (userId == null) throw new ArgumentNullException(nameof(userId));
            if (name == null) throw new ArgumentNullException(nameof(name));

            this.UserId = userId;
            this.Name = name;
        }

        public void ChangeName(Name name) 
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            this.Name = name;
        }

        public override string ToString()
        {
            return UserId + " " + Name;
        }
    }
}
