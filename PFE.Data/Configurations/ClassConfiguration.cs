﻿
using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Configurations
{
    public class ClassConfiguration : EntityTypeConfiguration<CLass>
    {
        public ClassConfiguration()
        {
            HasRequired<AcademicYear>(a => a.AcademicYear)
                .WithMany(c => c.listCLass)
                .HasForeignKey(c => c.AcademicYearFK)
                .WillCascadeOnDelete(true);

            HasRequired<Option>(o => o.Option)
                    .WithMany(c => c.ClassList)
                    .HasForeignKey(c => c.OptionFK)
                    .WillCascadeOnDelete(true);

        

                
            
        }
    }
}
