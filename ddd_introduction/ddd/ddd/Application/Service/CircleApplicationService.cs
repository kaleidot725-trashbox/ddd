using System;
namespace ddd.Application
{
    public class CircleApplicationService
    {
        private readonly ICircleFactory circleFactory;
        private readonly ICircleRepository circleRepository;
        private readonly CircleService circleService;
        private readonly IUserRepository userRepository;

        public CircleApplicationService(
            ICircleFactory circleFactory,
            ICircleRepository circleRepository,
            CircleService circleService,
            IUserRepository userRepository)
        {
            this.circleFactory = circleFactory;
            this.circleRepository = circleRepository;
            this.circleService = circleService;
            this.userRepository = userRepository;
        }

        public void Create(CircleCreateCommand command)
        {
            var ownerId = new UserId(command.UserId);
            var owner = userRepository.Find(ownerId);
            if (owner == null)
            {
                throw new Exception("サークルオーナーとなるユーザーが見つかりませんでした。");
            }

            var name = new CircleName(command.Name);
            var circle = circleFactory.Create(name, owner);
            if (circleService.Exists(circle))
            {
                throw new Exception("サークルは既に存在しています。");
            }

            circleRepository.Save(circle);
        }

        public void Join(CircleJoinCommand command)
        {
            var memberId = new UserId(command.UserId);
            var member = userRepository.Find(memberId);
            if (member == null)
            {
                throw new Exception("ユーザーが見つかりませんでした。");
            }

            var id = new CircleId(command.CircleId);
            var circle = circleRepository.Find(id);
            if (circle == null)
            {
                throw new Exception("サークルが見つかりませんでした。");
            }

            // FIXME ここの人数制限があとあと面倒になる、例えば Invite という関数をこのクラスに増やしたときには、このコードをコピペすることになり管理が面倒になってしまう。
            if (circle.Members.Count >= 29)
            {
                throw new Exception(id.ToString());
            }

            circle.Members.Add(member);
            circleRepository.Save(circle);
        }
    }
}
