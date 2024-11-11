﻿namespace UserProvider.Business.Models;

public class User
{
    public string? UserId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;

}