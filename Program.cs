﻿using System;
using System.Collections.Generic;

namespace my_first_app
{

    class Wizard
    {
        public string name;
        public string favouriteSpell;
        private int spellSlots;
        private float experience;

        public static int Count;

        public Wizard(string _name, string _favouriteSpell)
        {
            name = _name;
            favouriteSpell = _favouriteSpell;
            spellSlots = 2;
            experience = 0f;

            Count++;
        }

        public void CastSpell()
        {
            if(spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favouriteSpell);
                spellSlots --;
                experience += 0.3f;
            } else
            {
                Console.WriteLine(name + " is out of spell slots!");
            }
        }

        public void Meditate()
        {
            Console.WriteLine(name + " meditates to regain spell slots");
            spellSlots = 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Gandalf", "Fireball");
        
            wizard01.CastSpell();
            wizard01.CastSpell();
            wizard01.CastSpell();

            wizard01.Meditate();

            Wizard wizard02 = new Wizard("Saruman", "Lightning Strike");

            wizard02.CastSpell();

            Console.WriteLine(Wizard.Count);
           
            Console.ReadKey();
        }
    }
}