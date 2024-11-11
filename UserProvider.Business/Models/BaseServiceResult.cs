namespace UserProvider.Business.Models;

public abstract class BaseServiceResult
{
    public string? Message { get; set; }
    public bool Success { get; set; }
    public int StatusCode { get; set; }
}
