using BRW.API.Context;
using BRW.API.Entities;
using BRW.API.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BRW.API.Service;

public class UsersService : IUserService
{
    private readonly BrwAppContext _context;

    public UsersService(BrwAppContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> GetUsers() => await _context.Users.ToListAsync();


    public async Task<User> GetUserById(int id) => await _context.Users.FindAsync(id);

    public async Task RegisterUser(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateUser(User userTarget, Guid id)
    {
        _context.Entry(userTarget).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

}