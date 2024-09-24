namespace AcampJovens.Common.Models.ViewModels;

public record CamperDetailsViewModel
{
    public int Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string FullName { get; init; }
}