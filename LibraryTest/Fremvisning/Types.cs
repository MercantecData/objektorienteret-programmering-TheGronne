using System;
using System.Collections.Generic;
using System.Text;

namespace Fremvisning
{
    public class Types
    {
        public Type[] types;

        public Types(Type[] types)
        {
            this.types = types;
        }

        public enum Type
        {
            Normal,
            Grass,
            Fire,
            Water,
            Bug,
            Rock,
            Poison,
            Psychic,
            Ground,
            Ice,
            Dragon,
            Dark,
            Fighting,
            Ghost,
            Steel,
            Flying,
            Electric,
            Fairy,
            None
        }
    }
}
