using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student
    {
        string name;
        int id;
        List<Team> studentTeams = new List<Team>();

        public Student(string name, int id, List<Team> studentTeams)
        {
            this.name = name;
            this.id = id;
            this.studentTeams = studentTeams;
        }
    }
}
