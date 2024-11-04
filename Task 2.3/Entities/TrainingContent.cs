namespace Task_2._3.Entities
{
    public class TrainingContent
    {
        public string? Description { get; set; }

        protected TrainingContent(string? description)
        {
            Description = description;
        }
    }
}
