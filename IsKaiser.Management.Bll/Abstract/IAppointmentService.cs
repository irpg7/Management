using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IAppointmentService
    {
        List<Appointment> GetAll();
        Appointment Get(int id);
        void Add(Appointment appointment);
        void Update(Appointment appointment);
        List<Appointment> GetAllByCustomer(int appointmentId);
    }
}
