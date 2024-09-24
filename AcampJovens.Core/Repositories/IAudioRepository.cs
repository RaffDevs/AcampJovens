using AcampJovens.Core.Entities;

namespace AcampJovens.Core.Repositories;

public interface IAudioRepository
{
    Task<Audio?> GetByIdAsync(int id);
    Task<Audio> CreateAsync(Audio audio);
    Task UpdateAsync( Audio audio);
    Task DeleteAsync(Audio audio);
}