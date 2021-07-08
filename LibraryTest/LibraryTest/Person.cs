using System;
using System.Collections.Generic;

namespace LibraryTest
{
    public class Person
    {
        public string name;
        public int age;
        public string gender;
        public string address;
        public int birthdate;
        public int height;
        public int weight;
        public Job job;

        public Person(string name, int age, string address, int birthdate, int height, int weight, Job job)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.birthdate = birthdate;
            this.height = height;
            this.weight = weight;
            this.job = job;
        }
    }
}