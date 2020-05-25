using System;
namespace ddd.ApplicationService
{
    public class UserRegisterCommand
    {
        public UserRegisterCommand(string id, string name, string mailAddress)
        {
            this.Id = id;
            this.Name = name;
            this.MailAddress = mailAddress;
        }

        public string Id { get; }
        public string Name { get; set; }
        public string MailAddress { get; set; }
    }
}
