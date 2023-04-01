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
                _firstName = normalizeName(value);
            }
        }

        public string FamilyName
        {
            get => _familyName;
            set
            {
                _familyName = normalizeName(value);
            }
        }

        public int Age
        {
            get => _age;
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                _age = value;
            }
        }

        public Person(string firstName, string familyName, int age)
        {
            FirstName = firstName;
            FamilyName = familyName;
            Age = age;
        }

        public override string ToString() => $"{_firstName} {_familyName} ({_age})";

        private string normalizeName(string name)
        {
            if(name.Any(char.IsDigit) || String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Wrong name!");
            }

            string result = name.Trim().ToLower();
            return char.ToUpper(result[0]) + result.Substring(1);
        }
    }
}