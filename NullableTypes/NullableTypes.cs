namespace CSharp8Features.NullableTypes
{
    public static class NullableTypes
    {
        public static void Run()
        {
            var p1 = new PersonV1("Fred", "Flintstone");
            GetMiddleNameLength(p1);

            var p2 = new PersonV2("Barney", "Rubble");
            GetMiddleNameLength(p2);
        }

        // This works, but will fail
        public static int GetMiddleNameLength(PersonV1 p) => p.MiddleName.Length;

        // Compiler knows this can be null and will force us to do extra checking
        public static int GetMiddleNameLength(PersonV2 p) => p.MiddleName?.Length ?? 0;
    }
}
