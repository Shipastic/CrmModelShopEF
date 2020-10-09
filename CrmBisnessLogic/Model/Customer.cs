using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBisnessLogic.Model
{
  public  class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Check> Checks { get; set; }      //устранение реализации многие ко многим через промежуточную таблицуе Check, 
                                                                    //в Check - добавляем CustomerID, а в Customer - коллекцию Check - ов, получилась связь 1 ко многим между Customer и Check
        public override string ToString()
        {
            return Name;
        }
    }
}
