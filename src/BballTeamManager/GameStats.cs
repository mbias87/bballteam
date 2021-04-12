

using System;

namespace BballTeam {
    
    public class GameStats {

        
        /// <summary>
        /// the home team name
        /// </summary>
        /// <value></value>
        public string HomeTeam {get ;set;}
        /// <summary>
        /// the away team name
        /// </summary>
        /// <value></value>
        public string AwayTeam {get; set;}

        /// <summary>
        /// home team points 
        /// </summary>
        /// <value></value>
        public int HomeTeamPoints {get; set;}

        /// <summary>
        /// away team points 
        /// </summary>
        /// 
        public int AwayTeamPoints {get; set;}


        public object GameSim(Team teamOne, Team teamTwo) {
            Random rnd = new Random();
            int number = rnd.Next(60,150);

            var homeTeam = new { Team = teamOne.TeamName, Points = number  };
            var awayTeam = new { Team = teamTwo.TeamName, Points = number };
            var stats = new { HomeTeamPoints = homeTeam.Points, AwayTeamPoints = awayTeam.Points };
            if (homeTeam.Points > awayTeam.Points) {
                teamOne.TeamRecord.AddWin();
                teamTwo.TeamRecord.AddLoss();
                Console.WriteLine("Home Team won");
                return stats;
            } else {
                teamTwo.TeamRecord.AddWin();
                teamOne.TeamRecord.AddLoss();
                Console.WriteLine("Away Team won");
                return stats;
            }
            
            

        }
        
    }
}