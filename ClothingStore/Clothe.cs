using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore
{
    public abstract class Clothe
    {
        protected int cost;
        protected bool qualityType;         //False for normal, true for premium

        public Clothe(bool _qualityType)
        {
            qualityType = _qualityType;
        }

        public abstract float  GetClotheCost();
    }
}
