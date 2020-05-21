using System;
namespace ddd.ApplicationService
{
    public class UserDeleteCommand
    {
        public UserDeleteCommand(string id)
        {
            this.Id = id;
        }

        public string Id { get; }
    }
}
