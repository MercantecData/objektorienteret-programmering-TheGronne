using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Team
    {
        string name;
        int id;
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();

        public Team(string name, int id, List<Student> students, List<Teacher> teachers)
        {
            this.name = name;
            this.id = id;
            this.students = students;
            this.teachers = teachers;
        }
    }
}
