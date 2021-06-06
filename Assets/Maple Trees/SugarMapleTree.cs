using System;
namespace MapleEmpire
{
    public class SugarMapleTree
    {
        readonly String name = "Sugar Maple Tree";
        readonly int cost = 3500;

        public SugarMapleTree()
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
            Console.WriteLine("This is a Sugar Maple Tree. It can be used to make Maple Sugar");
        }
    }
}
