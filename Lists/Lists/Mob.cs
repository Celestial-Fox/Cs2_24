using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class Mob
    {
        internal bool isDead;
        internal int hp = 10;

        internal void DoDamage(int damage)
        {
            hp =- damage;
            if (hp < 0)
            {
                isDead = true;
            }
        }

        
    }


}
