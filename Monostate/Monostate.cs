namespace Monostate.Monostate
{
    class Monostate
    {
        private static string _FirstName;
        private static string _LastName;
        private static int _Age;

        public string FirstName
        {
            get => _FirstName;
            set => _FirstName = value;
        }

        public string LastName
        {
            get => _LastName;
            set => _LastName = value;
        }

        public int Age
        {
            get => _Age;
            set => _Age = value;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, Lastname: {LastName}, Age: {Age}";
        }
    }
}