using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Miner : Player
    {
        public const float ORE_MINED_PER_SHIFT = 33.15f;
        //instead of set its return? ⤵
        public override float CostPerShift { get { return 1.95f; } }
        //what is base for ⤵
        public Miner() : base("Miner") { }

        protected override void DoJob()
        {
            Chest.CollectOre(ORE_MINED_PER_SHIFT);
        }
    }
}
