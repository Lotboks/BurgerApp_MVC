
namespace BurgerApp.Services.Implementations
{
    using BurgerApp.DataAccess.Repositories.Interfaces;
    using BurgerApp.Domain.Models;
    using BurgerApp.Mappers;
    using BurgerApp.Services.Interfaces;
    using BurgerApp.ViewModels.BurgerViewModels;

    public class BurgerService : IBurgerService
    {

        private IRepository<Burger> _burgerRepository;

        public BurgerService(IRepository<Burger> _burgerRepository)
        {
            this._burgerRepository = _burgerRepository;   
        }

        public async Task<List<BurgerListViewModel>> GetBurgersForCards()
        {
            List<Burger> burgerDb = await _burgerRepository.GetAll();

            return burgerDb.Select(x => x.ToBurgerListViewModel()).ToList();
        }
    }
}
