using AcampJovens.Core.Entities;

namespace AcampJovens.Core.Repositories;

public interface IMessageRepository
{
    Task<Message> GetByIdAsync(int id);
    Task<List<Message>> GetAllAsync();
    Task<Message> CreateAsync(Message message);
    Task UpdateAsync(Message message);
    Task DeleteAsync(Message message);
}