using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFundamental
{
    public class MyLinkedList<K>
    {
        public class Node<T>
        {
            public Node<T>? Previous { get; set; }
            public Node<T>? Next { get; set; }
            public T Value { get; set; }
            public Node(Node<T>? previous, Node<T>? next, T value)
            {
                Previous = previous;
                Next = next;
                Value = value;
            }
        }

        private Node<K>? _node;
        private int count = 0;
        public int Count { get => count; }

        public void AddFirst(K value)
        {

            if (_node == null)
            {
                _node = new Node<K>(null, null, value);
                count = 1;
                return;
            }
            var fNode = new Node<K>(null, _node, value);
            _node.Previous = fNode;
            _node = fNode;
            count++;
        }

        public void AddLast(K value)
        {
            if (_node == null)
            {
                _node = new Node<K>(null, null, value);
                count = 1;
                return;
            }
            var node = _node;
            while (node.Next != null) node = node.Next;
            node.Next = new Node<K>(node, null, value);
            count++;
        }

        public Node<K>? First()
        {
            return _node;
        }

        public Node<K>? Last()
        {
            if (_node == null) return null;
            var node = _node;
            while (node.Next != null)
                node = node.Next;
            return node;
        }

        public void ForEach(Action<K, int?> callback)
        {
            var node = _node;
            var index = count;
            while (node != null)
            {
                index--;
                callback(node.Value, count - index);
                node = node.Next;
            }
        }

        public void Clear()
        {
            _node = null;
        }

        public void Remove(K value)
        {
            var node = _node;
            while (node != null)
            {
                if (node.Value != null && node.Value.Equals(value))
                {
                    var _prev = node.Previous;
                    var _next = node.Next;
                    // node position in middle
                    //6 -> 4 -> 3 -> 2 -> 1 -> 5
                    if (_prev != null && _next != null)
                    {
                        _prev.Next = _next;
                    }
                    // node position in first
                    if (_prev == null && _next != null)
                    {
                        _next.Previous = null;
                        _node = _next;
                    }
                    // node position in last
                    if (_next == null && _prev != null)
                    {
                        _prev.Next = null;
                    }
                    // linked list just has one element
                    if (_next == null && _prev == null)
                    {
                        _node = null;
                    }
                    count--;
                }
                node = node.Next;
            }
        }
    }
}
