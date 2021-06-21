using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    class StudentInfo
    {
        private string id;
        private string name;
        private int marks;

        public string GetId() { return this.id; }
        public string GetName() { return this.name; }
        public int GetMarks() { return this.marks; }

        public void SetId(string value) { this.id = value; }
        public void SetName(string value) { this.name = value; }
        public void SetMarks(int value) { this.marks = value; }
    }
}
