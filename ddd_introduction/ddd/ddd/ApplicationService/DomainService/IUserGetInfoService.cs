using System;
namespace ddd.ApplicationService
{
    public interface IUserGetInfoService
    {
        public UserData Handle(String userId);
    }
}
