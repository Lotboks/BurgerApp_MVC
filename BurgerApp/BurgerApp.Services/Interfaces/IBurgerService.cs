using BurgerApp.ViewModels.BurgerViewModels;

namespace BurgerApp.Services.Interfaces
{
    public interface IBurgerService
    {
        Task<List<BurgerListViewModel>> GetBurgersForCards();

    }
}
