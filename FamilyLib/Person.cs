namespace FamilyLib
{
    public class Person
    {
        private string _firstName;
        private string _familyName;
        private int _age;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = normalizeString(value);
            }
        }

        public string FamilyName
        {
            get => _familyName;
            set
            {
                _familyName = normalizeString(value);
            }
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public Person(string firstName, string familyName, int age)
        {
            FirstName = firstName;
            FamilyName = familyName;
            Age = age;
        }

        public override string ToString() => $"{_firstName} {_familyName} ({_age})";

        private string normalizeString(string value)
        {
            string result = value.Trim().ToLower();
            return char.ToUpper(result[0]) + result.Substring(1);
        }
    }
}