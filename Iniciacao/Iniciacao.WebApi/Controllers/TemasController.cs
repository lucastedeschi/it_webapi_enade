using Iniciacao.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Iniciacao.Services.Tema;
using Iniciacao.WebApi.Models;

namespace Iniciacao.WebApi.Controllers
{
    public class TemasController : ApiController
    {
        private readonly ITemaService _temaService;

        public TemasController(ITemaService temaService)
        {
            _temaService = temaService;
        }

        public TemaModel GetTemaById(int id)
        {
            return MapTemaToModel(_temaService.GetTemaById(id));
        }

        public IEnumerable<TemaModel> GetAll()
        {
            List<TemaModel> temas = new List<TemaModel>();

            foreach (var tema in _temaService.GetAll())
            {
                temas.Add(MapTemaToModel(tema));
            }

            return temas;
        }

        public static TemaModel MapTemaToModel(Tema tema)
        {
            return new Models.TemaModel()
            {
                Id = tema.Id,
                Nome = tema.Nome,
                Descricao = tema.Descricao
            };
        }
    }
}
