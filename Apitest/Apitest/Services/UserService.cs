using Apitest.Repository;

namespace Apitest.Services
{
   
        public class UserService : IUserService
        {

            private readonly IUserRepository _userRepository;
            public UserService(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }
            public async Task<object> Getdata()
            {
                return await _userRepository.getApi();
            }
        }
    }

