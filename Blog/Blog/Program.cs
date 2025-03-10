using BusinessLogicLayer.IService;
using BusinessLogicLayer.Mapping;
using BusinessLogicLayer.Services;
using DataAccessLayer.Data;
using DataAccessLayer.IRepository;
using DataAccessLayer.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<IBlogService, BlogService>();
//builder.Services.AddScoped<ICategory, CategoryRepository>();
//builder.Services.AddScoped<IProduct, ProductRepository>();
//builder.Services.AddScoped<ICategoryService, CategoryService>();
//builder.Services.AddScoped<CategoryMapper>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
