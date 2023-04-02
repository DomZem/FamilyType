using FamilyLib;

namespace FamilyConsoleAppDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test: poprawne tworzenie obiektu Person, dane poprawne");
            try
            {
                Person p = new Person(familyName: "Kowalski", firstName: "Jan", age: 18);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            Console.WriteLine("Test: poprawne tworzenie obiektu Person, błędne imię lub nazwisko, pierwsza duża pozostałe małe");
            try
            {
                Person p = new Person(familyName: "KOwalski", firstName: "jan", age: 18);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            Console.WriteLine("Test: poprawne tworzenie obiektu Person, błędne imię lub nazwisko, niewłaściwy wiek");
            try
            {
                Person p = new Person(familyName: "KOwalski", firstName: "jan", age: -18);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            Console.WriteLine("Test: modyfikacja obiektu");
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

            Console.WriteLine();

            Console.WriteLine("Test: tworzenie obiektu Child");
            try
            {
                Person o = new Person(familyName: "Kowalski", firstName: "Krzysztof", age: 30);
                Person m = new Person(familyName: "Kowalski", firstName: "Ewa", age: 29);
                Child d = new Child(familyName: "Kowalski", firstName: "Anna", age: 10, mother: m, father: o);
                Console.WriteLine(d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            Console.WriteLine("Test: tworzenie obiektu Child brak rodziców");
            try
            {
                Child d = new Child(familyName: "Kowalski", firstName: "Anna", age: 14);

                Console.WriteLine(d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

            Console.WriteLine("Test: tworzenie obiektu Child brak jednego z rodziców");
            try
            {
                Person o = new Person(familyName: "Molenda", firstName: "Krzysztof", age: 30);
                Person m = new Person(familyName: "Molenda", firstName: "Ewa", age: 29);
                Child d = new Child(familyName: "Molenda", firstName: "Anna", age: 14, father: o);
                Console.WriteLine(d);
                d = new Child(familyName: "Molenda", firstName: "Anna", age: 14, mother: m);
                Console.WriteLine(d);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}