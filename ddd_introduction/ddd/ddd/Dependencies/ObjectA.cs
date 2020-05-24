using System;
namespace ddd.Dependencies
{
    public class ObjectA
    {
        private ObjectB objectB;

        public ObjectA(ObjectB objectB)
        {
            this.objectB = objectB;
        }
    }
}
