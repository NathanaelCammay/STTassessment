using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageLibrary
{
    public class Pack
    {
        // create class for instance of pack
        public int Index { get; set; }
        public int Weight { get; set; }
        public int MaxWeight { get; set; }

        public int Cost { get; set; }

        public int WeightPlusCost 
        {
            get
            {
                var weightPlusCost = Weight + Cost;
                return weightPlusCost;  // calculate weight + cost and set as property
            }
        }
    }
}
