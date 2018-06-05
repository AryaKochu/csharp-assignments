namespace LinkedList.SingleLinkedList
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
}
