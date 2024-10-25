namespace Task_2._3.Entities
{
    public class Lecture : Lesson
    {
        public string Topic { get; set; }

        public Lecture(string description, string topic ) : base(description)
        {
            Topic = topic ?? string.Empty;
        }

        public override Lesson Clone()
        {
            return new Lecture(this.Description, this.Topic);
        }
    }
}
