using System;
namespace ddd.Dependencies
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
