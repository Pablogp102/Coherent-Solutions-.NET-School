namespace Task_2._3.Entities
{
    public class Training : TrainingContent
    {
        private List<Lesson> _sessions;

        public Training(string? description) : base(description) 
        {
            _sessions = new List<Lesson>();
        }

        public List<Lesson> GetSessions()
        {
            return new List<Lesson>(_sessions);
        }

        public void AddSession(Lesson session)
        {
            if (session is Lecture || session is PracticalLesson)
            { 
                _sessions.Add(session);
            }
            else
            {
                throw new ArgumentException("Invalid session type. Must be Lecture or PracticalLesson.");
            }
        }

        public bool IsPractical()
        {
            foreach (var session in _sessions)
            {
                if (session is Lecture)
                {
                    return false;
                }
            }
            return true;
        }

        public Training Clone()
        {
            var clone = new Training(this.Description);
            foreach (var session in _sessions)
            {
                clone.AddSession(session.Clone());
            }
            return clone;
        }
    }
}
