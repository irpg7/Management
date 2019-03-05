using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IDebateService
    {
        List<Debate> GetAll();
        Debate Get(int id);
        void Add(Debate debate);
        void Update(Debate debate);
        List<Debate> GetAllByCustomer(int customerId);
    }
}
