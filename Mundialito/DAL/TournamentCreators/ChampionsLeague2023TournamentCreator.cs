using Mundialito.DAL.Games;
using Mundialito.DAL.Players;
using Mundialito.DAL.Stadiums;
using Mundialito.DAL.Teams;
using System;
using System.Collections.Generic;

namespace Mundialito.DAL.DBCreators
{
    public class ChampionsLeague2023TournamentCreator : ITournamentCreator
    {
        public List<Team> GetTeams()
        {
            var teams = new List<Team>();
            teams.Add(CreateTeam("Royal Antwerp F.C.", "BLG"));
            teams.Add(CreateTeam("Arsenal F.C.", "ENG"));
            teams.Add(CreateTeam("Club Atlético de Madrid", "ESP"));
            teams.Add(CreateTeam("FC Barcelona", "ESP"));
            teams.Add(CreateTeam("FC Bayern München", "GER"));
            teams.Add(CreateTeam("SL Benfica", "POR"));
            teams.Add(CreateTeam("RC Lens", "FRA"));
            teams.Add(CreateTeam("Feyenoord", "NE"));
            teams.Add(CreateTeam("Newcastle United F.C.", "ENG"));
            teams.Add(CreateTeam("Borussia Dortmund", "GER"));
            teams.Add(CreateTeam("Galatasaray S.K.", "TUR"));
            teams.Add(CreateTeam("FC Internazionale Milano", "ITA"));
            teams.Add(CreateTeam("Celtic F.C.", "SCT"));
            teams.Add(CreateTeam("RB Leipzig", "GER"));
            teams.Add(CreateTeam("SSC Napoli", "ITA"));
            teams.Add(CreateTeam("Real Sociedad", "ESP"));
            teams.Add(CreateTeam("S.C. Braga", "BLG"));
            teams.Add(CreateTeam("Manchester City FC", "ENG"));
            teams.Add(CreateTeam("Manchester United", "ENG"));
            teams.Add(CreateTeam("AC Milan", "ITA"));
            teams.Add(CreateTeam("Paris Saint-Germain", "FRA"));
            teams.Add(CreateTeam("FC Porto", "POR"));
            teams.Add(CreateTeam("Real Madrid CF", "ESP"));
            teams.Add(CreateTeam("FC Salzburg", "AUT"));
            teams.Add(CreateTeam("Sevilla FC", "ESP"));
            teams.Add(CreateTeam("FC Shakhtar Donetsk", "UKR"));
            teams.Add(CreateTeam("PSV", "NE"));
            teams.Add(CreateTeam("FK Crvena zvezda", "SRB"));
            teams.Add(CreateTeam("S.S. Lazio", "ITA"));
            teams.Add(CreateTeam("1. FC Union Berlin", "GER"));
            teams.Add(CreateTeam("BSC Young Boys", "SUI"));
            teams.Add(CreateTeam("F.C. Copenhagen", "DEN"));
            return teams;
        }
        public List<Game> GetGames(Dictionary<String, Stadium> stadiums, Dictionary<String, Team> teams)
        {
            var games = new List<Game>();
            games.Add(new Game
            {
                HomeTeamId = teams["AC Milan"].TeamId,
                AwayTeamId = teams["Newcastle United F.C."].TeamId,
                Date = GetFixedDate(new DateTime(2023, 9, 19, 19, 45, 0)),
                StadiumId = stadiums["Stadion Wankdorf"].StadiumId
            });
            return games;
        }
        public List<Stadium> GetStadiums()
        {
            var stadiums = new List<Stadium>();
            stadiums.Add(new Stadium() { Name = "San Siro Stadium", Capacity = 80000, City = "Milano" });


            return stadiums;
        }
        public List<Player> GetPlayers()
        {
            var players = new List<Player>();
            players.Add(new Player() { Name = "Erling Braut Haaland" });
            players.Add(new Player() { Name = "Robert Lewandowski" });
            players.Add(new Player() { Name = "Romelu Lukaku" });
            players.Add(new Player() { Name = "Kylian Mbappe-Lottin" });
            players.Add(new Player() { Name = "Miguel Bruno Fernandes" });
            players.Add(new Player() { Name = "Antoine Griezmann" });
            players.Add(new Player() { Name = "Fernando Gabriel Jesus" });
            players.Add(new Player() { Name = "Ferran Torres" });
            players.Add(new Player() { Name = "Jose Vinicius Junior" });
            players.Add(new Player() { Name = "Other" });
            return players;
        }
        private DateTime GetFixedDate(DateTime date)
        {
            return date.Subtract(TimeSpan.FromHours(3));
            //return date.AddDays(65);
        }

        private Team CreateTeam(String name, String shortName)
        {
            return new Team() { Name = name, ShortName = shortName, Flag = string.Format("https://api.fifa.com/api/v1/picture/flags-sq-2/{0}", shortName), Logo = string.Format("https://api.fifa.com/api/v1/picture/flags-sq-2/{0}", shortName) };
        }

    }
}
