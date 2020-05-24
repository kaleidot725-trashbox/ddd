using System;
namespace ddd.Dependencies
{
    public interface IUserDeleteService
    {
        public void Handle(UserDeleteCommand command);
    }
}
