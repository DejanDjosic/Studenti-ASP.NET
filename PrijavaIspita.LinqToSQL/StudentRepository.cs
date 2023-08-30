using PrijavaIspita.Domain;
using PrijavaIspita.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaIspita.LinqToSQL
{
    public class StudentRepository : IStudentRepository
    {
        private PrijavaIspitaDataContext _prijavaIspitaDataContext = new PrijavaIspitaDataContext();
        public void Create(StudentBo student)
        {
            Student student1 = new Student
            {
                ime = student.Ime,
                prezime = student.Prezime,
                godinaUpisa = student.GodinaUpisa,
                idSmer=student.Smer.Id
            };
            _prijavaIspitaDataContext.Students.InsertOnSubmit(student1);
            try
            {
                _prijavaIspitaDataContext.SubmitChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Greska prilikom unosa: " + ex);
            }
        }

        public void Delete(StudentBo student)
        {
            var studentZaBrisanje = _prijavaIspitaDataContext.Students.SingleOrDefault(s => s.idStudent == student.Id);

         

            _prijavaIspitaDataContext.Students.DeleteOnSubmit(studentZaBrisanje);

            try
            {
                _prijavaIspitaDataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska prilikom ažuriranja: " + ex);
            }
        }

        public IEnumerable<StudentBo> GetAll()
        {
            List<StudentBo> studentBos = new List<StudentBo>();
            foreach(Student student in _prijavaIspitaDataContext.Students)
            {
                
                studentBos.Add(Map(student));

            }
            return studentBos;
        }
        private StudentBo Map(Student student)
        {
            StudentBo studentBo = new StudentBo
            {
                Id = student.idStudent,
                Ime = student.ime,
                Prezime = student.prezime,
                GodinaUpisa = student.godinaUpisa,
                Smer = new SmerBo
                {
                    Id = student.Smer.idSmer,
                    Naziv = student.Smer.naziv
                }
            };
            return studentBo;
        }

        public StudentBo GetById(int id)
        {
            Student student = _prijavaIspitaDataContext.Students.Single(t => t.idStudent == id);
            return Map(student);
        }


        public IEnumerable<StudentBo> getBySmer(SmerBo smer)
        {
            List<StudentBo> studentBos = new List<StudentBo>();
            foreach (Student s in _prijavaIspitaDataContext.Students)
            {
                if (s.idSmer == smer.Id)
                {
                    studentBos.Add(Map(s));
                }

            }
            return studentBos;
        }

        public void Edit(StudentBo student)
        {
            var izmenjenStudent = _prijavaIspitaDataContext.Students.SingleOrDefault(s => s.idStudent == student.Id);

            if (izmenjenStudent != null) {

                izmenjenStudent.idStudent = student.Id;
                izmenjenStudent.ime = student.Ime;
                izmenjenStudent.prezime = student.Prezime;
                izmenjenStudent.godinaUpisa = student.GodinaUpisa;
                izmenjenStudent.idSmer = student.Smer.Id;
            }


            try
            {
                _prijavaIspitaDataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska prilikom ažuriranja: " + ex);
            }
        }
    }
}
