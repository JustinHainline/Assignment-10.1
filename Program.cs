using System;
using System.Text.Json;
namespace Assignment_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myTeam = new FootballTeam
            {
                TeamName = "Green Bay Packers",
                YearFounded = 1919,
                TotalPlayers = 348,
                CoachName = "Matt LaFleur",
                HomeStadium = "Lambeau Field",
                IsChampion = false,

            };
            string jsonString = JsonSerializer.Serialize(myTeam);
            Console.WriteLine(jsonString);


            //string fileName = "FootballTeam.json";
            //string jsonStringD = File.ReadAllText(fileName);

            //FootballTeam? footballTeam = JsonSerializer.Deserialize<FootballTeam>(jsonStringD);
        }
        public class FootballTeam
        {
            public string TeamName { get; set; }
            public int YearFounded { get; set; }
            public int TotalPlayers { get; set; }

            public string _coachName;
            public string CoachName 
            {
                get { return _coachName; }
                set { _coachName = value; }
            }
            
            public string _homeStadium;
            public string HomeStadium 
            {  
                get { return _homeStadium; }
                set { _homeStadium = value;}
            }
            public bool IsChampion { get; set; }


        }
    }
}
