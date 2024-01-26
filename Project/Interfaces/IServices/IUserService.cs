using Project.DTO.InternalDTO;
using Project.Models;

namespace Project.Interfaces.IServices
{
    public interface IUserService
    {
        public Task<GeneralResponseInternalDTO> AddUser(UserModel user);
    }
}
