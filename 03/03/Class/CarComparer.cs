using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace _03.Class
{
    class CarComparer : IComparer<Car>
    {
        public enum compareOption
        {
            make,
            model,
            price
        }
        public compareOption selectedOption { get; set; }
        public int Compare([AllowNull] Car x, [AllowNull] Car y)
        {
            if (x.Make.CompareTo(y.Make) != 0)
            {
                return x.Make.CompareTo(y.Make);
            }
            else if (x.Model.CompareTo(y.Model) != 0)
            {
                return x.Model.CompareTo(y.Model);
            }
            else if (x.Price.CompareTo(y.Price) != 0)
            {
                return -1 * x.Price.CompareTo(y.Price);
            }
            return 0;
        }
    }
}
