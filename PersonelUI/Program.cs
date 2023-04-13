

using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities_.Concrete;

namespace PersonelUI
{
    internal static class Program
    {
        public static IContainer Container;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Container = Configure();
            Application.Run(new AnaSayfa(Container.Resolve<IBolumService>(),
                Container.Resolve<IPersonelService>(),Container.Resolve<IGorevService>(),Container.Resolve<IOgrenimDurumService>()));
        }

        static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<BolumManager>().As<IBolumService>();
            builder.RegisterType<EFBolumDal>().As<IBolumDal>();  
            
            builder.RegisterType<GorevManager>().As<IGorevService>();
            builder.RegisterType<EFGorevDal>().As<IGorevDal>();    
            
            builder.RegisterType<PersonelManager>().As<IPersonelService>();
            builder.RegisterType<EFPersonelDal>().As<IPersonelDal>();

            builder.RegisterType<OgrenimDurumManager>().As<IOgrenimDurumService>();
            builder.RegisterType<EFOgrenimDurumDal>().As<IOgrenimDurumDal>();

            builder.RegisterType<AnaSayfa>();
            return builder.Build();
        }

    }
}