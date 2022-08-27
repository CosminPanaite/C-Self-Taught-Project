using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PlayGroundProject
{
    interface IFootballPlayer
    {
        void presentPlayer();
    }
    class FootballPlayer : FootballTeam,IFootballPlayer
    {
        public string playerName;
        public int value;
        public int number;
        public int age;
        

        public FootballPlayer(string name) : base(name)
        {

        }
        public FootballPlayer(string teamName, string playerName, int value, int number, int age) : this(teamName)
        {
            
            this.playerName = playerName;
            this.value = value;
            this.number = number;
            this.age = age;
        }

        public void presentPlayer( )
        {
            Console.WriteLine("The player " + playerName + " from team "+ name +" has a value of " + value + " milions and his age is " + age);
        }

    }
}
