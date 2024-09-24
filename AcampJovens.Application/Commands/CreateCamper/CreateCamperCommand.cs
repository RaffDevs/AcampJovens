using AcampJovens.Common.Models.InputModels;
using MediatR;

namespace AcampJovens.Application.Commands.CreateCamper;

public class CreateCamperCommand : IRequest
{
    public CreateCamperInputModel Model { get; set; }
}