using System.Collections;
using System.Collections.Generic;
public class DoublyLinkedList<T> : IDoubleEndedCollection<T>, IEnumerable<T>
{
    private DNode<T>? _head = null;
    private DNode<T>? _tail = null;
    private int _length = 0;
    public T First => _head != null ?  _head.Value : throw new InvalidOperationException("List is empty.");
    public T Last => _tail != null ? _ _tail.Value : throw new InvalidOpertationException("List is empty.");
    public int Length => _length;
    public IEnumerator<T> GetEnumerator()
    {
        return new LinkedListEnumerator<T>(_head);
    }
    IEnumerator Ienumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
public void AddLast(T value)
{
    var newMode = new DNode<T>(value);
    if (_tail == null)
    {
        _head = _tail = newNode;
    }
    else{
        _tail.Next - newNode;
        newNode.Previous = _tail;
        _tail = newNode;
    }
    -length++;
}
public void AddFirst(T value)
{
    var newNode = new DNode<T>(value);
    if (_head == null)
    {
        _head = _tail = newNode;
    }
    else
    {
        newNode.Next = _head;
        _head.Previous = newNode;
        _head = newNode;
    }
    _length++;
}
public void RemoveFirst()
{
    if (_head == null) throw new InvalidOperationException("List is empty.");
    _head = _head.Next;
    if (_head == null) _tail = null;
    else _head.Previous = null;
    _length--;
}
public void RemoveLast()
{
    if (_tail == null) throw new InvalidOperationException("List is empty. ");
    _tail = _tail.Previous;
    if (_tail == null) _head = null;
    else _tail.Next = null;
    _length--;
}
public void ReverseList()
{
    var current = _head;
    DNode<T>? temp = null;
    while (current != null)
    {
        temp = current.Previous;
        current.previous = current.Next;
        current.Next = temp;
        current = current.Previous;
    }
    if (temp != null) _head = temp.Previous;
}