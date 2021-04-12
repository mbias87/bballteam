using System;
using System.Linq;
using System.Collections.Generic;
 namespace BballTeam {

    public class Roster {


        /// <summary>
        /// adds player to roster
        /// </summary>
        /// <param name="newPlayer"></param>
        public void AddPlayer(Player newPlayer) 
        {
            this.TeamRoster.Add(newPlayer);
        }

        /// <summary>
        /// removes player from roster
        /// </summary>
        /// <param name="removedPlayer"></param>
        public void RemovePlayer(Player removedPlayer) 
        {
            this.TeamRoster.Remove(removedPlayer);
        }

        /// <summary>
        /// adds player to starting five
        /// </summary>
        /// <param name="player"></param>
        public void AddStartingFivePlayer(Player player) 
        {
            this.StartingFive.Add(player);
        }

        /// <summary>
        /// 
        /// removes player from starting five
        /// </summary>
        
        public void RemoveStartingFivePlayer(Player player) 
        {
            this.StartingFive.Remove(player);
        }

        /// <summary>
        /// adds player to injured player list
        /// </summary>
        /// <param name="player"></param>

        public void AddInjuredPlayer(Player player) 
        {
            this.InjuredPlayers.Add(player);
        }

        /// <summary>
        /// removes player from injured palyer list 
        /// </summary>
        /// <param name="player"></param>
        public void RemoveInjuredPlayer(Player player)
        {
            this.InjuredPlayers.Remove(player);
        }


        public void ShowRoster() {
            
            if (this.TeamRoster.Count() > 0) 
            {
                Console.WriteLine("The current Roster is: ");
                foreach (var player in TeamRoster) 
                {
                    Console.WriteLine($"{player.Name}");
                }

            }
        }

        /// <summary>
        /// starting 5 players
        /// </summary>
        /// <typeparam name="Player"></typeparam>
        /// <returns></returns>
        List<Player> StartingFive = new List<Player>();
        /// <summary>
        /// teams current roster
        /// </summary>
        /// <typeparam name="Player"></typeparam>
        /// <returns></returns>
        List<Player> TeamRoster = new List<Player>();

        /// <summary>
        /// list of injured players
        /// </summary>
        /// <typeparam name="Player"></typeparam>
        /// <returns></returns>
        List<Player> InjuredPlayers = new List<Player>();
    }
}