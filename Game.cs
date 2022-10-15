using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Game
    {
        public string NameOgGame { get;  }
        public int Rating { get;  }
        

        public Game(string nameOfGame, int rating)
        {
            NameOgGame = nameOfGame;
            Rating = rating;
            
        }


    }
}
