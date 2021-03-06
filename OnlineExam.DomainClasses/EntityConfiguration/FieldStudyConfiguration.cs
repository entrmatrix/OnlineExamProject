﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineExam.DomainClasses.Entities;

namespace OnlineExam.DomainClasses.EntityConfiguration
{
    public class FieldStudyConfiguration:EntityTypeConfiguration<FieldStudy>
    {
        public FieldStudyConfiguration()
        {
            Property(x => x.CaptionFa).IsRequired().HasMaxLength(50);
            Property(x => x.CaptionEn).IsRequired().HasMaxLength(50).HasColumnType("varchar");
            Property(x => x.DisplayOrder).IsRequired();
        }
    }
}
