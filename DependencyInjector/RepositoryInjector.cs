using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EtiqaCDN.Repositories;
using EtiqaCDN.Interfaces;

namespace EtiqaCDN.DependencyInjector
{
	public static class RepositoryInjector
	{
		public static IServiceCollection RegisterRepository(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddTransient<IFreelancer, FreelancerRepository>();

			return services;
		}
	}
}
