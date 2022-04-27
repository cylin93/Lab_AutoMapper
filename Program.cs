using AutoMapper;
using Lab_AutoMapper.Mappings;
using Lab_AutoMapper.TypeConverters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// 註冊 Mapper 可依不同需求使用
//// method1 用反射去取得同組件中的 Profile 來載入
//builder.Services.AddAutoMapper(typeof(Program));
//// method2 如果你有用到多層的架構，或者只是想要逐個 Profile 進行註冊，方便進行控管的話
//builder.Services.AddScoped<FamilyToResidentTypeConverter>();
//builder.Services.AddAutoMapper(config =>
//{
//    config.AddProfile<TodoMapping>();
//    config.AddProfile<ResidentMapping>();
//});
// method3 只要把全部的組件都丟到 AddAutoMapper 裡就好，這就可以利用反射來達到我們的目的
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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

app.UseAuthorization();

app.MapControllers();

app.Run();
