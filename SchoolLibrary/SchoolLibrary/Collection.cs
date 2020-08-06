using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SchoolLibrary
{
    public class Collection
    {
        public List<Student> students = new List<Student>();
        public List<Employee> teachers = new List<Employee>();
        public List<Team> teams = new List<Team>();
        int currentStudentID;
        int currentTeacherID;
        int currentTeamID;

        public Collection(List<Student> students, List<Employee> teachers, List<Team> teams)
        {
            this.students = students;
            this.teachers = teachers;
            this.teams = teams;
        }


        //adds student
        public void add(string name, int age)
        {
            Student student = new Student(name, currentStudentID, age, new List<Team>());
            students.Add(student);
            currentStudentID++;
        }
        //removes student
        public void remove(Student student)
        {
            foreach (var Student in teams.Where(x => x.students.Contains(student)))
            {
                remove(student);
            }
            students.Remove(student);
        }

        //adds teacher
        public void add(string name, decimal earnings, int paymentDay, bool payed, bool isTeacher)
        {
            Employee teacher = new Employee(name, currentTeacherID, new List<Team>(), earnings, paymentDay, payed, isTeacher);
            teachers.Add(teacher);
            currentTeacherID++;
        }
        //removes teacher
        public void remove(Employee teacher)
        {
            foreach (var Teacher in teams.Where(x => x.teachers.Contains(teacher)))
            {
                remove(teacher);
            }
            teachers.Remove(teacher);
        }

        //adds team
        public void add(string name)
        {
            Team team = new Team(name, currentTeamID, new List<Student>(), new List<Employee>());
            teams.Add(team);
            currentTeamID++;
        }
        //removes team
        public void remove(Team team)
        {
            foreach (var Team in students.Where(x => x.teams.Contains(team)))
            {
                remove(team);
            }
            foreach (var Team in teachers.Where(x => x.teams.Contains(team)))
            {
                remove(team);
            }
            teams.Remove(team);
        }

        //returns a list of all students in the school
        public List<Student> getStudents()
        {
            return students;
        }
        //returns a list of all teachers in the school
        public List<Employee> getTeachers()
        {
            return teachers;
        }
        //returns a list of all teams in the school
        public List<Team> getTeams()
        {
            
            return teams;
        }
    }
}
