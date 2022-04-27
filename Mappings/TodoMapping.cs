using AutoMapper;
using Lab_AutoMapper.Models;

namespace Lab_AutoMapper.Mappings
{
    public class TodoMapping : Profile
    {
        public TodoMapping()
        {
            CreateMap<TodoViewModel, TodoModel>()
                .ForMember(x => x.UpdatedTime, y => y.MapFrom(o => o.Time))
                .ForMember(x => x.CreatedTime, y => y.Ignore())
                .ForMember(x => x.ID, y => y.MapFrom(o => o.ID));

            CreateMap<TodoModel, TodoViewModel>()
               .ForMember(x => x.Time, y => y.MapFrom(o => o.UpdatedTime))
               .ForMember(x => x.ID, y => y.MapFrom(o => o.ID));

        }
    }
}
