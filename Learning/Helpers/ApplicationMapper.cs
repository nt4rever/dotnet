using AutoMapper;
using Learning.Data;
using Learning.Models;

namespace Learning.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper() {
            CreateMap<Book, BookModel>().ReverseMap();
        }
    }
}
