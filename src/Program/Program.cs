using System;
using System.Collections.Generic;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };

            Wizard gandalf; 
            gandalf= new Wizard("Gandalf");
            gandalf.Staff = new Staff();
            gandalf.SpellsBook = book;

            Dwarf gimli = new Dwarf("Gimli");
            gimli.Axe = new Axe();
            gimli.Helmet = new Helmet();
            gimli.Shield = new Shield();
            Console.WriteLine(gimli.DefenseValue);
            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
        }

        static void DoEncounter()
        {
            public List<Character> Heroes = new List<Character>();
            public List<Character> Enemies = new List<Character>();
            boolean fighting = true;

            while(fighting)
            {
                
                for (int i = 0; i < Enemies.Count-1; i++)
                {
                    if(Heroes.Count == 1)
                    {
                        Heroes[0].ReceiveAttack(Enemies[i].AttackValue);
                        if(Heroes[0].Health < 1)
                        {
                            Console.WriteLine($"El heroe {Heroes[0].Name} murío");
                            Heroes.Clear();
                        }
                    }
                    else if(Heroes.Count == Enemies.Count)
                    {
                        Heroes[i].ReceiveAttack(Enemies[i].AttackValue);
                        if(Heroes[i] < 1)
                        {
                            Console.WriteLine($"El heroe {Heroes[i].Name} murío");
                            Heroes.Remove(Heroes[i]);
                        }
                    }
                    else if(Heroes.Count < Enemies.Count)
                    {
                        Heroes[i].ReceiveAttack(Enemies[i+1].AttackValue);
                        if(Heroes[i] < 1)
                        {
                            Console.WriteLine($"El heroe {Heroes[i].Name} murío");
                            Heroes.Remove(Heroes[i]);
                        }
                    }

                    if(Heroes.Count  1)
                    {
                        Console.WriteLine("Ganan los enemigos");
                        fighting = false;
                    }
                }

                if (Heroes.Count > 0)
                {
                    for (int i = 0; i < Heroes.Count; i++)
                    {
                        if (Enemies.Count > 0)
                        {
                            for (int j = 0; j < Enemies.Count; i++)
                            {
                                Enemies[j].ReceiveAttack(Heroes[i]);
                                if (Enemies[j].Health < 1)
                                {
                                    Console.WriteLine($"El enemigo {Enemies[j].Name} murió");
                                    Heroes[i].ReceiveVictoryPointsFromEnemy(Enemies[j].VictoryPoints);
                                    Enemies.Remove(Enemies[j])
                                }
                            }
                        }
                        else
                        {
                            fighting = false;
                            Console.WriteLine("Ganan los Heroes!")
                        }
                    }
                }
            }
        }
    }
}
