namespace LeetCodeProblems.Lesson
{
    public static class A1
    {
        public static void A()
        {
            (double, int) a = (4.5, 2);
            Console.WriteLine(a.Item1);
            a.Item2 = 12;
            (int sideA, double sideB) side = (12, 23);
            Console.WriteLine(side.sideA);
        }
    }
}
