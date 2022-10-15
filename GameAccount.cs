using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class GameAccount
    {
        List<Game> allGames = new List<Game>();

        private static int counterOfGames = 0;
        public string UserName { get; }
        public int GamesCount 
        { 
            get {
                int gamesCount = counterOfGames;  
                return gamesCount;
            }
        }
        public int CurrentRating 
        {
            get
            {
                int currentRating = 0;
                    foreach (Game element in allGames)
                    {
                        currentRating += element.Rating;
                    }
                
                return currentRating;
            }
        
        }
        

        public GameAccount(string userName)
        {
            UserName = userName;
            
        }


        public void WinGame(string gameName, int rating, string userName, string opponentName)
        {
            if (rating < 1)
            {
                throw new ArgumentException("Invalid Game. No winner");
            }

            var game = new Game(gameName, rating);
            allGames.Add(game);
            ++counterOfGames;
            Console.WriteLine("{0} won and {1} lost", userName, opponentName);
        }

        public void LoseGame(string gameName, int rating, string userName, string opponentName)
        {
            if (rating < 1)
            {
                throw new ArgumentException("Invalid Game. No winner");
            }
            var game = new Game(gameName, -rating + 1);
            allGames.Add(game);
            ++counterOfGames;
            Console.WriteLine("{0} won and {1} lost", opponentName, userName);
        }


        public string GetHistory()
        {
            var report = new StringBuilder();
            int currentRating = 0;
            report.AppendLine("Name\t\tGoal\tCurrent Rating");
            foreach (var item in allGames)
            {
                currentRating += item.Rating;
                report.AppendLine($"{item.NameOgGame}\t{item.Rating}\t{currentRating}");
            }
            return report.ToString();
        }




    }
}
