using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PlayGroundProject.MainClass;
using static PlayGroundProject.RepoStats;

namespace PlayGroundProject
{
    class MainClass
    {
        static void Main(string[] args)
        {
            RepoStats repo = new RepoStats();
            FootballTeam footballTeam1 = new FootballPlayer("Chelsea");
            FootballPlayer footballPlayer1 = new FootballPlayer("Chelsea", "Drogba", 11, 45, 32);
            footballPlayer1.presentPlayer();
            List<FootballPlayer> footballPlayers = new List<FootballPlayer>();
            repo.buyPlayer(footballPlayer1);
            repo.buyPlayer(footballPlayer1);
            repo.sellPlayer(footballPlayer1);
            var result = repo.numberOfPlayers;
            repo.numberOfPlayers();
            Console.WriteLine("The youngest player has " + repo.ageOfYoungestPlayer() + " years!");
            repo.sortByValue();
           // Console.WriteLine();
            
            addValues delObj1 = new addValues(repo.printSumOfTwoPlayers);
            FootballPlayer footballPlayer2 = new FootballPlayer("Chelsea", "Lampard", 8, 50, 31);

            
           

    }

        
}



}

