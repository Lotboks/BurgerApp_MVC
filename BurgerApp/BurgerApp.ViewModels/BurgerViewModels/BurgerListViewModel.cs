﻿namespace BurgerApp.ViewModels.BurgerViewModels
{
    public class BurgerListViewModel
    {

        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Price { get; set; }

        public bool IsVegetarian { get; set; }

        public bool IsVegan { get; set; }

        public bool HasFries { get; set; }



    }
}
