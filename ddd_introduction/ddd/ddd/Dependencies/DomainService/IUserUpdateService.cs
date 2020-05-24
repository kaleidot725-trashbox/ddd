using System;
namespace ddd.Dependencies
{
    public interface IUserUpdateService
    {
        public void Handle(UserUpdateCommand command);
    }
}
