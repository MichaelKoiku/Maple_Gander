using System;
namespace MapleEmpire
{
    public class FieldMapleTree
    {
        readonly String name = "Field Maple Tree";
        readonly int cost = 8500;

        public FieldMapleTree()
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
            Console.WriteLine("This is a Field Maple Tree. It can be used to make Maple Butter");
        }
    }
}
