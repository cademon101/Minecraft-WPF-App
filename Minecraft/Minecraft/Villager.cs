using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    internal class Villager : Player
    {
        public const float PLAYERS_HELPED_PER_DAY = 0.15f;
        public override float CostPerShift { get { return 1.35f; } }
        private Builder builder;
        //What is going on here? ⤵
        public Villager(Builder builder) : base("Villager")
        {
            this.builder = builder;
        }
        protected override void DoJob()
        {
            builder.TrainPlayers(PLAYERS_HELPED_PER_DAY);
        }
    }
}
