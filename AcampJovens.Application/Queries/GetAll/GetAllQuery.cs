using AcampJovens.Common.Models.ViewModels;
using MediatR;

namespace AcampJovens.Application.Queries.GetAll;

public class GetAllQuery : IRequest<List<CamperViewModel>>
{
    
}