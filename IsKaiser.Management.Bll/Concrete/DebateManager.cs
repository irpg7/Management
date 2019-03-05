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
    public class DebateManager : IDebateService
    {
        IDebateDal _debateDal;

        public DebateManager(IDebateDal debateDal)
        {
            _debateDal = debateDal;
        }

        public void Add(Debate debate)
        {
            ValidationTool.Validate(new DebateValidator(), debate);
            _debateDal.Add(debate);
        }

        public Debate Get(int id)
        {
            return _debateDal.Get(deb => deb.DebateId == id);
        }

        public List<Debate> GetAll()
        {
            return _debateDal.GetAll();
        }

        public void Update(Debate debate)
        {
            ValidationTool.Validate(new DebateValidator(), debate);
            _debateDal.Update(debate);
        }
        public List<Debate> GetAllByCustomer(int customerId)
        {
            return _debateDal.GetAll(d=>d.CustomerId==customerId);
        }
    }
}
