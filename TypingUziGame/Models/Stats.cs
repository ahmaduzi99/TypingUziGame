namespace TypingUziGame.Models
{
    public class Stats
    {
      
        public int Correct { get; set; }
        public int Missed { get; set; }
        public int Total { get;  set; }
        public int Accuracy { get; set; }

        public void countTotal()
        {
            Total = Correct + Missed;
        }

        public void CountAccuracy()
        {
            Accuracy = Correct * 100 / (Correct + Missed);
        }
    }
}
