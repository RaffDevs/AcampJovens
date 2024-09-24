using AcampJovens.Core.Entities;
using AcampJovens.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AcampJovens.Infrastructure.Repositories;

public class AudioRepository : IAudioRepository
{
    private readonly AcampJovensDbContext _context;

    public AudioRepository(AcampJovensDbContext context)
    {
        _context = context;
    }

    public async Task<Audio?> GetByIdAsync(int id)
    {
        return await _context.Audios.FindAsync(id);
    }

    public async Task<Audio> CreateAsync(Audio audio)
    {
        var result = await _context.Audios.AddAsync(audio);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task UpdateAsync(Audio audio)
    {
        _context.Audios.Update(audio);
        await _context.SaveChangesAsync();

    }

    public async Task DeleteAsync(Audio audio)
    {
        _context.Audios.Remove(audio);
        await _context.SaveChangesAsync();
    }
}