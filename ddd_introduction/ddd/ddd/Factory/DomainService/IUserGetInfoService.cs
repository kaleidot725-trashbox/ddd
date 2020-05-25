using System;
namespace ddd.Factory
{
    public interface IUserGetInfoService
    {
        public UserData Handle(String userId);
    }
}
