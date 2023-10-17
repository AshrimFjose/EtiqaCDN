using EtiqaCDN.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtiqaCDN.Models.Results
{
	public class FreelancerResultModel
	{
		public bool Success { get; set; }
		public string Message { get; set; }
		public int Total { get; set; }
		public List<FreelancerModel> Result { get; set; }
	}
}
