using MyHardware.Infrastructure.Common.Interfaces;
using MyHardwareWeb.Application.Interfaces;
using MyHardwareWeb.Domain.Models;
namespace MyHardwareWeb.Infrastructure.Repository
{
    public class AdressRepository : Repository<Adress>, IAdressRepository
    {
        public AdressRepository(
            IApplicationDbContext context) : base(context) { }

        #region --------Private Methods----------
        //private async Task ExportAllAdress()
        //{
        //    IEnumerable<Adress> listAdress = await _db.Adress.ToListAsync();
        //    await _excelService.ExportToExcel(listAdress, "C:/ProjetosMateusPadraoMvc/MathDrinksWeb/MathDrinks/excel", "adress");
        //    return;
        //}
        #endregion
    }
}
