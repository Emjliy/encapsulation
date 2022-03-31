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
            int[] arr1 = { 1, 2, 3 };
            //Console.WriteLine(numberss.Rank);
            int[] arr = new int[3];
            arr1.CopyTo(arr, 0);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(arr==arr1);
            
        }
    }
}
