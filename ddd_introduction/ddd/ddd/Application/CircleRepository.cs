using System;
using System.Collections.Generic;
using System.Linq;

namespace ddd.Application
{
    public class CircleRepository : ICircleRepository
    {
        private List<Circle> circles = new List<Circle>();

        public CircleRepository()
        {
        }

        public Circle Find(CircleId id)
        {
            return circles.First(it => it.Id.Equals(id));
        }

        public Circle Find(CircleName name)
        {
            return circles.First(it => it.Name.Equals(name));
        }

        public void Save(Circle circle)
        {
            var delete = this.Find(circle.Id);
            if (delete != null)
            {
                circles.Remove(delete);
            }

            circles.Add(circle);
        }
    }
}
