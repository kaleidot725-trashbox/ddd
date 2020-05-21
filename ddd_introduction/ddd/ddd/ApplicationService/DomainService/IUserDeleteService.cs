using System;
namespace ddd.ApplicationService
{
    public interface IUserDeleteService
    {
        public void Handle(UserDeleteCommand command);
    }
}
