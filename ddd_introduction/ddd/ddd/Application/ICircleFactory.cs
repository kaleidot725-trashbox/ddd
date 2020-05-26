using System;
namespace ddd.Application
{
    public interface ICircleFactory
    {
        Circle Create(CircleName name, User owner);
    }
}
