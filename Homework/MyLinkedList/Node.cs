namespace MyLinkedList
{
    public class Node<T>
    {
        public Node(T t)
        {
            Next = null;
            Data = t;
        }

        public Node<T> Next { get; set; }
        public T Data { get; set; }
    }
}