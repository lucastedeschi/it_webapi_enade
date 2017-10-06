using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Iniciacao.Domain;
using Iniciacao.Services.Questao;
using Iniciacao.WebApi.Models;

namespace Iniciacao.WebApi.Controllers
{
    public class QuestoesController : ApiController
    {
        private readonly IQuestaoService _questaoService;

        public QuestoesController(IQuestaoService questaoService)
        {
            _questaoService = questaoService;
        }

        public IEnumerable<QuestaoModel> GetAll()
        {
            List<QuestaoModel> questoes = new List<QuestaoModel>();

            foreach (var questao in _questaoService.GetAll())
            {
                questoes.Add(MapQuestaoToModel(questao));
            }

            return questoes;
        }

        public IEnumerable<QuestaoModel> GetQuestoesByTemaId(int temaId)
        {
            List<QuestaoModel> questoes = new List<QuestaoModel>();

            foreach (var questao in _questaoService.GetQuestoesByTemaId(temaId))
            {
                questoes.Add(MapQuestaoToModel(questao));
            }

            return questoes;
        }

        public IEnumerable<QuestaoModel> GetQuestoesByAnoEnade(int anoEnade)
        {
            List<QuestaoModel> questoes = new List<QuestaoModel>();

            foreach(var questao in _questaoService.GetQuestoesByAnoEnade(anoEnade))
            {
                questoes.Add(MapQuestaoToModel(questao));
            }

            return questoes;
        }

        public QuestaoModel GetQuestaoById(int id)
        {
            return MapQuestaoToModel(_questaoService.GetQuestaoById(id));            
        }

        public static QuestaoModel MapQuestaoToModel(Questao questao)
        {
            return new QuestaoModel()
            {
                Id = questao.Id,
                Titulo = questao.Titulo,
                Descricao = questao.Descricao,
                Resposta = questao.Resposta,
                EnadeAno = questao.EnadeAno,
                TemaId = questao.TemaId
            };
        }
    }
}
