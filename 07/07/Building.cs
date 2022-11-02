using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal abstract class Building
    {

        public abstract void Add();
    }

    internal class CalculateBuilding : Building
    {
        public void Add (int val)
        {

        }

        public override void Add()
        {
            throw new NotImplementedException();
        }
    }
}
