class Program
{
    static void Main(string[] args)
    {
        double x = 1;
        int n = 1000000;

        double schet = System.Math.Sin(x);
        double summ = schet;

        for (int i = 1; i < n; i++)
        {
            schet = System.Math.Sin(schet);
            summ += schet;
        }
        Console.WriteLine(summ);
       
    }
}
