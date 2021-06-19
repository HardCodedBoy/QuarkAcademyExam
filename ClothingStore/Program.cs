using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            ClotheStore clotheStore = new ClotheStore();
            int option;
            int amount;
            bool quality;
            Price price;

            while (true)
            {


                Console.WriteLine("Tienda: " + clotheStore.Name);
                Console.WriteLine("Dirección: " + clotheStore.Adress);
                Console.WriteLine("Nombre vendedor: " + clotheStore.Seller.Name + " " + clotheStore.Seller.LastName);
                Console.WriteLine("ID vendedor: " + clotheStore.Seller.Id);

                Console.WriteLine("\nElija una prenda para vender o presione 0 para ver el historial de ventas");
                Console.WriteLine("1: Camisa  \n 2:Pantalón");
                option = Convert.ToInt32(Console.ReadLine());

                if(option == 0)
                {
                    clotheStore.PrintPriceHisotryComplete();
                }
                else if (option == 1)
                {
                    Console.WriteLine("Seleccione las características de las camisas a cotizar:");
                    Console.WriteLine("1: Manga corta y cuello normal \n 2:Manga corta y cuello mao \n 3:Manga larga y cuello normal  \n4: Manga larga cuello mao");

                    option = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese la cantidad a cotizar");
                    amount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrse la calidad de las prendas (0:standard/ 1:premium)");
                    int n = Convert.ToInt32(Console.ReadLine());
                    quality = (n == 0) ? false : true;

                    switch (option)
                    {
                        case 1:
                            if (amount > clotheStore.shortSleeveShirtNormalNeckAmount)
                                Console.WriteLine("ERROR se quiere cotizar más de la cantidad en stock");
                            else
                            {
                                price = new Price(clotheStore.Seller.Id, amount, new Shirt(quality, false, false));
                                clotheStore.Quote(price);
                                Console.WriteLine("Precio de la cotización: " + price.priceResult);
                            }
                            break;

                        case 2:
                            if (amount > clotheStore.shortSleeveShirtMaoNeckAmount)
                                Console.WriteLine("ERROR se quiere cotizar más de la cantidad en stock");
                            else
                            {
                                price = new Price(clotheStore.Seller.Id, amount, new Shirt(quality, false, true));
                                clotheStore.Quote(price);
                                Console.WriteLine("Precio de la cotización: " + price.priceResult);
                            }
                            break;

                        case 3:
                            if (amount > clotheStore.longSleeveShirtNormalNeckAmount)
                                Console.WriteLine("ERROR se quiere cotizar más de la cantidad en stock");
                            else
                            {
                                price = new Price(clotheStore.Seller.Id, amount, new Shirt(quality, true, false));
                                clotheStore.Quote(price);
                                Console.WriteLine("Precio de la cotización: " + price.priceResult);
                            }
                            break;
                        case 4:
                            if (amount > clotheStore.shortSleeveShirtMaoNeckAmount)
                                Console.WriteLine("ERROR se quiere cotizar más de la cantidad en stock");
                            else
                            {
                                price = new Price(clotheStore.Seller.Id, amount, new Shirt(quality, true, true));
                                clotheStore.Quote(price);
                                Console.WriteLine("Precio de la cotización: " + price.priceResult);
                            }
                            break;
                    }
                }
                else if (option == 2)
                {
                    Console.WriteLine("Seleccione las características de los pantalones a cotizar:");
                    Console.WriteLine("1: Normal \n 2:Chupín");

                    option = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese la cantidad a cotizar");
                    amount = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrse la calidad de las prendas (0:standard/ 1:premium)");
                    int n = Convert.ToInt32(Console.ReadLine());
                    quality = (n == 0) ? false : true;

                    switch (option)
                    {
                        case 1:
                            if (amount > clotheStore.normalTrouserAmount)
                                Console.WriteLine("ERROR se quiere cotizar más de la cantidad en stock");
                            else
                            {
                                price = new Price(clotheStore.Seller.Id, amount, new Trouser(quality, false));
                                clotheStore.Quote(price);
                                Console.WriteLine("Precio de la cotización: " + price.priceResult);
                            }
                            break;

                        case 2:
                            if (amount > clotheStore.chupinTrouserAmount)
                                Console.WriteLine("ERROR se quiere cotizar más de la cantidad en stock");
                            else
                            {
                                price = new Price(clotheStore.Seller.Id, amount, new Trouser(quality, true));
                                clotheStore.Quote(price);
                                Console.WriteLine("Precio de la cotización: " + price.priceResult);
                            }
                            break;
                    }
                }

                Console.WriteLine("\n \n \n \n \n \n \n \n \n");
            }


         
        }


    }
}
