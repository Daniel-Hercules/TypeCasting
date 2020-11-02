using System;

namespace Type_Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Casting - Done automatically 
            // when passing from a smaller type to a
            // larger type.

            int myInt = 5;

            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            // Explicit Casting - Done, manually by
            // placing the type in parenttheses in 
            // front of the value.

            double anotherDouble = 2.34;

            //This will only give the full number of the double.
            
            int anotherInt = (int)anotherDouble;

            Console.WriteLine(anotherDouble);
            Console.WriteLine(anotherInt);



        }
    }
}
