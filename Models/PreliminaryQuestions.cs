namespace StudyBuddy.Models
{
    public class PreliminaryQuestion
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CategoryName { get; set; } = string.Empty;
        public string QuestionText { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new();
        public int CorrectAnswerIndex { get; set; }
        public List<int> CloseAnswerIndexes { get; set; } = new(); // Answers that are "close"
    }

    public class PreliminaryTestResult
    {
        public Dictionary<string, CategoryScore> CategoryScores { get; set; } = new();
        public TimeSpan TotalTime { get; set; }
        public DateTime CompletedAt { get; set; }
    }

    public class CategoryScore
    {
        public string CategoryName { get; set; } = string.Empty;
        public int Points { get; set; }
        public TimeSpan TimeSpent { get; set; }
        public AnswerResult Result { get; set; }
    }

    public enum AnswerResult
    {
        VeryQuickCorrect,    // < 20s, correct
        VeryQuickClose,      // < 20s, close
        QuickCorrect,        // 20-60s, correct
        QuickClose,          // 20-60s, close
        NormalCorrect,       // 1-5min, correct
        NormalClose,         // 1-5min, close
        SlowCorrect,         // > 5min, correct
        SlowClose,           // > 5min, close
        Wrong                // Wrong answer
    }
}