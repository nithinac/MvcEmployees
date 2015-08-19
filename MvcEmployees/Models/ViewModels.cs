using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using MvcEmployees.Utilities;
using System.Web.Mvc;
namespace MvcEmployees.Models
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel() { }

        public EmployeeViewModel(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }

        public string Name { get; set; }
    }

    public class EmployeeDetailsViewModel
    {
        public EmployeeDetailsViewModel() { }

        public EmployeeDetailsViewModel(List<string> slist, List<string> clist)
        {
            StatesList = slist.Select(x=>new SelectListItem(){Text=x.ToString()});
            CitiesList = clist.Select(x => new SelectListItem() { Text = x.ToString() });
        }

        [Required,Display(Name="Id")]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public GenderType Gender { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        [Required,RegularExpression("[0-9]{6}")]
        public string Pincode { get; set; }

        public IEnumerable<SelectListItem> StatesList { get; set; }

        public IEnumerable<SelectListItem> CitiesList { get; set; }

        public SelectList GenderList
        {
            get
            {
                return Gender.ToSelectList<GenderType>();
            }
        }
    }

    public class UserViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }

}