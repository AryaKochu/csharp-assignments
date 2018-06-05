using System;
using System.Collections.Generic;

namespace LinkedList.SingleLinkedList
{
    public class SingleLinkedList<T>
    {
        private Node<T> _headNode = null;
       
        public List<Node<T>> DisplaySingleLinkedList()
        {
            List<Node<T>> resultList = new List<Node<T>>();
            var tempNode = _headNode;
            resultList.Add(tempNode);
            while (tempNode.Next != null)
            {
                tempNode = tempNode.Next;
                resultList.Add(tempNode);
            }
            return resultList;
        }
        public void InsertAtBeginning(T item)
        {
            var node = new Node<T>(item);
            if (_headNode == null)
            {
                node.Next = null;
                _headNode = node;
            }
            else
            {
                node.Next = _headNode;
                _headNode = node;
            }
        }

        public void InsertAtEnd(T item)
        {
            var node = new Node<T>(item);

            if (_headNode == null)
            {
                _headNode = node;
            }
            else
            {
                var tempNode = _headNode;
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = node;
            }
        }

        public void DeleteFromTheBeginning()
        {
            var tempNode = _headNode;
            _headNode = _headNode.Next;
            tempNode.Next = null;
        }

        public void DeleteFromTheEnd()
        {
            var tailNnode= _headNode;
            var tempNode = tailNnode;
            while (tailNnode.Next != null)
            {
                tempNode = tailNnode;
                tailNnode = tailNnode.Next;
            }

            tempNode.Next = null;
        }

        public void InsertNodeAtGivenPosition(T item, int pos)
          {
              var node = new Node<T>(item);
              var temp = _headNode;
              var prevNode = temp;
            var count = 1;
              do
              {
                  if (count == pos)
                  {
                      var nextNode = temp;
                      prevNode.Next = node;
                      node.Next = nextNode;

                  }

                  count++;
                  prevNode = temp;
                  temp = temp.Next;
            } while(temp.Next != null);

          }
    }
}
