class Mynullable
{
    public static void MyNullable()
    {
        int? a = null;
        Console.WriteLine(a.HasValue);
        object t = a;
        Console.WriteLine(t.GetType());
        Console.WriteLine(a.GetValueOrDefault());
        
    }
           
}

