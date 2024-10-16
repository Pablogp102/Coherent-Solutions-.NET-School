namespace Task_2._3.Entities
{
    public class Lecture
    {
        public string Description { get; set; }
        public string Topic { get; set; }

        public Lecture(string description, string topic) 
        { 
            Description = description ?? string.Empty; 
            Topic = topic ?? string.Empty; 
        }
    }
}
