using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPractice
{
    internal class Program
    {
        static void Main()
        {
            Dog dog = new("Sparky");

            // conditional operator checks the value if it was null. if thats true work continues, if false it returns the "if" statement.
            bool? startsWith = dog.Owner?.StartsWith('A');

            Console.WriteLine(Convert.ToBoolean(startsWith));

            dog.Owner = "Aladar";
            startsWith = dog.Owner?.StartsWith('A');

            Console.WriteLine(Convert.ToBoolean(startsWith));

            //ternary operator makes an if/else -> on the left returns the true side, on the right returns the false
            string nameIsSparky = dog.Name == "Sparky"
                          ? "Yes"
                          : "No";
            Console.WriteLine(nameIsSparky);

            Dog dog2 = new("Lessie");

            //in this case the operator checks the left value... if it's null assign it with the right side value else nothing happens
            dog2.Owner ??= "Sanyi";

            Console.WriteLine(dog2.Owner);

            dog2.Owner ??= "Laci";
            Console.WriteLine(dog2.Owner + " " + dog.Owner);

        }
    }
}
