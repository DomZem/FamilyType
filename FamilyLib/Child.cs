namespace FamilyLib
{
    public class Child : Person
    {
        private int _age;

        public Person Mother { get; init; }

        public Person Father { get; init; }

        public new int Age 
        {
            get => _age;
            set
            {
                if(value <= 0 || value >= 15)
                {
                    throw new ArgumentException("Child’s age must be less than 15!");
                }
                _age = value;   
            }
        }

        public Child(string firstName, string familyName, int age, Person mother = null, Person father = null): base(firstName, familyName, age)
        {
            Mother = mother;
            Father = father;
            Age = age;
        }

        public override string ToString() => $"{base.ToString()} \nmother: {(Mother != null ? Mother.ToString() : "No data")} \nfather: {(Father != null ? Father.ToString() : "No data")}";
    }
}
