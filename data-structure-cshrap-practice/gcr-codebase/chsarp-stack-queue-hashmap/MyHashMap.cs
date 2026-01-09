using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueueHashMap
{
    public class MyHashMap
    {
        private const int SIZE = 1000;
        private List<KeyValuePair<int, int>>[] buckets;

        public MyHashMap()
        {
            buckets = new List<KeyValuePair<int, int>>[SIZE];
        }

        private int Hash(int key) => key % SIZE;

        public void Put(int key, int value)
        {
            int index = Hash(key);

            if (buckets[index] == null)
                buckets[index] = new List<KeyValuePair<int, int>>();

            foreach (var pair in buckets[index])
            {
                if (pair.Key == key)
                    return; // Key already exists, ignore (or update if required)
            }

            buckets[index].Add(new KeyValuePair<int, int>(key, value));
        }

        public int Get(int key)
        {
            int index = Hash(key);

            if (buckets[index] != null)
            {
                foreach (var pair in buckets[index])
                {
                    if (pair.Key == key)
                        return pair.Value;
                }
            }
            return -1;
        }

        public void Remove(int key)
        {
            int index = Hash(key);

            if (buckets[index] != null)
                buckets[index].RemoveAll(p => p.Key == key);
        }
    }

    // Logical Main class
    class MyHashMapDemo
    {
        public static void Main(string[] args)
        {
            MyHashMap map = new MyHashMap();

            map.Put(1, 100);
            map.Put(2, 200);
            map.Put(1001, 300); // Collision case

            Console.WriteLine("Get 1: " + map.Get(1));
            Console.WriteLine("Get 2: " + map.Get(2));
            Console.WriteLine("Get 1001: " + map.Get(1001));

            map.Remove(2);
            Console.WriteLine("Get 2 after removal: " + map.Get(2));
        }
    }
}
