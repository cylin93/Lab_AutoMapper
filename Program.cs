using AutoMapper;
using Lab_AutoMapper.Mappings;
using Lab_AutoMapper.TypeConverters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// ���U Mapper �i�̤��P�ݨD�ϥ�
//// method1 �ΤϮg�h���o�P�ե󤤪� Profile �Ӹ��J
//builder.Services.AddAutoMapper(typeof(Program));
//// method2 �p�G�A���Ψ�h�h���[�c�A�Ϊ̥u�O�Q�n�v�� Profile �i����U�A��K�i�汱�ު���
//builder.Services.AddScoped<FamilyToResidentTypeConverter>();
//builder.Services.AddAutoMapper(config =>
//{
//    config.AddProfile<TodoMapping>();
//    config.AddProfile<ResidentMapping>();
//});
// method3 �u�n��������ե󳣥�� AddAutoMapper �̴N�n�A�o�N�i�H�Q�ΤϮg�ӹF��ڭ̪��ت�
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
