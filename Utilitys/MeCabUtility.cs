using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeCab;
using MecabSample.Models;

namespace MecabSample.Utilitys
{
    public static class MeCabUtility
    {
        public static List<JapaneseNlpModel> AnalysisSentnece(string sentence) {
            var parameter = new MeCabParam();
            var tagger = MeCabTagger.Create(parameter);
            List<JapaneseNlpModel> models = new List<JapaneseNlpModel>();
            
            foreach (var node in tagger.ParseToNodes(sentence))
            {
                if (node.CharType > 0)
                {
                    var features = node.Feature.Split(',');
                    var displayFeatures = string.Join(", ", features);
                    JapaneseNlpModel model = new JapaneseNlpModel();
                    
                    model.Keyword = node.Surface ?? "*";

                    for(int count=0;count<features.Length;count++){
                        switch (count)
                        {
                            case 0:
                                model.Hinshi = features[count] ?? "*";
                                break;
                            case 1:
                                model.HinshiHosoBunrui = features[count] ?? "*";
                                break;
                            case 2:
                                model.Feature3 = features[count] ?? "*";
                                break;
                            case 3:
                                model.Feature4 = features[count] ?? "*";
                                break;
                            case 4:
                                model.Katsuyogata = features[count] ?? "*";
                                break;
                            case 5:
                                model.KatsuyoKatachi = features[count] ?? "*";
                                break;
                            case 6:
                                model.GenKei = features[count] ?? "*";
                                break;
                            case 7:
                                model.Kana = features[count] ?? "*";
                                break;
                            case 8:
                                model.Hatsuon = features[count] ?? "*";
                                break;
                            default:
                            throw new NotImplementedException();
                        }
                    }
                   
                    models.Add(model);
                }
            }
            return models;
        }
    }
}