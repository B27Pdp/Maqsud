using System.Collections;
using System.Linq;

public class MyQueue
{

    Stack stc = new Stack();
    Stack stc1 = new Stack();
    public MyQueue()
    {

    }

    public void Push(int x)
    {
        int count = stc.Count;
        for (int i = 0; i < count; i++)
        {
            stc1.Push(stc.Pop());
        }
        stc.Push(x);
        for (int i = 0; i < count; i++)
        {
            stc.Push(stc1.Pop());
        }
    }

    public int Pop()
    {
        return (int)stc.Pop();
    }

    public int Peek()
    {
        return (int)stc.Peek();
    }

    public bool Empty()
    {
        return stc.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */