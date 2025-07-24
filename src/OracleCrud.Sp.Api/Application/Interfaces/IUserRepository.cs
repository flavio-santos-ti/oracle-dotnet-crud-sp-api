using OracleCrud.Sp.Api.Domain.Dtos;

namespace OracleCrud.Sp.Api.Application.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<UserDto>> GetAllAsync();
    Task<string> InsertAsync(UserDto user);
    Task<string> UpdateAsync(UserDto user);
    Task<string> DeleteAsync(string id);
}
