using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaIspita.Domain.Repository
{
   public interface ISmerRepository
    {
        IEnumerable<SmerBo> GetAll();
        void Create(SmerBo smer);
        void Delete(SmerBo smer);
        void Edit (SmerBo smer);

        SmerBo GetById(int id);


    }
}
