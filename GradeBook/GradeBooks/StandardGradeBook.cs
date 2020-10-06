﻿using System;
using System.Linq;

using GradeBook.Enums;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using GradeBook.GradeBooks;


namespace GradeBook.GradeBooks
{
    public class StandardGradeBook  : BaseGradeBook 
    {
        
        public StandardGradeBook(string name, bool isWeight) : base(name, isWeight)
        {
            Type = GradeBookType.Standard;
         
        }

    }
}
