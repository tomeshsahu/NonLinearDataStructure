using System;
using NonLinearDataStructure;
public class Program
{
    public static void Main(String[] args)
    {
        UC2_BinarySearch<int> binarySearch = new UC2_BinarySearch<int>(70);
        binarySearch.Insert(56);
        binarySearch.Insert(30);
        // binarySearch.Insert(56);
        bool result = binarySearch.IfExists(70, binarySearch);
        binarySearch.Display();
    }
}
