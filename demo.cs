using System;

namespace demo
{
    class studentInfo
    {

        private string id;
        private string name;
        private int marks;

        public string GetId()
        {
            return this.id; 
            
        }
       public string GetName()
        {
            return this.name; 
            
        }
        public string GetMarks()
        {
            return this.marks; 
            
        }
      public void SetId(string value)
       {   this.id = value;   }

      public void SetName(string value)
       {   this.name = value;   }

     public void SetMarks(int value)
       {   this.marks = value;   }

    class program
    {
        static void Main()
        {
            studentinfo s1 = new studentinfo();
            s1.SetId("S100");
            s1.Setname("manasa");
            s1.Setmarks(90);

            string idvalue= s1.GetId();
            string namevalue = s1.GetName();
            int marksvalue = s1.Getmarks();
            System.Console.WriteLine(idvalue);
            System.Console.WriteLine(namevalue);
            System.Console.WriteLine(marksvalue);;

        }
    }

}
