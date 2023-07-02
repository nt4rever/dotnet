using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Class)]
    public class MotaAttribute : Attribute
    {
        public MotaAttribute(string v) => Description = v;
        public string Description { get; set; }
    }

    [Mota("This is user class")]
    class User
    {
        [Mota("Field name of user")]
        public string Name { get; set; }
    }

    class AttrDemo
    {
        public static void Demo()
        {
            var a = new User();
            foreach (Attribute attr in a.GetType().GetCustomAttributes(false))
            {
                MotaAttribute attr2 = attr as MotaAttribute;
                if (attr2 != null) Console.WriteLine($"{a.GetType().Name,10} : {attr2.Description}");
            }
        }
    }
}
