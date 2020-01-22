using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PeterSzatmaryTurnIn1.Models;

namespace PeterSzatmaryTurnIn1.Data
{
    public class PeterSzatmaryTurnIn1Context : DbContext
    {
        public PeterSzatmaryTurnIn1Context (DbContextOptions<PeterSzatmaryTurnIn1Context> options)
            : base(options)
        {
        }

        public DbSet<PeterSzatmaryTurnIn1.Models.Course> Course { get; set; }

        public DbSet<PeterSzatmaryTurnIn1.Models.Enrollment> Enrollment { get; set; }

        public DbSet<PeterSzatmaryTurnIn1.Models.Student> Student { get; set; }
    }
}
