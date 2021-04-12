using System;
using System.Linq;
namespace BballTeam {

    public class Record {



        public void getRecord() {
           Console.WriteLine($"The Team has {this.wins} wins, and the team has {this.losses} losses and has {this.ties} ties");     
        }

        public void AddWin() {
            this.wins++;
        }
        public void AddLoss() {
            this.losses++;
        }

        public void AddTies() {
            this.ties++;
        }

        /// <summary>
        /// the amount of wins a team has
        /// </summary>
        public int wins = 0;
        
        /// <summary>
        /// 
        /// the amount of losses
        /// </summary>       
          int losses = 0;

        /// <summary>
        /// amount of ties 
        /// </summary>
          int ties = 0;
    }
}