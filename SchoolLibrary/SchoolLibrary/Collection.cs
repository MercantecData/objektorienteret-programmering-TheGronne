using System;
using System.Collections.Generic;

namespace SchoolLibrary
{
    public class Collection
    {
        private List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        List<Team> teams = new List<Team>();

        public Collection(List<Student> students, List<Teacher> teachers, List<Team> teams)
        {
            this.students = students;
            this.teachers = teachers;
            this.teams = teams;
        }

        public void getAllStudents(List<Student> list)
        {
            var students = new List<Student>();
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(students[i].nam)
            }
        }
    }
}
