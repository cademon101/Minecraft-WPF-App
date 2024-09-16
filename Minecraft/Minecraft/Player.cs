using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    internal class Player
    {
        public virtual float CostPerShift { get; }
        //[R][]why do I need this? ⤵
        public string Role { get; private set; }
        public Player(string role)
        {
            Role = role;
        }
        
        public void WorkNextShift()
        {
            if (Chest.UseIron(CostPerShift))
            {
                DoJob();
            }
        }
        //[R][]Protected Virtual? ⤵
        protected virtual void DoJob() { /* Subclasses come in here */}
    }

}
