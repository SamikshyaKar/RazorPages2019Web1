using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages2019Web1.Services;
using RazorPages2019Web1.Models;

namespace RazorPages2019Web1.Pages.EmployeeDetails
{
    public class IndexModel : PageModel
    {
		private readonly IEmployeeDetailsRepository _employeeDetailsRepository;

		public IEnumerable<EmployeeDetail> EmployeeDetail { get; set; }

		public IndexModel(IEmployeeDetailsRepository _employeeDetailsRepository)
		{
			this._employeeDetailsRepository = _employeeDetailsRepository;
		}
        public void OnGet()
        {
			EmployeeDetail = _employeeDetailsRepository.GetallEmployeeDetails();

		}
    }
}