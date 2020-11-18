using Primeiro.Data.VO;
using Primeiro.Model;

namespace Primeiro.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
    }
}
