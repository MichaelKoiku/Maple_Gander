using System;

namespace MapleEmpire
{
    class Game
    {
        int day;
        int cash;
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
        Guide guide;
        Farm playerFarm;
        Factory factory;
        Store store;
        int valuation;

        public Game()
        {
            this.cash = 100000;
            this.canadianMapleTree = new CanadianMapleTree();
            this.sugarMapleTree = new SugarMapleTree();
            this.guide = new Guide();
            this.mapleSyrup = new MapleSyrup();
            this.mapleSugar = new MapleSugar();
            this.playerFarm = new Farm(this.factory);
            this.factory = new Factory(this.store, this.canadianMapleTree, this.sugarMapleTree, this.japaneseMapleTree, this.norwayMapleTree, this.fieldMapleTree, this.silverMapleTree,this.mapleSyrup, this.mapleSugar, this.mapleFlakes, this.mapleTaffy, this.mapleButter, this.mapleWater);
            this.store = new Store(this.mapleSyrup, this.mapleSugar);
            this.valuation = this.cash + this.playerFarm.GetValue() + this.factory.GetValue() + this.store.GetValue();

        }

        public void StartGame()
        {
            bool flag = true;

            while (flag)
            {
                if(this.cash <= 0)
                {
                    flag = false;
                    Console.WriteLine("\nOops, you went bankrupt. Game over");
                }

                //Set price on each action -> Change to Game Manager.runProcesses()
                store.SetMarketandBlackMarketPrice();

                //Game Controls
                Console.Write("Enter command: ");
                string command = Console.ReadLine();

                switch (command)
                {
                    //Gameplay Commands
                    case "quit":
                        flag = false;
                        Console.WriteLine("\nThank you for playing.");
                        break;
                    case "help":
                        this.guide.PrintGuide();
                        break;
                    case "stats":
                        Console.WriteLine("\nPlayer Stats");
                        Console.WriteLine("Current Cash: " + this.cash.ToString());
                        Console.WriteLine("Current Farm Value: " + this.playerFarm.GetValue().ToString());
                        Console.WriteLine("Current Factory Value: " + this.factory.GetValue().ToString());
                        Console.WriteLine("Current Store Profit: " + this.store.GetValue().ToString());
                        Console.WriteLine("Current Valuation: " + this.valuation);

                        Console.WriteLine("\nGameplay Stats");
                        Console.WriteLine("Plant Tree Costs");
                        Console.WriteLine("\tCanadian Maple Tree: " + this.canadianMapleTree.GetCost().ToString());
                        Console.WriteLine("\tSugar Maple Tree: " + this.sugarMapleTree.GetCost().ToString());
                        Console.WriteLine("Expand Farm or Factory Cost: " + this.playerFarm.GetExpansionCost().ToString());
                        //Console.WriteLine("Store in Storage beyond capacity cost: ");
                        break;
                    //Farm Commands
                    case "plant":
                        Console.Write("What tree would you like to plant? (canadian/sugar): ");
                        string answer0 = Console.ReadLine();
                        switch (answer0.ToLower())
                        {
                            case "canadian":
                                if (this.cash > this.canadianMapleTree.GetCost())
                                {
                                    playerFarm.Plant(this.canadianMapleTree, this.canadianMapleTree.getName());
                                    this.cash -= this.canadianMapleTree.GetCost();
                                }
                                else
                                {
                                    Console.WriteLine("You do not have enough cash to plant this tree. Try a cheaper alternative");
                                }
                                break;
                            case "sugar":
                                if (this.cash > this.sugarMapleTree.GetCost())
                                {
                                    playerFarm.Plant(this.sugarMapleTree, this.sugarMapleTree.getName());
                                    this.cash -= this.sugarMapleTree.GetCost();
                                }
                                else
                                {
                                    Console.WriteLine("You do not have enough cash to plant this tree. Try a cheaper alternative");
                                }
                                break;
                            case "japanese":
                                if (this.cash > this.japaneseMapleTree.GetCost())
                                {
                                    playerFarm.Plant(this.japaneseMapleTree, this.japaneseMapleTree.getName());
                                    this.cash -= this.japaneseMapleTree.GetCost();
                                }
                                else
                                {
                                    Console.WriteLine("You do not have enough cash to plant this tree. Try a cheaper alternative");
                                }
                                break;
                            case "norway":
                                if (this.cash > this.norwayMapleTree.GetCost())
                                {
                                    playerFarm.Plant(this.norwayMapleTree, this.norwayMapleTree.getName());
                                    this.cash -= this.norwayMapleTree.GetCost();
                                }
                                else
                                {
                                    Console.WriteLine("You do not have enough cash to plant this tree. Try a cheaper alternative");
                                }
                                break;
                            case "field":
                                if (this.cash > this.fieldMapleTree.GetCost())
                                {
                                    playerFarm.Plant(this.fieldMapleTree, this.fieldMapleTree.getName());
                                    this.cash -= this.fieldMapleTree.GetCost();
                                }
                                else
                                {
                                    Console.WriteLine("You do not have enough cash to plant this tree. Try a cheaper alternative");
                                }
                                break;
                            case "silver":
                                if (this.cash > this.silverMapleTree.GetCost())
                                {
                                    playerFarm.Plant(this.silverMapleTree, this.silverMapleTree.getName());
                                    this.cash -= this.silverMapleTree.GetCost();
                                }
                                else
                                {
                                    Console.WriteLine("You do not have enough cash to plant this tree. Try a cheaper alternative");
                                }
                                break;
                            default:
                                Console.WriteLine("\nEnter a valid tree to plant.");
                                break;
                        }
                        break;
                    case "harvest":
                        Console.Write("What tree would you like to harvest from your farm (canadian/sugar): ");
                        string answer1 = Console.ReadLine();
                        switch (answer1.ToLower())
                        {
                            case "canadian":
                                playerFarm.Harvest(this.canadianMapleTree, this.canadianMapleTree.getName());     
                                break;
                            case "sugar":
                                playerFarm.Harvest(this.sugarMapleTree, this.sugarMapleTree.getName());
                                break;
                            case "japanese":
                                playerFarm.Harvest(this.japaneseMapleTree, this.japaneseMapleTree.getName());
                                break;
                            case "norway":
                                playerFarm.Harvest(this.norwayMapleTree, this.norwayMapleTree.getName());
                                break;
                            case "field":
                                playerFarm.Harvest(this.fieldMapleTree, this.fieldMapleTree.getName());
                                break;
                            case "silver":
                                playerFarm.Harvest(this.silverMapleTree, this.silverMapleTree.getName());
                                break;
                            default:
                                Console.WriteLine("\nEnter a valid tree to harvest.");
                                break;
                        }
                        break;
                    case "expand farm":
                        Console.Write("How many extra spaces would you like to add to your farm?: ");
                        int answer2 = Convert.ToInt32(Console.ReadLine());
                        if (this.cash > playerFarm.GetExpansionCost() * answer2)
                        {
                            this.cash -= (playerFarm.GetExpansionCost() * answer2);
                            playerFarm.Expand(answer2);
                        }
                        else
                        {
                            Console.WriteLine("Woah Woah. Slow Down! You can't afford that right now.");
                        }
                        break;
                    case "status farm":
                        playerFarm.GetDetails();
                        break;
                    //Factory Controls
                    case "status factory":
                        factory.GetDetails();
                        break;
                    
                    case "produce":
                        factory.Produce();
                        break;
                    case "ship":
                        factory.Ship();
                        break;
                    case "expand factory":
                        Console.Write("How many extra spaces would you like to add to your factory?: ");
                        int answer3 = Convert.ToInt32(Console.ReadLine());
                        if (this.cash > factory.GetExpansionCost() * answer3)
                        {
                            this.cash -= (factory.GetExpansionCost() * answer3);
                            factory.Expand(answer3);
                        }
                        else
                        {
                            Console.WriteLine("Woah Woah. Slow Down! You can't afford that right now.");
                        }
                        break;
                    //Store Controls
                    case "sell":
                        this.store.Sell();
                        break;
                    case "withdraw":
                        this.cash += this.store.GetProfit();
                        break;
                    case "status market":
                        this.store.GetMarketDetails();
                        break;
                    case "status store":
                        this.store.GetMarketDetails();
                        break;
                    default:
                        Console.WriteLine("\nInvalid command. type 'help' to see the player guide.");
                        break;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("An Intellectual Property of SOLID Incorporated");
            Console.WriteLine("Maple Empire: A game designed and developed by Michael Koiku.");
            Console.WriteLine("\nWelcome to Maple Empire! You are an entrepreneur starting with 100,000 CAD that wants to make his humble Maple Business into an Empire. \nCan you do it? The road might be tough and the market unforgiving but as long as you do not go bankrupt, everyday is a new day to reach your goal. Good Luck!");
            Console.WriteLine("\nType 'help' to see the player guide");

            Game game = new Game();
            game.StartGame();
        }
    }
}
