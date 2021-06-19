using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore
{
    class Seller
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Id { get; private set; }

        public Seller()
        {
            Name = "Roberto";
            LastName = "Riba";

            Id = 1234;
        }
    }
}
