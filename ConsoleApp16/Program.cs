
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using static Proggram.Products;


namespace Proggram {


    public class Products
    {
        public class bread
        {
            public string Name = "Bread";
            public int Id { get; set; }
            public int Price = 22;
        }
        public class Milk
        {
            public string Name = "Milk";
            public int Id { get; set; }
            public int Price = 60;
        }
        public class Eggs
        {
            public string Name = "Eggs";
            public int Id { get; set; }
            public int Price = 30;
        }
    }


    public class Shop
    {

        public List<Products.bread> Bread { get; set; }
        public List<Products.Milk> Milk { get; set; }
        public List<Products.Eggs> Eggs { get; set; }

        public Shop()
        {
            Bread = new List<Products.bread>();
            Milk = new List<Products.Milk>();
            Eggs = new List<Products.Eggs>();

        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            int money = 200;

            

            Shop findlistinshop = new Shop();

            Products.bread bread = new Products.bread();
            bread.Id = 10;

            findlistinshop.Bread.Add(bread);

            Products.Milk milk = new Products.Milk();
            milk.Id = 10;
            findlistinshop.Milk.Add(milk);

            Products.Eggs eggs = new Products.Eggs();
            eggs.Id = 10;
            findlistinshop.Eggs.Add(eggs);

            Console.WriteLine("Hello and welcome to our shop! You can choose what products you need: ");
            

            StringBuilder allproducts1 = new StringBuilder();
            StringBuilder allproducts2 = new StringBuilder();
            StringBuilder allproducts3 = new StringBuilder();
            Work(bread, milk, eggs, money, allproducts1, allproducts2, allproducts3);




        }

