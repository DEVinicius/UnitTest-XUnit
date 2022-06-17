using CloudCostumers.API.Models;
using CloudCostumers.API.Services.Interface;

namespace CloudCostumers.API.Services.Implementation;

public class UserService : IUserService
{
    private readonly HttpClient _httpClient;

    public UserService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public Task<List<User>> GetAllUsers()
    {
        throw new NotImplementedException();
    }
}