using OracleCrud.Sp.Api.Domain.Dtos;

namespace OracleCrud.Sp.Api.Application.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserDto>> GetAllAsync();
    Task<string> InsertAsync(CreateUserDto user);
    Task<string> UpdateAsync(UserDto user);
    Task<string> DeleteAsync(string id);
}
