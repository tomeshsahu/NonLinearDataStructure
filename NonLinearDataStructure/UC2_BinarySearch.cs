using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonLinearDataStructure
{
    public class UC2_BinarySearch<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        UC2_BinarySearch<T> LeftTree { get; set; }
        UC2_BinarySearch<T> RighttTree { get; set; }
        public UC2_BinarySearch(T nodeData)
        {

            this.NodeData = nodeData;
            this.LeftTree = LeftTree;
            this.RighttTree = RighttTree;
        }
        int leftcount = 0;
        int rightcount = 0;
        bool result = false;
        public void Insert(T item)
        {
            T currentNodeValues = this.NodeData;
            if ((currentNodeValues.CompareTo(item)) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new UC2_BinarySearch<T>(item);
                }
                else
                {
                    this.LeftTree.Insert(item);
                }
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftcount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (RighttTree != null)
            {
                this.rightcount++;
                this.RighttTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftcount + this.rightcount));
        }
        public bool IfExists(T element, UC2_BinarySearch<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the Element in BST" + " " + node.NodeData);
                return true;
            }
            else
            {
                Console.WriteLine("current Element is in BST" + node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.LeftTree);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                IfExists(element, node.RighttTree);
            }
            return result;
        }

    }
}