﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aiursoft.Blog.Models.ErrorViewModels
{
    public class Code404ViewModel : ErrorViewModel
    {
        public Code404ViewModel()
        {
            Title = "404 Not found";
            Description = "The target url you view is not found.";
        }
    }
}
