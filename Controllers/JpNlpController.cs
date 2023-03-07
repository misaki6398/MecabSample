using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MecabSample.Models;
using MecabSample.Utilitys;
using MecabSample.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MecabSample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JpNlpController : ControllerBase
    {

        [HttpPost("")]

        public ActionResult<IEnumerable<JapaneseNlpModel>> Post([FromBody] JapaneseNlpViewModel viewModel)
        {
            var models = MeCabUtility.AnalysisSentnece(viewModel.Sentence);
            foreach (var model in models)
            {
                var jackNote = CompareUtility.CompareJackNote(model);
                if (jackNote is not null)
                {
                    model.JackNoteUrl = jackNote.JackNoteUrl;
                    model.JackNoteText = jackNote.JackNoteText;
                }
            }
            return models;
        }
    }
}