namespace Task_2._3.Entities
{
    public class Training
    {
        private List<object> _sessions;

        public Training()
        {
            _sessions = new List<object>();
        }

        public List<object> GetSessions()
        {
            return _sessions;
        }

        public void AddSession(object session)
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
            var clone = new Training();
            foreach (var session in _sessions)
            {
                if ( session is Lecture lecture)
                {
                    clone.AddSession(new Lecture(lecture.Description, lecture.Topic));
                }
                else if (session is PracticalLesson practicalLesson)
                {
                    clone.AddSession(new PracticalLesson (practicalLesson.Description, practicalLesson.TaskConditionLink, practicalLesson.SolutionLink));
                }
            }
            return clone;
        }
    }
}
