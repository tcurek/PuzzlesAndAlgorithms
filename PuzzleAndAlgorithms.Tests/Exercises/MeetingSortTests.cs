using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzlesAndAlgorithms.Exercises;
using System.Collections.Generic;
using System.Linq;

namespace PuzzlesAndAlgorithms.Tests.Exercises
{
    [TestClass()]
    public class MeetingSortTests
    {
        [TestMethod()]
        public void ReturnsMostMeetingsICanAttend()
        {
            var meetings = new List<Meeting>
            {
                new Meeting {Name = "1", DurationHours = 4},
                new Meeting {Name = "2", DurationHours = 4},
                new Meeting {Name = "3", DurationHours = 10},
                new Meeting {Name = "4", DurationHours = 3},
                new Meeting {Name = "5", DurationHours = 6}
            };


            var expected = new List<Meeting>
            {
                new Meeting {Name = "4", DurationHours = 3},
                new Meeting {Name = "1", DurationHours = 4},
            };

            var sut = new MeetingSort();
            var result = sut.MostMeetingsICanAttend(meetings, 8);

            Assert.IsTrue(expected.SequenceEqual(result, new MeetingEquivalence()));
        }

        [TestMethod()]
        public void ReturnsEmptyListWhenICannotAttend()
        {
            var meetings = new List<Meeting>
            {
                new Meeting {Name = "1", DurationHours = 4},
                new Meeting {Name = "2", DurationHours = 4},
                new Meeting {Name = "3", DurationHours = 10},
                new Meeting {Name = "4", DurationHours = 3},
                new Meeting {Name = "5", DurationHours = 6}
            };


            var expected = new List<Meeting>();

            var sut = new MeetingSort();
            var result = sut.MostMeetingsICanAttend(meetings, 1);

            Assert.IsTrue(expected.SequenceEqual(result, new MeetingEquivalence()));
        }
    }

    public class MeetingEquivalence : IEqualityComparer<Meeting>
    {
        public bool Equals(Meeting x, Meeting y)
        {
            if (x == null || y == null)
                return false;

            return (x.DurationHours == y.DurationHours && x.Name == y.Name);
        }

        public int GetHashCode(Meeting obj)
        {
            return base.GetHashCode();
        }
    }
}
