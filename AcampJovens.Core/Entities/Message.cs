namespace AcampJovens.Core.Entities;

public class Message : BaseEntity
{
    public string ParentFullName { get; private set; }
    public string SonFullName { get; private set; }
    
    public Audio AudioFile { get; private set; }

    public Message(string parentFullName, string sonFullName)
    {
        ParentFullName = parentFullName;
        SonFullName = sonFullName;
    }
}