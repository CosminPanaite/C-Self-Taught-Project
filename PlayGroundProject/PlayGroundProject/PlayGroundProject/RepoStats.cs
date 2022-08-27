using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Authentication;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PlayGroundProject
{
    
    class RepoStats 
    {
        List<FootballPlayer>repo=new List<FootballPlayer>();
        List<FootballTeam> teams = new List<FootballTeam>();
        
        public void addTeams(FootballTeam team) {
            teams.Add(team);        
        }

        public void removeTeams(FootballTeam team)
        {
            teams.Remove(team);
        }

            public void buyPlayer(FootballPlayer footballPlayer)
        {
            repo.Add(footballPlayer);
        }

        public void  numberOfPlayers()
        {
            Console.WriteLine("The number of players is "+repo.Count);
        }

        public void sellPlayer(FootballPlayer footballPlayer)
        {
            repo.Remove(footballPlayer);
        }

        public int ageOfYoungestPlayer()
        {
            List<int>ages=new List<int>();
            foreach(FootballPlayer footballPlayer in repo)
            {
                ages.Add(footballPlayer.age);
            }
            var result = ages.Min();

            return result;
        }
        public int veteranPlayer()
        {
            List<int> ages = new List<int>();
            foreach (FootballPlayer footballPlayer in repo)
            {
                ages.Add(footballPlayer.age);
            }
            var result = ages.Max();

            return result;
        }
        public void sortByValue()
        {
            List<int> values = new List<int>();
            foreach (FootballPlayer footballPlayer in repo)
            {
                values.Add(footballPlayer.value);
            }
            values.Sort();
            Console.WriteLine("Values of team" + values);            
        }

        public delegate void addValues(int a, int b);

        public void printSumOfTwoPlayers(int a, int b)

        {
            FootballPlayer footballPlayer1 = new FootballPlayer("Chelsea", "Drogba", 11, 45, 32);

            FootballPlayer footballPlayer2 = new FootballPlayer("Chelsea", "Lampard", 8, 50, 31);
            a = footballPlayer1.value;
            b = footballPlayer2.value;
            var result = a + b;
            Console.WriteLine("The sum of values of 2 players is " + result);



        }
      
    }


}
