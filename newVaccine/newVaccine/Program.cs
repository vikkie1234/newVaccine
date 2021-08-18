using System;

namespace newVaccine
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, surname, gender, province;
            string DOB;

            Console.WriteLine("Vaccince Registration Form");
            Console.WriteLine(".................................");

            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Surname: ");
            surname = Console.ReadLine();
            Console.Write("Gender: ");
            gender = Console.ReadLine();
            Console.Write("Date of birth: ");
            DOB = Console.ReadLine();

            Console.Write("Province: ");

            province = Console.ReadLine();
        }
    }
}
