var services = new ServiceCollection()
    .AddDpContext<DataContext>(x => x.UseSqlServer())
    .AddScoped<CustomerRepository>()
    .Addscoped<ProjektRepository>()
    .AddScoped<CustomerService>()
    .AddScoped<ProjectService>()
    .Addscoped<MenuDialogs>();
    .BuildServiceProvider();

var menuyDialogs = GetRequierdService<MenuDialogs>();
await menuDialogs.MenuOptions();
