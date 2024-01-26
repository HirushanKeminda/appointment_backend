using Project.DTO.InternalDTO;
using Project.Interfaces.IRepositories;
using Project.Interfaces.IServices;
using Project.Models;

namespace Project.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
               _userRepository = userRepository;
        }
        public async Task<GeneralResponseInternalDTO> AddUser(UserModel user)
        {
            try
            {
                var result= await _userRepository.AddUser(user);
                return result;
            }
            catch (Exception ex)
            {
                var response = new GeneralResponseInternalDTO(false, ex.Message);
                return response;
            }
        }
    }
}
