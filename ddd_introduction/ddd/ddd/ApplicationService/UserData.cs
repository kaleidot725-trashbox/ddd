using System;
namespace ddd.ApplicationService
{
    class UserData
    {
        public UserData(User source)
        {
            Id = source.UserId.value;
            Name = source.UserId.value;
        }

        public string Id { get; }
        public string Name { get; }
    }
}
