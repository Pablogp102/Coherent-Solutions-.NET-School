namespace Task_2._3.Entities
{
    public class PracticalLesson
    {
        public string Description { get; set; }
        public string TaskConditionLink { get; set; }
        public string SolutionLink { get; set; }

        public PracticalLesson(string description, string taskConditionLink, string solutionLink)
        {
            Description = description ?? string.Empty;
            TaskConditionLink = taskConditionLink ?? string.Empty;
            SolutionLink = solutionLink ?? string.Empty;
        }
    }
}
