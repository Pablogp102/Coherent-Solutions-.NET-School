using System.ComponentModel;

namespace Task_2._3.Entities
{
    public class Training : TrainingContent
    {
        private Lesson[] _sessions;
        private int _sessionCount;

        public Training(string? description) : base(description) 
        {
            _sessions = new Lesson[4];
            _sessionCount = 0;
        }

        public Lesson[] GetSessions()
        {
            var sessionsCopy = new Lesson[_sessionCount];
            Array.Copy(_sessions, sessionsCopy, _sessionCount);
            return sessionsCopy;
        }

        public void AddSession(Lesson session)
        {
            if (_sessionCount ==  _sessions.Length) 
            {
                Array.Resize(ref _sessions, _sessions.Length + 1);
            }
            _sessions[_sessionCount++] = session;
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
                if (session != null)
                {
                    clone.AddSession(session.Clone());
                }
            }
            return clone;
        }
    }
}
