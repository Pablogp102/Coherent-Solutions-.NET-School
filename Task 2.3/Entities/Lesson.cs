namespace Task_2._3.Entities
{
    public class Lesson : TrainingContent
    {
        public Lesson(string? description) : base(description) { }

        public virtual Lesson Clone() 
        {
            return new Lesson(this.Description);
        }
    }
}
