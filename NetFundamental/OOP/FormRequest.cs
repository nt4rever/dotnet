using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental.OOP
{
    class FormRequest
    {
        protected string message = string.Empty;
        public FormRequest() { }
        public virtual void Rules()
        {
            //rules
            Console.WriteLine("This is rules");
        }
        public void Validation()
        {
            //validation
            Console.WriteLine($"This is validation {this.message}");
        }
    }
}
