using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MecabSample.Models
{
    public class JackNoteMapModel
    {
        public string? Keyword { get; set; }
        // 品詞
        public string? Hinshi { get; set; }
        // 品詞細分類
        public string? HinshiHosoBunrui { get; set; }
        // 活用型
        public string? Katsuyogata { get; set; }
        public string? JackNoteUrl { get; set; }
        public string? JackNoteText { get; set; }
    }
}