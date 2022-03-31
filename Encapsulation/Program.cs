using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student(15, "Emily" ,"Aghayeva","IT");
            //Group group = new Group();
            //group.AddStudents(student1);
            int[] arr1 = { 1, 2, 234, 4, 3 };
            Array.Sort(arr1);
            //Console.WriteLine(numberss.Rank);
            foreach (var item in arr1)
            {
                Console.WriteLine(item);

            }
           
        }
    }
}
