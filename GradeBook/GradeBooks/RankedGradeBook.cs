using System;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook (string name): base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            }
            if (20 < averageGrade)
            {
                return 'A';
            }
            if ( 40 < averageGrade && averageGrade <= 20)
            {
                return 'B';
            }
            if (60 < averageGrade && averageGrade <= 40)
            {
                return 'C';
            }
            if (80 < averageGrade && averageGrade <= 60)
            {
                return 'D';
            }

            return 'F';
        }
    }
}