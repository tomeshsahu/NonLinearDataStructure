using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonLinearDataStructure
{
    public class UC1_CalculatingFrequency<K, V>
    {
        private readonly int size;
        private readonly LinkedList<KeyValues<K, V>>[] items;
        public UC1_CalculatingFrequency(int size)
        {
            this.size = size;
            items = new LinkedList<KeyValues<K, V>>[size];
        }
        public int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValues<K, V>> linkedlist = GetLinkedList(position);
            KeyValues<K, V> item = new KeyValues<K, V>() { key = key, value = value };
            linkedlist.AddLast(item);
        }
        public LinkedList<KeyValues<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValues<K, V>> linkedlist = items[position];
            if (linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValues<K, V>>();
                items[position] = linkedlist;
            }
            return linkedlist;
        }
        public V Get(K key)
        {
            int position = GetArrayPosition(key);

            LinkedList<KeyValues<K, V>> linkedList = GetLinkedList(position);

            foreach (KeyValues<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }
        public void Remove(K key)
        {

            int position = GetArrayPosition(key);
            LinkedList<KeyValues<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValues<K, V> foundItem = default(KeyValues<K, V>);
            foreach (KeyValues<K, V> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }
        public void Display()
        {
            foreach (var linkedList in items)
            {
                if (linkedList != null)

                    foreach (KeyValues<K, V> keyvalue in linkedList)
                    {

                        Console.WriteLine(keyvalue.key + " " + keyvalue.value);
                    }
            }
        }
    }
}
