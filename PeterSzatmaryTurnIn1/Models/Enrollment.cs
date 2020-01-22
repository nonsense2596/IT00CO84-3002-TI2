﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeterSzatmaryTurnIn1.Models
{
    public class Enrollment
    {
        public int Id { get; set; }
        public Nullable<Grade> Grade { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }

}
