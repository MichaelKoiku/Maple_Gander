using System;
namespace MapleEmpire
{
    public class SilverMapleTree
    {
        readonly String name = "Silver Maple Tree";
        readonly int cost = 10000;

        public SilverMapleTree()
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
            Console.WriteLine("This is a Silver Maple Tree. It can be used to make Maple Water");
        }
    }
}
