namespace StudyBuddy.Models
{
    public class PreliminaryQuestion
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CategoryName { get; set; } = string.Empty;
        public string QuestionText { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new();
        public int CorrectAnswerIndex { get; set; }
        public List<int> CloseAnswerIndexes { get; set; } = new();
    }

    public class PreliminaryTestResult
    {
        public Dictionary<string, CategoryScore> CategoryScores { get; set; } = new();
        public List<QuestionResult> IndividualQuestionResults { get; set; } = new(); // NEW
        public TimeSpan TotalTime { get; set; }
        public DateTime CompletedAt { get; set; }
    }

    // NEW: Track individual question results
    public class QuestionResult
    {
        public string QuestionId { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public int Points { get; set; }
        public TimeSpan TimeSpent { get; set; }
        public AnswerResult Result { get; set; }
    }

    public class CategoryScore
    {
        public string CategoryName { get; set; } = string.Empty;
        public int Points { get; set; }
        public int TotalQuestions { get; set; } // NEW
        public int AveragePoints { get; set; } // NEW
        public TimeSpan TimeSpent { get; set; }
        public AnswerResult Result { get; set; }
    }

    public enum AnswerResult
    {
        VeryQuickCorrect,
        VeryQuickClose,
        QuickCorrect,
        QuickClose,
        NormalCorrect,
        NormalClose,
        SlowCorrect,
        SlowClose,
        Wrong
    }
}