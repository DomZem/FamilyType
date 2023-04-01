using FamilyLib;

namespace FamilyUnitTests
{
    [TestClass]
    public class FamilyUnitTests
    {
        [DataTestMethod, TestCategory("Constructors")]
        [DataRow("KoWalskI", "jan", 18,
                 "Kowalski", "Jan", 18)]
        [DataRow("Nowak", "Pawe³", 20,
                 "Nowak", "Pawe³", 20)]
        [DataRow("  LewandoWsKi  ", "KrzYSztof  ", 32,
                 "Lewandowski", "Krzysztof", 32)]
        public void Constructor_3args_names_normaliztion(string firstName, string familyName, int age,
                                                 string expectedFirstName, string expectedFamilyName, int expectedAge)
        {
            Person p = new Person(firstName, familyName, age);
            Assert.AreEqual(expectedFirstName, p.FirstName);
            Assert.AreEqual(expectedFamilyName, p.FamilyName);
            Assert.AreEqual(expectedAge, p.Age);
        }

        [DataTestMethod, TestCategory("Constructors")]
        [DataRow(-18)]
        [DataRow(-1)]
        public void Constructor_NegativeAge_ThrowsArgumentException(int age)
        {
            // Arrange & Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Person("Robert", "Kowalski", age));
        }

    }
}