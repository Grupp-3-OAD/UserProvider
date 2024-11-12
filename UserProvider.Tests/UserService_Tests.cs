using Moq;
using UserProvider.Business.Interfaces;
using UserProvider.Business.Models;
using UserProvider.Business.Services;

namespace UserProvider.Tests;

public class UserService_Tests
{
    private readonly IUserValidator _userValidator;
    private readonly IUserService _userService;
    private readonly Mock<IUserRepository> _mockUserRepository;

    public UserService_Tests()
    {
        _userValidator = new UserValidator();
        _mockUserRepository = new Mock<IUserRepository>();
        _userService = new UserService(_userValidator, _mockUserRepository.Object);
    }

    [Fact]
    public void CreateUser_ShouldCreateUser_ReturnSuccess()
    {
        //Arrange
        var userRequest = new UserRequest { FirstName = "Kaspar", LastName = "Johansson", Email = "kaspar.johansson@domain.com", Password = "bytmig123" };
        var repositoryResult = new UserRepositoryResult { Success = true };

        _mockUserRepository.Setup(x => x.Save(It.IsAny<UserEntity>())).Returns(repositoryResult);

        //Act
        var result = _userService.CreateUser(userRequest);

        //Assert
        Assert.True(result.Success);
    }

    //Skrivet med hjälp av Chatgtp
    [Fact]
    public void UpdateUserEmail_ShouldUpdateUserEmail_ReturnUpdatedUSer()
    {
        // Arrange
        var mockValidator = new Mock<IUserValidator>();
        var mockRepository = new Mock<IUserRepository>();

        var userService = new UserService(mockValidator.Object, mockRepository.Object);

        var user = new User { UserId = "1", FirstName = "Kaspar", LastName = "Johansson", Email = "kaspar.johansson@domain.com" };

        mockRepository.Setup(x => x.GetOneUser(user.UserId)).Returns(user);

        // Act
        userService.UpdateUserEmail(user.UserId, "kaspar.wale@gmail.com");

        // Assert
        var updatedUser = mockRepository.Object.GetOneUser(user.UserId);
        Assert.NotNull(updatedUser);
        Assert.Equal("kaspar.wale@gmail.com", updatedUser.Email);
    }

    //Skrivet med hjälp av Chatgtp
    [Fact]
    public void ContinueAsGuest_UserRedirectedToGuestHomePage_WithGuestAccess()  
    {
        // Arrange
        var navigationServiceMock = new Mock<INavigationService>();
        var accessServiceMock = new Mock<IAccessService>();

        var guestService = new GuestService(navigationServiceMock.Object, accessServiceMock.Object);

        // Act
        guestService.ContinueAsGuest();

        // Assert
        accessServiceMock.Verify(access => access.SetGuestAccess(), Times.Once);
        navigationServiceMock.Verify(nav => nav.RedirectTo("GuestHomePage"), Times.Once);


    }


}
