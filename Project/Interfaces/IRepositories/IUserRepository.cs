using Project.DTO.InternalDTO;
using Project.Models;

namespace Project.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        public Task<GeneralResponseInternalDTO> AddUser(UserModel user);
        //public Task<GeneralResponseInternalDTO> DeleteUser(UserModel user);
    }
}
