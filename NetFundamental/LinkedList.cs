using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    public class LinkedListDemo
    {
        public void TestLinkedList()
        {
            LinkedList<string> list = new();
            list.AddFirst("first");
            list.AddFirst("second");
            list.AddFirst("third");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            LinkedListNode<string>? node = list.Last;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Previous;
            }
        }
    }
}
