namespace AcampJovens.Core.Entities;

public class Message : BaseEntity
{
    public string SenderName { get; private set; }
    public int CamperId { get; set; }
    
    public Camper Camper { get; private set; }
    public Audio AudioFile { get; private set; }


    public Message(string senderName, int camperId)
    {
        SenderName = senderName;
        CamperId = camperId;
    }

    public void Update(string senderName)
    {
        SenderName = senderName;
    }
}