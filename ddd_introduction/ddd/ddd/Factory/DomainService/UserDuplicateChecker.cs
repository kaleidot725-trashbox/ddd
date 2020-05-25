using System;
namespace ddd.Factory
{
    class UserDuplicatedChecker
    {
        private readonly IUserRepository userRepository;

        public UserDuplicatedChecker(IUserRepository userRepository) {
            this.userRepository = userRepository;
        }

        public bool Check(User user)
        {
            return userRepository.Find(user.MailAddress) != null;
        }
    }
}
