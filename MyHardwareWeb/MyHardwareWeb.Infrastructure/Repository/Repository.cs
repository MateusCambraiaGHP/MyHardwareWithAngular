﻿

using Microsoft.EntityFrameworkCore;
using MyHardware.Infrastructure.Common.Interfaces;
using MyHardwareWeb.Domain.Models;

namespace MyHardwareWeb.Infrastructure.Repository
{
    public abstract class Repository<TEntity> where TEntity : Entity
    {
        protected readonly IApplicationDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        protected Repository(
            IApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual async Task Create(TEntity entityModel)
        {
            await _dbSet.AddAsync(entityModel);
            await _context.Save();
        }

        public virtual async Task<TEntity> Update(TEntity entityModel)
        {
            _dbSet.Update(entityModel);
            await _context.Save();
            return entityModel;
        }

        public virtual async Task<TEntity?> FindById(int id)
        {
            var currentEntity = await _dbSet.AsNoTracking()
                .Where(c => c.Id == id).FirstOrDefaultAsync();
            return currentEntity;
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            List<TEntity> currentEntity = await _dbSet.ToListAsync();
            return currentEntity;
        }

        #region --------Private Methods----------
        //private async Task ExportAllAdress()
        //{
        //    IEnumerable<Adress> listAdress = await _dbSet.ToListAsync();
        //    await _excelService.ExportToExcel(listAdress, "C:/ProjetosMateusPadraoMvc/MathDrinksWeb/MathDrinks/excel", "adress");
        //    return;
        //}
        #endregion
    }
}
