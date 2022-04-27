using AutoMapper;
using Lab_AutoMapper.Models;
using Lab_AutoMapper.TypeConverters;

namespace Lab_AutoMapper.Mappings
{
    public class ResidentMapping : Profile
    {
        public ResidentMapping()
        {
            CreateMap<FamilyModel, IEnumerable<ResidentModel>>()
                ////較不複雜的使用方法
                //.ConvertUsing(f => f.Member != null ? f.Member.Select(p => new ResidentModel { Address = f.Address, Name = p.Name }) : new List<ResidentModel>());
                ////比較複雜的使用方法，可以用實作型別轉
                .ConvertUsing<FamilyToResidentTypeConverter>();
        }
    }
}
