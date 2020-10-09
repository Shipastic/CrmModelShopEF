using System.Collections.Generic;

namespace CrmBisnessLogic.Model
{
  public  class Product
    {
        public int ProductId { get; set; }      // Первичный ключ
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
