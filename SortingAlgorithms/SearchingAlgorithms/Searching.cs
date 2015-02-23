using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    public class BinarySearching<T, V> where T : IComparable
    {
        public BinarySearching(int capacity)
        {
            keys = new T[capacity];
            values = new V[capacity];
        }
        private static int INIT_CAPACITY = 2;
        T[] keys;
        V[] values;
        private int N = 0;
              

        // resize the underlying arrays
        private void resize(int capacity)
        {
        }

        // is the key in the table?
        public bool contains(T key)
        {
            return false;
        }
     
        public int size()
        {
            return N;
        }

        public void insert(T key, V value)
        {

        }
        public V get(T key)
        {
            int rankVar = rank(key);
            return values[rankVar];
        }
        public int rank(T key)
        {
            return 0;
        }
    }
}
