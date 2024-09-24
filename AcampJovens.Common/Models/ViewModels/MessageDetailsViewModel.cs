namespace AcampJovens.Common.Models.ViewModels;

public record MessageDetailsViewModel
{
    public int Id { get; init; }
    public string SenderName { get; init; }
    public int CamperId { get; init; }
    public int AudioId { get; init; }
}