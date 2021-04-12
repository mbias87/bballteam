using System;
using System.Collections.Generic;
using System.Linq;

namespace BballTeam
{
    public delegate void GameFinishedDelegate(object sender, EventArgs args);

    public class TeamBase
    {
        public TeamBase(string teamName, string mascot, string location, string coach)
        {
            TeamName = teamName;
            Mascot = mascot;
            Location = location;
            Coach = coach;
        }

         /// <summary>
        /// the current teams name
        /// </summary>
        
        public string TeamName {get;set;}

        /// <summary>
        /// the teams mascot
        /// </summary>
        
        public string Mascot {get; set;}

        /// <summary>
        /// the location of the team
        /// </summary>
        
        public string Location {get; set;}

        public string Coach {get; set;}

    }
    public class Team: TeamBase
    {

        public event GameFinishedDelegate GameFinished;
        public Team(string teamName, string mascot,string location, string coach) : base(teamName,mascot,location,coach){
            
            this.TeamRecord = new Record();
            this.TeamRoster = new Roster();

        }

       
        public Record TeamRecord {get;set;}


        public Roster TeamRoster {get; set;}


        // Roster - List of Players/ List of Injured Players/ Starting 5 Players

        // Player - Add Player , Delete Player, Suspend Player

        // Record - Wins - Losses - Draws  Add Game(score,win or loss) updates record

        

        
    }
}