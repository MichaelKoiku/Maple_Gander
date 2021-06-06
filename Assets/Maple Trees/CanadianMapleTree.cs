using System;
namespace MapleEmpire
{
    public class CanadianMapleTree
    {
        readonly String name = "Canadian Maple Tree";
        readonly int cost = 2500;

        public CanadianMapleTree()
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
            Console.WriteLine("This is a Canadian Maple Tree. It can be used to make Maple Syrup");
        }
    }
}
