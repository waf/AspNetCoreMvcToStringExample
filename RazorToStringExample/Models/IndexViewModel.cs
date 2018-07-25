using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorToStringExample.Models
{
    public class IndexViewModel
    {
        public string Message { get; }

        public IndexViewModel(string message)
        {
            this.Message = message;
        }
    }
}
