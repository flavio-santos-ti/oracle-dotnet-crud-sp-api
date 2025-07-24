using Oracle.ManagedDataAccess.Client;
using OracleCrud.Sp.Api.Application.Interfaces;
using OracleCrud.Sp.Api.Domain.Dtos;
using System.Data;

namespace OracleCrud.Sp.Api.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly string _connectionString;

    public UserRepository(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("OracleDb")!;
    }

    public async Task<IEnumerable<UserDto>> GetAllAsync()
    {
        var users = new List<UserDto>();

        using var connection = new OracleConnection(_connectionString);
        using var command = new OracleCommand("SELECT id, name, email FROM vw_users", connection);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            users.Add(new UserDto
            {
                Id = reader.GetString(0),
                Name = reader.GetString(1),
                Email = reader.GetString(2)
            });
        }

        return users;
    }

    public async Task<string> InsertAsync(UserDto user)
    {
        using var connection = new OracleConnection(_connectionString);
        using var command = new OracleCommand("app_user.sp_insert_user", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add("p_id", OracleDbType.Varchar2).Value = user.Id;
        command.Parameters.Add("p_name", OracleDbType.Varchar2).Value = user.Name;
        command.Parameters.Add("p_email", OracleDbType.Varchar2).Value = user.Email;

        var resultParam = new OracleParameter("p_result", OracleDbType.Varchar2, 4000)
        {
            Direction = ParameterDirection.Output
        };
        command.Parameters.Add(resultParam);

        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();

        return resultParam.Value?.ToString() ?? "Erro ao inserir usuário.";
    }

    public async Task<string> UpdateAsync(UserDto user)
    {
        using var connection = new OracleConnection(_connectionString);
        using var command = new OracleCommand("app_user.sp_update_user", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add("p_id", OracleDbType.Varchar2).Value = user.Id;
        command.Parameters.Add("p_name", OracleDbType.Varchar2).Value = user.Name;
        command.Parameters.Add("p_email", OracleDbType.Varchar2).Value = user.Email;

        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();

        return "Usuário atualizado com sucesso.";
    }

    public async Task<string> DeleteAsync(string id)
    {
        using var connection = new OracleConnection(_connectionString);
        using var command = new OracleCommand("app_user.sp_delete_user", connection)
        {
            CommandType = CommandType.StoredProcedure
        };

        command.Parameters.Add("p_id", OracleDbType.Varchar2).Value = id;

        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();

        return "Usuário excluído com sucesso.";
    }
}
