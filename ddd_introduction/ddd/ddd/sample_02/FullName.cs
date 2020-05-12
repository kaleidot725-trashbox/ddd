using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ddd.sample_02
{
    class FullName
    {
        public readonly Name FirstName;
        public readonly Name MiddleName;
        public readonly Name LastName;


        public FullName(Name firstName, Name middleName, Name lastName)
        {
            if (firstName == null) throw new ArgumentNullException(nameof(firstName));
            if (middleName == null) throw new ArgumentNullException(nameof(middleName));
            if (lastName == null) throw new ArgumentNullException(nameof(lastName));

            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }


        private bool Equals(FullName other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(FirstName, other.FirstName) && string.Equals(LastName, other.LastName) && string.Equals(MiddleName, other.MiddleName);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((FullName)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((FirstName != null ? FirstName.GetHashCode() : 0) * 397) ^ (LastName != null ? LastName.GetHashCode() : 0);
            }
        }

        public override string ToString()
        {
            return FirstName + " " + MiddleName + " " + LastName;
        }
    }
}
