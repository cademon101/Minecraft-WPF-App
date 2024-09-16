using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Blacksmith : Player
    {
        public const float IRON_SMELTED_PER_SHIFT = 33.15f;
        public override float CostPerShift { get { return 1.7f; } }
        public Blacksmith() : base("Blacksmith") { }

        protected override void DoJob()
        {
            Chest.SmeltOreToIron(IRON_SMELTED_PER_SHIFT);
        }
    }
}
