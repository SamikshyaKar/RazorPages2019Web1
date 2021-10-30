using RazorPages2019Web1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RazorPages2019Web1.Services
{
	public class MockEmployeeRepositoryDetails : IEmployeeDetailsRepository
	{
		private List<EmployeeDetail> _employeeDetailsList;
		public MockEmployeeRepositoryDetails()
		{
			_employeeDetailsList = new List<EmployeeDetail>()
			{
			new EmployeeDetail(){ID=1,Name="Samu1",Email="Samu1@gmail.com",Department=Department.IT,Photopath="samu.jpg" },
			new EmployeeDetail(){ID=2,Name="Samu2",Email="Samu2@gmail.com",Department=Department.HR,Photopath="samu1-.jpg" },
			new EmployeeDetail(){ID=3,Name="Samu3",Email="Samu3@gmail.com",Department=Department.IT },

			};

		}
		public IEnumerable<EmployeeDetail> GetallEmployeeDetails()
		{
			return _employeeDetailsList;
		}

		public EmployeeDetail GetEmployeeDetail(int id)
		{
			return _employeeDetailsList.FirstOrDefault(e => e.ID == id);
		}
	}
}






