using System.Collections.Generic;

using System;

namespace CrmBisnessLogic.Model
{
   public class Check
    {
        //промежуточный класс для удаления связи многие ко многим
        public int CheckId { get; set; }

        // для внешнего ключа нужно 2 поля
        public int CustomerId { get; set; } 
        public virtual Customer Customer { get; set; }

        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; }
        public DateTime Created { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return $"{CheckId} от {Created.ToString("dd.MM.yy hh:mm:ss")}";
        }

    }
}
