﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Architecture.ViewModels.Category
{
    public class GenericEditCategoryViewModel
    {
        [MinLength(3)]
        public string Title { get; set; }
    }
}
