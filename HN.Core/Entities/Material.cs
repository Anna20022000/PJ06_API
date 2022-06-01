using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HN.Core.Entities
{
    public class Material
    {
        public int ID { get; set; }
        public string MaterialCode { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Fabric { get; set; }
        public Double Quantity { get; set; }
        public Decimal Price { get; set; }
        public int Season { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int MaterialCategory_ID { get; set; }

    }
}