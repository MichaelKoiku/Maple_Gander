using System;
using System.Collections.Generic;

namespace MapleEmpire
{
    public class Store
    {
        List<Object> invetory;
        int mapleSyrupMarketPrice;
        int mapleSyrupBlackMarketPrice;
        int mapleSugarMarketPrice;
        int mapleSugarBlackMarketPrice;
        int retailBaseLine;
        int profit;
        MapleSyrup mapleSyrup;
        MapleSugar mapleSugar;

        public Store(MapleSyrup m, MapleSugar s)
        {
            this.invetory = new List<Object>();
            this.mapleSyrupMarketPrice = 4;
            this.mapleSyrupBlackMarketPrice = 4;
            this.mapleSugarMarketPrice = 8;
            this.mapleSugarBlackMarketPrice = 8;
            this.retailBaseLine = 3;
            this.profit = 0;
            this.mapleSyrup = m;
            this.mapleSugar = s;
        }

        public void AddToInventory(Object product)
        {
            this.invetory.Add(product);
        }

        public void SetMarketandBlackMarketPrice()
        {
            Random rnd = new Random();
            int newSyrupDailyPrice = rnd.Next(1, 6);
            int newSyrupBlackMarketPrice = rnd.Next(1, 6);
            int newSugarDailyPrice = rnd.Next(1, 10);
            int newSugarBlackMarketPrice = rnd.Next(1, 10);
            this.mapleSyrupMarketPrice = newSyrupDailyPrice;
            this.mapleSyrupBlackMarketPrice = newSyrupBlackMarketPrice;
            this.mapleSugarMarketPrice = newSugarDailyPrice;
            this.mapleSugarBlackMarketPrice = newSugarBlackMarketPrice;
        }

        public void GetMarketPrice()
        {

            Console.WriteLine("Maple Syrup: " + this.mapleSyrupMarketPrice);
            Console.WriteLine("Maple Sugar: " + this.mapleSugarMarketPrice);
        }

        public void GetBlackMarketPrice()
        {
            Console.WriteLine("Maple Syrup: " + this.mapleSyrupBlackMarketPrice);
            Console.WriteLine("Maple Sugar: " + this.mapleSugarBlackMarketPrice);
        }

        public void GetMarketDetails()
        {
            Console.WriteLine("\nDaily Market Price:");
            GetMarketPrice();
            Console.WriteLine("\nDaily Black Market Price:");
            GetBlackMarketPrice();
        }

        public int GetProfit()
        {
            int withdrawal = this.profit;
            this.profit = 0;
            return withdrawal;
        }

        public int GetValue()
        {
            return this.profit;
        }

        public void Sell()
        {
            Console.Write("\nWhat would you like to sell? (syrup/sugar): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "syrup":
                    if (invetory.Contains(mapleSyrup))
                    {
                        invetory.Remove(mapleSyrup);
                        Console.Write("Do you want to sell on the market or the black market? (market/black): ");
                        string answer2 = Console.ReadLine();

                        switch (answer2.ToLower())
                        {
                            case "market":
                                profit += ((this.mapleSyrupMarketPrice - this.retailBaseLine) * 2000);
                                Console.WriteLine("You sold on the market for " + profit);
                                break;
                            case "black":
                                profit += ((this.mapleSyrupBlackMarketPrice - this.retailBaseLine) * 2000);
                                Console.WriteLine("You sold on the black market for " + profit);
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Maple syrup is unavailable in your inventory.");
                    }
                    break;
                case "sugar":
                    if (invetory.Contains(mapleSugar))
                    {
                        invetory.Remove(mapleSugar);
                        Console.Write("Do you want to sell on the market or the black market? (market/black): ");
                        string answer2 = Console.ReadLine();

                        switch (answer2.ToLower())
                        {
                            case "market":
                                profit += ((this.mapleSugarMarketPrice - this.retailBaseLine) * 4000);
                                Console.WriteLine("You sold on the market for " + profit);
                                break;
                            case "black":
                                profit += ((this.mapleSugarBlackMarketPrice - this.retailBaseLine) * 4000);
                                Console.WriteLine("You sold on the black market for " + profit);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Maple sugar is unavailable in your inventory.");
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid product");
                    break;
            }
        }
    }
}
