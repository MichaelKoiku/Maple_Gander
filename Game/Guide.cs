using System;
namespace MapleEmpire
{
    public class Guide
    {
        public Guide()
        {
        }

        public void PrintGuide()
        {
            Console.WriteLine("\nPlayer Guide");

            Console.WriteLine("\nGame Commands");
            Console.WriteLine("help - see player guide");
            Console.WriteLine("stats - see your current stats and other game stats");
            Console.WriteLine("quit - quit game");

            Console.WriteLine("\nFarm Commands");
            Console.WriteLine("plant - plant Maple trees in your farm");
            Console.WriteLine("harvest - harvest your trees and send them to your factory as raw materials");
            Console.WriteLine("expand farm - add extra spaces to your farm");
            Console.WriteLine("status farm - get the current details about your farm");

            Console.WriteLine("\nFactory Commands");
            Console.WriteLine("status factory - get the current details about your factory and shipment");
            Console.WriteLine("produce - produce available products in your Factory");
            Console.WriteLine("ship - ship your Factory products to your store for sales");
            Console.WriteLine("expand factory - add extra spaces to your factory");

            Console.WriteLine("\nStore Controls");
            Console.WriteLine("sell - sell an item from your store");
            Console.WriteLine("withdraw - move all gross profits from store to cash balance. This sets your store's profits to zero");
            Console.WriteLine("status market - get the current market prices");
            Console.WriteLine("status store - get the current details about your store");

        }
    }
}
