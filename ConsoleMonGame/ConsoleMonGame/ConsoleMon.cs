﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;
        private List<Skill> skills;
        internal Element weakness;

        internal void TakeDamage(int damage)
        {   
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }

        internal ConsoleMon()
        {
            skills = new List<Skill>();
        }


    }
}
