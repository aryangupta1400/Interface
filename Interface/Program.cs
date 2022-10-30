
// 4) Create Interface for Fruits and implement method in diffrent fruits.
//    Then print name and color of that fruits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            apple.FruitColor();
            apple.VitaminContent();

            Mango mango = new Mango();
            mango.FruitColor();
            mango.VitaminContent();

            Console.ReadKey();
        }
    }

    interface IFruit
    {
        void FruitColor();
        
        void VitaminContent();
    }

    class Apple : IFruit
    {
        public void FruitColor()
        {
            Console.WriteLine("\nApples are RED in color.");
        }

        public void VitaminContent()
        {
            Console.WriteLine("Apples have high Vitamin C and Vitamin E content.\n");
        }
    }

    class Mango : IFruit
    {
        public void FruitColor()
        {
            Console.WriteLine("\nMango are YELLOW in color.");
        }

        public void VitaminContent()
        {
            Console.WriteLine("Apples have high Vitamin A, Vitamin C and Vitamin K content.\n");
        }
    }
}
