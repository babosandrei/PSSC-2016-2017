using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class InvalidCreditValue:Exception
    {
         Credits credit;
          public InvalidCreditValue()
          {
              if (credit.Count < 0)
              {
                  throw new ArgumentException("Invalid value for credit");
              }
  
          }
    }
}
