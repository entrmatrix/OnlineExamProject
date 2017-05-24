﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExam.Models.Accounting
{
    public class Login
    {
        [Display(ResourceType = typeof(AttributeResource), Name = "DisplayUserName")]
        [Required(ErrorMessageResourceType = typeof(AttributeResource), ErrorMessageResourceName = "RequiredUserName")]
        public String UserName { get; set; }
        [Display(ResourceType = typeof(AttributeResource), Name = "DisplayPassword")]
        [Required(ErrorMessageResourceType = typeof(AttributeResource), ErrorMessageResourceName = "RequiredPass")]
        public String Password { get; set; }

    }
}
