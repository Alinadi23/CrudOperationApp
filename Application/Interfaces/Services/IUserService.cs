using Application.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<List<UserVM>> GetAllUser();
        Task Create(UserVM user);
        Task Update(UserVM user);
        Task Delete(int id);
    }
}
