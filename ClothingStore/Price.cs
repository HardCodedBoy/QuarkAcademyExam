using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore
{
    class Price
    {
        private static int priceIdGenerator = 0;

        public int PriceId { get; private set; }
        private int sellerId;
        private DateTime priceDate;
        private Clothe clotheSold;
        private int clotheAmount;
        public float priceResult { get; private set; }

        public Price(int _sellerId, int _clotheAmount, Clothe _clotheSold)
        {
            PriceId = priceIdGenerator;
            priceIdGenerator++;

            sellerId = _sellerId;
            clotheSold = _clotheSold;
            clotheAmount = _clotheAmount;

            priceResult = clotheSold.GetClotheCost() * clotheAmount;

            priceDate = DateTime.Now;
        }


        public float GetPriceResult()
        {
            return priceResult;
        }

        public void PrintPriceComplete()
        {
            Console.WriteLine($"Id de la cotización: {PriceId} \nId vendedor: {sellerId} \nFecha de la cotización: {priceDate} \nPrecio de la cortización: {priceResult}");
        }
    }
}
