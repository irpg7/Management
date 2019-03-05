using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System.Collections.Generic;

namespace IsKaiser.Management.Bll.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }
        [FluentValidationAspect(typeof(AppointmentValidator))]
        public void Add(Appointment appointment)
        {
            _appointmentDal.Add(appointment);
        }

        public Appointment Get(int id)
        {
            return _appointmentDal.Get(ap => ap.AppointmentId == id);
        }

        public List<Appointment> GetAll()
        {
            return _appointmentDal.GetAll();
        }
        [FluentValidationAspect(typeof(AppointmentValidator))]
        public void Update(Appointment appointment)
        {
            _appointmentDal.Update(appointment);
        }
        public List<Appointment> GetAllByCustomer(int customerId)
        {
            return _appointmentDal.GetAll(ap=>ap.CustomerId==customerId);
        }
    }
}
