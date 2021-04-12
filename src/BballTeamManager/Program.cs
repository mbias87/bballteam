using System;

namespace BballTeam
{
    class Program
    {
        static void Main(string[] args)
        {

            var lakers = new Team("Los Angeles Lakers", "BullDog", "Los Angeles", "mike jones");
            var clippers = new Team("Los Angeles Clippers", "Scissors", "Los Angeles", "ricky bobby");
            var newGame = new GameStats();
            lakers.TeamRecord.AddWin();
            lakers.TeamRecord.AddWin();
            lakers.TeamRecord.AddLoss();
            lakers.TeamRecord.getRecord();
            Player myPlayer = new Player() {
                Name = "Ashley Brun",
                Position = "Shooting Guard",
                Starter = false,
                Height = "6",
                Weight = "250",
                Country = "Jamica",
                College = "SPSU",
                Age = 38,
                BirthDate = "Not sure"
            };
            lakers.TeamRoster.AddPlayer(myPlayer);
            lakers.TeamRoster.ShowRoster();
            newGame.GameSim(lakers, clippers);
        }
    }
}
