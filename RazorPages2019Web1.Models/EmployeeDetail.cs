using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPages2019Web1.Models
{
	public class EmployeeDetail
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Photopath { get; set; }
		public Department? Department { get; set; }

	}
}
