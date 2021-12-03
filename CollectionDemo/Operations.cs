using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    public class Operations
    {
        public static void List()
        {
            List<string> list = new List<string>();
            list.Add("Naveen");
            list.Add("Raju");
            list.Add("Sai");
            list.Add("Lokesh");
            list.Remove("Sai");
            foreach(var data in list)
            {
                Console.WriteLine(data);
            }
        }
        public static void Stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(30);
            stack.Push(78);
            stack.Push(47);
            stack.Push(98);
            stack.Push(3);
            foreach (var data in stack)
            {
                Console.WriteLine(data);
            }
        }
        public static void Queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(46);
            queue.Enqueue(90);
            queue.Enqueue(89);
            queue.Enqueue(51);
            foreach(var data in queue)
            {
                Console.WriteLine(data);
            }
        }
        public static void Set()
        {
            var set = new HashSet<string>();
            set.Add("Naveen");
            set.Add("Lokesh");
            set.Add("Sai");
            set.Add("Lokesh");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void Dictionary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Naveen");
            dictionary.Add(101, "lokesh");
            dictionary.Add(102, "Sai");
            dictionary.Add(103, "Pavan");
            foreach(var data in dictionary)
            {
                Console.WriteLine("Key = " + data.Key + " & Value = " + data.Value);
            }
        }
    }
}