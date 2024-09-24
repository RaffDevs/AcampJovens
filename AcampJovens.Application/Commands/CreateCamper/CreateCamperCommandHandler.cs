using AcampJovens.Core.Entities;
using AcampJovens.Core.Repositories;
using MediatR;

namespace AcampJovens.Application.Commands.CreateCamper;

public class CreateCamperCommandHandler : IRequestHandler<CreateCamperCommand>
{
    private readonly ICamperRepository _camperRepository;

    public CreateCamperCommandHandler(ICamperRepository camperRepository)
    {
        _camperRepository = camperRepository;
    }

    public async Task Handle(CreateCamperCommand request, CancellationToken cancellationToken)
    {
        var camper = new Camper(request.Model.FirstName, request.Model.LastName);
        await _camperRepository.CreateAsync(camper);
    }
}