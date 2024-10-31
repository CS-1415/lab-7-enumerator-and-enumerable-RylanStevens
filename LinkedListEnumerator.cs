using System.Collections;
using System.Collections.Generic;
public class LinkedListEnumerator<T> : IEnumerator<T>
{
    private readonly DNode<T>? _firstNode;
    private DNode<T>? _currentNode;
    public LinkedListEnumerator(DNode<T>? firstNode)
    {
        _firstNode = firstNode;
        _currentNode = null;
    }
    public T Current => _currentNode != null ? _currentNode.Value : throw new InvalidOperationException();
    object IEnumerator.Current => Current;
    public bool MoveNext()
    {
        if (_currentNode == null)
        {
            _currentNode = _firstNode;
        }
        else
        {
            _currentNode = _currentNode.Next;
        }
        return _currentNode != null;
    }
    public void Reset()
    {
        _currentNode = null;
    }
    public void Dispose()
    {
        
    }
}