using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryContext _db;

    public MachinesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Machine> model = _db.Machines.ToList();
      return View(model);
    }

    // public ActionResult Create()
    // {
    //   return View();
    // }

    // [HttpPost]
    // public ActionResult Create(Course course)
    // {
    //   _db.Courses.Add(course);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult AddStudent(int id)
    // {
    //   Course thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
    //   ViewBag.StudentId = new SelectList(_db.Students, "StudentId", "StudentName");
    //   return View(thisCourse);
    // }

    // [HttpPost]
    // public ActionResult AddStudent(Course course, int studentId)
    // {
    //   #nullable enable
    //   CourseStudent? joinEntity = _db.CourseStudents.FirstOrDefault(join => (join.CourseId == course.CourseId && join.StudentId == studentId));
    //   #nullable disable
    //   if (joinEntity == null && studentId != 0)
    //   {
    //     _db.CourseStudents.Add(new CourseStudent() { CourseId = course.CourseId, StudentId = studentId});
    //     _db.SaveChanges();
    //   }
    //   return RedirectToAction("Details", new { id = course.CourseId });
    // }

    // public ActionResult Details(int id)
    // {
    //   Course thisCourse = _db.Courses
    //                           .Include(course => course.JoinEntities)
    //                           .ThenInclude(join => join.Student)
    //                           .FirstOrDefault(course => course.CourseId == id);
    //   return View(thisCourse);
    // }

    // public ActionResult Edit(int id)
    // {
    //   Course thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
    //   ViewBag.StudentId = new SelectList(_db.Students, "StudentId", "StudentName");
    //   return View(thisCourse);
    // }

    // [HttpPost]
    // public ActionResult Edit(Course course)
    // {
    //   _db.Courses.Update(course);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   Course thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
    //   return View(thisCourse);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   Course thisCourse = _db.Courses.FirstOrDefault(course => course.CourseId == id);
    //   _db.Courses.Remove(thisCourse);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}