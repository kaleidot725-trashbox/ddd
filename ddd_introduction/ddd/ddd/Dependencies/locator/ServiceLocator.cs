using System;
namespace ddd.Dependencies.locator
{
    public static class ServiceLocator
    {
        public static ObjectB Resolve() {
            return new ObjectB();
        }
    }
}
