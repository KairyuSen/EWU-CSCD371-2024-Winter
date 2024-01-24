namespace ClassDemo;

public class Person
{
    public Person(string firstName)
    {
        FirstName = firstName;
    }
    private string _firstName; //Never access this field except from within the
                               //implementation of the get and set methods.

    public string FirstName
    {
        get => _firstName!;
        set
        {
            _firstName = value ?? throw new ArgumentNullException(nameof(value));
        }
    }

    public string LastName { get; set; }

    public void SetName(string? temp)
    {
        _firstName = null; // Wrong
        FirstName = null; // Right
    }
}