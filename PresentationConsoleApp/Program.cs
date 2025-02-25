using Business.services;
using Data.Context;
using Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

    .AddDpContext<Datacontext>(x => x.UseSqlServer())
    .AddScoped<CustomerRepository>()
    .Addscoped<ProjektRepository>()
    .AddScoped<CustomerService>()
    .AddScoped<ProjectService>()
    .Addscoped<MenuDialogs>();
    .BuildServiceProvider();

var menuyDialogs = GetRequierdService<MenuDialogs>();
await menuDialogs.MenuOptions();
