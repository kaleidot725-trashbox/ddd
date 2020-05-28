using System;

namespace ddd.Application
{
    public class User
    {
        public readonly UserId UserId;
        public UserName Name;
        public MailAddress MailAddress;

        public User(UserId userId, UserName name, MailAddress mailAddress)
        {
            if (userId == null) throw new ArgumentNullException(nameof(userId));
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (mailAddress == null) throw new ArgumentNullException(nameof(mailAddress));

            this.UserId = userId;
            this.Name = name;
            this.MailAddress = mailAddress;
        }

        public void ChangeName(UserName name)
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
