using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTest
{
    public class Job
    {
        public string name;
        public string title;
        public string address;
        public int monthlyPay;
        public int weeklyWorkHours;

        public Job(string name, string title, string address, int monthlyPay, int weeklyWorkHours)
        {
            this.name = name;
            this.title = title;
            this.address = address;
            this.monthlyPay = monthlyPay;
            this.weeklyWorkHours = weeklyWorkHours;
        }
    }
}