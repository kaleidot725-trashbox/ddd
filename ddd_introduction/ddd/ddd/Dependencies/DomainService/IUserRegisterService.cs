using System;
namespace ddd.Dependencies
{
    public interface IUserRegisterService
    {
        public void Handle(UserRegisterCommand command);
    }
}
