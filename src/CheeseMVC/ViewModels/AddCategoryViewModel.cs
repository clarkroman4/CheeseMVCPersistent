using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;


namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel
    {
        [Required]
        [Display(Name = "Cheese Category")]
        public string CategoryName { get; set; }
        public object Name { get; internal set; }
    }
}
