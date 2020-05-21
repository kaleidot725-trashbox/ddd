using System;
namespace ddd.ApplicationService
{
    public interface IUserRegisterService
    {
        public void Handle(UserRegisterCommand command);
    }
}
