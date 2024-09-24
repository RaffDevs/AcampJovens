using AcampJovens.Core.Entities;
using AcampJovens.Core.Repositories;

namespace AcampJovens.Infrastructure.Repositories;

public class CamperRepository : ICamperRepository
{
    private readonly AcampJovensDbContext _context;

    public CamperRepository(AcampJovensDbContext context)
    {
        _context = context;
    }

    public async Task<Camper?> GetByIdAsync(int id)
    {
        return await _context.Campers.FindAsync(id);
    }

    public async Task<Camper> CreateAsync(Camper camper)
    {
        var result = await _context.Campers.AddAsync(camper);
        await _context.SaveChangesAsync();
        return result.Entity;
    }
    

    public async Task UpdateAsync(Camper camper)
    {
         _context.Campers.Update(camper);
         await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Camper camper)
    {
        _context.Remove(camper);
        await _context.SaveChangesAsync();
    }
}