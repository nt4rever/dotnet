using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental.OOP
{
    partial class Product
    {
        public Product()
        {
            this.Id = 0;
        }

        partial void CalcSalary()
        {
            throw new NotImplementedException();
        }
    }
}
