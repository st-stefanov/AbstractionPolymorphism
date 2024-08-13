using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding.Models.Heroes
{
    public class Warrior : Fighter
    {
        public Warrior(string name) : base(name)
        {
        }

        public override int Power => 80;

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
