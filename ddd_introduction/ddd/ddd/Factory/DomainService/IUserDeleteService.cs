using System;
namespace ddd.Factory
{
    public interface IUserDeleteService
    {
        public void Handle(UserDeleteCommand command);
    }
}
