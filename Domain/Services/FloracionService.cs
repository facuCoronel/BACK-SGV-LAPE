using AutoMapper;
using Domain.Dto.Floracion;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class FloracionService : IFloracionService
    {
        private readonly IFloracionRepository _floracionRespository;
        private readonly IMapper _mapper;

        public FloracionService(IFloracionRepository floracionRespository, IMapper mapper)
        {
            _floracionRespository = floracionRespository;
            _mapper = mapper;
        }

        public bool PostFloracion(string tipo)
        {
            var fl = new Floracion();
            fl.Tipo = tipo;
            _floracionRespository.Add(fl);
            _floracionRespository.Commit();
            return true;
        }


        public bool PutFloracion(FloracionPutDto fl)
        {
            var flo = _floracionRespository.GetById(fl.Id);
            if (flo is null)
                throw new Exception("No se encontro floracion");

            flo.Tipo = fl.Tipo;
            _floracionRespository.Update(flo);
            _floracionRespository.Commit();

            return true;

        }


        public IEnumerable<FloracionGetDto> GetAllFloracion()
        {
            return _mapper.Map<IEnumerable<FloracionGetDto>>(_floracionRespository.GetAll());
        }


    }
}
