using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore
{
    class Trouser : Clothe
    {
        private bool type;

        public Trouser(bool _qualityType, bool _type) : base(_qualityType)
        {
            cost = 500;
        }

        public override float GetClotheCost()
        {
            float finalCost = cost;

            if (type == true)
                finalCost = (finalCost * 12) / 100f;

            if(qualityType == true)
                finalCost = (finalCost * 30) / 100f;

            return finalCost;
        }
    }
}
