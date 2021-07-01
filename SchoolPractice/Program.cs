using System;
using System.Collections.Generic;
namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student charles = new Student();
            charles.Name = "Charles";
            Console.WriteLine(charles.Name);

            Student charlesCredits = new Student();
            charles.NumberOfCredits = 1;
            Console.WriteLine(charles.NumberOfCredits);

            Student charlesgpa = new Student();
            charles.Gpa = 4.0;
            Console.WriteLine(charles.Gpa);

            Teacher jon = new Teacher();
            jon.FirstName = "Jon";
            jon.LastName = "White";
            jon.Subject = "Math";
            jon.YearsTeaching = 5;
            Console.WriteLine($"{jon.FirstName} {jon.LastName} has been teaching {jon.Subject} for {jon.YearsTeaching} years.");

            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
        }
    }
}
