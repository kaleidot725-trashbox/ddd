using System;
namespace ddd.ApplicationService
{
    class UserApplicationService
    {
        private readonly IUserRepository userRepository;
        private readonly UserService userService;

        public UserApplicationService(IUserRepository userRepository, UserService userService)
        {
            this.userRepository = userRepository;
            this.userService = userService;
        }

        public UserData Get(String userId)
        {
            var targetId = new UserId(userId);
            var user = userRepository.Find(targetId);

            if (user == null)
            {
                return null;
            }

            return new UserData(user);
        }

        public void Register(String userId, String name) 
	    {
            var user = new User(new UserId(userId), new Name(name));
            if (userService.Exists(user)) 
	        {
                throw new CanNotRegisterUserException(userId, "ユーザは既に存在しています。");
	        }

            userRepository.Save(user);
	    }
    }
}
