using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Teacher
    {
        string name;
        int id;
        List<Team> teacherTeams = new List<Team>();
        decimal earnings;
        int paymentDay;
        bool payed;

        public Teacher(string name, int id, List<Team> teacherTeams, decimal earnings, int paymentDay, bool payed)
        {
            this.name = name;
            this.id = id;
            this.teacherTeams = teacherTeams;
            this.earnings = earnings;
            this.paymentDay = paymentDay;
            this.payed = payed;
        }
    }
}
