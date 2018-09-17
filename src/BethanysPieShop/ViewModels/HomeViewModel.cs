using System.Collections.Generic;
using BethanysPieShop.Models;


namespace BethanysPieShop.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
        }

        public IEnumerable<Pie> PiesOfTheWeek { get; set; }
    }
}