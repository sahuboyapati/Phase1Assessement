using System;

namespace ConAppAssessment
{
    class Program
    {
        private static readonly Assessment.OneDayTeam _team = new Assessment.OneDayTeam();

        private static void Add()
        {
            Console.Write("Enter Player Id: ");
            var playerId = Console.ReadLine();
            Console.Write("Enter Player Name: ");
            var playerName = Console.ReadLine();
            Console.Write("Enter Player Age: ");
            var playerAge = Console.ReadLine();

            Assessment.Player player = new Assessment.Player()
            {
                PlayerId = int.Parse(playerId),
                PlayerName = playerName,
                PlayerAge = int.Parse(playerAge)
            };

            _team.Add(player);
            Console.WriteLine("Player is added successfully");
        }

        private static void RemoveById()
        {
            Console.Write("Enter Player Id to Remove: ");
            var playerId = Console.ReadLine();
            _team.Remove(int.Parse(playerId));
            Console.WriteLine("Player is removed successfully");
        }

        private static void GetPlayerDetailsById()
        {
            Console.Write("Enter Player Id: ");
            var playerId = Console.ReadLine();
            var player = _team.GetPlayerById(int.Parse(playerId));

            if (player != null)
                Console.WriteLine($"{player.PlayerId}    {player.PlayerName}    {player.PlayerAge}");
            else
                Console.WriteLine("Player not found");
        }

        private static void GetPlayerDetailsByName()
        {
            Console.Write("Enter Player Name: ");
            var playerName = Console.ReadLine();
            var player = _team.GetPlayerByName(playerName);

            if (player != null)
                Console.WriteLine($"{player.PlayerId}    {player.PlayerName}    {player.PlayerAge}");
            else
                Console.WriteLine("Player not found");
        }

        private static void GetAllPlayerDetails()
        {
            var players = _team.GetAllPlayers();

            foreach (var player in players)
            {
                Console.WriteLine($"{player.PlayerId}    {player.PlayerName}    {player.PlayerAge}");
            }
        }

        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("Enter 1: To Add Player");
                Console.WriteLine("Enter 2: To Remove Player by Id");
                Console.WriteLine("Enter 3: To Get Player by Id");
                Console.WriteLine("Enter 4: To Get Player by Name");
                Console.WriteLine("Enter 5: To Get All Players");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        RemoveById();
                        break;
                    case "3":
                        GetPlayerDetailsById();
                        break;
                    case "4":
                        GetPlayerDetailsByName();
                        break;
                    case "5":
                        GetAllPlayerDetails();
                        break;
                    default:
                        break;
                }

                Console.Write("Do you want to continue (yes/no)?: ");
                var continueChoice = Console.ReadLine().ToLower();
                if (continueChoice != "yes")
                {
                    break;
                }
            }
        }
    }
}
