using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore
{
    class ClotheStore
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public Seller Seller { get; private set; }
        private Dictionary<int, Price> priceHistory;

        private int clothesInStockAmount = 3000;


        public int shortSleeveShirtNormalNeckAmount = 300;
        public int shortSleeveShirtMaoNeckAmount = 200;
        public int longSleeveShirtNormalNeckAmount = 350;
        public int longSleeveShirtMaoNeckAmount = 150;

        public int normalTrouserAmount = 500;
        public int chupinTrouserAmount = 1500;


        public ClotheStore()
        {
            Name = "El ropero de Graciela";
            Adress = "Calle 245";
            Seller = new Seller();
            priceHistory = new Dictionary<int, Price>();

          
        }

        public void Quote(Price newPrice)
        {
            priceHistory.Add(newPrice.PriceId, newPrice);
        }


        public void PrintPriceHisotryComplete()
        {
            Console.WriteLine(priceHistory.Count);

            foreach (KeyValuePair<int, Price> price in priceHistory)
            {
                price.Value.PrintPriceComplete();
            }
        }
    }
}
