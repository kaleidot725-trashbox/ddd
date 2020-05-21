using System;

namespace ddd.ApplicationService
{
    class UserApplicationService
    {
        private readonly IUserGetInfoService userGetInfoService;
        private readonly IUserRegisterService userRegisterService;
        private readonly IUserDeleteService userDeleteService;
        private readonly IUserUpdateService userUpdateService;

        public UserApplicationService(
            IUserGetInfoService userGetInfoService,
            IUserRegisterService userRegisterService,
            IUserDeleteService userDeleteService,
            IUserUpdateService userUpdateService)
        {
            this.userGetInfoService = userGetInfoService;
            this.userRegisterService = userRegisterService;
            this.userDeleteService = userDeleteService;
            this.userUpdateService = userUpdateService;
        }

        public UserData Get(String userId)
        {
            return userGetInfoService.Handle(userId);
        }

        public void Register(UserRegisterCommand command) 
	    {
            this.userRegisterService.Handle(command);
	    }

        public void Delete(UserDeleteCommand command)
        {
            this.userDeleteService.Handle(command);

        }

        public void Update(UserUpdateCommand command)
        {
            this.userUpdateService.Handle(command);
        }
    }
}
