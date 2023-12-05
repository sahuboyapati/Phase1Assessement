using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment
{
    public class OneDayTeam : ITeam
    {
        private readonly List<Player> oneDayTeam = new List<Player>();

        public void Add(Player player)
        {
            if (oneDayTeam.Count < 11)
            {
                oneDayTeam.Add(player);
            }
            else
            {
                throw new InvalidOperationException("Cannot add more than 11 players to the team.");
            }
        }

        public List<Player> GetAllPlayers()
        {
            return new List<Player>(oneDayTeam);
        }

        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.FirstOrDefault(player => player.PlayerId == playerId);
        }

        public Player GetPlayerByName(string name)
        {
            return oneDayTeam.FirstOrDefault(player => player.PlayerName == name);
        }

        public void Remove(int playerId)
        {
            var playerToRemove = oneDayTeam.FirstOrDefault(player => player.PlayerId == playerId);

            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
            }
            else
            {
                Console.WriteLine("Player not found.");
            }
        }
    }
}
