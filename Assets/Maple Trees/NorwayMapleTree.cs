using System;
namespace MapleEmpire
{
    public class NorwayMapleTree
    {
        readonly String name = "Norway Maple Tree";
        readonly int cost = 7000;

        public NorwayMapleTree()
        {
        }

        public String getName()
        {
            return name;
        }

        public int GetCost()
        {
            return cost;
        }

        public void GetDetails()
        {
            Console.WriteLine("This is a Norway Maple Tree. It can be used to make Maple Taffy");
        }
    }
}
