using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    internal class CreditCard
    {
        public string CardNumber { get; set; }
        public string UserName { get; set; }

        public decimal CreditLimit { get; set; }

        public CreditCard Clone()
        {
            return(CreditCard)this.MemberwiseClone();
        }
    }
}
