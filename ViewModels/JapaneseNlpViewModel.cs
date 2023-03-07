using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MecabSample.ViewModels
{
    public class JapaneseNlpViewModel
    {
        [Required]
        public string Sentence { get; set; }
    }
}