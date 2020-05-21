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

        public void Update(UserUpdateCommand command)
        {
            var targetId = new UserId(command.Id);
            var user = userRepository.Find(targetId);

            if (user == null)
            {
                throw new Exception("ユーザーは存在しません。");
            }


            if (command.Name != null)
            {
                var newUserName = new Name(command.Name);
                user.ChangeName(newUserName);
            }

            if (command.MailAddress != null)
            {
                var newMailAddress = new MailAddress(command.MailAddress);
                user.ChangeMailAddress(newMailAddress);
            }

            userRepository.Save(user);
        }

        public void Register(String userId, String name, String mailAddress) 
	    {
            var user = new User(new UserId(userId), new Name(name), new MailAddress(mailAddress));
            if (userService.Exists(user)) 
	        {
                throw new Exception("ユーザは既に存在しています。");
	        }

            userRepository.Save(user);
	    }
    }
}
