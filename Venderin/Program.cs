using System;
using System.Collections.Generic;
using System.Linq;
using Vendering.Items;

namespace Venderin
{
    public class Program
    {
        public static List<Item> ListOfAllItems = new List<Item>();

        static void Main(string[] args)
        {
            DoInitStuff();

            Console.WriteLine("Welcome to Vending inc!");

            char userChoice = ' ';

            while (userChoice != 'q')
            {
                Console.WriteLine("Press 'P' to purchase an item. 'I' to view inventory. Press q to quit: ");
                userChoice = Char.ToLower(Console.ReadKey().KeyChar);

                switch (userChoice)
                {
                    case 'p':
                        Item selectedItem = GetUserSelection();
                        if (VerifyFunds(selectedItem))
                            GetItem(selectedItem);
                        break;

                    case 'i':
                        break;

                    case 'q':
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Goodbye.");
        }

        public static void DoInitStuff() 
        {
            //this is not the best way to do this. I did it this way as a shortcut
            ListOfAllItems = new List<Item>();

            ListOfAllItems.Add(new Chips());
            ListOfAllItems.Add(new ChocolateBar());
            ListOfAllItems.Add(new CocaCola());
            ListOfAllItems.Add(new PepsiMax());
            ListOfAllItems.Add(new Lemon());
        }

        public static Item GetUserSelection()
        {
            Console.WriteLine();
            Console.WriteLine("Select an item category.");

            int counter = 0;
            foreach (string category in Enum.GetNames(typeof(ItemCategory)))
            {
                Console.WriteLine($"{counter+1}: {category}");
                counter++;
            }
            Console.WriteLine();

            int userSelection = Console.ReadKey().KeyChar - '0'; //this is a fancy way to cast char to int

            while (userSelection < 1 || userSelection > counter)
            {
                Console.WriteLine($"\nPlease enter a valid number between 1 and {counter}.");
                userSelection = Console.ReadKey().KeyChar - '0';
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Select an item to buy.");

            List<Item> itemList = ListOfAllItems.Where(x => x.Category == (ItemCategory)(userSelection - 1)).ToList();

            counter = 0;
            foreach (Item item in itemList)
            {               
                Console.WriteLine($"{counter+1}: {item.Name}");
                counter++;
            }
            Console.WriteLine();

            userSelection = Console.ReadKey().KeyChar - '0'; //we seem to be copy pasting code now... red flag to extract to its' own method.

            while (userSelection < 1 || userSelection > itemList.Count)
            {
                Console.WriteLine($"\nPlease enter a valid number between 1 and {counter}.");
                userSelection = Console.ReadKey().KeyChar - '0';
            }

            Item selectedItem = itemList[userSelection - 1];

            Console.WriteLine($"\n\nYou picked {selectedItem.Name}.");


            return selectedItem;
        }

        public static bool VerifyFunds(Item selectedItem)
        {
            //if (CustomerMoney >= selectedItem.Price) ...

            return true;
        }

        public static void GetItem(Item selectedItem)
        {
            /*
            if (VendingMachineInventory.Contains(selectedItem))
            {
                VendingMachineInventory.Remove(selectedItem);
                CustomerInventory.Add(selectedItem);
            }
            else
            {
                Console.WriteLine("Sorry that is out of stock");
            }
            */
        }
    }
}
