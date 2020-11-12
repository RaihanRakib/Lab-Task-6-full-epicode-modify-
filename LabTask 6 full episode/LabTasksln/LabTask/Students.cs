using System;

namespace LabTask
{
    class Students
    {
 
        private
        String name;
        String id;
        String department;
        float cgpa;
        private Students()
        { }
        public Students(String n, String i, String d, float cg)
        {
            name = n;
            id = i;
            department = d;
            cgpa = cg;
        }
        public void ShowInfo()
        {
            Console.WriteLine(" Student name is: " + name);
            Console.WriteLine(" Student ID is: " + id);
            Console.WriteLine(" Student Department is: " + department);
            Console.WriteLine(" Student CGPA is: " + cgpa);
        }
    }
}
