using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PetStore
{
    public static class DecimalExtensions
    {
        public static decimal DiscountPrice(decimal lylaPrice)
        {
            lylaPrice = lylaPrice * 0.9m;
            return lylaPrice;
        }
        public static decimal DiscountThisPrice(this decimal lylaPrice)
        {
            lylaPrice = Math.Round(lylaPrice * 0.9m, 2);
            return lylaPrice;
        }
    }
    public static class CollectionExtensions
    {
        public static List<T> InStock<T>(this List<T> list) where T : Product
        {
            return list.Where(dL => dL.Quantity > 0).ToList();
        }
            public static void DisplayAllProducts<T>(this List<T> list) where T : Product
            {
            bool validSearch;
            foreach (var item in list)
            {
                try
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                    Console.WriteLine($"Name:                           {item.Name}");
                    Console.WriteLine($"Description:                    {item.Description}");
                    Console.WriteLine($"Price:                          {item.Price}");
                    Console.WriteLine($"Discounted Price:               {item.Price.DiscountThisPrice()}");
                    Console.WriteLine($"Quantity:                       {item.Quantity}");
                    //try { Console.WriteLine($"Safe for Kittens:               {_products[name].Value.KittenFood}");

                    Console.WriteLine("----------------------------------------------------------------------------------------");

                    validSearch = true;
                }
                catch (KeyNotFoundException e)
                {
                    validSearch = false;
                    Console.WriteLine("\nProduct doesn't exist in database.\n");
                    Console.WriteLine("----------------------------------------------------------------------------------------");
                }
            }
        } //Can't use generics with a dictionary have to fix edit function to update list too!!
    } // use bracket using Tkey, TValue to use generics with a dictionary. just use a list for now. maybe someday
}
