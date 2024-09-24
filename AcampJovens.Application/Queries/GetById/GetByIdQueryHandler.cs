using AcampJovens.Common.Models.ViewModels;
using AcampJovens.Core.Repositories;
using MediatR;

namespace AcampJovens.Application.Queries.GetById;

public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, CamperDetailsViewModel>
{
    private readonly ICamperRepository _camperRepository;

    public GetByIdQueryHandler(ICamperRepository camperRepository)
    {
        _camperRepository = camperRepository;
    }

    public async Task<CamperDetailsViewModel> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _camperRepository.GetByIdAsync(request.Id);

        if (result is null)
        {
            throw new NotImplementedException();
        }

        return new CamperDetailsViewModel
        {
            Id = result.Id,
            FirstName = result.FirstName,
            LastName = result.LastName,
            FullName = result.FullName
        };
    }
}