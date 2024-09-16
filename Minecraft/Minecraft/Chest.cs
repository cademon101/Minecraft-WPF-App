using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing.IndexedProperties;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    static class Chest
    {
        public static float ORE_CONVERSION_RATIO = .19f;
        public static float LOW_LEVEL_WARNING = 10f;
        private static float ore = 25f;
        private static float iron = 100f;
        //R[What is a constant] R[Why public] N[only public can be constuck?]
        //static WorkTheNextShift();
        //protected virtual DoJob();

        /// <summary>
        /// Takes any ore left subtracks from 
        /// </summary>
        /// <param name="amount"></param>
        // didnt make this public and didnt add amount
        public static void CollectOre(float amount)
        {
            if (amount > 0f) ore += amount;
        }
        public static void SmeltOreToIron(float amount)
        {
            float oreToSmelt = amount;
            if (oreToSmelt > ore) oreToSmelt = ore;
            ore -= oreToSmelt;
            iron += oreToSmelt * ORE_CONVERSION_RATIO;
        }
        public static bool UseIron(float amount)
        {
            if (iron >= amount)
            {
                iron -= amount;
                return true;
            }
            return false;
        }
        public static string StatusReport { 
            get 
            {
                //[R][] How does this work and why return
                string status = $"{iron:0.0} iron in invontory\n" +
                                $"{ore:0.0} ore in invontory";
                string warnings = "";
                if (iron < LOW_LEVEL_WARNING) warnings +=
                        "\nLOW IRON- Bring in some builders";
                if (ore < LOW_LEVEL_WARNING) warnings +=
                        "\nLOW ORE- Bring in some miners";
                return status + warnings;
            } 
        }
    }
}
