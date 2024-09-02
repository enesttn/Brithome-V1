using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac;

public class AutofacBusinessModule:Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<PropertyManager>().As<IPropertyService>().SingleInstance();
        builder.RegisterType<EfPropertyDal>().As<IPropertyDal>().SingleInstance();
    }
}
