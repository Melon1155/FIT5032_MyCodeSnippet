using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_MyCodeSnippet.Models.Excerise
{
    public class Student
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public string StudentID { get; set; }

        public Student(String name, String phoneNumber, String studentID) 
        {
            Name = name;
            PhoneNumber = phoneNumber;
            StudentID = studentID;
        }

        public class ExampleDictionary
        {
            public void Example()
            {
                Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
                Student s1 = new Student("Jason", "040000000", "2300000");
                Student s2 = new Student("Jack", "040000000", "2300001");
                studentDictionary.Add(1, s1);
                studentDictionary.Add(2, s2);
                Student result = new Student("", "", "");

                studentDictionary.TryGetValue(1, out result);
            }
        }
    }
}