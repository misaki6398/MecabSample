using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MecabSample.Models
{
    public class JapaneseNlpModel
    {
        public string? Keyword { get; set; }

        // 品詞
        public string? Hinshi { get; set; }
        // 品詞細分類
        public string? HinshiHosoBunrui { get; set; }
        // ?
        public string? Feature3 { get; set; }
        // ?
        public string? Feature4 { get; set; }
        // 活用型
        public string? Katsuyogata { get; set; }
        // 活用形
        public string? KatsuyoKatachi { get; set; }
        // 原形
        public string? GenKei { get; set; }
        // 假名
        public string? Kana { get; set; }
        // 發音
        public string? Hatsuon { get; set; }
        public string? JackNoteUrl { get; set; }
        public string? JackNoteText { get; set; }

    }
}