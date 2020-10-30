using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook (string name): base(name)
        {
            GradeBookType Type = GradeBookType.Standard;
        }
    }

}