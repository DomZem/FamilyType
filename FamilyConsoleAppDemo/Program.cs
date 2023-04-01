using FamilyLib;

namespace FamilyConsoleAppDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* Test: poprawne tworzenie obiektu Person, dane poprawne */
            try
            {
                Person p = new Person(familyName: "Jan", firstName: "Kowlaski", age: 18);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /* Test: poprawne tworzenie obiektu Person, błędne imię lub nazwisko, pierwsza duża pozostałe małe */
            try
            {
                Person p = new Person(familyName: "KOwalski", firstName: "jan", age: 18);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /* Test: poprawne tworzenie obiektu Person, błędne imię lub nazwisko, niewłaściwy wiek */
            try
            {
                Person p = new Person(familyName: "KOwalski", firstName: "jan", age: -18);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /* Test: modyfikacja obiektu */
            try
            {
                Person p = new Person(familyName: "Kowalski", firstName: "Jan", age: 18);
                p.modifyFirstName(" Pi otr");
                p.modifyFamilyName("No wa kowski ");
                p.modifyAge(35);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}