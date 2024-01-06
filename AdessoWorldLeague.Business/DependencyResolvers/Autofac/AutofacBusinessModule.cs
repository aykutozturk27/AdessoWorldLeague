using AdessoWorldLeague.Business.Abstract;
using AdessoWorldLeague.Business.Concrete.Managers;
using AdessoWorldLeague.DataAccess.Abstract;
using AdessoWorldLeague.DataAccess.Concrete.InMemory;
using Autofac;

namespace AdessoWorldLeague.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TeamManager>().As<ITeamService>().SingleInstance();
            builder.RegisterType<ImTeamDal>().As<ITeamDal>().SingleInstance();

            builder.RegisterType<GroupManager>().As<IGroupService>().SingleInstance();
            builder.RegisterType<ImGroupDal>().As<IGroupDal>().SingleInstance();
        }
    }
}
