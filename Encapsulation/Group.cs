using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Group 
    {
        public string GroupName
        {
            get
            {
                return GroupName;
            }
            set { GroupName = value; }
        }
        public int MaxStuCount
        {
            get
            {
                return MaxStuCount;
            }
            set { MaxStuCount = value; }
        }
        public Student[] Students = new Student[] { };
        public void AddStudents(Student firstStu)
        {
            if (Students.Length + 1 > MaxStuCount)
            {
                Student[] newStudent = new Student[Students.Length + 1];
                for (int i = 0; i < Students.Length; i++)
                {
                    newStudent[i] = Students[i];
                }
                newStudent[newStudent.Length - 1] = firstStu;
                Students = newStudent;
                Console.WriteLine(Students[0].Name);
            }
            else
            {
                Console.WriteLine("FULL");
            }

        }
        public void RemoveStudents(int id)
        {
            Student[] newStudent = new Student[Students.Length - 1];
            int targInd = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                if (id != Students[id].Id)
                {
                    newStudent[i] = Students[i];
                    targInd++;
                }
                else return;
            }
            for (int j = 0; j < Students.Length; j++)
            {
                newStudent[j] = Students[j + 1];
            }
            Students = newStudent;


        }

    }
}
