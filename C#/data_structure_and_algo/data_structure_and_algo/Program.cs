using System;

namespace data_structure_and_algo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Topic cover in this example are syntex, comments, variables, data types.
            // variable types 
            int age = 20; // int or long for integer values. 
            float height = 5.8F; // float or double for floating point numbers 
            float f1 = 35e3F;
            double d1 = 12E4D;
            char grade = 'A';
            string name  = "John Smith";
            bool isPass = true;
            Console.WriteLine(" Student Bio-data");
            Console.WriteLine(" Name: " + name + "\n Age : " + age + "\n Height : " + height + "\n Grade : " + grade + "\n Pass : " + isPass);
            Console.WriteLine("sample of floating points \n float : " + f1 + "\n double : " + d1  );
            */

            // adding line
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is : " + name);

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
        }
    }
}
