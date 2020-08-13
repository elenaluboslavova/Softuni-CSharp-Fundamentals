using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dictHP = new Dictionary<string, int>();
            var dictMP = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] heroInfo = Console.ReadLine().Split().ToArray();

                string heroName = heroInfo[0];
                int HP = int.Parse(heroInfo[1]);
                int MP = int.Parse(heroInfo[2]);

                dictHP.Add(heroName, HP);
                dictMP.Add(heroName, MP);
            }

            string input = Console.ReadLine();

            while (input != "End")
            {
                List<string> list = input.Split(" - ").ToList();

                string action = list[0];

                if (action == "CastSpell")
                {
                    string heroName = list[1];
                    int neededMP = int.Parse(list[2]);
                    string spellName = list[3];

                    if (dictMP[heroName] >= neededMP)
                    {
                        dictMP[heroName] -= neededMP;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {dictMP[heroName]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }

                else if (action == "TakeDamage")
                {
                    string heroName = list[1];
                    int damage = int.Parse(list[2]);
                    string attacker = list[3];

                    dictHP[heroName] -= damage;

                    if (dictHP[heroName] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {dictHP[heroName]} HP left!");
                    }
                    else
                    {
                        dictHP.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }

                else if (action == "Recharge")
                {
                    string heroName = list[1];
                    int amount = int.Parse(list[2]);

                    

                    if (dictMP[heroName] + amount > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 - dictMP[heroName]} MP!");
                        dictMP[heroName] = 200;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                        dictMP[heroName] += amount;
                    }
                }

                else if (action == "Heal")
                {
                    string heroName = list[1];
                    int amount = int.Parse(list[2]);

                    

                    if (dictHP[heroName] + amount > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - dictHP[heroName]} HP!");

                        dictHP[heroName] = 100;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                        dictHP[heroName] += amount;
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var item in dictHP.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"  HP: {item.Value}");
                Console.WriteLine($"  MP: {dictMP[item.Key]}");
            }

        }
    }
}
