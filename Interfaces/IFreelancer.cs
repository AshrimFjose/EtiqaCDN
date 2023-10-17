using EtiqaCDN.Models.Results;
using EtiqaCDN.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtiqaCDN.Interfaces
{
	public interface IFreelancer
	{
		Task<FreelancerResultModel> GetAll();
		Task<FreelancerResultModel> GetById(Guid id);
		Task<FreelancerResultModel> Create(FreelancerModel freelancer);
		Task<FreelancerResultModel> Update(FreelancerModel freelancer);
		Task<FreelancerResultModel> Delete(Guid id);
	}
}
