using EtiqaCDN.Interfaces;
using EtiqaCDN.Models.Results;
using EtiqaCDN.Models.Tables;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtiqaCDN.Controllers
{
	[ApiExplorerSettings(GroupName = "Freelancer")]
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class FreelancerController : ControllerBase
	{
		private readonly IFreelancer _iFreelancer;

		public FreelancerController(IFreelancer iFreelancer)
		{
			_iFreelancer = iFreelancer;
		}

		[HttpGet]
		public async Task<FreelancerResultModel> GetAll ()
		{
			var data = await _iFreelancer.GetAll();
			return data;
		}

		[HttpGet]
		public async Task<FreelancerResultModel> GetById(Guid id)
		{
			var data = await _iFreelancer.GetById(id);
			return data;
		}

		[HttpPost]
		public async Task<FreelancerResultModel> Create([FromBody] FreelancerModel freelancer)
		{
			var data = await _iFreelancer.Create(freelancer);
			return data;
		}

		[HttpPut]
		public async Task<FreelancerResultModel> Update([FromBody] FreelancerModel freelancer)
		{
			var data = await _iFreelancer.Update(freelancer);
			return data;
		}

		[HttpDelete]
		public async Task<FreelancerResultModel> Delete(Guid id)
		{
			var data = await _iFreelancer.Delete(id);
			return data;
		}
	}
}
