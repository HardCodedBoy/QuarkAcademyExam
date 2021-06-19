using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore
{
    public class Shirt : Clothe
    {
        private bool sleeveType;        //false for short, true for long
        private bool neckType;          //false for normal, true for mao.

        public Shirt(bool _qualityType, bool _sleeveType, bool _neckType) : base(_qualityType)
        {
            cost = 300;
            sleeveType = _sleeveType;
            neckType = _neckType;
        }

        public override float GetClotheCost()
        {
            float finalCost = cost;

            if (sleeveType == false)
                finalCost += (finalCost * 90) / 100f;

            if (neckType == true)
                finalCost += (finalCost * 3) / 100f;

            if (qualityType == true)
                finalCost += (finalCost * 30) / 100f;

            return finalCost;
        }
    }
}
