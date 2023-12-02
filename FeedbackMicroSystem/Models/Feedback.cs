namespace FeedbackMicroSystem.Models
{
    public class Feedback
    {
        public string? Id { get; set; }
        public string? Comment { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CustomerName { get; set; }
        public bool Discarded { get; set; }
        public bool Moderated { get; set; }
        public bool Published { get; set; }
        public Order? Order { get; set; }
        public List<Question>? Questions { get; set; }
        public double? Score { get; set; }
        public string? SurveyId { get; set; }
    }
}
