using AutoMapper;
using MyHardwareWeb.Domain.Models;
using MyHardwareWeb.Infrastructure.Repository;

namespace MyHardwareWeb.Infrastructure.Services
{
    public abstract class Service<TModel, TEntity> where TEntity : Entity
    {

        private readonly Repository<TEntity> _repository;
        private readonly IMapper _mapper;

        protected Service(
            IMapper mapper,
            Repository<TEntity> repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task Save(TModel entityModel)
        {
            var entityMap = _mapper.Map<TEntity>(entityModel);
            await _repository.Create(entityMap);
        }

        public virtual async Task<TEntity> Edit(TEntity entityModel)
        {
            var entityMap = _mapper.Map<TEntity, TEntity>(entityModel);
            await _repository.Update(entityMap);
            return entityMap;
        }

        public virtual TEntity? FindById(int id)
        {
            var currentEntity = _repository.FindById(id).Result;
            return currentEntity;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            var listEntity = _repository.GetAll().Result;
            return listEntity;
        }
    }
}