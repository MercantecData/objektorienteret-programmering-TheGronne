using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Fremvisning
{
    public class CreatureDex
    {
        private List<Pokemon> PokeDex = new List<Pokemon>();
        private List<Trainer> TrainerDex = new List<Trainer>();

        public List<Pokemon> getAllPokemon()
        {
            return PokeDex;
        }
        public List<Trainer> getAllTrainers()
        {
            return TrainerDex;
        }
        public void addPokemon(
            int number,
            int numberOfTypes,
            Types types,
            string description,
            int level,
            string name,
            int age,
            Pokemon.Gender gender,
            double weight,
            int height)
        {
            Pokemon pokemon = new Pokemon(number, numberOfTypes, types, description, level, name, age, gender, weight, height);
            PokeDex.Add(pokemon);
        }
    }
}
