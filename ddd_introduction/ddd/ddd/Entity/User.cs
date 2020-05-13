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

        public void changeName(Name name) 
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            this.Name = name;
        }


        private bool Equals(User other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return (this.UserId.value == other.UserId.value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((User)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0));
            }
        }

        public override string ToString()
        {
            return UserId + " " + Name;
        }
    }
}