        public static void Work(Products.bread bread, Products.Milk milk, Products.Eggs eggs, int money, StringBuilder allproducts1, StringBuilder allproducts2, StringBuilder allproducts3) {

            Console.WriteLine($"1 - Bread: Price - {bread.Price}, in avaible - {bread.Id}");
            Console.WriteLine($"2 - Milk: Price - {milk.Price}, in avaible - {milk.Id}");
            Console.WriteLine($"3 - Eggs: Price - {eggs.Price}, in avaible - {eggs.Id}");
            Console.WriteLine($"4 - Add new quantity to existent ");

            Console.WriteLine("Your choise: ");

            

            int input = int.Parse(Console.ReadLine());

            bool fa = true;

            while (fa)
            {
                switch (input)
                {
                    case 1:
                        Console.WriteLine($"Bread: Price - {bread.Price}, in avaible - {bread.Id}");
                        Console.WriteLine("Do you want to buy this? Y/N ");
                        string answer = Console.ReadLine();
                        if (answer == "Y")
                        {
                            Console.WriteLine("What count of this product do you need? ");
                            int count = int.Parse(Console.ReadLine());
                            if (count > bread.Id)
                            {
                                Console.WriteLine("We don`t have this count of this product");
                            }
                            else
                            {
                                if (money >= (count * bread.Price) || bread.Id >= count)
                                {
                                    money = money - (count * bread.Price);
                                    bread.Id = bread.Id - count;
                                    allproducts1.Append($"Bread ({count}) = {count * bread.Price} UAH.");

                                    Console.WriteLine("We add this product in your list. Do you want to continue or we can sum up? y/n ");
                                    string ans = (Console.ReadLine());
                                    if (ans == "y")
                                    {
                                        Work(bread, milk, eggs, money, allproducts1, allproducts2, allproducts3);
                                    }
                                    if (ans == "n")
                                    {
                                        Receipt(bread, milk, eggs, money, allproducts1.ToString(), allproducts2.ToString(), allproducts3.ToString());
                                    }
                                    fa = false;
                                }
                                else
                                {
                                    Console.WriteLine("You dont have enough money or this count of product is not in avaible.");
                                }
                            }
                        }
                        else if (answer == "N")
                        {
                            fa = false;
                        }
                        else
                        {
                            goto case (1);
                        }
                        break;
                    case 2:
                        Console.WriteLine($"Milk: Price - {milk.Price}, in avaible - {milk.Id}");
                        Console.WriteLine("Do you want to buy this? Y/N ");
                        string answer2 = Console.ReadLine();
                        if (answer2 == "Y")
                        {
                            Console.WriteLine("What count of this product do you need? ");
                            int count2 = int.Parse(Console.ReadLine());
                            if (count2 > milk.Id)
                            {
                                Console.WriteLine("We don`t have this count of this product");
                            }
                            else
                            {
                                if (money >= (count2 * milk.Price) || milk.Id >= count2)
                                {
                                    money = money - (count2 * milk.Price);
                                    milk.Id = milk.Id - count2;
                                    allproducts2.Append($"Milk ({count2}) = {count2 * milk.Price} UAH.");
                                    Console.WriteLine("We add this product in your list. Do you want to continue or we can sum up? y/n ");
                                    string ans = (Console.ReadLine());
                                    if (ans == "y")
                                    {
                                        Work(bread, milk, eggs, money, allproducts1, allproducts2, allproducts3);
                                    }
                                    if (ans == "n")
                                    {
                                        Receipt(bread, milk, eggs, money, allproducts1.ToString(), allproducts2.ToString(), allproducts3.ToString());
                                    }
                                    fa = false;
                                }
                                else
                                {
                                    Console.WriteLine("You dont have enough money or this count of product is not in avaible.");
                                }
                            }
                        }
                        else if (answer2 == "N")
                        {
                            fa = false;
                        }
                        else
                        {
                            goto case (2);
                        }
                        break;
                    case 3:
                        Console.WriteLine($"Eggs: Price - {eggs.Price}, in avaible - {eggs.Id}");
                        Console.WriteLine("Do you want to buy this? Y/N ");
                        string answer3 = Console.ReadLine();
                        if (answer3 == "Y")
                        {
                            Console.WriteLine("What count of this product do you need? ");
                            int count3 = int.Parse(Console.ReadLine());
                            if (count3 > eggs.Id)
                            {
                                Console.WriteLine("We don`t have this count of this product");
                            }
                            else
                            {
                                if (money >= (count3 * eggs.Price) || eggs.Id >= count3)
                                {
                                    money = money - (count3 * eggs.Price);
                                    eggs.Id = eggs.Id - count3;
                                    allproducts3.Append($"Eggs ({count3}) = {count3 * eggs.Price} UAH.");
                                    Console.WriteLine("We add this product in your list. Do you want to continue or we can sum up? y/n ");
                                    string ans = (Console.ReadLine());
                                    if (ans == "y")
                                    {
                                        Work(bread, milk, eggs, money, allproducts1, allproducts2, allproducts3);
                                    }
                                    if (ans == "n")
                                    {
                                        Receipt(bread, milk, eggs, money, allproducts1.ToString(), allproducts2.ToString(), allproducts3.ToString());
                                    }
                                    fa = false;
                                }
                                else
                                {
                                    Console.WriteLine("You dont have enough money or this count of product is not in avaible.");
                                }
                            }
                        }
                        else if (answer3 == "N")
                        {
                            fa = false;
                        }
                        else
                        {
                            goto case (3);
                        }
                        break;
                    case 4:
                        Console.WriteLine("What type of products you choose? ");
                        Console.WriteLine($"Bread - 1 (Now {bread.Id}), Milk - 2 (Now {milk.Id}), Eggs - 3 (Now {bread.Id})");
                        int g = int.Parse(Console.ReadLine());
                        switch (g)
                        {
                            case 1:
                                Console.WriteLine("Enter quantity: ");
                                int quanbr = int.Parse(Console.ReadLine());
                                bread.Id = quanbr;
                                break;
                            case 2:
                                Console.WriteLine("Enter quantity: ");
                                int quanmilk = int.Parse(Console.ReadLine());
                                milk.Id = quanmilk;
                                break;
                            case 3:
                                Console.WriteLine("Enter quantity: ");
                                int quaneggs = int.Parse(Console.ReadLine());
                                eggs.Id = quaneggs;
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("What?");
                        break;
                }
            }
        }

        public static void Receipt(Products.bread bread, Products.Milk milk, Products.Eggs eggs, int money, string allproducts1, string allproducts2, string allproducts3)
        {

            Console.WriteLine("Your name and surname: ");
            string clientinfo = Console.ReadLine();

            Console.WriteLine("Receipt:");
            Console.WriteLine("");
            Console.WriteLine($"Customer {clientinfo} buyed: ");
            Console.WriteLine("");
            Console.WriteLine(allproducts1);
            Console.WriteLine(allproducts2);
            Console.WriteLine(allproducts3);
            Console.WriteLine("");
            Console.WriteLine($"Total cost: {200 - money} UAH");
        }
    }
}