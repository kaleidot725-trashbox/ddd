using System;
namespace ddd.Factory
{
    class UserRegisterService : IUserRegisterService
    {
        private readonly IUserRepository userRepository;
        private readonly UserDuplicatedChecker userDuplicatedChecker;

        public UserRegisterService(IUserRepository userRepository) {
            this.userRepository = userRepository;
            this.userDuplicatedChecker = new UserDuplicatedChecker(this.userRepository);
        }

        public void Handle(UserRegisterCommand command)
        {
            var user = new User(new UserId(command.Id), new Name(command.Name), new MailAddress(command.MailAddress));
            if (userDuplicatedChecker.Check(user))
            {
                throw new Exception("ユーザは既に存在しています。");
            }

            userRepository.Save(user);
        }
    }
}
