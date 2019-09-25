namespace CSharp8Features.NullableTypes
{
    /// <summary>
    /// Non-Nullable Person
    /// </summary>
    public class PersonV2
    {
        public string FirstName { get; set; }

        // As this is not initialised we will get a warning if we don't use the nullable operator (?)
        public string? MiddleName { get; set; }

        public string LastName { get; set; }

        public PersonV2(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
