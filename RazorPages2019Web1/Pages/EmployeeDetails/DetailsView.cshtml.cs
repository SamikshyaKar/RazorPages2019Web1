using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages2019Web1.Models;
using RazorPages2019Web1.Services;

namespace RazorPages2019Web1.Pages.EmployeeDetails
{
	
    public class DetailsViewModel : PageModel
    {
		private readonly IEmployeeDetailsRepository employeeDetailsRepository;

		public DetailsViewModel(IEmployeeDetailsRepository employeeDetailsRepository)
		{
			this.employeeDetailsRepository = employeeDetailsRepository;
		}

		public EmployeeDetail EmployeeDetail { get; private set; }

		public void OnGet(int id)
        {
			EmployeeDetail=employeeDetailsRepository.GetEmployeeDetail(id);
        }
    }
}