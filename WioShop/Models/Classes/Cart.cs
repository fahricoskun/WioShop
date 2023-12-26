using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WioShop.Models.Classes
{
    public class Cart
    {
        private List<CartLine> _cardLines = new List<CartLine>();
        public List<CartLine> CartLines 
        {
            get { return _cardLines; } 
        }

        public void UrunEkle(Product product, int number)
        {
            var line = _cardLines.FirstOrDefault(i => i.Product.Id == product.Id);

            if(line == null) 
            {
                _cardLines.Add(new CartLine() { Product = product, Number = number });
            }
            else 
            {
                line.Number += number;
            }
        }

        public void UrunSil(Product product)
        {
            _cardLines.RemoveAll(i => i.Product.Id == product.Id);
        }

        public double Tutar()
        {
            return _cardLines.Sum(i => i.Product.ProductPrice * i.Number);
        }

        public void Clear()
        { 
            _cardLines.Clear(); 
        }
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Number { get; set; }
    }
}