using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGroundProject
{
    interface IFootballTeam
    {
        void IntroduceTeam(int year);
    }
    class FootballTeam : IFootballTeam
    {
        protected string name;

        public FootballTeam(string name)
        {
            this.name = name;
        }
        public void IntroduceTeam(int year)
        {
            Console.WriteLine("The team " + name + " was founded in " + year);
        }
       

    }
}
