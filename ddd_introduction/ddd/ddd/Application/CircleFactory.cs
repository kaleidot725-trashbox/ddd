using System;
using System.Collections.Generic;

namespace ddd.Application
{
    public class CircleFactory
    {
        public Circle Create(CircleName name, User owner)
        {
            var id = new CircleId(Guid.NewGuid().ToString());
            return new Circle(id, name, owner, new List<User>());
        }
    }
}
