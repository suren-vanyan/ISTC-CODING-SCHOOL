using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Player nadal = new Player()
            {
                FirstName = "Rafael",
                LastName = "Nadal",
                BirthDate = new DateTime(1986, 06, 03),
                Rank = 1,
                Points = 7660,
                Weight = 85,
                Height = 185,
                Coutry = "Spain",
                BirthPlace = "Spain",
                Residence = "Spain",
                //Win = 1,
                //Aces=8,
            };

            Player novac = new Player()
            {
                FirstName = "Novac",
                LastName = "Djokovic",
                BirthDate = new DateTime(1987, 05, 22),
                Rank = 2,
                Points = 7445,
                Weight = 80,
                Height = 189,
                Coutry = "Serbia",
                BirthPlace = "Serbia",
                Residence = "Serbia",
                //Win = 1,
                //Aces=8,  
            };

            Player federer = new Player()
            {
                FirstName = "Roger",
                LastName = "Federer",
                BirthDate = new DateTime(1981, 08, 08),
                Rank = 3,
                Points = 6260,
                Weight = 82,
                Height = 185,
                Coutry = "Switzerland",
                BirthPlace = "Switzerland",
                Residence = "Switzerland",
                //Win = 1,
                //Aces=8,  
            };

            Player alex = new Player()
            {
                FirstName = "Alexander",
                LastName = "Zverev",
                BirthDate = new DateTime(1997, 05, 20),
                Rank = 5,
                Points = 5115,
                Weight = 80,
                Height = 183,
                Coutry = "Germany",
                BirthPlace = "Russian",
                Residence = "Germany",
                //Win = 1,
                //Aces=8,  
            };
       
            

            Courts[] courts = new Courts[]
            {
                new Courts("Rod Laver Arena","Melbourne",14820,"OutdoorHard "),
                new Courts("Margaret Court Arena","Melbourne",7500,"OutdoorHard"),
                new Courts("Philippe-Chatrier Court","Paris",14840,"OutdoorClay"),
                new Courts("Centre Court","London",15916,"OutdoorGrass "),
            };

            Player[] player = new Player[4] { nadal, novac, federer, alex };

            Matches firstMatch = new Matches(courts[0]);
            firstMatch.tournament = Tournaments.Australian_Open;
            firstMatch.Round = Rounds.QUARTER_FINALS;
            firstMatch.Date = new DateTime(2018, 05, 10);
            firstMatch.Time = "16:00:00";

            
            Console.WriteLine($"{firstMatch.tournament}\n {courts[0].Name},\n Dates: {firstMatch.Date} \n Location:{courts[0].City} " +
                                  $"\n Surface:{ courts[0].Surface} \n Round: {firstMatch.Round}");

           
            Console.WriteLine($"Men's singles:{nadal.FirstName} {nadal.LastName}");
            Console.WriteLine($"Men's singles:{novac.FirstName} {novac.LastName}");
            Console.WriteLine($"Men's singles:{federer.FirstName} {federer.LastName}");
            Console.WriteLine($"Men's singles:{alex.FirstName} {alex.LastName}");

            Player winnerPlayer = player[rnd.Next(0, 4)];
            winnerPlayer.Win++;
            winnerPlayer.Aces+=2;
            winnerPlayer.Points += 20;
            Console.WriteLine($"Winner is {winnerPlayer.FirstName} {winnerPlayer.LastName}");
            

            Console.WriteLine(new string('*',50));

            Matches secondMatch = new Matches(courts[2]);
            firstMatch.tournament = Tournaments.RolandGarros;
            firstMatch.Round = Rounds.FINALS;
            firstMatch.Date = new DateTime(2018, 07, 20);
            firstMatch.Time = "14:00:00";

        
            Console.WriteLine($"{firstMatch.tournament}\n {courts[2].Name},\n Dates: {firstMatch.Date} \n Location:{courts[2].City} " +
                                  $"\n Surface:{ courts[2].Surface} \n Round: {firstMatch.Round}");


            Console.WriteLine($"Men's singles:{nadal.FirstName} {nadal.LastName}");
            Console.WriteLine($"Men's singles:{novac.FirstName} {novac.LastName}");
            Console.WriteLine($"Men's singles:{federer.FirstName} {federer.LastName}");
            Console.WriteLine($"Men's singles:{alex.FirstName} {alex.LastName}");

            Player winnerPlayer2 = player[rnd.Next(0, 4)];
            winnerPlayer.Win++;
            winnerPlayer.Aces += 2;
            winnerPlayer.Points += 20;
            Console.WriteLine($"Winner is {winnerPlayer2.FirstName} {winnerPlayer2.LastName}");

        }
    }
}
