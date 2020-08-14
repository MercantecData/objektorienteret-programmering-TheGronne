using System;
using System.Collections.Generic;
using System.Text;

namespace Fremvisning
{
    public class Trainer : Creatures
    {
        protected string favouritePokemon;
        protected Types.Type favouriteType;
        protected Pokemon[] pokemonParty;
        protected List<Pokemon> caughtPokemon;

        public Trainer(string favouritePokemon, Types.Type favouriteType, Pokemon[] pokemonParty, List<Pokemon> caughtPokemon, string name, int age, Creatures.Gender gender, double weight, double height)
        {
            this.favouritePokemon = favouritePokemon;
            this.favouriteType = favouriteType;
            this.pokemonParty = new Pokemon[6];
            this.caughtPokemon = new List<Pokemon>();
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.weight = weight;
            this.height = height;
        }

        public string returnFavouritePokemon()
        {
            return favouritePokemon;
        }
        public Types.Type returnFavouriteType()
        {
            return favouriteType;
        }
        public Pokemon[] returnPokemonParty()
        {
            return pokemonParty;
        }
        public List<Pokemon> returnCaughtPokemon()
        {
            return caughtPokemon;
        }
    }
}