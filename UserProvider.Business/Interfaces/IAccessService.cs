namespace UserProvider.Business.Interfaces;

public interface IAccessService
{
    bool IsUserLoggedIn { get; }
    void SetGuestAccess();
}

