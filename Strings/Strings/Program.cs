using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstName = "Ryan";
            var lastName = "Patrick";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new String[3]{ "John", "Jack", "Mary"};
            var formattedNames = string.Join(",", names);

            var text = @"Hi John 
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
