using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo s1 = new StudentInfo();
            s1.SetId("$100");
            s1.SetName("manasa");
            s1.SetMarks(90);

            string idValue = s1.GetId();
            string nameValue = s1.GetName();
            int marksValue = s1.GetMarks();
            System.Console.WriteLine(idValue);
            System.Console.WriteLine(nameValue);
            System.Console.WriteLine(marksValue);

        }
    }
}
