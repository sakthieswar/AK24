
using AES.ApiTemplate.BL.BuisnessLogic;
using AES.ApiTemplate.BL.Interfaces;
using AES.ApiTemplate.Services.Context;
using AES.ApiTemplate.Services.Interfaces;
using AES.ApiTemplate.Services.Repository;
using AES.ApiTemplate.Services.Services;

var builder = WebApplication.CreateBuilder(args);


//Enable CORS
builder.Services.AddCors(p => {
    p.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()); //.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

// Add services to the container.
builder.Services.AddSingleton<DbStoreContext>();

builder.Services.AddScoped<IDapperr, Dapperr>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddSingleton<ILoggerManager, LoggerManager>();

builder.Services.AddScoped<IProductBuisnessLayer, ProductBuisnessLayer>();
builder.Services.AddScoped<IUserBuisnessLayer, UserBuisnessLayer>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//var connectionString = builder.Configuration.GetConnectionString("SqlConnection") ?? default!;
//builder.Services.AddTransient<IUnitOfWork>(sp => new UnitOfWork(connectionString));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//var connection = new SqlConnection(connectionString);

app.UseHttpsRedirection();

app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthorization();

app.MapControllers();

app.Run();
