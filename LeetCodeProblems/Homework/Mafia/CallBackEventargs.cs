namespace LeetCodeProblems.Homework.Mafia
{
    public class CallBackEventargs:EventArgs
    {
        public int Id { get; set; }
        public string OrderMessage { get; set; }
        public DateTime SendDate { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Message:{OrderMessage}, SendDate:{SendDate}";
        }
    }
}