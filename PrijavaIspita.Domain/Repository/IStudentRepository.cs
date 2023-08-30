using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaIspita.Domain.Repository
{
    public interface IStudentRepository
        
    {
        IEnumerable<StudentBo> GetAll();
        void Create(StudentBo student);
        void Edit(StudentBo student);

        void Delete(StudentBo student);

        StudentBo GetById(int id);
        IEnumerable<StudentBo> getBySmer(SmerBo smer);
    }
}
