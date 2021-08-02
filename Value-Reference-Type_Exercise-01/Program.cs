using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Value_and_Reference_Types_Exercise_01
{
    public class Dog
    {
        public string name;
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            #region Value Type TODOs w/ answers

            // TODO: Declare and initialize 3 value type variables of types: double, int, and string
            double myDouble = .005;
            int myInteger = 10;
            string myString = "Hello World";

            // TODO: Write out each of these to the Conosle like so:
            // Console.WriteLine($"Before: {yourVarible}");
            Console.WriteLine($"Before: {myDouble}");
            Console.WriteLine($"Before: {myInteger}");
            Console.WriteLine($"Before: {myString}");

            // TODO: Use the ChangeValueType() function to "change the value type" for each variable
            // ChangeValueType(yourVariable);
            ChangeValueType(myDouble);
            ChangeValueType(myInteger);
            ChangeValueType(myString);

            AddSpace();

            // Thought Experiment: What will the value of the original variable be after going through the ChangeValueType() method?
            // TODO: Double variable value = .005
            // TODO: Integer variable value = 10
            // TODO: String variable value = "Hello World"

            // Why:
            // Answer: Because these are Value Types their values are copied, therefore, when you write the original to the conosle none of them have changed!

            // TODO: Write out the original variable to the console after being changed by the ChangeValueType() function
            // Console.WriteLine($"Original: {yourVariable}");
            Console.WriteLine($"After: {myDouble}");
            Console.WriteLine($"After: {myInteger}");
            Console.WriteLine($"After: {myString}");

            #endregion

            AddSection();

            #region Reference Type TODOs w/ answers
            // TODO: Use the 4 reference type variables that are already declared and initialized below
            StringBuilder sb = new StringBuilder("The starting string's value.");
            List<int> myList = new List<int>() { 1, 2, 3 };
            int[] myArray = new int[] { 4, 5, 6 };
            Dog myDogObject = new Dog { name = "Lassy" };

            // TODO: Write out each of these to the Conosle. Remember to use a loop for the list and array
            Console.Write($"Before: {sb}");

            AddSmallSpace();

            Console.Write($"Before: ");

            foreach (var num in myList)
            {
                Console.Write(num);
            }

            AddSmallSpace();

            Console.Write($"Before: ");

            foreach (var num in myArray)
            {
                Console.Write(num);
            }

            AddSmallSpace();

            Console.Write($"Before: ");

            Console.WriteLine(myDogObject.name);

            AddSpace();

            // TODO: Use the ChangeReferenceType() function to "change the reference type" for each variable
            ChangeReferenceType(sb);
            ChangeReferenceType(myList);
            ChangeReferenceType(myArray);
            ChangeReferenceType(myDogObject);

            // Thought Experiment: What will the value of the original variable be after going through the ChangeReferenceType() method?
            // TODO: StringBuilder variable value = The ending string's value.
            // TODO: List<int> variable values = 100200300
            // TODO: int[] variable values = 400500600
            // TODO: Dog object variable's name = A changed name
            // Answer: Because these are Reference Types their values are not copied, therefore, when you write the original to the conosle they will be changed!


            // TODO: Write out the original variables to the console after being changed by the ChangeReferenceType() function
            Console.Write($"After: {sb}");

            AddSmallSpace();

            Console.Write($"After: ");
            foreach (var num in myList)
            {
                Console.Write(num);
            }

            AddSmallSpace();

            Console.Write($"After: ");
            foreach (var num in myArray)
            {
                Console.Write(num);
            }

            AddSmallSpace();

            Console.WriteLine($"After: {myDogObject.name}");

            #endregion
        }

        #region Value Type TODO methods

        static void ChangeValueType(double x)
        {
            x = 1.125; // x's value has been changed to 1.125
        }

        static void ChangeValueType(int x)
        {
            x = 100; // x's value has been changed to 100
        }

        static void ChangeValueType(string x)
        {
            x = "A new value"; // x's value has been chaged to "A new value"
        }


        #endregion

        #region Reference Types TODO methods

        public static void ChangeReferenceType(StringBuilder sb)
        {
            sb.Remove(0, sb.Length);
            sb.Append("The ending string's value.");
        }

        public static void ChangeReferenceType(List<int> list)
        {
            list.RemoveAll(x => x < 4);
            list.Add(100);
            list.Add(200);
            list.Add(300);
        }

        public static void ChangeReferenceType(int[] arr)
        {
            arr[0] = 400;
            arr[1] = 500;
            arr[2] = 600;
        }

        public static void ChangeReferenceType(Dog dog)
        {
            dog.name = "A changed name";
        }

        #endregion

        #region Utility Methods

        public static void AddSmallSpace()
        {
            Console.WriteLine();
        }

        public static void AddSpace()
        {
            Console.WriteLine();
            Console.WriteLine("*********************************************************");
            Console.WriteLine();
        }

        public static void AddSection()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("===============================================================================================");
            Console.WriteLine();
            Console.WriteLine();
        }

        #endregion
    }
}
