using System;
namespace ddd.Dependencies
{
    public class UserUpdateCommand
    {
        public UserUpdateCommand(string id, string name = null, string mailAddress = null)
        {
            Id = id;
            Name = name;
            MailAddress = mailAddress;
        }

        public string Id { get; }
        public string Name { get; set; }
        public string MailAddress { get; set; }
    }
}
