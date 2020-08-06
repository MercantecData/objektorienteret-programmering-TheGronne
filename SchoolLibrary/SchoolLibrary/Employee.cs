using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Employee
    {
        public string name;
        public int id;
        public List<Team> teams = new List<Team>();
        public decimal earnings;
        public int paymentDay;
        public bool payed;
        public bool isTeacher;

        public Employee(string name, int id, List<Team> teams, decimal earnings, int paymentDay, bool payed, bool isTeacher)
        {
            this.name = name;
            this.id = id;
            this.teams = teams;
            this.earnings = earnings;
            this.paymentDay = paymentDay;
            this.payed = payed;
            this.isTeacher = isTeacher;
        }


        //Changes name of teacher
        public void edit(string name)
        {
            this.name = name;
        }
        //changes earnings/month of teacher
        public void edit(decimal earnings)
        {
            this.earnings = earnings;
        }
        //changes payment day of month of teacher
        public void edit(int paymentDay)
        {
            this.paymentDay = paymentDay;
        }
        //changes if teacher has been payed this month
        public void edit(bool payed)
        {
            this.payed = payed;
        }

        //returns a list of all teams the teacher is in
        public List<Team> getTeams()
        {
            return teams;
        }
        //returns all current values of the teacher as a string
        public string getProfile()
        {
            string list = "";
            string list2 = "";
            for (int i = 0; i < teams.Count; i++)
            {
                list = teams[i].name;
                list2 = list2 + ", " + list;
            }
            return "Name: " + this.name + ", ID: " + this.id + ", Teams: " + list2 + ", Earnings: " + this.earnings + ", Payment Day: " + this.paymentDay + ", Payed: " + payed + ", " + isTeacher + ".";
        }
    }
}
