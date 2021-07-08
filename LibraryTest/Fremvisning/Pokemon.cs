using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Fremvisning
{
    public class Pokemon : Creatures
    {
        protected int number;
        protected int numberOfTypes;
        protected Types types;
        protected string description;
        protected int level;
        
        public Pokemon(int number, int numberOfTypes, Types types, string description, int level, string name, int age, Gender gender, double weight, double height)
        {
            this.number = number;
            this.numberOfTypes = numberOfTypes;
            this.types = types;
            this.description = description;
            this.level = level;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.weight = weight;
            this.height = height;
        }

        public int returnNumber()
        {
            return number;
        }
        public int returnNumberOfTypes()
        {
            return numberOfTypes;
        }
        public Types.Type[] returnTypes()
        {
             return types.types;
        }
        public string returnDescription()
        {
            return description;
        }
        public int returnLevel()
        {
            return level;
        }
    }
}