using PlayesTeam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication10
{
    class TeamProgram
    {
        void Main(string[] args)
        {
            Player player1 = new Player();
            player1.Age = 12;
            player1.Names = "ERato";
            player1.Nationality = "IRAN";
            player1.Field = "Hamle hamle team iran ";

            List<Player> team = new List<Player>();

            team.Add(player1);
            foreach (var player in team)
            {
                Console.WriteLine(player.Names);
            }

        }
    }
}