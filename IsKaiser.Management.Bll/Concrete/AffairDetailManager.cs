using IsKaiser.Management.Bll.Abstract;
using IsKaiser.Management.Bll.ValidationRules.FluentValidation;
using IsKaiser.Management.Core.Aspects.Postsharp.ValidationAspects;
using IsKaiser.Management.Dal.Abstract;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Concrete
{
    public class AffairDetailManager : IAffairDetailService
    {
        IAffairDetailDal _affairDetailDal;

        public AffairDetailManager(IAffairDetailDal affairDetailDal)
        {
            _affairDetailDal = affairDetailDal;
        }
        [FluentValidationAspect(typeof(AffairDetailValidator))]
        public void Add(AffairDetail affairDetail)
        {
            _affairDetailDal.Add(affairDetail);
        }

        public void Delete(AffairDetail affairDetail)
        {
            _affairDetailDal.Delete(affairDetail);
        }

        public AffairDetail GetDetailById(int affairId)
        {
            return _affairDetailDal.Get(ad => ad.AffairId == affairId);
        }
        [FluentValidationAspect(typeof(AffairDetailValidator))]
        public void Update(AffairDetail affairDetail)
        {
            _affairDetailDal.Update(affairDetail);
        }
    }
}
