using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook (string name) : base(name)
        {
            GradeBookType Type  = GradeBookType.Ranked;
        }
    }

}