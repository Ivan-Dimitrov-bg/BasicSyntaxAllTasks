using System;

namespace _01._Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            string strGrades = string.Format("{0:0.00}", grade);


            //Name: John, Age: 15, Grade: 5.40';
            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2}", name, age, strGrades);
        }
    }
}
