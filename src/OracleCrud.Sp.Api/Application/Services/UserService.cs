using OracleCrud.Sp.Api.Application.Interfaces;
using OracleCrud.Sp.Api.Domain.Dtos;
using FDS.NetCore.ObjectMapping.Extensions;

namespace OracleCrud.Sp.Api.Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _repository;

    public UserService(IUserRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<UserDto>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<string> InsertAsync(CreateUserDto user)
    {
        var userDto = user
            .MapTo<UserDto>()
            .Apply(t => t.Id = Guid.NewGuid().ToString());

        return await _repository.InsertAsync(userDto);
    }

    public async Task<string> UpdateAsync(UserDto user)
    {
        return await _repository.UpdateAsync(user);
    }

    public async Task<string> DeleteAsync(string id)
    {
        return await _repository.DeleteAsync(id);
    }
}
