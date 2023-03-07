using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MecabSample.Models;

namespace MecabSample.Utilitys
{
    public static class CompareUtility
    {
        private static List<JackNoteMapModel> mapModels = new List<JackNoteMapModel>();
        static CompareUtility()
        {
            JackNoteMapModel mapModel = new JackNoteMapModel
            {
                Keyword = "から",
                Hinshi = "助詞",
                HinshiHosoBunrui = "格助詞",
                JackNoteUrl = "https://main.jacknotes.digital/06+%E5%8A%A9%E8%A9%9E/%E5%9F%BA%E6%9C%AC%E5%8A%A9%E8%A9%9E/%E5%8A%A9%E8%A9%9E%E3%80%8C%E3%81%8B%E3%82%89%E3%80%8D",
                JackNoteText = "助詞「から」"

            };
            mapModels.Add(mapModel);
            mapModel = new JackNoteMapModel
            {
                Keyword = "だから",
                Hinshi = "接続詞",
                HinshiHosoBunrui = "*",
                JackNoteUrl = "https://main.jacknotes.digital/32%E3%80%90%E8%B3%87%E6%96%99%E5%BA%AB%E3%80%91%E5%B8%B8%E7%94%A8%E5%96%AE%E5%AD%97%EF%BC%88%E5%89%AF%E3%83%BB%E6%8E%A5%EF%BC%89/%E3%81%A0%E3%81%8B%E3%82%89",
                JackNoteText = "だから"
            };
            mapModels.Add(mapModel);
        }
        public static JackNoteMapModel CompareJackNote(JapaneseNlpModel model)
        {
            var result = mapModels.Where(c => c.Keyword == model.Keyword
            && c.Hinshi == model.Hinshi
            && c.HinshiHosoBunrui == model.HinshiHosoBunrui);
            return result.FirstOrDefault();
        }
    }
}