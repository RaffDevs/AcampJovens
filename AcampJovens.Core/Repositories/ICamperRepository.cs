using AcampJovens.Core.Entities;

namespace AcampJovens.Core.Repositories;

public interface ICamperRepository
{
    Task<Camper?> GetByIdAsync(int id);

    Task<List<Camper>> GetAllAsync();
    Task<Camper> CreateAsync(Camper camper);
    Task UpdateAsync(Camper camper);
    Task DeleteAsync(Camper camper);
}