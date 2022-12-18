using crud_operation.Models;
using Microsoft.AspNetCore.Mvc;

namespace crud_operation.Controllers
{
    public class TeacherController : Controller
    {


        // This is Student Model Class list
        private static List<teacher_Model> teach = new List<teacher_Model>();
        public IActionResult Index()
        {
            return View();
        }
           // ads teacher data 
            public IActionResult AddTeacher()
             {

             return View();
            }

        // post method
        [HttpPost]
        public IActionResult AddTeacher(teacher_Model teacher_)
        {
            teach.Add(teacher_);
            return RedirectToAction(actionName: "teacher_Display");
        }

        // Dsiplay data 
           public IActionResult teacher_Display()
           {
            return View(teach);
           }


        /// delete Teacher
        /// 
        public IActionResult delete_Teacher(int id)
        {
            var itemToRemove = teach.Single((t => t.Id == id));
            teach.Remove(itemToRemove);
            return RedirectToAction(actionName: "teacher_Display");
        }



        // update Teacher  S
        public IActionResult update_teacher(int id)
        {
            var itemTupdate = teach.Single((t => t.Id == id));
            return View(itemTupdate);
        }

        // post update
        [HttpPost]
        public IActionResult update_teacher(teacher_Model tc)
        {

            var itemTupdate = teach.Single((t => t.Id == tc.Id));
             if(itemTupdate != null)
            {
                itemTupdate.first_Name = tc.first_Name;
                itemTupdate.last_Name = tc.last_Name;
                itemTupdate.email = tc.email;
                itemTupdate.phone_Number = tc.phone_Number;

            }
            return RedirectToAction(actionName: "teacher_Display");
        }
        // Details
      /*  public IActionResult details_teacher()
        {
            return View(teach);
        }*/


    }
}
