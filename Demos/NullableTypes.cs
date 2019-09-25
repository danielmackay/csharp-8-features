// Enable at the project level by adding<nullable> enabled</nullable> to your .csproj file
//
// Disable at the file level by using `#nullable disable`

namespace CSharp8Features.Demos
{
    public static class NullableTypes
    {
        public static void Demo()
        {
            var p1 = new PersonV1("Fred", "Flintstone");
            GetMiddleNameLength(p1);

            var p2 = new PersonV2("Barney", "Rubble");
            GetMiddleNameLength(p2);

            Weapon cantBeNull;
            Weapon? canBeNull;

            canBeNull = null;

            // Note the compiler warning
            cantBeNull = null;

            canBeNull = new Weapon();
            cantBeNull = new Weapon();

            canBeNull.Repair();
            cantBeNull.Repair();
        }

        // This works, but will fail
        public static int GetMiddleNameLength(PersonV1 p) => p.MiddleName.Length;

        // Compiler knows this can be null and will force us to do extra checking
        public static int GetMiddleNameLength(PersonV2 p) => p.MiddleName?.Length ?? 0;
    }

#nullable disable
    /// <summary>
    /// Unsafe Nullable Person
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
#nullable enable

    /// <summary>
    /// Safe Nullable Person
    /// </summary>
    public class PersonV2
    {
        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string LastName { get; set; }

        public PersonV2(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Weapon
    {
        public void Repair() { }
    }

}
