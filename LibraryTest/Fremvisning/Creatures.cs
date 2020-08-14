using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Fremvisning
{
    public delegate string stringDel();
    public delegate double doubleDel();
    public class Creatures
    {
        protected string name;
        protected int age;
        protected Gender gender;
        protected double weight;
        protected double height;

        public Creatures(string name, int age, Gender gender, double weight, double height)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.weight = weight;
            this.height = height;
        }

        public Creatures()
        {

        }

        public enum Gender
        {
            Male,
            Female,
            None
        }

        public string returnName()
        {
            return name;
        }
        public int returnAge()
        {
            return age;
        }
        public Gender returnGender()
        {
            return gender;
        }
        public double returnWeight()
        {
            return weight;
        }
        public double returnHeight()
        {
            return height;
        }
    }
}
