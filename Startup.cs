using EtiqaCDN.DependencyInjector;
using EtiqaCDN.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtiqaCDN
{
	public class Startup
	{
		// Please check each API Controller for [ApiExplorerSettings(GroupName = "???")]
		private List<SwaggerUIModel> swaggerUIModels = new List<SwaggerUIModel>() {
			new SwaggerUIModel() { apiExplorer = "Freelancer",  apiTitle = "Freelancer", apiName = "Freelancer" }
		};

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();

			services
				.AddControllers()
				.AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);

			services.AddSwaggerGen();

			if (swaggerUIModels.Count > 0)
			{
				foreach (var apis in swaggerUIModels)
				{
					services.AddSwaggerGen(c => { c.SwaggerDoc(apis.apiExplorer, new OpenApiInfo { Title = apis.apiTitle }); });
				}
			}
			else
			{
				services.AddSwaggerGen(c => { c.SwaggerDoc("default", new OpenApiInfo { Title = "Default Without API Explorer Settings" }); });
			}

			// Dependency Injection
			services.RegisterRepository(Configuration);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});

			app.UseSwagger();
			app.UseSwaggerUI(c => {

				if (swaggerUIModels.Count > 0)
				{
					foreach (var apis in swaggerUIModels)
					{
						c.SwaggerEndpoint("/swagger/" + apis.apiExplorer + "/swagger.json", apis.apiName);
					}
				}
				else
				{
					c.SwaggerEndpoint("/swagger/default/swagger.json", "Default Without API Explorer Settings");
				}
			});
		}
	}
}
