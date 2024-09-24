using AcampJovens.Common.Models.ViewModels;
using MediatR;

namespace AcampJovens.Application.Queries.GetById;

public class GetByIdQuery : IRequest<CamperDetailsViewModel>
{
    public int Id { get; set; }
}