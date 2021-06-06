using System;
using System.Collections.Generic;

namespace MapleEmpire
{
    public class Farm
    {
        int capacity;
        int available;
        int planted;
        int value;
        readonly int expansion_cost_per_space;
        List<Object> plantedTrees;
        Factory factory;


        public Farm(Factory f)
        {
            this.capacity = 5;
            this.available = 5;
            this.planted = 0;
            this.value = 25000;
            this.expansion_cost_per_space = 5000;
            this.plantedTrees = new List<Object>();
            this.factory = f;
        }

        public void Plant(Object tree, String name)
        {
            if(this.available > 0)
            {
                this.planted++;
                this.available--;
                plantedTrees.Add(tree);
                Console.WriteLine("You have successfully planted " + name + ". You are still able to plant " + this.available.ToString() + " trees.");
            }
            else
            {
                Console.WriteLine("No available spaces left. Try harvesting some trees or expanding your farm's capacity.");
            }
        }

        public void Harvest(Object tree, String name)
        {
            switch (plantedTrees.Contains(tree))
            {
                case true:
                    this.planted--;
                    this.available++;
                    Console.WriteLine("You have successfully harvested " + name + ". It has been sent to your Factory for production.");
                    this.factory.AddToInventory(tree);
                    plantedTrees.Remove(tree);
                    break;
                default:
                    Console.WriteLine("You have have not planted " + name + " on your farm.");
                    break;
            }
        }

        public void Expand(int space)
        {
            this.capacity += space;
            this.available += space;
            this.value += (space * this.expansion_cost_per_space);
            Console.WriteLine("You have expanded this farm by " + space.ToString() + ".");
        }

        public void GetDetails()
        {
            Console.WriteLine("Your farm currently has a capacity of " + this.capacity.ToString() + " and " + this.available.ToString() + " spaces available for planting.");
            if(plantedTrees.Count != 0)
            {
                Console.WriteLine("You have also planted the following tree(s) in your farm:");
                plantedTrees.ForEach(Console.WriteLine);
            }
        }

        public int GetExpansionCost()
        {
            return this.expansion_cost_per_space;
        }

        public int GetValue()
        {
            return this.value;
        }
    }
}
