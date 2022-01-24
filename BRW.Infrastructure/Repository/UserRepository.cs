using System.Diagnostics;
using BRW.Domain.Entities;
using BRW.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BRW.Infrastructure.Repository;

public class UserRepository
{
    private readonly BrwContext _context;
    private const string ErrorDbAccess = "Erro ao acessar o banco de dados";

    public UserRepository(BrwContext context)
    {
        _context = context;
    }
    
    public async Task<User> CreateUser(User user)
    {
        try
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
        catch (Exception e)
        {
            throw new Exception(message: ErrorDbAccess);
        }
    }

    public async Task<List<User>> GetAllUsers()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User?> UserByGuid(Guid guid)
    {
        return await _context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Guid == guid);
    }

    public async Task<User?> UserEmail(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }
    
    public async Task DatabaseSaveChanges()
    {
        await _context.SaveChangesAsync();
    }

    public async Task DeleteUser(User user)
    {
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
    }
}