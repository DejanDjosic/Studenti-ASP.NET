using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrijavaIspita.Domain;
using PrijavaIspita.Domain.Repository;
using PrijavaIspita.LinqToSQL;

namespace PrijavaIspita.Client.Controllers
{
    public class StudentController : Controller
    {
        #region Fields
        private IStudentRepository _studentRepository;
        private ISmerRepository _smerRepository;


        #endregion

        public StudentController()
        {
            _studentRepository = new StudentRepository();
            _smerRepository = new SmerRepository();

        }

        // GET: Student
        public ActionResult Index()
        {
            List<StudentBo> students = _studentRepository.GetAll().ToList();
            return View(students);
        }
        public ActionResult Create()
        {
            List<SmerBo> smerovi = _smerRepository.GetAll().ToList();
            ViewBag.Smerovi = smerovi;
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentBo studentBo)
        {
            _studentRepository.Create(studentBo);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            List<SmerBo> smerovi = _smerRepository.GetAll().ToList();
            ViewBag.Smerovi = smerovi;
            StudentBo studentBo = _studentRepository.GetById(id);
            return View(studentBo);
        }

        [HttpPost]
        public ActionResult Edit(StudentBo studentBo)
        {
            _studentRepository.Edit(studentBo);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            List<SmerBo> smerovi = _smerRepository.GetAll().ToList();
            ViewBag.Smerovi = smerovi;
            StudentBo studentBo = _studentRepository.GetById(id);
            return View(studentBo);
        }

        [HttpPost]
        public ActionResult Delete(StudentBo studentBo)
        {
            _studentRepository.Delete(studentBo);
            return RedirectToAction("Index");
        }
    }
}