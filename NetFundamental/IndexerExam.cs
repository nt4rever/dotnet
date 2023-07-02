using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    class IndexerExam
    {
        private string firstName = string.Empty;
        private string lastName = string.Empty;

        public string this[string index]
        {
            get
            {
                if (index == "firstName") return firstName;
                else if (index == "lastName") return lastName;
                else throw new Exception("Index not existing");
            }
            set
            {
                if (index == "firstName") firstName = value;
                else if (index == "lastName") lastName = value;
                else throw new Exception("Index not existing");
            }
        }
    }
}
