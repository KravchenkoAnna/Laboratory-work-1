using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Game
    {
        public string NameOgGame { get;  }
        public int Rating { get;  }
        public string Number { get; }

        private static int id = 123;

        public int Counter {
            get {
                int counter = 0;
                counter++;
                return counter; 
            }
            
            
        }
        public Game(string nameOfGame, int rating)
        {
            NameOgGame = nameOfGame;
            Rating = rating;
            Number = id.ToString();
            id++;
            
        }


    }
}
