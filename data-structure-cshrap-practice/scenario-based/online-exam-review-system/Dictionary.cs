using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace online_exam_review_system
{
    internal class Dictionary
    {
        private int[] keys;
        private string[] values;
        public int count;

        public Dictionary(int size)
        {
            keys = new int[size];
            values = new string[size];
            count = 0;
        }

        public void Add( int key , string value)
        {
            for (int i = 0; i < count; i++)
            {
                if (key == keys[i])
                {
                    values[i] = value;
                    return;
                }

            }
            keys[count] = key;
            values[count] = value;
            count++;

        }

        public string Get(int key)
        {
            for (int i = 0; i < count; i++)
            {
                if (keys[i] == key)
                    return values[i];
            }
            return null;
        }

        public int Count()
        {
            return count;
        }

        public int GetKeyAt(int index)
        {
            return keys[index];
        }

        public string GetValueAt(int index)
        {
            return values[index];
        }
    }
}
