using System;
using System.Linq;

using GradeBook.Enums;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using GradeBook.GradeBooks;
namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {

        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;

        }
        public void GetLetterGrade()
        {

        }
    }
}
