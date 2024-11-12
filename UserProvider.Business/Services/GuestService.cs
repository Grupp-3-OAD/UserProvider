using UserProvider.Business.Interfaces;

namespace UserProvider.Business.Services
{
    public class GuestService
    {
        private readonly INavigationService _navigationService;
        private readonly IAccessService _accessService;

        public GuestService(INavigationService navigationService, IAccessService accessService)
        {
            _navigationService = navigationService;
            _accessService = accessService;
        }

        public void ContinueAsGuest()
        {
            _accessService.SetGuestAccess();
            _navigationService.RedirectTo("GuestHomePage");
        }
    }
}
