using AcampJovens.Common.Models.ViewModels;
using AcampJovens.Core.Repositories;
using MediatR;

namespace AcampJovens.Application.Queries.GetAll;

public class GetAllQueryHandler : IRequestHandler<GetAllQuery, List<CamperViewModel>>
{
    private readonly ICamperRepository _camperRepository;

    public GetAllQueryHandler(ICamperRepository camperRepository)
    {
        _camperRepository = camperRepository;
    }

    public async Task<List<CamperViewModel>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var result = await _camperRepository.GetAllAsync();

        if (!result.Any())
        {
            return [];
        }

        return result
            .Select(c => new CamperViewModel { Id = c.Id, FirstName = c.FirstName, LastName = c.LastName })
            .ToList();
    }
}