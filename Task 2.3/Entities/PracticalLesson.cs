namespace Task_2._3.Entities
{
    public class PracticalLesson : Lesson
    {
        public string TaskConditionLink { get; set; }
        public string SolutionLink { get; set; }

        public PracticalLesson(string description, string taskConditionLink, string solutionLink)
            : base(description)
        {
            Description = description ?? string.Empty;
            TaskConditionLink = taskConditionLink ?? string.Empty;
            SolutionLink = solutionLink ?? string.Empty;
        }

        public override Lesson Clone()
        {
            return new PracticalLesson(this.Description, this.TaskConditionLink, this.SolutionLink);
        }
    }
}
