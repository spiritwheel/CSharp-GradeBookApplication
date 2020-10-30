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
            if (averageGrade <= 5)
            {
                throw new InvalidOperationException();
            }
            if (5 < averageGrade && averageGrade <= 20)
            {
                return 'A';
            }
            if (20 < averageGrade && averageGrade <= 40)
            {
                return 'B';
            }
            if (40 < averageGrade && averageGrade <= 60)
            {
                return 'C';
            }
            if (60 < averageGrade && averageGrade <= 80)
            {
                return 'D';
            }

            return 'F';
        }
    }
}