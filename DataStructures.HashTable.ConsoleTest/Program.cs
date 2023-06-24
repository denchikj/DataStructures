using System;

namespace DataStructures.HashTable.ConsoleTest
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Implementations.HashTable ht = new Implementations.HashTable(2);
            ht.Set("banana", 200);
            ht.Set("pear", 100);

            foreach (var item in ht.Keys())
            {                
                Console.WriteLine(ht.Get(item));
            }
        }
    }
}