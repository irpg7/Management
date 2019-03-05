using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using IsKaiser.Management.Bll.Utilities;
using IsKaiser.Management.Entities.ComplexTypes;
using System.Linq;

namespace IsKaiser.Management.Bll.Concrete
{
    public class AffairManager : IAffairService
    {
        IAffairDal _affairDal;

        public AffairManager(IAffairDal affairDal)
        {
            _affairDal = affairDal;
        }

        public void Add(Affair affair)
        {
            _affairDal.Add(affair);
        }

        public void Delete(Affair affair)
        {
            _affairDal.Delete(affair);
        }

        public Affair Get(int affairId)
        {
            return _affairDal.Get(a => a.AffairId == affairId);
        }

        public List<AffairsListCT> GetAffairList()
        {
            return _affairDal.GetAffairList();
        }

        public List<Affair> GetAll()
        {
            return _affairDal.GetAll();
        }

        public void Update(Affair affair)
        {
            _affairDal.Update(affair);
        }
    }
}
