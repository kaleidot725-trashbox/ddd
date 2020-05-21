using System;
namespace ddd.ApplicationService
{
    class UserData
    {
        public string Id { get; }
        public string Name { get; }
        public string MailAddress { get; }

        public UserData(User source)
        {
            Id = source.UserId.Value;
            Name = source.Name.Value;
            MailAddress = source.MailAddress.Value;
        }
    }
}
