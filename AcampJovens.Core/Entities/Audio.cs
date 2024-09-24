namespace AcampJovens.Core.Entities;

public class Audio : BaseEntity
{
    public string AudioBase64 { get; private set; }
    public int MessageId { get; private set; }
    public Message Message { get; private set; }
    public Guid Guid { get; private set; }

    public Audio(string audioBase64, int messageId)
    {
        AudioBase64 = audioBase64;
        MessageId = messageId;
        Guid = Guid.NewGuid();
    }

    public void Update(string audioBase64)
    {
        AudioBase64 = audioBase64;
    }
}