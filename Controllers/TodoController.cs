using AutoMapper;
using Lab_AutoMapper.Mappings;
using Lab_AutoMapper.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab_AutoMapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IMapper _mapper;
        public TodoController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        [Route("Get1")]
        public TodoModel Get1()
        {
            TodoViewModel viewModel = new TodoViewModel()
            {
                Content = "test",
                ID = Guid.NewGuid().ToString(),
                Time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                Title = "測試"
            };
            return _mapper.Map<TodoModel>(viewModel);
        }

        [HttpGet]
        [Route("Get2")]
        public TodoViewModel Get2()
        {
            TodoModel model = new TodoModel()
            {
                Content = "test@@",
                ID = Guid.NewGuid(),
                CreatedTime = DateTime.Now.AddDays(-1),
                UpdatedTime = DateTime.Now,
                Title = "測試@@"
            };
            return _mapper.Map<TodoViewModel>(model);
        }

        [HttpGet]
        [Route("Get3")]
        public IEnumerable<ResidentModel> Get3()
        {
            FamilyModel model = new FamilyModel()
            {
              Address="New Taipei",
              Member=new List<PersonModel>()
            
            };
            model.Member.Add(new PersonModel { Name = "AAA", ID = "1" });
            model.Member.Add(new PersonModel { Name = "BBB", ID = "2" });
            model.Member.Add(new PersonModel { Name = "CCC", ID = "3" });
            return _mapper.Map< IEnumerable<ResidentModel>>(model);
        }
    }
}
