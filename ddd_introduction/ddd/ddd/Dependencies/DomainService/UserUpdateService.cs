using System;
namespace ddd.Dependencies
{
    class UserUpdateService : IUserUpdateService
    {
        private readonly IUserRepository userRepository;

        public UserUpdateService(IUserRepository userRepository) {
            this.userRepository = userRepository;
        }

        public void Handle(UserUpdateCommand command)
        {
            var user = userRepository.Find(new UserId(command.Id));
            if (user == null)
            {
                throw new Exception("ユーザーは存在しません。");
            }


            if (command.Name != null)
            {
                user.ChangeName(new Name(command.Name));
            }

            if (command.MailAddress != null)
            {
                user.ChangeMailAddress(new MailAddress(command.MailAddress));
            }

            userRepository.Save(user);
        }
    }
}
