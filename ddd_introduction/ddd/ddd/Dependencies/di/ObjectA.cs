using System;
namespace ddd.Dependencies.di
{
    public class ObjectA
    {
        private readonly ObjectB objectB;

        public ObjectA(ObjectB objectB)
        {
            this.objectB = objectB;
        }
    }
}
