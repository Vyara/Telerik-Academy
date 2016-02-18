using System.Collections.Generic;
using System.Web.Mvc;

namespace Calculator.Models.AccountModels
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
    }
}