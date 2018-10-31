namespace QuoteAPI
{
    using System;
    using Autofac;
    using Autofac.Extensions.DependencyInjection;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using QuoteAPI.Models;
    using QuoteAPI.Services;

    /// <summary>
    /// References:
    /// https://autofaccn.readthedocs.io/en/latest/integration/aspnetcore.html
    /// http://www.codedigest.com/posts/49/using-autofac-instead-of-inbuilt-di-container-with-in-aspnet-core-mvc.
    /// </summary>
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<QuoteDBContext>(opt => opt.UseSqlServer("Server=localhost;Database=QuoteDB;Trusted_Connection=True;"));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Now register our services with Autofac container
            var builder = new ContainerBuilder();

            // BEFORE Populate registrations.
            PrePopulationRegistration(builder);

            // Note that Populate is basically a foreach to add things
            // into Autofac that are in the collection. If you register
            // things in Autofac BEFORE Populate then the stuff in the
            // ServiceCollection can override those things; if you register
            // AFTER Populate those registrations can override things
            // in the ServiceCollection. Mix and match as needed.
            builder.Populate(services);

            // AFTER Populate registrations.
            PostPopulationRegistration(builder);

            var container = builder.Build();

            // Create the IServiceProvider based on the container.
            return new AutofacServiceProvider(container);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }

        // If you register things in Autofac BEFORE Populate then the stuff in the ServiceCollection can override those things.
        private static void PrePopulationRegistration(ContainerBuilder builder)
        {
        }

        // If you register AFTER Populate those registrations can override things in the ServiceCollection. Mix and match as needed.
        private static void PostPopulationRegistration(ContainerBuilder builder)
        {
            // Instead of registering your dependencies InstancePerRequest, use InstancePerLifetimeScope and you should get the same behavior.
            builder.RegisterType<QuoteService>().As<IQuoteService>().InstancePerLifetimeScope();
            builder.RegisterType<AuthorService>().As<IAuthorService>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();
        }
    }
}
