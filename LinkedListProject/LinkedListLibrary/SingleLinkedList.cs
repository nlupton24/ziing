using System.Collections;

namespace LinkedListLibrary
{
    public class SingleLinkedList<T> : IEnumerable<T>
    {
        private Node<T>? _head = null;
        private Node<T>? _current = null;
        public Node<T>? Head 
        {
            get { return _head; }
            set { _head = value; }
        }

        public Node<T>? Current
        {
            get { return _current; }
            set { _current = value; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            _current = _head;
            while (_current != null)
            {
                yield return _current.Data;
                _current = _current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
