namespace AcampJovens.Common.Models.ViewModels;

public class AudioDetailsViewModel
{
    public Guid Guid { get; init; }
    public IEnumerable<byte> Audio { get; init; }
}