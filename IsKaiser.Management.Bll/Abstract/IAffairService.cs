using IsKaiser.Management.Entities.ComplexTypes;
using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IAffairService
    {
        void Add(Affair affair);
        void Update(Affair affair);
        void Delete(Affair affair);

        Affair Get(int affairId);

        List<Affair> GetAll();

        List<AffairsListCT> GetAffairList();
    }
}
