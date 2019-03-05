using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.Utilities;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Bll.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public void Add(Appointment appointment)
        {
            ValidationTool.Validate(new AppointmentValidator(), appointment);
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

        public void Update(Appointment appointment)
        {
            ValidationTool.Validate(new AppointmentValidator(), appointment);
            _appointmentDal.Update(appointment);
        }
        public List<Appointment> GetAllByCustomer(int customerId)
        {
            return _appointmentDal.GetAll(ap=>ap.CustomerId==customerId);
        }
    }
}
