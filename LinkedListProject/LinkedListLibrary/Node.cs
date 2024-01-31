namespace LinkedListLibrary
{
    public class Node<T>(T? data)
    {
        private Node<T>? _next = null;
        private T? _data = data;

        public Node<T>? Next 
        { 
            get { return _next; }
            set { _next = value; } 
        }

        public T? Data
        {
            get { return _data; }
            set { _data = value; }
        }
    }
}
