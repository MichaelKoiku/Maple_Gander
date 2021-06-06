using System;
using System.Collections.Generic;

namespace MapleEmpire
{
    public class Factory
    {
        int value;
        int capacity;
        int available;
        readonly int expansion_cost_per_space;
        CanadianMapleTree canadianMapleTree;
        SugarMapleTree sugarMapleTree;
        JapaneseMapleTree japaneseMapleTree;
        NorwayMapleTree norwayMapleTree;
        FieldMapleTree fieldMapleTree;
        SilverMapleTree silverMapleTree;
        MapleSyrup mapleSyrup;
        MapleSugar mapleSugar;
        MapleFlakes mapleFlakes;
        MapleTaffy mapleTaffy;
        MapleButter mapleButter;
        MapleWater mapleWater;
        List<Object> warehouseFactory;
        List<Object> shipment;
        Store store;

        public Factory(Store s, CanadianMapleTree cmt, SugarMapleTree sugarmt, JapaneseMapleTree jmt, NorwayMapleTree nmt, FieldMapleTree fmt, SilverMapleTree silvermt, MapleSyrup ms, MapleSugar msg, MapleFlakes mflks, MapleTaffy mtfy, MapleButter mbutr, MapleWater mwtr)
        {
            this.value = 40000;
            this.capacity = 5;
            this.available = 5;
            this.expansion_cost_per_space = 5000;
            this.canadianMapleTree = cmt;
            this.sugarMapleTree = sugarmt;
            this.japaneseMapleTree = jmt;
            this.norwayMapleTree = nmt;
            this.fieldMapleTree = fmt;
            this.silverMapleTree = silvermt;
            this.mapleSyrup = ms;
            this.mapleSugar = msg;
            this.mapleFlakes = mflks;
            this.mapleTaffy = mtfy;
            this.mapleButter = mbutr;
            this.mapleWater = mwtr;
            this.warehouseFactory = new List<Object>();
            this.shipment = new List<Object>();
            this.store = s;
        }

        public void AddToInventory(Object tree)
        {
            this.warehouseFactory.Add(tree);
        }

        public void Produce()
        {
            Console.Write("\nWhat would you like to produce? (syrup/sugar): ");
            string answer = Console.ReadLine();

            if(this.available > 0)
            {
                switch (answer.ToLower())
                {
                    case "syrup":
                        if (warehouseFactory.Contains(this.canadianMapleTree))
                        {
                            available--;
                            this.shipment.Add(this.mapleSyrup);
                            this.warehouseFactory.Remove(canadianMapleTree);
                            Console.WriteLine("You have produced and stored 1 'maple syrup'. It has been added to your shipment. You have " + this.available + " free spaces left");
                        }
                        else
                        {
                            Console.WriteLine("You do not have the neccesary tree in your inventory to produce maple syrup. Please plant or harvest a Canadian Maple Tree");
                        }
                        break;
                    case "sugar":
                        if (warehouseFactory.Contains(this.sugarMapleTree))
                        {
                            available--;
                            this.shipment.Add(this.mapleSugar);
                            this.warehouseFactory.Remove(sugarMapleTree);
                            Console.WriteLine("You have produced and stored 1 'maple sugar'. It has been added to your shipment. You have " + this.available + " free spaces left");
                        }
                        else
                        {
                            Console.WriteLine("You do not have the neccesary tree in your inventory to produce maple sugar. Please plant or harvest a Sugar Maple Tree");
                        }
                        break;
                    case "flakes":
                        if (warehouseFactory.Contains(this.japaneseMapleTree))
                        {
                            available--;
                            this.shipment.Add(this.mapleFlakes);
                            this.warehouseFactory.Remove(japaneseMapleTree);
                            Console.WriteLine("You have produced and stored 1 'maple flakes'. It has been added to your shipment. You have " + this.available + " free spaces left");
                        }
                        else
                        {
                            Console.WriteLine("You do not have the neccesary tree in your inventory to produce maple sugar. Please plant or harvest a Japanese Maple Tree");
                        }
                        break;
                    case "taffy":
                        if (warehouseFactory.Contains(this.norwayMapleTree))
                        {
                            available--;
                            this.shipment.Add(this.mapleTaffy);
                            this.warehouseFactory.Remove(norwayMapleTree);
                            Console.WriteLine("You have produced and stored 1 'maple taffy'. It has been added to your shipment. You have " + this.available + " free spaces left");
                        }
                        else
                        {
                            Console.WriteLine("You do not have the neccesary tree in your inventory to produce maple taffy. Please plant or harvest a Norway Maple Tree");
                        }
                        break;
                    case "butter":
                        if (warehouseFactory.Contains(this.norwayMapleTree))
                        {
                            available--;
                            this.shipment.Add(this.mapleButter);
                            this.warehouseFactory.Remove(norwayMapleTree);
                            Console.WriteLine("You have produced and stored 1 'maple butter'. It has been added to your shipment. You have " + this.available + " free spaces left");
                        }
                        else
                        {
                            Console.WriteLine("You do not have the neccesary tree in your inventory to produce maple butter. Please plant or harvest a Field Maple Tree");
                        }
                        break;
                    case "water":
                        if (warehouseFactory.Contains(this.silverMapleTree))
                        {
                            available--;
                            this.shipment.Add(this.mapleWater);
                            this.warehouseFactory.Remove(silverMapleTree);
                            Console.WriteLine("You have produced and stored 1 'maple water'. It has been added to your shipment. You have " + this.available + " free spaces left");
                        }
                        else
                        {
                            Console.WriteLine("You do not have the neccesary tree in your inventory to produce maple water. Please plant or harvest a Silver Maple Tree");
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter a valid product");
                        break;

                }
            }
            else
            {
                Console.WriteLine("No available spaces left. Try harvesting some trees or expanding your factory's capacity.");
            }

        }

        public void Ship()
        {
            if(this.shipment.Count != 0)
            {
                foreach (var e in this.shipment)
                {
                    this.store.AddToInventory(e);
                    this.available++;
                }
                this.shipment.Clear();
                Console.WriteLine("You shipment has arrived at the store!");
            }
            else
            {
                Console.WriteLine("You can not ship empty items to your store!");
            }

        }

        public void GetShipmentDetails()
        {
            if (shipment.Count != 0)
            {
                Console.WriteLine("You have the following product(s) ready for shipment:");
                shipment.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("You have nothing to ship");
            }
        }

        public void GetDetails()
        {
            Console.WriteLine("Your factory currently has a capacity of " + this.capacity.ToString() + " and " + this.available.ToString() + " spaces available for production.");
            if (warehouseFactory.Count != 0)
            {
                Console.WriteLine("You have the following material(s) ready for production:");
                this.warehouseFactory.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("You have no material(s) ready for production");
            }
            GetShipmentDetails();
        }

        public void Expand(int space)
        {
            this.capacity += space;
            this.available += space;
            this.value += (space * this.expansion_cost_per_space);
            Console.WriteLine("You have expanded this factory by " + space.ToString() + ".");
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
