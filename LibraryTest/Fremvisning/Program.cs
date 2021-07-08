using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using Fremvisning;
using Microsoft.VisualBasic.FileIO;

namespace Fremvisning
{
    class Program
    {
        public static void Main(string[] args)
        {
            CreatureDex creaturedex = new CreatureDex();

            creaturedex.addPokemon(4, 1, new Types(new Types.Type[] { Types.Type.Fire }), "Dscription", 5, "Charmander", 3, Creatures.Gender.Male, 38.50, 50);
            creaturedex.addPokemon(6, 2, new Types(new Types.Type[] { Types.Type.Fire, Types.Type.Flying }), "Description", 32, "Charizard", 16, Creatures.Gender.Male, 72.1866, 100);

            /////////////
            
            for (int i = 0; i < creaturedex.getAllPokemon().Count; i++)
            {
                var example = creaturedex.getAllPokemon()[i].returnTypes();

                if (example.Length == 2)
                {
                    Console.WriteLine("" + example[0] + " " + example[1]);
                }
                else
                {
                    Console.WriteLine("" + example[0]);
                }
            }

            /////////////
            
            Trainer Ash = new Trainer("Pikachu", Types.Type.Dark, new Pokemon[6], new List<Pokemon>(), "Ash", 10, Creatures.Gender.Male, 50, 150);
            stringDel example21;
            stringDel example22;

            example21 = Ash.returnFavouritePokemon;
            example22 = creaturedex.getAllPokemon()[0].returnName;

            Console.WriteLine(isFavouritePokemon(example21(), example22()));

            /////////////
            
            doubleDel example31;
            doubleDel example32;

            example31 = creaturedex.getAllPokemon()[0].returnHeight;
            example32 = creaturedex.getAllPokemon()[0].returnWeight;

            Console.WriteLine(weightPerKilo(example31(), example32()));

            /////////////
        }


        static string isFavouritePokemon(string name, string name2)
        {
            if (name == name2)
            {
                return "WOW!";
            }
            else
            {
                return "Nope";
            }
        }
        static double weightPerKilo(double height, double weight)
        {
            double result = height / weight;
            return result;
        }
    }
}
