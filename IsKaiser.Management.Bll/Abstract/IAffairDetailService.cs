using IsKaiser.Management.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace IsKaiser.Management.Bll.Abstract
{
    public interface IAffairDetailService
    {
        void Add(AffairDetail affairDetail);
        void Update(AffairDetail affairDetail);
        void Delete(AffairDetail affairDetail);

        AffairDetail GetDetailById(int affairId);

    }
}
