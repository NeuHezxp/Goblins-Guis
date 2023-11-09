using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goblins_Guis
{
    internal interface IAttack //interface does not give instructors
    {
        
        bool attemptAttack(int difficulty);
        bool stake(int stake);
        void Attack(int Roll);
    }
}
