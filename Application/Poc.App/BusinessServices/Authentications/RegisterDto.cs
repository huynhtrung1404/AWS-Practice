namespace Poc.App.BusinessServices.Authentications;

public class RegisterDto
{
    public string? UserName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public int Age { get; set; }
    public string? Address { get; set; }
}