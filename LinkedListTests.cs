using NUnit.Framework;

[TestFixture]
public class LinkedListTests
{
    private DoublyLinkedList<int> _list;

    [SetUp]
    public void Setup()
    {
        _list = new DoublyLinkedList<int>();
    }

    [Test]
    public void TestAddLast()
    {
        _list.AddLast(1);
        Assert.AreEqual(1, _list.Length);
        Assert.AreEqual(1, _list.Last);
    }

    [Test]
    public void TestAddFirst()
    {
        _list.AddFirst(2);
        Assert.AreEqual(1, _list.Length);
        Assert.AreEqual(2, _list.First);
    }

    [Test]
    public void TestRemoveFirst()
    {
        _list.AddFirst(3);
        _list.RemoveFirst();
        Assert.AreEqual(0, _list.Length);
    }

    [Test]
    public void TestRemoveLast()
    {
        _list.AddLast(4);
        _list.RemoveLast();
        Assert.AreEqual(0, _list.Length);
    }

    [Test]
    public void TestReverseList()
    {
        _list.AddLast(1);
        _list.AddLast(2);
        _list.AddLast(3);
        _list.ReverseList();
        Assert.AreEqual(3, _list.First);
        Assert.AreEqual(1, _list.Last);
    }
}
