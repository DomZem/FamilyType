using FamilyLib;

namespace FamilyConsoleAppDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p = new Person(familyName: "MOlenda", firstName: "krzysztof", age: -18);
                Console.WriteLine(p);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}