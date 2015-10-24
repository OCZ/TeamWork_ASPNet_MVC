namespace PhC.App.App_Start
{
    using AutoMapper;
    using Model;
    using Models.ViewModels;

    public class MapperConfig
    {
        public static void ConfigureMappings()
        {
            Mapper.CreateMap<Contest, ContestConciseViewModel>()
                .ForMember(model => model.Author, config => config.MapFrom(contest => contest.Creator.UserName))
                .ForMember(model => model.Date, config => config.MapFrom(contest => contest.CreatedOn))
                .ForMember(model => model.Entries, config => config.MapFrom(contest => contest.ContestEntries.Count));
        }
    }
}