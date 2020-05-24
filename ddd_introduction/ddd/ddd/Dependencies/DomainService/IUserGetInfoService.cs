using System;
namespace ddd.Dependencies
{
    public interface IUserGetInfoService
    {
        public UserData Handle(String userId);
    }
}
