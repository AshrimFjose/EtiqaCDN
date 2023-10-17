using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtiqaCDN.Models.Tables
{
	public class FreelancerModel
	{
		public Guid Id { get; set; }
		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string PhoneNum { get; set; }
		public string Hobby { get; set; }
		public string SkillSet { get; set; }
	}
}
