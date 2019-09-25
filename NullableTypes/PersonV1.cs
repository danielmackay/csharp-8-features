#nullable disable
namespace CSharp8Features.NullableTypes
{
    /// <summary>
    /// Nullable Person
    /// </summary>
    public class PersonV1
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public PersonV1(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
