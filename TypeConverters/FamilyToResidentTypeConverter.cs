using AutoMapper;
using Lab_AutoMapper.Models;

namespace Lab_AutoMapper.TypeConverters
{
    public class FamilyToResidentTypeConverter : ITypeConverter<FamilyModel, IEnumerable<ResidentModel>>
    {
        public IEnumerable<ResidentModel> Convert(FamilyModel source, IEnumerable<ResidentModel> destination, ResolutionContext context)
        {
            if (source.Member != null)
                destination = source.Member.Select(s => new ResidentModel { Address = source.Address, Name = s.Name, });
            return destination;
        }
    }
}
