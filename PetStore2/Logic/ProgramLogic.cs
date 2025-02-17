﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Logic
{
    public class ProgramLogic : Program
    {
        public void OpeningSequence()
        {
            //when makin 
            Console.Beep(392, 250);
            Console.Beep(349, 250);
            Console.Beep(294, 250);
            Console.Beep(220, 250);
            Console.Beep(196, 250);
            Console.Beep(330, 250);
            Console.Beep(392, 250);
            Console.Beep(494, 250);
            Console.WriteLine("------------------------------ Welcome To The Pet Store! -------------------------------");

            Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\r\n                                                                |\\_/|  \r\n                                                      \t        | @ @   Woof!\r\n           __..--''``---....___   _..._    __         \t        |   <>\r\n /// //_.-'    .-/\";  `        ``<._  ``.''_ `. / // /\t        |  _/\\------____ ((| |))\r\n///_.-' _..--.'_    \\                    `( ) ) // //           |               `--' |\r\n/ (_..-' // (< _     ;_..__               ; `' / ///        ____|_       ___|   |___.'\r\n / // // //  `-._,_)' // / ``--...____..-' /// / //        /_/_____/____/_______|\r\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        public void DisplayMenuInputOptions()
        {
            Console.WriteLine("------------------------------- [Please Select An Option] ------------------------------");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write(" [1 Find Or Create New Order]");
            Console.Write(" [2 Add Product To Order By Product Id]");
            //Console.Write(" [7 Total Inventory Price]");
            Console.Write(" \n [3 View Number of Products in Database]");
            Console.WriteLine(" [4 View Product List]");
            Console.WriteLine("\n[5 View Current Orders]");
            Console.Write(" [6 Change Current Order By OrderId]");
            Console.WriteLine(" [7 View Order By OrderId]");
            //Console.Write(" [9 For In Stock Products]");
            //Console.WriteLine(" [10 For Out Of Stock Products]");
            Console.WriteLine(" [0 Add New Product]");
            Console.WriteLine(" [Type 'exit' to quit]");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        //public void CreateNewProductOption()
        //{
        //    string userInput;
        //    do
        //    {
        //        Console.WriteLine("Select Product Type.\n[1:Dog Leash] [2:Cat Food]");
        //        Console.Write("User Input:");
        //        userInput = Console.ReadLine();

        //        if (userInput.ToLower().Replace(" ", "") == "1")
        //        {
        //            Console.WriteLine("You've Selected Dog Leash");
        //            NewDogLeash();
        //            break;
        //        }
        //        else if (userInput.ToLower().Replace(" ", "") == "2")
        //        {
        //            Console.WriteLine("You've Selected Cat Food.");
        //            CatFoodLogic.NewCatFood();

        //            break;
        //        }
        //    } while (userInput.ToLower().Trim() != "1" && userInput.Trim() != "2");
        //}
    }
}

