using System.Collections;

public class MyHashSet
{
    ArrayList list;

    public MyHashSet() => list = new ArrayList();

    public void Add(int key) { if (!Contains(key)) list.Add(key); }

    public void Remove(int key) { if (Contains(key)) list.Remove(key); }

    public bool Contains(int key) { return list.Contains(key); }
}


/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */