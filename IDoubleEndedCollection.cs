public interface IDoubleEndedCollection<T>
{
    T First { get; }
    T Last { get; }
    int Length { get; }
    void AddLast(T value);
    void AddFirst(T value);
    void Remove First();
    void RemoveLast();
    void InsertAfter(DNode, T value);
    void RemoveByValue(T value);
    void ReverseList();
}