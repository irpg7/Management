using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System.Collections.Generic;

namespace IsKaiser.Management.Bll.Concrete
{
    public class DebateManager : IDebateService
    {
        IDebateDal _debateDal;

        public DebateManager(IDebateDal debateDal)
        {
            _debateDal = debateDal;
        }
        [FluentValidationAspect(typeof(DebateValidator))]
        public void Add(Debate debate)
        {
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
        [FluentValidationAspect(typeof(DebateValidator))]
        public void Update(Debate debate)
        {
            _debateDal.Update(debate);
        }
        public List<Debate> GetAllByCustomer(int customerId)
        {
            return _debateDal.GetAll(d=>d.CustomerId==customerId);
        }
    }
}
