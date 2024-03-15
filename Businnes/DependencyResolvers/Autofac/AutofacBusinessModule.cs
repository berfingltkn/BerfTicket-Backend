using Autofac;
using Businnes.Abstract;
using Businnes.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businnes.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

            builder.RegisterType<SeatManager>().As<ISeatService>().SingleInstance();
            builder.RegisterType<EfSeatDal>().As<ISeatDal>().SingleInstance();

            builder.RegisterType<BusManager>().As<IBusService>().SingleInstance();  
            builder.RegisterType<EfBusDal>().As<IBusDal>().SingleInstance();

            builder.RegisterType<TicketManager>().As<ITicketService>().SingleInstance();
            builder.RegisterType<EfTicketDal>().As<ITicketDal>().SingleInstance();

            builder.RegisterType<TripManager>().As<ITripService>().SingleInstance();
            builder.RegisterType<EfTripDal>().As<ITripDal>().SingleInstance();


        }
    }
}
