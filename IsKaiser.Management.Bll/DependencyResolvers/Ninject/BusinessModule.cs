using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.Concrete;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Dal.Concrete.EntityFramework;
using Ninject.Modules;
using System;
using System.Linq;

namespace IsKaiser.Management.Bll.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerService>().To<CustomerManager>();
            Bind<ICustomerAccountantService>().To<CustomerAccountantManager>();
            Bind<ICustomerDirectorService>().To<CustomerDirectorManager>();
            Bind<ICustomerPurchasingStaffService>().To<CustomerPurchasingStaffManager>();
            Bind<IDebateService>().To<DebateManager>();
            Bind<IAppointmentService>().To<AppointmentManager>();
            Bind<IEmployeeService>().To<EmployeeManager>();
            Bind<IEmployeeTeamService>().To<EmployeeTeamManager>();
            Bind<IUserService>().To<UserManager>();
            Bind<IVehicleService>().To<VehicleManager>();
            Bind<IProductService>().To<ProductManager>();
            Bind<IInvoiceService>().To<InvoiceManager>();
            Bind<IInvoiceLineService>().To<InvoiceLineManager>();
            Bind<IProductTypeService>().To<ProductTypeManager>();

            Bind<ICustomerDal>().To<EfCustomerDal>();
            Bind<ICustomerAccountantDal>().To<EfCustomerAccountantDal>();
            Bind<ICustomerDirectorDal>().To<EfCustomerDirectorDal>();
            Bind<ICustomerPurchasingStaffDal>().To<EfCustomerPurchasingStaffDal>();
            Bind<IVehicleDal>().To<EfVehicleDal>();
            Bind<IDebateDal>().To<EfDebateDal>();
            Bind<IAppointmentDal>().To<EfAppointmentDal>();
            Bind<IEmployeeDal>().To<EfEmployeeDal>();
            Bind<IEmployeeTeamDal>().To<EfEmployeeTeamDal>();
            Bind<IUserDal>().To<EfUserDal>();
            Bind<IProductDal>().To<EfProductDal>();
            Bind<IInvoiceDal>().To<EfInvoiceDal>();
            Bind<IInvoiceLineDal>().To<EfInvoiceLineDal>();
            Bind<IProductTypeDal>().To<EfProductTypeDal>();


        }
    }
}
