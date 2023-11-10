using AutoMapper;
using Domain.Dto.Stock;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;
        private readonly IMapper _mapper;

        public StockService(IMapper mapper, IStockRepository stockRepository)
        {
            _mapper = mapper;
            _stockRepository = stockRepository;
        }

        public bool InsertStock(StockPostDto stockPostDto)
        {
            var validator = _stockRepository.ForFilter<Stock>(x => stockPostDto.ProductoId == x.ProductoId).FirstOrDefault();
            if (!(validator is null))
                throw new Exception("Ya existe el articulo con stock, no se pudo crear el registro");


            var entity = _mapper.Map<Stock>(stockPostDto);
            _stockRepository.Add(entity);
            _stockRepository.Commit();

            return true;
        }

        public bool ActualizarStock(StockPutDto stockPutDto)
        {
            var entity = _mapper.Map<Stock>(stockPutDto);

            _stockRepository.Update(entity);
            _stockRepository.Commit();

            return true;
        }

        public IEnumerable<StockGetDto> GetAllStock()
        {
            return _mapper.Map<IEnumerable<StockGetDto>>(_stockRepository.GetAll());
        }

        public StockGetDto GetByIdStock(int id)
        {
            return _mapper.Map<StockGetDto>(_stockRepository.GetById(id));
        }

        public bool DeleteStockById(int id)
        {
            var entity = _stockRepository.GetById(id);
            _stockRepository.Remove(entity);
            _stockRepository.Commit();
            return true;
        }



    }
}
