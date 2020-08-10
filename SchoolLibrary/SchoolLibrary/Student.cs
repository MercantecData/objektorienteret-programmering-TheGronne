using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student
    {
        public string name;
        public int id;
        public int age;
        public List<Team> teams = new List<Team>();

        public Student(string name, int id, int age,List<Team> teams)
        {
            this.name = name;
            this.id = id;
            this.age = age;
            this.teams = teams;
        }


        //changes name of student
        public void edit(string name)
        {
            this.name = name;
        }
        //changes age of student
        public void edit(int age)
        {
            this.age = age;
        }

        //returns a list of all teams the student is in
        public List<Team> getTeams()
        {
            return teams;
        }
        //returns all current values of the student as a string
        public string getProfile()
        {
            string list = "";
            string list2 = "";
            for (int i = 0; i < teams.Count; i++)
            {
                list = teams[i].name;
                list2 = list2 + ", " + list;
            }
            return "Name: " + this.name + ", ID: " + this.id + ", Teams: " + list2 + ".";
        }
    }
}
