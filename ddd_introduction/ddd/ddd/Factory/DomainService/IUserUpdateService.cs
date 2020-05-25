using System;
namespace ddd.Factory
{
    public interface IUserUpdateService
    {
        public void Handle(UserUpdateCommand command);
    }
}
