using System;
namespace ddd.Application
{
    public class CircleCreateCommand
    {
        public CircleCreateCommand(string userId, string name)
        {
            this.UserId = userId;
            this.Name = name;
        }

        public string UserId { get; }
        public string Name { get; }
    }
}
