using BRW.API.Entities;

namespace BRW.API.Service.Interfaces;

public interface IUserService
{

    public Task<IEnumerable<User>> GetUsers(); 

    public Task<User> GetUserById(int id);


    public Task RegisterUser(User user);
    public Task UpdateUser(User userTarget, Guid id);

}