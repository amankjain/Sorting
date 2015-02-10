using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    public class Node<T> where T: IComparable
    {
        public string key;
        public T value;
    }
    public class LinkedList<T> where T: IComparable
    {
        Node<T> head;
        Node<T> next;
    }
}
