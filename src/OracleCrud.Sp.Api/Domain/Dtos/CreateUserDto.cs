namespace OracleCrud.Sp.Api.Domain.Dtos;

public class CreateUserDto
{
    public string Name { get; set; } = default!;
    public string Email { get; set; } = default!;
}
