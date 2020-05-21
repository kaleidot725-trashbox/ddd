using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace ddd.ApplicationService
{
    class User
    {
        public readonly UserId UserId;
        public Name Name;
        public MailAddress MailAddress;

        public User(UserId userId, Name name, MailAddress mailAddress)
        {
            if (userId == null) throw new ArgumentNullException(nameof(userId));
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (mailAddress == null) throw new ArgumentNullException(nameof(mailAddress));

            this.UserId = userId;
            this.Name = name;
            this.MailAddress = mailAddress;
        }

        public void ChangeName(Name name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            this.Name = name;
        }

        public void ChangeMailAddress(MailAddress mailAddress)
        {
            if (mailAddress == null) throw new ArgumentNullException(nameof(mailAddress));
            this.MailAddress = mailAddress;
        }

        public override string ToString()
        {
            return UserId + " " + Name;
        }
    }
}
