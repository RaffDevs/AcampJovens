using AcampJovens.Core.Entities;
using AcampJovens.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AcampJovens.Infrastructure.Repositories;

public class MessageRepository : IMessageRepository
{
    private readonly AcampJovensDbContext _context;

    public MessageRepository(AcampJovensDbContext context)
    {
        _context = context;
    }

    public async Task<Message?> GetByIdAsync(int id)
    {
        return await _context.Messages.FindAsync(id);
    }

    public async Task<List<Message>> GetAllAsync()
    {
        return await _context.Messages.ToListAsync();
    }

    public async Task<Message> CreateAsync(Message message)
    {
        var result = await _context.Messages.AddAsync(message);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task UpdateAsync(Message message)
    {
         _context.Messages.Update(message);
         await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Message message)
    {
        _context.Messages.Remove(message);
        await _context.SaveChangesAsync();
    }
}