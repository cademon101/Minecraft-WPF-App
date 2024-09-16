using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Minecraft
{
    class Builder : Player
    {
        public const float NEW_PLAYERS_PER_DAY = 0.45f;
        public const float IRON_PER_NEWPLAYER = 0.5f;

        private Player[] players = new Player[0];
        private float newPlayers = 0;
        private float unassignedPlayers = 3;

        public string StatusReport { get; private set; }
        public override float CostPerShift { get { return 2.15f; } }
        public Builder() : base("Builder")
        {
            AssignPlayer("Miner");
            AssignPlayer("Blacksmith");
            AssignPlayer("Villager");

        }
        //why wake off the s in player ⤵
        private void AddPlayer(Player player)
        {
            if (unassignedPlayers >= 1)
            {
                unassignedPlayers--;
                Array.Resize(ref players, players.Length + 1);
                players[players.Length - 1] = player;
            }
        }
        private void UpdateStatusReport()
        {
            StatusReport = $"Chest check up:\n{Chest.StatusReport}\n" +
            $"\nNew players: {newPlayers:0.0}\nUnassigned players: {unassignedPlayers:0.0}\n" +
            $"{PlayerStatus("Miner")}\n{PlayerStatus("Blacksmith")}" +
            $"\n{PlayerStatus("Villager")}\nTOTAL PLAYERS: {players.Length}";
        }
        public void TrainPlayers(float playersToTrain)
        {
            if (newPlayers >= playersToTrain)
            {
                newPlayers -= playersToTrain;
                unassignedPlayers += playersToTrain;
            }
        }
        private string PlayerStatus(string role)
        {
            int count = 0;
                foreach (Player player in players)
                if (player.Role == role) count++;
            string s = "s";
            if (count == 10) s = "";
            return $"{count} {role} player{s}";
        }


        public void AssignPlayer(String role)
        {
            switch (role)
            {
                //[R][]How this works
                case "Miner":
                    AddPlayer(new Miner());
                    break;
                case "Villager":
                    AddPlayer(new Villager(this));
                    break;
                case "Blacksmith":
                    AddPlayer(new Blacksmith());
                    break;
            }
            UpdateStatusReport();
        }

        protected override void DoJob()
        {
            newPlayers += NEW_PLAYERS_PER_DAY;
            foreach (Player player in players)
            {
                player.WorkNextShift();
            }
            Chest.UseIron(unassignedPlayers * IRON_PER_NEWPLAYER);
            UpdateStatusReport();
        }
    }
}
