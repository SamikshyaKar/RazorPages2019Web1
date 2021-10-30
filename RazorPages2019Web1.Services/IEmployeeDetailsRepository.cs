using RazorPages2019Web1.Models;
using System;
using System.Collections.Generic;

namespace RazorPages2019Web1.Services
{
	public interface IEmployeeDetailsRepository
	{

		IEnumerable<EmployeeDetail> GetallEmployeeDetails();
		EmployeeDetail GetEmployeeDetail(int id);

	}
}
