using System.Collections.Generic;

namespace PuzzlesAndAlgorithms.Exercises
{
    public class MeetingSort
    {
        /*
         * Attend as many meetings as possible for that given day.
         */

        public List<Meeting> MostMeetingsICanAttend(List<Meeting> meetings, int hoursAvailable)
        {
            var result = new List<Meeting>();

            meetings.Sort(new MeetingComparer());

            int sum = 0;

            for (int i = 0; i < meetings.Count; i++)
            {
                if(sum + meetings[i].DurationHours > hoursAvailable)
                    break;

                sum += meetings[i].DurationHours;
                result.Add(meetings[i]);
            }
            
            return result;
        }

    }

    public class Meeting
    {
        public string Name { get; set; }
        public int DurationHours { get; set; }

        public override string ToString()
        {
            return $"{Name} : {DurationHours}";
        }
    }

    public class MeetingComparer : IComparer<Meeting>
    {
        public int Compare(Meeting x, Meeting y)
        {
            if (x.DurationHours == y.DurationHours)
                return 0;

            return x.DurationHours < y.DurationHours ? -1 : 1;
        }
    }
}
