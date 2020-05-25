using System;
namespace ddd.Factory
{
    class UserGetInfoService : IUserGetInfoService
    {
        private readonly IUserRepository userRepository;

        public UserGetInfoService(IUserRepository userRepository) {
            this.userRepository = userRepository;
        }

        public UserData Handle(String userId)
        {
            var user = userRepository.Find(new UserId(userId));
            if (user == null)
            {
                return null;
            }

            return new UserData(user);
        }
    }
}
