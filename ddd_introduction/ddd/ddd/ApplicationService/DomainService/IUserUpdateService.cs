using System;
namespace ddd.ApplicationService
{
    public interface IUserUpdateService
    {
        public void Handle(UserUpdateCommand command);
    }
}
