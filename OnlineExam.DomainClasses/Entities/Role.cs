﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.DomainClasses.Entities
{
    public class Role
    {
        #region Properties

        public Guid Id { get; set; }

        public String CaptionEn { get; set; }

        public String CaptionFa { get; set; }

        #endregion Properties
    }
}
