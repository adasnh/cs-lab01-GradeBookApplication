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
    class StandardGradeBook  : BaseGradeBook 
    {
        
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
         
        }

    }
}
