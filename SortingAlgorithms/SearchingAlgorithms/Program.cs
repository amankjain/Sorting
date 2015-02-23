using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearching<String, int> st = new BinarySearching<String, int>(50);
            st.insert("Aman", 100);
            st.insert("Bman", 80); st.insert("Cman", 70); st.insert("Dman", 60); st.insert("Eman", 50);
            Console.WriteLine("Aman:" + st.get("Aman"));
            Console.WriteLine("Eman:" + st.get("Aman"));
            Console.WriteLine("Dman:" + st.get("Aman"));
        }


    }
}
