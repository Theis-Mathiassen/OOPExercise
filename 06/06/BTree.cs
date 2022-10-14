using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class BTree<T>
    {
        public BTreeElem<T>? Left { get; set; }
        public BTreeElem<T>? Right { get; set; }

        public BTree()
        {

        }
    }

    internal class BTreeElem<T>
    {

    }
}
