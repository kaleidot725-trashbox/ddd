using System;
namespace ddd.Dependencies.locator
{
    public class ObjectA
    {
        private readonly ObjectB objectB;

        public ObjectA()
        {
            this.objectB = ServiceLocator.Resolve();
        }
    }
}
