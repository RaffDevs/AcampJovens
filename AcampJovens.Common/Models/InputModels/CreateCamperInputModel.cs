namespace AcampJovens.Common.Models.InputModels;

public record CreateCamperInputModel
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
}