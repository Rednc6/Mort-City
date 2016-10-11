using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureVer1
{
    public class StartGame
    {
        public StartGame()
        {
            Player newPlayer = new Player(20, 20, 2500);
            Console.WriteLine("\r\n\n\n\n Pick your name \r\n");
            newPlayer.Name = Console.ReadLine();
            
            Locations homeLocation = new Locations(01, "Home", "Slayers street 97F, apartment 834c. Home sweet Home");
 

        }
        
    }
}
