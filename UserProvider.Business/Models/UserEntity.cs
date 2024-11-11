namespace UserProvider.Business.Models;

public class UserEntity : User
{
    
    public string Password { get; set; } = null!;
    public DateTime Created { get; set; }
}
