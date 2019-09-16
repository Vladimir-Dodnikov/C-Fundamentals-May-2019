using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PricePerBox { get; set; }
        public double itemPrice { get; set; }
    }
    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }
    class StoreBoxes
    {
        static void Main()
        {
            var boxes = new List<Box>();
           
            string input = string.Empty;

            while ((input=Console.ReadLine()) != "end")
            {
                if (input == "end")
                {
                    break;
                }

                string[] itemInfo = input.Split(" ");
                int itemSerialNumber = int.Parse(itemInfo[0]);
                string itemName = itemInfo[1];
                int itemQuantity = int.Parse(itemInfo[2]);
                double itemPrice = double.Parse(itemInfo[3]);

                double boxPrice = GetPriceOfBox(itemQuantity, itemPrice);

                var boxInfo = new Box();
                
                boxInfo.SerialNumber = itemSerialNumber;
                boxInfo.Item.Name = itemName;
                boxInfo.ItemQuantity = itemQuantity;
                boxInfo.Item.Price = itemPrice;
                boxInfo.PricePerBox = boxPrice;

                boxes.Add(boxInfo);
            }
            var sortedBoxes = boxes.OrderByDescending(i=>i.PricePerBox).ToList();

            foreach (var box in sortedBoxes)
            {
                Console.WriteLine($"{box.SerialNumber}\n" +
                    $"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity} \n" +
                    $"-- ${box.PricePerBox:f2}");
            }
        }

        public static double GetPriceOfBox(int itemQuantity, double itemPrice)
        {
            return itemQuantity * itemPrice;
        }
    }
}
