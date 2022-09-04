using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14App1
{
    public enum Categorys
    {
        Food,
        Technic
    }
    public class Product
    {
        public string NameProduct { get; set; }
        public int PriceProduct { get; set; }
        public string ImageProduct { get; set; }
        public Categorys CategoryProduct { get; set; }

        public override string ToString()
        {
            return NameProduct;
        }
    }
}
