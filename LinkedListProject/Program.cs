using System;
using System.Linq;
using LinkedList.SingleLinkedList;

namespace LinkedListProject
{
    public class Program
    {
       private static void Main()
        {

            SingleLinkedList<string> sll = new SingleLinkedList<string>();

            // Insert node at the beginning - if there LL is empty
            Console.WriteLine("\n\nINSERTION AT THE BEGINNING!!");
            InsertAtTheBeginning(sll, "Node 02");
            InsertAtTheBeginning(sll, "Node 03");

            //Insert node at the end
            Console.WriteLine("\n\nINSERTION AT THE END!!");
            InsertAtTheEnd(sll, "Node 01");
            InsertAtTheEnd(sll, "Node 04");


            Console.WriteLine("\n\nREMOVE FROM THE BEGINNING!!");
            RemoveFromTheBeginning(sll);

            Console.WriteLine("\n\nREMOVE FROM THE END!!");
            RemoveFromTheEnd(sll);

            InsertAtTheBeginning(sll, "Node 12");
            InsertAtTheEnd(sll, "Node 13");

            Console.Write("\nEnter the data to be inserted: ");         
            var data = Console.ReadLine();
            Console.WriteLine("Enter the position: ");
            var pos = Console.ReadLine();

            sll.InsertNodeAtGivenPosition(data, Int32.Parse(pos));
            DisplayTheNodes(sll);
            var c = Console.Read();
        }

        private static void InsertAtTheBeginning(SingleLinkedList<string> sll, string data)
        {
            sll.InsertAtBeginning(data);
            DisplayTheNodes(sll);

        }

        private static void InsertAtTheEnd(SingleLinkedList<string> sll, string data)
        {
            sll.InsertAtEnd(data);
            DisplayTheNodes(sll);

        }

        private static void RemoveFromTheBeginning(SingleLinkedList<string> sll)
        {
            sll.DeleteFromTheBeginning();
            DisplayTheNodes(sll);
        }

        private static void RemoveFromTheEnd(SingleLinkedList<string> sll)
        {
            sll.DeleteFromTheEnd();
            DisplayTheNodes(sll);
        }

        public static void InsertNodeAtGivenPosition(SingleLinkedList<string> sll)
        {
           
        }
        private static void DisplayTheNodes(SingleLinkedList<string> sll)
        {
            Console.WriteLine($"\nExisting nodes in Linked List: \n");

            var resultList = sll.DisplaySingleLinkedList();
            foreach (var node in resultList)
            {
                Console.Write($"{node.Data}");
                if (node.Next != null)
                {
                    Console.Write(" -> ");
                }
            }
        }
    }
}
