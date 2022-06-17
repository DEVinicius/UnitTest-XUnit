using CloudCostumers.API.Models;

namespace CloudCostumers.API.Services.Interface;

public interface IUserService
{
    public Task<List<User>> GetAllUsers();
}