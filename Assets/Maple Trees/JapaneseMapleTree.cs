using System;
namespace MapleEmpire
{
    public class JapaneseMapleTree
    {
        readonly String name = "Japanese Maple Tree";
        readonly int cost = 5000;

        public JapaneseMapleTree()
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
            Console.WriteLine("This is a Japanese Maple Tree. It can be used to make Maple Flakes");
        }
    }
}
