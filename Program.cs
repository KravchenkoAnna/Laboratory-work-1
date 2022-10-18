using System;

namespace Lab1 {

    class Program {

        static void Main(string[] args) {

            
            string username = "Roland";
            Console.WriteLine(username);
            string opponentname = "Bob";
            Console.WriteLine(opponentname);

            Console.WriteLine("\nGame account for " + username + "\n");
            int goal1 = 20;
            Console.WriteLine("The game goal is " + goal1 + "\n");
            int tempCounter = 0;
            
            GameAccount first = new GameAccount(username);


            first.WinGame("Football game", goal1, username, opponentname);
            Console.WriteLine("{0}`s rating is {1}", username, first.CurrentRating);
            
            Console.WriteLine();
            first.LoseGame("Football game", goal1, username, opponentname);
            Console.WriteLine("{0}`s rating is {1}", username, first.CurrentRating);
            
            Console.WriteLine("Roland`s plaing history:\n");
            Console.WriteLine(first.GetHistory());

            Console.WriteLine("\nGame account for " + opponentname + "\n");

            int goal2 = 30;
            Console.WriteLine("The game goal is " + goal2 + "\n");

            GameAccount second = new GameAccount(opponentname);


            second.WinGame("Tennis game", goal2, opponentname, username);
            Console.WriteLine("{0}`s rating is {1}", opponentname, second.CurrentRating);
            
            Console.WriteLine();
            second.LoseGame("Tennis game", goal2, opponentname, username);
            Console.WriteLine("{0}`s rating is {1}", opponentname, second.CurrentRating);
            
            Console.WriteLine("Bob`s plaing history:\n");
            Console.WriteLine(second.GetHistory());

        }
    }
}

