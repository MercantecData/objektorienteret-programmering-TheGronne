using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Team
    {
        public string name;
        public int id;
        public List<Student> students = new List<Student>();
        public List<Employee> teachers = new List<Employee>();

        public Team(string name, int id, List<Student> students, List<Employee> teachers)
        {
            this.name = name;
            this.id = id;
            this.students = students;
            this.teachers = teachers;
        }


        //changes name of team
        public void edit(string name)
        {
            this.name = name;
        }

        //returns a list of all students on the team
        public List<Student> getStudents()
        {
            return students;
        }
        //returns a list of all teachers on the team
        public List<Employee> getTeachers()
        {
            return teachers;
        }

        //adds a student to the team
        public void add(Student student)
        {
            student.teams.Add(this);
            students.Add(student);
        }
        //removes a student from the team
        public void remove(Student student)
        {
            student.teams.Remove(this);
            students.Remove(student);
        }

        //adds a teacher to the team
        public void add(Employee teacher)
        {
            teacher.teams.Add(this);
            teachers.Add(teacher);
        }
        //removes a teacher from the team
        public void remove(Employee teacher)
        {
            teacher.teams.Remove(this);
            teachers.Remove(teacher);
        }
    }
}
