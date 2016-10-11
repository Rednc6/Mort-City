using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\r\n");
            Console.WriteLine("  ////////////////////////////////////////////////////////");
            Console.WriteLine("  //                                                    //");
            Console.WriteLine("  //                                                    //");
            Console.WriteLine("  //                                                    //");
            Console.WriteLine("  //                Welcome to                          //");
            Console.WriteLine("  //                       Mort City                    //");
            Console.WriteLine("  //                                                    //");
            Console.WriteLine("  //                                                    //");
            Console.WriteLine("  //                                                    //");
            Console.WriteLine("  ////////////////////////////////////////////////////////");
            Console.ResetColor();
            Console.WriteLine("");

            StartGame startgame = new StartGame();
            Console.ReadLine();
            // switchto start game and... start the game. Add later.
        }
    }
}
