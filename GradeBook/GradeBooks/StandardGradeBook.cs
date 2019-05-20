﻿namespace GradeBook.GradeBooks
{
    using GradeBook.Enums;

    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Standard;
        }
    }
}
