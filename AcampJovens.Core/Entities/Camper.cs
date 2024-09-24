namespace AcampJovens.Core.Entities;

public class Camper : BaseEntity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Message? Message { get; private set; }

    public Camper(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void Update(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FullName => string.Concat(FirstName, " ", LastName);
}